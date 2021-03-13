// <copyright file="Form1.cs" company="Biomolecular Mass Spectrometry and Proteomics (http://hecklab.com)">
// This file is part of HeckLib.
//
// HeckLib is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2.1 of the License, or
// (at your option) any later version.
//
// HeckLib is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with HeckLib; if not, write to the Free Software
// Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
// </copyright>

using BoardGameClock;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BoardGameClockGui
{
	/// <summary>
	/// template for the form class of a windows forms app project.
	/// </summary>
	public partial class Form1 : Form
	{
		public Clock CurrentClock;

		public bool IsFirst { get; set; } = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="Form1"/> class.
		/// </summary>
		public Form1()
		{
			this.InitializeComponent();
			playingLabel.Paint += PlayingLabel_Paint;
			GraphicsPath p = new GraphicsPath();
			p.AddEllipse(3, 3, nextButton.Width - 8, nextButton.Height - 8);
			nextButton.Region = new Region(p);
		}

		private void PlayingLabel_Paint(object sender, PaintEventArgs e)
		{
			playingLabel.Left = (int)(ClientSize.Width / 2) - (int)(0.5 * playingLabel.Width);
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			CurrentClock.Next();
			playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex];
			string fold = Path.GetTempPath() + "bgClock.json";
			JsonSerializer serializer = new JsonSerializer();
			using (StreamWriter sw = new StreamWriter(fold))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, CurrentClock);
			}
		}

		private void nextButton_Resize(object sender, EventArgs e)
		{
			GraphicsPath p = new GraphicsPath();
			p.AddEllipse(3, 3, nextButton.Width - 8, nextButton.Height - 8);
			nextButton.Region = new Region(p);
		}

		private void newButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				if (ofd.FileName.ToLower().EndsWith(".json"))
				{
					string lines = System.IO.File.ReadAllText(ofd.FileName);

					CurrentClock = JsonConvert.DeserializeObject<BoardGameClock.Clock>(lines);
					CurrentClock.Pause();

					playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex] + "(Paused)";
				}
				else
				{
					string[] lines = System.IO.File.ReadAllLines(ofd.FileName);

					List<string> nameList = new List<string>();
					for (int i = 0; i < lines.Length; i++)
					{
						if (lines[i] != string.Empty)
							nameList.Add(lines[i]);
					}

					CurrentClock = new Clock(nameList.Count, nameList);
				}
			}

			newButton.Visible = false;
			startButton.Visible = true;
			stopButton.Visible = false;
			pauseButton.Visible = false;
		}

		private void startButton_Click(object sender, EventArgs e)
		{
			CurrentClock.Start();
			playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex];
			stopButton.Visible = true;
			pauseButton.Visible = true;
			startButton.Visible = false;
		}

		private void stopButton_Click(object sender, EventArgs e)
		{
			CurrentClock.Stop();
			playingLabel.Text = "Game over";
			stopButton.Visible = false;
			pauseButton.Visible = false;
			startButton.Visible = false;
			newButton.Visible = true;
		}

		private void pauseButton_Click(object sender, EventArgs e)
		{
			CurrentClock.Pause();

			playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex] + "(Paused)";
			stopButton.Visible = false;
			pauseButton.Visible = false;
			startButton.Visible = true;
		}

		private void boxplotControl_Click(object sender, EventArgs e)
		{
			var cols = new Color[]
			{
				System.Drawing.Color.Blue,
				System.Drawing.Color.Coral,
				System.Drawing.Color.Crimson,
				System.Drawing.Color.Violet,
				System.Drawing.Color.MediumTurquoise,
				System.Drawing.Color.MediumVioletRed,
				System.Drawing.Color.DarkOrchid,
			};
			
			var A1 = boxplotControl.ChartAreas[0];

			boxplotControl.Series.Clear();
			boxplotControl.ChartAreas.Clear();

			boxplotControl.ChartAreas.Add(A1);

			List<Series> sList = new List<Series>();

			ChartArea A2 = boxplotControl.ChartAreas.Add("A2");
			Series BS = boxplotControl.Series.Add("BoxPlotSeries");
			BS.ChartArea = "A2";
			BS.ChartType = SeriesChartType.BoxPlot;
			int i = 0;
			foreach (var clock in CurrentClock.UserTurnTimes)
			{
				sList.Add(new Series(CurrentClock.UserNames[i]));
				sList.Last().ChartType = SeriesChartType.Line;
				sList.Last().Color = cols[i];
				for (int j = 0; j < clock.Count; j++)
				{
					sList.Last().Points.AddXY(j, clock[j]);
					sList.Last().Points.Last().Color = cols[i];
				}

				boxplotControl.Series.Add(sList.Last());
				BS.Points.Add(new DataPoint(i + 1, 0));
				DataPoint DPT = BS.Points[BS.Points.Count - 1];
				DPT["BoxPlotSeries"] = CurrentClock.UserNames[i];
				DPT.Color = cols[i];
				i++;
			}

			A2.AlignWithChartArea = "ChartArea1";
			A2.AlignmentOrientation = AreaAlignmentOrientations.Horizontal;

			if (IsFirst)
			{
				A1.Position.Width *= 0.75f;
				IsFirst = false;
			}
			A2.Position.Y = A1.Position.Y;
			A2.Position.X = A1.Position.Right;
			A2.Position.Width = A1.Position.Width * 0.25f;

			A2.AxisX.LabelStyle.ForeColor = Color.Transparent;
			A2.AxisX.MajorGrid.Enabled = false;
			A2.AxisX.MajorTickMark.Enabled = false;
			A2.AxisX.Minimum = 0;
			A2.AxisX.Maximum = CurrentClock.NumUsers + 1;
			//A2.AxisY.Maximum = A1.AxisY.Maximum;
			//A2.AxisY.Minimum = A1.AxisY.Minimum;
		}
	}
}
