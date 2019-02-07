namespace AElgendyAssignment2
{
    partial class DesignForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSave = new System.Windows.Forms.SaveFileDialog();
            this.btnNone = new System.Windows.Forms.Button();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.btnYellowBox = new System.Windows.Forms.Button();
            this.btnGreenBox = new System.Windows.Forms.Button();
            this.btnRedBox = new System.Windows.Forms.Button();
            this.btnBlueBox = new System.Windows.Forms.Button();
            this.btnGreenDoor = new System.Windows.Forms.Button();
            this.btnRedDoor = new System.Windows.Forms.Button();
            this.btnYellowDoor = new System.Windows.Forms.Button();
            this.btnBlueDoor = new System.Windows.Forms.Button();
            this.btnWall = new System.Windows.Forms.Button();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblColumn = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(22, 21);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(250, 69);
            this.btnNone.TabIndex = 1;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.btnYellowBox);
            this.groupBoxTools.Controls.Add(this.btnGreenBox);
            this.groupBoxTools.Controls.Add(this.btnRedBox);
            this.groupBoxTools.Controls.Add(this.btnBlueBox);
            this.groupBoxTools.Controls.Add(this.btnGreenDoor);
            this.groupBoxTools.Controls.Add(this.btnRedDoor);
            this.groupBoxTools.Controls.Add(this.btnYellowDoor);
            this.groupBoxTools.Controls.Add(this.btnBlueDoor);
            this.groupBoxTools.Controls.Add(this.btnWall);
            this.groupBoxTools.Controls.Add(this.btnNone);
            this.groupBoxTools.Location = new System.Drawing.Point(22, 31);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(295, 803);
            this.groupBoxTools.TabIndex = 2;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tool Box";
            // 
            // btnYellowBox
            // 
            this.btnYellowBox.Location = new System.Drawing.Point(22, 695);
            this.btnYellowBox.Name = "btnYellowBox";
            this.btnYellowBox.Size = new System.Drawing.Size(250, 69);
            this.btnYellowBox.TabIndex = 1;
            this.btnYellowBox.Text = "Yellow Box";
            this.btnYellowBox.UseVisualStyleBackColor = true;
            this.btnYellowBox.Click += new System.EventHandler(this.btnYellowBox_Click);
            // 
            // btnGreenBox
            // 
            this.btnGreenBox.Location = new System.Drawing.Point(22, 620);
            this.btnGreenBox.Name = "btnGreenBox";
            this.btnGreenBox.Size = new System.Drawing.Size(250, 69);
            this.btnGreenBox.TabIndex = 1;
            this.btnGreenBox.Text = "Green Box";
            this.btnGreenBox.UseVisualStyleBackColor = true;
            this.btnGreenBox.Click += new System.EventHandler(this.btnGreenBox_Click);
            // 
            // btnRedBox
            // 
            this.btnRedBox.Location = new System.Drawing.Point(22, 546);
            this.btnRedBox.Name = "btnRedBox";
            this.btnRedBox.Size = new System.Drawing.Size(250, 69);
            this.btnRedBox.TabIndex = 1;
            this.btnRedBox.Text = "Red Box";
            this.btnRedBox.UseVisualStyleBackColor = true;
            this.btnRedBox.Click += new System.EventHandler(this.btnRedBox_Click);
            // 
            // btnBlueBox
            // 
            this.btnBlueBox.Location = new System.Drawing.Point(22, 471);
            this.btnBlueBox.Name = "btnBlueBox";
            this.btnBlueBox.Size = new System.Drawing.Size(250, 69);
            this.btnBlueBox.TabIndex = 1;
            this.btnBlueBox.Text = "Blue Box";
            this.btnBlueBox.UseVisualStyleBackColor = true;
            this.btnBlueBox.Click += new System.EventHandler(this.btnBlueBox_Click);
            // 
            // btnGreenDoor
            // 
            this.btnGreenDoor.Location = new System.Drawing.Point(22, 396);
            this.btnGreenDoor.Name = "btnGreenDoor";
            this.btnGreenDoor.Size = new System.Drawing.Size(250, 69);
            this.btnGreenDoor.TabIndex = 1;
            this.btnGreenDoor.Text = "Green Door";
            this.btnGreenDoor.UseVisualStyleBackColor = true;
            this.btnGreenDoor.Click += new System.EventHandler(this.btnGreenDoor_Click);
            // 
            // btnRedDoor
            // 
            this.btnRedDoor.Location = new System.Drawing.Point(22, 321);
            this.btnRedDoor.Name = "btnRedDoor";
            this.btnRedDoor.Size = new System.Drawing.Size(250, 69);
            this.btnRedDoor.TabIndex = 1;
            this.btnRedDoor.Text = "Red Door";
            this.btnRedDoor.UseVisualStyleBackColor = true;
            this.btnRedDoor.Click += new System.EventHandler(this.btnRedDoor_Click);
            // 
            // btnYellowDoor
            // 
            this.btnYellowDoor.Location = new System.Drawing.Point(22, 246);
            this.btnYellowDoor.Name = "btnYellowDoor";
            this.btnYellowDoor.Size = new System.Drawing.Size(250, 69);
            this.btnYellowDoor.TabIndex = 1;
            this.btnYellowDoor.Text = "Yellow Door";
            this.btnYellowDoor.UseVisualStyleBackColor = true;
            this.btnYellowDoor.Click += new System.EventHandler(this.btnYellowDoor_Click);
            // 
            // btnBlueDoor
            // 
            this.btnBlueDoor.Location = new System.Drawing.Point(22, 171);
            this.btnBlueDoor.Name = "btnBlueDoor";
            this.btnBlueDoor.Size = new System.Drawing.Size(250, 69);
            this.btnBlueDoor.TabIndex = 1;
            this.btnBlueDoor.Text = "Blue Door";
            this.btnBlueDoor.UseVisualStyleBackColor = true;
            this.btnBlueDoor.Click += new System.EventHandler(this.btnBlueDoor_Click);
            // 
            // btnWall
            // 
            this.btnWall.Location = new System.Drawing.Point(22, 96);
            this.btnWall.Name = "btnWall";
            this.btnWall.Size = new System.Drawing.Size(250, 69);
            this.btnWall.TabIndex = 1;
            this.btnWall.Text = "Wall";
            this.btnWall.UseVisualStyleBackColor = true;
            this.btnWall.Click += new System.EventHandler(this.btnWall_Click);
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(647, 31);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 3;
            // 
            // txtColumn
            // 
            this.txtColumn.Location = new System.Drawing.Point(453, 31);
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.Size = new System.Drawing.Size(100, 22);
            this.txtColumn.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(792, 31);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(88, 22);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(376, 36);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(55, 17);
            this.lblColumn.TabIndex = 5;
            this.lblColumn.Text = "Column";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(576, 31);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(30, 17);
            this.lblRow.TabIndex = 5;
            this.lblRow.Text = "row";
            // 
            // DesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 846);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblColumn);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtColumn);
            this.Controls.Add(this.txtRows);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DesignForm";
            this.Text = "DesignForm";
            this.Load += new System.EventHandler(this.DesignForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxTools.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgSave;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.Button btnRedBox;
        private System.Windows.Forms.Button btnBlueBox;
        private System.Windows.Forms.Button btnGreenDoor;
        private System.Windows.Forms.Button btnRedDoor;
        private System.Windows.Forms.Button btnYellowDoor;
        private System.Windows.Forms.Button btnBlueDoor;
        private System.Windows.Forms.Button btnWall;
        private System.Windows.Forms.Button btnGreenBox;
        private System.Windows.Forms.Button btnYellowBox;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label lblRow;
    }
}