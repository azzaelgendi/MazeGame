namespace AElgendyAssignment2
{
    partial class PlayForm
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
            this.components = new System.ComponentModel.Container();
            this.dlgLoad = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnleft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.navToolBox = new System.Windows.Forms.GroupBox();
            this.labelNMoves = new System.Windows.Forms.Label();
            this.labelShowMoves = new System.Windows.Forms.Label();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.navToolBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgLoad
            // 
            this.dlgLoad.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1302, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadGameToolStripMenuItem
            // 
            this.loadGameToolStripMenuItem.Name = "loadGameToolStripMenuItem";
            this.loadGameToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.loadGameToolStripMenuItem.Text = "Load Game";
            this.loadGameToolStripMenuItem.Click += new System.EventHandler(this.loadGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.Location = new System.Drawing.Point(85, 22);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(58, 76);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnleft
            // 
            this.btnleft.Location = new System.Drawing.Point(30, 95);
            this.btnleft.Name = "btnleft";
            this.btnleft.Size = new System.Drawing.Size(58, 76);
            this.btnleft.TabIndex = 1;
            this.btnleft.UseVisualStyleBackColor = true;
            this.btnleft.Click += new System.EventHandler(this.btnleft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(139, 95);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(58, 76);
            this.btnRight.TabIndex = 1;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(85, 166);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(58, 76);
            this.btnDown.TabIndex = 1;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // navToolBox
            // 
            this.navToolBox.Controls.Add(this.btnDown);
            this.navToolBox.Controls.Add(this.btnRight);
            this.navToolBox.Controls.Add(this.btnleft);
            this.navToolBox.Controls.Add(this.btnUp);
            this.navToolBox.Location = new System.Drawing.Point(1080, 140);
            this.navToolBox.Name = "navToolBox";
            this.navToolBox.Size = new System.Drawing.Size(215, 259);
            this.navToolBox.TabIndex = 2;
            this.navToolBox.TabStop = false;
            this.navToolBox.Text = "Tool Box";
            // 
            // labelNMoves
            // 
            this.labelNMoves.AutoSize = true;
            this.labelNMoves.Location = new System.Drawing.Point(1127, 42);
            this.labelNMoves.Name = "labelNMoves";
            this.labelNMoves.Size = new System.Drawing.Size(122, 17);
            this.labelNMoves.TabIndex = 3;
            this.labelNMoves.Text = "Number Of Moves";
            // 
            // labelShowMoves
            // 
            this.labelShowMoves.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelShowMoves.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShowMoves.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShowMoves.Location = new System.Drawing.Point(1110, 80);
            this.labelShowMoves.Name = "labelShowMoves";
            this.labelShowMoves.Size = new System.Drawing.Size(161, 36);
            this.labelShowMoves.TabIndex = 3;
            this.labelShowMoves.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 1000;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 593);
            this.Controls.Add(this.labelShowMoves);
            this.Controls.Add(this.labelNMoves);
            this.Controls.Add(this.navToolBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayForm";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.PlayForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.navToolBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgLoad;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnleft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.GroupBox navToolBox;
        private System.Windows.Forms.Label labelNMoves;
        private System.Windows.Forms.Label labelShowMoves;
        private System.Windows.Forms.Timer timerAnimation;
    }
}