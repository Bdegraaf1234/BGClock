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
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.mainTab = new System.Windows.Forms.TabPage();
			this.summaryTab = new System.Windows.Forms.TabPage();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.turnPrefixLabel = new System.Windows.Forms.Label();
			this.nextButton = new System.Windows.Forms.Button();
			this.playingLabel = new System.Windows.Forms.Label();
			this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mainTabControl.SuspendLayout();
			this.mainTab.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
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
			// mainTab
			// 
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
			// 
			// summaryTab
			// 
			this.summaryTab.Location = new System.Drawing.Point(4, 22);
			this.summaryTab.Name = "summaryTab";
			this.summaryTab.Padding = new System.Windows.Forms.Padding(3);
			this.summaryTab.Size = new System.Drawing.Size(792, 400);
			this.summaryTab.TabIndex = 1;
			this.summaryTab.Text = "summary";
			this.summaryTab.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem});
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
            this.pauseToolStripMenuItem});
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
			// turnPrefixLabel
			// 
			this.turnPrefixLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
			this.nextButton.Location = new System.Drawing.Point(288, 152);
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new System.Drawing.Size(190, 173);
			this.nextButton.TabIndex = 2;
			this.nextButton.Text = "Next";
			this.nextButton.UseVisualStyleBackColor = true;
			this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
			// 
			// playingLabel
			// 
			this.playingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.playingLabel.AutoSize = true;
			this.playingLabel.Location = new System.Drawing.Point(351, 47);
			this.playingLabel.Name = "playingLabel";
			this.playingLabel.Size = new System.Drawing.Size(0, 13);
			this.playingLabel.TabIndex = 3;
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
			this.mainTabControl.ResumeLayout(false);
			this.mainTab.ResumeLayout(false);
			this.mainTab.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.TabPage mainTab;
		private System.Windows.Forms.TabPage summaryTab;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.Label playingLabel;
		private System.Windows.Forms.Button nextButton;
		private System.Windows.Forms.Label turnPrefixLabel;
		private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
	}
}

