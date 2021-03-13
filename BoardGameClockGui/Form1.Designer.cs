namespace BoardGameClockGui
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.summaryTab = new System.Windows.Forms.TabPage();
			this.boxplotControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.mainTab = new System.Windows.Forms.TabPage();
			this.pauseButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.newButton = new System.Windows.Forms.Button();
			this.playingLabel = new System.Windows.Forms.Label();
			this.nextButton = new System.Windows.Forms.Button();
			this.turnPrefixLabel = new System.Windows.Forms.Label();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.summaryTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.boxplotControl)).BeginInit();
			this.mainTab.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// summaryTab
			// 
			this.summaryTab.Controls.Add(this.boxplotControl);
			this.summaryTab.Location = new System.Drawing.Point(4, 22);
			this.summaryTab.Name = "summaryTab";
			this.summaryTab.Padding = new System.Windows.Forms.Padding(3);
			this.summaryTab.Size = new System.Drawing.Size(792, 424);
			this.summaryTab.TabIndex = 1;
			this.summaryTab.Text = "summary";
			this.summaryTab.UseVisualStyleBackColor = true;
			// 
			// boxplotControl
			// 
			chartArea3.Name = "ChartArea1";
			this.boxplotControl.ChartAreas.Add(chartArea3);
			this.boxplotControl.Dock = System.Windows.Forms.DockStyle.Fill;
			legend3.Name = "Legend1";
			this.boxplotControl.Legends.Add(legend3);
			this.boxplotControl.Location = new System.Drawing.Point(3, 3);
			this.boxplotControl.Name = "boxplotControl";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.boxplotControl.Series.Add(series3);
			this.boxplotControl.Size = new System.Drawing.Size(786, 418);
			this.boxplotControl.TabIndex = 1;
			this.boxplotControl.Text = "boxplotControl";
			this.boxplotControl.Click += new System.EventHandler(this.boxplotControl_Click);
			// 
			// mainTab
			// 
			this.mainTab.Controls.Add(this.pauseButton);
			this.mainTab.Controls.Add(this.stopButton);
			this.mainTab.Controls.Add(this.startButton);
			this.mainTab.Controls.Add(this.newButton);
			this.mainTab.Controls.Add(this.playingLabel);
			this.mainTab.Controls.Add(this.nextButton);
			this.mainTab.Controls.Add(this.turnPrefixLabel);
			this.mainTab.Location = new System.Drawing.Point(4, 22);
			this.mainTab.Name = "mainTab";
			this.mainTab.Padding = new System.Windows.Forms.Padding(3);
			this.mainTab.Size = new System.Drawing.Size(792, 424);
			this.mainTab.TabIndex = 0;
			this.mainTab.Text = "main";
			this.mainTab.UseVisualStyleBackColor = true;
			// 
			// pauseButton
			// 
			this.pauseButton.Location = new System.Drawing.Point(20, 105);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(75, 23);
			this.pauseButton.TabIndex = 7;
			this.pauseButton.Text = "Pause";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Visible = false;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(20, 76);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(75, 23);
			this.stopButton.TabIndex = 6;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Visible = false;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(20, 47);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Visible = false;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// newButton
			// 
			this.newButton.Location = new System.Drawing.Point(20, 18);
			this.newButton.Name = "newButton";
			this.newButton.Size = new System.Drawing.Size(75, 23);
			this.newButton.TabIndex = 4;
			this.newButton.Text = "New";
			this.newButton.UseVisualStyleBackColor = true;
			this.newButton.Click += new System.EventHandler(this.newButton_Click);
			// 
			// playingLabel
			// 
			this.playingLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.playingLabel.AutoSize = true;
			this.playingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playingLabel.Location = new System.Drawing.Point(375, 51);
			this.playingLabel.Name = "playingLabel";
			this.playingLabel.Size = new System.Drawing.Size(0, 74);
			this.playingLabel.TabIndex = 3;
			this.playingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// nextButton
			// 
			this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nextButton.BackColor = System.Drawing.Color.Firebrick;
			this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextButton.Location = new System.Drawing.Point(265, 128);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(264, 288);
			this.nextButton.TabIndex = 2;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = false;
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			this.nextButton.Resize += new System.EventHandler(this.nextButton_Resize);
			// 
			// turnPrefixLabel
			// 
			this.turnPrefixLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.turnPrefixLabel.AutoSize = true;
			this.turnPrefixLabel.Location = new System.Drawing.Point(351, 18);
			this.turnPrefixLabel.Name = "turnPrefixLabel";
			this.turnPrefixLabel.Size = new System.Drawing.Size(44, 13);
			this.turnPrefixLabel.TabIndex = 0;
			this.turnPrefixLabel.Text = "Playing:";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.mainTab);
			this.mainTabControl.Controls.Add(this.summaryTab);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(800, 450);
			this.mainTabControl.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainTabControl);
			this.Name = "Form1";
			this.Text = "Form1";
			this.summaryTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.boxplotControl)).EndInit();
			this.mainTab.ResumeLayout(false);
			this.mainTab.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabPage summaryTab;
		private System.Windows.Forms.TabPage mainTab;
		private System.Windows.Forms.Label playingLabel;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Label turnPrefixLabel;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.DataVisualization.Charting.Chart boxplotControl;
		private System.Windows.Forms.Button pauseButton;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button newButton;
	}
}

