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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fromJsonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.summaryTab = new System.Windows.Forms.TabPage();
			this.mainTab = new System.Windows.Forms.TabPage();
			this.turnPrefixLabel = new System.Windows.Forms.Label();
			this.nextButton = new System.Windows.Forms.Button();
			this.playingLabel = new System.Windows.Forms.Label();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.boxplotControl = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.newButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.pauseButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.summaryTab.SuspendLayout();
			this.mainTab.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.boxplotControl)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.chartsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fIleToolStripMenuItem
			// 
			this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.fromJsonToolStripMenuItem});
			this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
			this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fIleToolStripMenuItem.Text = "File";
			this.fIleToolStripMenuItem.Click += new System.EventHandler(this.fIleToolStripMenuItem_Click);
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// startToolStripMenuItem
			// 
			this.startToolStripMenuItem.Name = "startToolStripMenuItem";
			this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.startToolStripMenuItem.Text = "Start";
			this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
			// 
			// stopToolStripMenuItem
			// 
			this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
			this.stopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.stopToolStripMenuItem.Text = "Stop";
			this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
			// 
			// pauseToolStripMenuItem
			// 
			this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
			this.pauseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pauseToolStripMenuItem.Text = "Pause";
			this.pauseToolStripMenuItem.Click += new System.EventHandler(this.pauseToolStripMenuItem_Click);
			// 
			// fromJsonToolStripMenuItem
			// 
			this.fromJsonToolStripMenuItem.Name = "fromJsonToolStripMenuItem";
			this.fromJsonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fromJsonToolStripMenuItem.Text = "FromJson";
			this.fromJsonToolStripMenuItem.Click += new System.EventHandler(this.fromJsonToolStripMenuItem_Click);
			// 
			// chartsToolStripMenuItem
			// 
			this.chartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem});
			this.chartsToolStripMenuItem.Name = "chartsToolStripMenuItem";
			this.chartsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.chartsToolStripMenuItem.Text = "Charts";
			// 
			// updateToolStripMenuItem
			// 
			this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
			this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
			this.updateToolStripMenuItem.Text = "Update";
			this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
			// 
			// summaryTab
			// 
			this.summaryTab.Controls.Add(this.boxplotControl);
			this.summaryTab.Location = new System.Drawing.Point(4, 22);
			this.summaryTab.Name = "summaryTab";
			this.summaryTab.Padding = new System.Windows.Forms.Padding(3);
			this.summaryTab.Size = new System.Drawing.Size(792, 400);
			this.summaryTab.TabIndex = 1;
			this.summaryTab.Text = "summary";
			this.summaryTab.UseVisualStyleBackColor = true;
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
			this.mainTab.Size = new System.Drawing.Size(792, 400);
			this.mainTab.TabIndex = 0;
			this.mainTab.Text = "main";
			this.mainTab.UseVisualStyleBackColor = true;
			this.mainTab.Click += new System.EventHandler(this.mainTab_Click);
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
			// nextButton
			// 
			this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.nextButton.BackColor = System.Drawing.Color.Firebrick;
			this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 48.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nextButton.Location = new System.Drawing.Point(265, 128);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(264, 264);
			this.nextButton.TabIndex = 2;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = false;
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			this.nextButton.Resize += new System.EventHandler(this.nextButton_Resize);
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
			this.playingLabel.TextChanged += new System.EventHandler(this.playingLabel_TextChanged);
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.mainTab);
			this.mainTabControl.Controls.Add(this.summaryTab);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Location = new System.Drawing.Point(0, 24);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(800, 426);
			this.mainTabControl.TabIndex = 0;
			// 
			// boxplotControl
			// 
			chartArea4.Name = "ChartArea1";
			this.boxplotControl.ChartAreas.Add(chartArea4);
			this.boxplotControl.Dock = System.Windows.Forms.DockStyle.Fill;
			legend4.Name = "Legend1";
			this.boxplotControl.Legends.Add(legend4);
			this.boxplotControl.Location = new System.Drawing.Point(3, 3);
			this.boxplotControl.Name = "boxplotControl";
			series4.ChartArea = "ChartArea1";
			series4.Legend = "Legend1";
			series4.Name = "Series1";
			this.boxplotControl.Series.Add(series4);
			this.boxplotControl.Size = new System.Drawing.Size(786, 394);
			this.boxplotControl.TabIndex = 1;
			this.boxplotControl.Text = "boxplotControl";
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
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(20, 47);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(75, 23);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.Location = new System.Drawing.Point(20, 76);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(75, 23);
			this.stopButton.TabIndex = 6;
			this.stopButton.Text = "Stop";
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// pauseButton
			// 
			this.pauseButton.Location = new System.Drawing.Point(20, 105);
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Size = new System.Drawing.Size(75, 23);
			this.pauseButton.TabIndex = 7;
			this.pauseButton.Text = "Pause";
			this.pauseButton.UseVisualStyleBackColor = true;
			this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.mainTabControl);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.summaryTab.ResumeLayout(false);
			this.mainTab.ResumeLayout(false);
			this.mainTab.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.boxplotControl)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem chartsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fromJsonToolStripMenuItem;
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

