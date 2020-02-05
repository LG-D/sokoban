namespace LGashiAssignment1
{
    partial class MazeDesignerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeDesignerForm));
            this.lblRows = new System.Windows.Forms.Label();
            this.lblColumns = new System.Windows.Forms.Label();
            this.pnlUserInput = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtColumns = new System.Windows.Forms.TextBox();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.pnlGameBoard = new System.Windows.Forms.Panel();
            this.pnlToolBox = new System.Windows.Forms.Panel();
            this.picDestination = new System.Windows.Forms.PictureBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.picWall = new System.Windows.Forms.PictureBox();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.picNone = new System.Windows.Forms.PictureBox();
            this.lblToolBox = new System.Windows.Forms.Label();
            this.rdbDestination = new System.Windows.Forms.RadioButton();
            this.rdbWall = new System.Windows.Forms.RadioButton();
            this.rdbBox = new System.Windows.Forms.RadioButton();
            this.rdbHero = new System.Windows.Forms.RadioButton();
            this.rdbNone = new System.Windows.Forms.RadioButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlUserInput.SuspendLayout();
            this.pnlToolBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNone)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(57, 21);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(46, 17);
            this.lblRows.TabIndex = 0;
            this.lblRows.Text = "Rows:";
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(305, 21);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(66, 17);
            this.lblColumns.TabIndex = 1;
            this.lblColumns.Text = "Columns:";
            // 
            // pnlUserInput
            // 
            this.pnlUserInput.Controls.Add(this.btnGenerate);
            this.pnlUserInput.Controls.Add(this.txtColumns);
            this.pnlUserInput.Controls.Add(this.txtRows);
            this.pnlUserInput.Controls.Add(this.lblRows);
            this.pnlUserInput.Controls.Add(this.lblColumns);
            this.pnlUserInput.Location = new System.Drawing.Point(34, 30);
            this.pnlUserInput.Name = "pnlUserInput";
            this.pnlUserInput.Size = new System.Drawing.Size(767, 58);
            this.pnlUserInput.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(552, 17);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(97, 25);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtColumns
            // 
            this.txtColumns.Location = new System.Drawing.Point(401, 18);
            this.txtColumns.Name = "txtColumns";
            this.txtColumns.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtColumns.Size = new System.Drawing.Size(100, 22);
            this.txtColumns.TabIndex = 3;
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(126, 18);
            this.txtRows.Name = "txtRows";
            this.txtRows.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRows.Size = new System.Drawing.Size(100, 22);
            this.txtRows.TabIndex = 2;
            // 
            // pnlGameBoard
            // 
            this.pnlGameBoard.AutoSize = true;
            this.pnlGameBoard.Location = new System.Drawing.Point(270, 111);
            this.pnlGameBoard.Name = "pnlGameBoard";
            this.pnlGameBoard.Size = new System.Drawing.Size(1018, 500);
            this.pnlGameBoard.TabIndex = 3;
            // 
            // pnlToolBox
            // 
            this.pnlToolBox.Controls.Add(this.picDestination);
            this.pnlToolBox.Controls.Add(this.picBox);
            this.pnlToolBox.Controls.Add(this.picWall);
            this.pnlToolBox.Controls.Add(this.picHero);
            this.pnlToolBox.Controls.Add(this.picNone);
            this.pnlToolBox.Controls.Add(this.lblToolBox);
            this.pnlToolBox.Controls.Add(this.rdbDestination);
            this.pnlToolBox.Controls.Add(this.rdbWall);
            this.pnlToolBox.Controls.Add(this.rdbBox);
            this.pnlToolBox.Controls.Add(this.rdbHero);
            this.pnlToolBox.Controls.Add(this.rdbNone);
            this.pnlToolBox.Location = new System.Drawing.Point(34, 111);
            this.pnlToolBox.Name = "pnlToolBox";
            this.pnlToolBox.Size = new System.Drawing.Size(210, 500);
            this.pnlToolBox.TabIndex = 4;
            // 
            // picDestination
            // 
            this.picDestination.Image = global::LGashiAssignment1.Properties.Resources.yellow;
            this.picDestination.Location = new System.Drawing.Point(11, 414);
            this.picDestination.Name = "picDestination";
            this.picDestination.Size = new System.Drawing.Size(78, 64);
            this.picDestination.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDestination.TabIndex = 14;
            this.picDestination.TabStop = false;
            // 
            // picBox
            // 
            this.picBox.Image = global::LGashiAssignment1.Properties.Resources.box_tile;
            this.picBox.Location = new System.Drawing.Point(11, 319);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(78, 64);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // picWall
            // 
            this.picWall.Image = ((System.Drawing.Image)(resources.GetObject("picWall.Image")));
            this.picWall.Location = new System.Drawing.Point(11, 227);
            this.picWall.Name = "picWall";
            this.picWall.Size = new System.Drawing.Size(78, 64);
            this.picWall.TabIndex = 12;
            this.picWall.TabStop = false;
            // 
            // picHero
            // 
            this.picHero.Image = global::LGashiAssignment1.Properties.Resources.gaby;
            this.picHero.Location = new System.Drawing.Point(11, 133);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(78, 64);
            this.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHero.TabIndex = 11;
            this.picHero.TabStop = false;
            // 
            // picNone
            // 
            this.picNone.Image = global::LGashiAssignment1.Properties.Resources.none_tile;
            this.picNone.Location = new System.Drawing.Point(11, 39);
            this.picNone.Name = "picNone";
            this.picNone.Size = new System.Drawing.Size(78, 64);
            this.picNone.TabIndex = 0;
            this.picNone.TabStop = false;
            // 
            // lblToolBox
            // 
            this.lblToolBox.AutoSize = true;
            this.lblToolBox.Location = new System.Drawing.Point(67, 0);
            this.lblToolBox.Name = "lblToolBox";
            this.lblToolBox.Size = new System.Drawing.Size(59, 17);
            this.lblToolBox.TabIndex = 5;
            this.lblToolBox.Text = "ToolBox";
            // 
            // rdbDestination
            // 
            this.rdbDestination.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbDestination.Location = new System.Drawing.Point(3, 401);
            this.rdbDestination.Name = "rdbDestination";
            this.rdbDestination.Size = new System.Drawing.Size(191, 87);
            this.rdbDestination.TabIndex = 10;
            this.rdbDestination.TabStop = true;
            this.rdbDestination.Text = "Destination";
            this.rdbDestination.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbDestination.UseVisualStyleBackColor = true;
            this.rdbDestination.CheckedChanged += new System.EventHandler(this.tool_CheckedChanged);
            // 
            // rdbWall
            // 
            this.rdbWall.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbWall.Location = new System.Drawing.Point(4, 215);
            this.rdbWall.Name = "rdbWall";
            this.rdbWall.Size = new System.Drawing.Size(191, 87);
            this.rdbWall.TabIndex = 9;
            this.rdbWall.TabStop = true;
            this.rdbWall.Text = "Wall";
            this.rdbWall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbWall.UseVisualStyleBackColor = true;
            this.rdbWall.CheckedChanged += new System.EventHandler(this.tool_CheckedChanged);
            // 
            // rdbBox
            // 
            this.rdbBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbBox.Location = new System.Drawing.Point(4, 308);
            this.rdbBox.Name = "rdbBox";
            this.rdbBox.Size = new System.Drawing.Size(191, 87);
            this.rdbBox.TabIndex = 8;
            this.rdbBox.Text = "Box";
            this.rdbBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbBox.UseVisualStyleBackColor = true;
            this.rdbBox.CheckedChanged += new System.EventHandler(this.tool_CheckedChanged);
            // 
            // rdbHero
            // 
            this.rdbHero.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbHero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbHero.Location = new System.Drawing.Point(4, 122);
            this.rdbHero.Name = "rdbHero";
            this.rdbHero.Size = new System.Drawing.Size(191, 87);
            this.rdbHero.TabIndex = 7;
            this.rdbHero.TabStop = true;
            this.rdbHero.Text = "Hero";
            this.rdbHero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbHero.UseVisualStyleBackColor = true;
            this.rdbHero.CheckedChanged += new System.EventHandler(this.tool_CheckedChanged);
            // 
            // rdbNone
            // 
            this.rdbNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdbNone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdbNone.Location = new System.Drawing.Point(4, 29);
            this.rdbNone.Name = "rdbNone";
            this.rdbNone.Size = new System.Drawing.Size(191, 87);
            this.rdbNone.TabIndex = 6;
            this.rdbNone.TabStop = true;
            this.rdbNone.Text = "None";
            this.rdbNone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rdbNone.UseVisualStyleBackColor = true;
            this.rdbNone.CheckedChanged += new System.EventHandler(this.tool_CheckedChanged);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1352, 28);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MazeDesignerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1352, 727);
            this.Controls.Add(this.pnlToolBox);
            this.Controls.Add(this.pnlGameBoard);
            this.Controls.Add(this.pnlUserInput);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MazeDesignerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Design Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MazeDesignerForm_FormClosing);
            this.pnlUserInput.ResumeLayout(false);
            this.pnlUserInput.PerformLayout();
            this.pnlToolBox.ResumeLayout(false);
            this.pnlToolBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDestination)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNone)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Panel pnlUserInput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtColumns;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Panel pnlGameBoard;
        private System.Windows.Forms.Panel pnlToolBox;
        private System.Windows.Forms.Label lblToolBox;
        private System.Windows.Forms.RadioButton rdbDestination;
        private System.Windows.Forms.RadioButton rdbWall;
        private System.Windows.Forms.RadioButton rdbBox;
        private System.Windows.Forms.RadioButton rdbHero;
        private System.Windows.Forms.RadioButton rdbNone;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picNone;
        private System.Windows.Forms.PictureBox picWall;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.PictureBox picDestination;
    }
}