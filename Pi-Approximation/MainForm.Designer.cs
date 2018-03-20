
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
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.resetButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.quitButton = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBox
            // 
            this.imageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imageBox.Location = new System.Drawing.Point(12, 31);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(625, 380);
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
            this.menu.Size = new System.Drawing.Size(649, 28);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuButton
            // 
            this.menuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetButton,
            this.saveImageButton,
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
            // 
            // saveImageButton
            // 
            this.saveImageButton.Name = "saveImageButton";
            this.saveImageButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveImageButton.Size = new System.Drawing.Size(216, 26);
            this.saveImageButton.Text = "Save image";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(216, 26);
            this.aboutButton.Text = "About...";
            // 
            // quitButton
            // 
            this.quitButton.Name = "quitButton";
            this.quitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitButton.Size = new System.Drawing.Size(216, 26);
            this.quitButton.Text = "Quit";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 496);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Pi Approximator";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuButton;
        private System.Windows.Forms.ToolStripMenuItem resetButton;
        private System.Windows.Forms.ToolStripMenuItem saveImageButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripMenuItem quitButton;
    }
}

