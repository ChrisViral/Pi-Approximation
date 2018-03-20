
namespace Pi_Approximation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.resetButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.gapBox = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.generateButton = new System.Windows.Forms.Button();
            this.generateLabel = new System.Windows.Forms.Label();
            this.generateSuccessively = new System.Windows.Forms.RadioButton();
            this.generateOnce = new System.Windows.Forms.RadioButton();
            this.dataLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.menu.SuspendLayout();
            this.infoBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gapBox)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox.Location = new System.Drawing.Point(12, 31);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(594, 594);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox.TabIndex = 0;
            this.imageBox.TabStop = false;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuButton});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(624, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuButton
            // 
            this.menuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetButton,
            this.aboutButton,
            this.quitButton});
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(58, 24);
            this.menuButton.Text = "Menu";
            // 
            // resetButton
            // 
            this.resetButton.Name = "resetButton";
            this.resetButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetButton.Size = new System.Drawing.Size(216, 26);
            this.resetButton.Text = "Reset";
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(216, 26);
            this.aboutButton.Text = "About...";
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Name = "quitButton";
            this.quitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitButton.Size = new System.Drawing.Size(216, 26);
            this.quitButton.Text = "Quit";
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoBox.Controls.Add(this.msLabel);
            this.infoBox.Controls.Add(this.gapBox);
            this.infoBox.Controls.Add(this.startButton);
            this.infoBox.Controls.Add(this.generateButton);
            this.infoBox.Controls.Add(this.generateLabel);
            this.infoBox.Controls.Add(this.generateSuccessively);
            this.infoBox.Controls.Add(this.generateOnce);
            this.infoBox.Controls.Add(this.dataLabel);
            this.infoBox.Controls.Add(this.infoLabel);
            this.infoBox.Location = new System.Drawing.Point(12, 637);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(600, 100);
            this.infoBox.TabIndex = 2;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "Info";
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Enabled = false;
            this.msLabel.Location = new System.Drawing.Point(568, 58);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(26, 17);
            this.msLabel.TabIndex = 8;
            this.msLabel.Text = "ms";
            // 
            // gapBox
            // 
            this.gapBox.Enabled = false;
            this.gapBox.Location = new System.Drawing.Point(488, 56);
            this.gapBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gapBox.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.gapBox.Name = "gapBox";
            this.gapBox.Size = new System.Drawing.Size(80, 22);
            this.gapBox.TabIndex = 7;
            this.gapBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gapBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.gapBox.ValueChanged += new System.EventHandler(this.GapBox_ValueChanged);
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(406, 51);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(76, 30);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(406, 15);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(188, 30);
            this.generateButton.TabIndex = 5;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // generateLabel
            // 
            this.generateLabel.AutoSize = true;
            this.generateLabel.Location = new System.Drawing.Point(180, 22);
            this.generateLabel.Name = "generateLabel";
            this.generateLabel.Size = new System.Drawing.Size(72, 17);
            this.generateLabel.TabIndex = 4;
            this.generateLabel.Text = "Generate:";
            this.generateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // generateSuccessively
            // 
            this.generateSuccessively.AutoSize = true;
            this.generateSuccessively.Location = new System.Drawing.Point(258, 56);
            this.generateSuccessively.Name = "generateSuccessively";
            this.generateSuccessively.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateSuccessively.Size = new System.Drawing.Size(108, 21);
            this.generateSuccessively.TabIndex = 3;
            this.generateSuccessively.Text = "successively";
            this.generateSuccessively.UseVisualStyleBackColor = true;
            this.generateSuccessively.CheckedChanged += new System.EventHandler(this.GenerateSuccessively_CheckedChanged);
            // 
            // generateOnce
            // 
            this.generateOnce.AutoSize = true;
            this.generateOnce.Checked = true;
            this.generateOnce.Location = new System.Drawing.Point(258, 20);
            this.generateOnce.Name = "generateOnce";
            this.generateOnce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.generateOnce.Size = new System.Drawing.Size(60, 21);
            this.generateOnce.TabIndex = 2;
            this.generateOnce.TabStop = true;
            this.generateOnce.Text = "once";
            this.generateOnce.UseVisualStyleBackColor = true;
            this.generateOnce.CheckedChanged += new System.EventHandler(this.GenerateOnce_CheckedChanged);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(121, 22);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(16, 68);
            this.dataLabel.TabIndex = 1;
            this.dataLabel.Text = "0\r\n0\r\n0\r\n0";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(7, 22);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(120, 68);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "Points generated:\r\nWithin circle:\r\nOutside circle:\r\nCalculated Pi:";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 749);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(642, 796);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Pi Approximator";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gapBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuButton;
        private System.Windows.Forms.ToolStripMenuItem resetButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem quitButton;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Label generateLabel;
        private System.Windows.Forms.RadioButton generateSuccessively;
        private System.Windows.Forms.RadioButton generateOnce;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.NumericUpDown gapBox;
        private System.Windows.Forms.Button startButton;
    }
}

