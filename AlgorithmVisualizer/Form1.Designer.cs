
namespace AlgorithmVisualizer {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAlgorithmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countingSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cyanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowScanlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.currentAlgorithmLabel = new System.Windows.Forms.Label();
            this.playPauseButton = new System.Windows.Forms.Button();
            this.ScaleSelector = new System.Windows.Forms.NumericUpDown();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.SlowdownLabel = new System.Windows.Forms.Label();
            this.SlowdownSelector = new System.Windows.Forms.NumericUpDown();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SortLengthTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlowdownSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gray;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sortOptionsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(1, 1);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(942, 27);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.selectAlgorithmToolStripMenuItem});
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // selectAlgorithmToolStripMenuItem
            // 
            this.selectAlgorithmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem,
            this.selectSortToolStripMenuItem,
            this.countingSortToolStripMenuItem});
            this.selectAlgorithmToolStripMenuItem.Name = "selectAlgorithmToolStripMenuItem";
            this.selectAlgorithmToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.selectAlgorithmToolStripMenuItem.Text = "Select Algorithm";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.bubbleSortToolStripMenuItem.Text = "Bubble Sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.BubbleSortToolStripMenuItem_Click);
            // 
            // selectSortToolStripMenuItem
            // 
            this.selectSortToolStripMenuItem.Name = "selectSortToolStripMenuItem";
            this.selectSortToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.selectSortToolStripMenuItem.Text = "Select Sort";
            this.selectSortToolStripMenuItem.Click += new System.EventHandler(this.SelectSortToolStripMenuItem_Click);
            // 
            // countingSortToolStripMenuItem
            // 
            this.countingSortToolStripMenuItem.Name = "countingSortToolStripMenuItem";
            this.countingSortToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.countingSortToolStripMenuItem.Text = "Radix Sort (LSD)";
            this.countingSortToolStripMenuItem.Click += new System.EventHandler(this.RadixLSDSortToolStripMenuItem_Click);
            // 
            // sortOptionsToolStripMenuItem
            // 
            this.sortOptionsToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.sortOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.ShowScanlineToolStripMenuItem});
            this.sortOptionsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sortOptionsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(1);
            this.sortOptionsToolStripMenuItem.Name = "sortOptionsToolStripMenuItem";
            this.sortOptionsToolStripMenuItem.Size = new System.Drawing.Size(85, 19);
            this.sortOptionsToolStripMenuItem.Text = "Sort Options";
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.whiteToolStripMenuItem,
            this.cyanToolStripMenuItem,
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.yellowToolStripMenuItem,
            this.greyToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.WhiteToolStripMenuItem_Click);
            // 
            // cyanToolStripMenuItem
            // 
            this.cyanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cyanToolStripMenuItem.Name = "cyanToolStripMenuItem";
            this.cyanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cyanToolStripMenuItem.Text = "Cyan";
            this.cyanToolStripMenuItem.Click += new System.EventHandler(this.CyanToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.RedToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.BackColor = System.Drawing.Color.Blue;
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.BlueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.GreenToolStripMenuItem_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.YellowToolStripMenuItem_Click);
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greyToolStripMenuItem.Text = "Grey";
            this.greyToolStripMenuItem.Click += new System.EventHandler(this.GreyToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.BackColor = System.Drawing.Color.Purple;
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.PurpleToolStripMenuItem_Click);
            // 
            // ShowScanlineToolStripMenuItem
            // 
            this.ShowScanlineToolStripMenuItem.BackColor = System.Drawing.Color.Green;
            this.ShowScanlineToolStripMenuItem.Name = "ShowScanlineToolStripMenuItem";
            this.ShowScanlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ShowScanlineToolStripMenuItem.Text = "Gradient";
            this.ShowScanlineToolStripMenuItem.Click += new System.EventHandler(this.GradientSelectToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TimeLabel);
            this.panel1.Controls.Add(this.currentAlgorithmLabel);
            this.panel1.Location = new System.Drawing.Point(13, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 410);
            this.panel1.TabIndex = 2;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.BackColor = System.Drawing.Color.Black;
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(-1, 13);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(0, 13);
            this.TimeLabel.TabIndex = 8;
            this.TimeLabel.Visible = false;
            // 
            // currentAlgorithmLabel
            // 
            this.currentAlgorithmLabel.AutoSize = true;
            this.currentAlgorithmLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentAlgorithmLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.currentAlgorithmLabel.ForeColor = System.Drawing.Color.White;
            this.currentAlgorithmLabel.Location = new System.Drawing.Point(0, 0);
            this.currentAlgorithmLabel.Name = "currentAlgorithmLabel";
            this.currentAlgorithmLabel.Size = new System.Drawing.Size(73, 13);
            this.currentAlgorithmLabel.TabIndex = 0;
            this.currentAlgorithmLabel.Text = "Bubble Sort";
            this.currentAlgorithmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // playPauseButton
            // 
            this.playPauseButton.BackColor = System.Drawing.Color.White;
            this.playPauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.playPauseButton.Location = new System.Drawing.Point(13, 47);
            this.playPauseButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playPauseButton.Name = "playPauseButton";
            this.playPauseButton.Size = new System.Drawing.Size(75, 22);
            this.playPauseButton.TabIndex = 4;
            this.playPauseButton.Text = "Play";
            this.playPauseButton.UseVisualStyleBackColor = false;
            this.playPauseButton.Click += new System.EventHandler(this.PlayPauseButton_Click);
            // 
            // ScaleSelector
            // 
            this.ScaleSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleSelector.Location = new System.Drawing.Point(714, 50);
            this.ScaleSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScaleSelector.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ScaleSelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScaleSelector.Name = "ScaleSelector";
            this.ScaleSelector.Size = new System.Drawing.Size(51, 20);
            this.ScaleSelector.TabIndex = 5;
            this.ScaleSelector.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScaleSelector.ValueChanged += new System.EventHandler(this.ScaleSelector_ValueChanged);
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.ForeColor = System.Drawing.Color.White;
            this.ScaleLabel.Location = new System.Drawing.Point(665, 55);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(43, 13);
            this.ScaleLabel.TabIndex = 6;
            this.ScaleLabel.Text = "Scale:";
            // 
            // SlowdownLabel
            // 
            this.SlowdownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SlowdownLabel.AutoSize = true;
            this.SlowdownLabel.ForeColor = System.Drawing.Color.White;
            this.SlowdownLabel.Location = new System.Drawing.Point(811, 55);
            this.SlowdownLabel.Name = "SlowdownLabel";
            this.SlowdownLabel.Size = new System.Drawing.Size(61, 13);
            this.SlowdownLabel.TabIndex = 6;
            this.SlowdownLabel.Text = "Slowdown:";
            // 
            // SlowdownSelector
            // 
            this.SlowdownSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SlowdownSelector.Location = new System.Drawing.Point(878, 50);
            this.SlowdownSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SlowdownSelector.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SlowdownSelector.Name = "SlowdownSelector";
            this.SlowdownSelector.Size = new System.Drawing.Size(53, 20);
            this.SlowdownSelector.TabIndex = 7;
            this.SlowdownSelector.ValueChanged += new System.EventHandler(this.SlowdownSelector_ValueChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.White;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ResetButton.Location = new System.Drawing.Point(94, 47);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 22);
            this.ResetButton.TabIndex = 4;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SortLengthTimer
            // 
            this.SortLengthTimer.Interval = 1;
            this.SortLengthTimer.Tick += new System.EventHandler(this.SortLengthTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.SlowdownSelector);
            this.Controls.Add(this.SlowdownLabel);
            this.Controls.Add(this.ScaleLabel);
            this.Controls.Add(this.ScaleSelector);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.playPauseButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(500, 399);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cyprus\' sorting algorithm visualizer v0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SlowdownSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem selectAlgorithmToolStripMenuItem;
        private System.Windows.Forms.Label currentAlgorithmLabel;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSortToolStripMenuItem;
        private System.Windows.Forms.Button playPauseButton;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cyanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown ScaleSelector;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Label SlowdownLabel;
        private System.Windows.Forms.NumericUpDown SlowdownSelector;
        private System.Windows.Forms.ToolStripMenuItem countingSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowScanlineToolStripMenuItem;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer SortLengthTimer;
    }
}

