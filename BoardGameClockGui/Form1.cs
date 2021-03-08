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
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameClockGui
{
	/// <summary>
	/// template for the form class of a windows forms app project.
	/// </summary>
	public partial class Form1 : Form
	{
		public Clock CurrentClock;

		/// <summary>
		/// Initializes a new instance of the <see cref="Form1"/> class.
		/// </summary>
		public Form1()
		{
			this.InitializeComponent();
		}

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();

			if (ofd.ShowDialog() == DialogResult.OK)
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

		private void fIleToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			CurrentClock.Next();
			playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex];
		}

		private void startToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentClock.Start();
			playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex];
		}

		private void stopToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentClock.Stop();
			playingLabel.Text = "Game over";
		}

		private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			CurrentClock.Pause();

			playingLabel.Text = CurrentClock.UserNames[CurrentClock.RunningIndex] + "(Paused)";
		}
	}
}
