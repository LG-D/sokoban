namespace LGashiAssignment1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtMovesNumber = new System.Windows.Forms.TextBox();
            this.txtPushesNumber = new System.Windows.Forms.TextBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.lblNumberOfMoves = new System.Windows.Forms.Label();
            this.lblNumberOfPushes = new System.Windows.Forms.Label();
            this.pnlController = new System.Windows.Forms.Panel();
            this.pnlRightSide = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.pnlController.SuspendLayout();
            this.pnlRightSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1691, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.loadToolStripMenuItem.Text = "&Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtMovesNumber
            // 
            this.txtMovesNumber.BackColor = System.Drawing.Color.Thistle;
            this.txtMovesNumber.Enabled = false;
            this.txtMovesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovesNumber.Location = new System.Drawing.Point(174, 53);
            this.txtMovesNumber.Name = "txtMovesNumber";
            this.txtMovesNumber.ReadOnly = true;
            this.txtMovesNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMovesNumber.Size = new System.Drawing.Size(100, 22);
            this.txtMovesNumber.TabIndex = 0;
            this.txtMovesNumber.TabStop = false;
            // 
            // txtPushesNumber
            // 
            this.txtPushesNumber.BackColor = System.Drawing.Color.Thistle;
            this.txtPushesNumber.Enabled = false;
            this.txtPushesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPushesNumber.Location = new System.Drawing.Point(174, 94);
            this.txtPushesNumber.Name = "txtPushesNumber";
            this.txtPushesNumber.ReadOnly = true;
            this.txtPushesNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPushesNumber.Size = new System.Drawing.Size(100, 22);
            this.txtPushesNumber.TabIndex = 0;
            this.txtPushesNumber.TabStop = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Thistle;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(93, 4);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 49);
            this.btnUp.TabIndex = 3;
            this.btnUp.TabStop = false;
            this.btnUp.Text = "Up";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Thistle;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLeft.Location = new System.Drawing.Point(4, 75);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 52);
            this.btnLeft.TabIndex = 4;
            this.btnLeft.TabStop = false;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Thistle;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(93, 76);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 52);
            this.btnDown.TabIndex = 5;
            this.btnDown.TabStop = false;
            this.btnDown.Text = "Down";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Thistle;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(184, 75);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 52);
            this.btnRight.TabIndex = 6;
            this.btnRight.TabStop = false;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // pnlBoard
            // 
            this.pnlBoard.AutoSize = true;
            this.pnlBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBoard.Location = new System.Drawing.Point(28, 51);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(939, 576);
            this.pnlBoard.TabIndex = 7;
            // 
            // lblNumberOfMoves
            // 
            this.lblNumberOfMoves.AutoSize = true;
            this.lblNumberOfMoves.Location = new System.Drawing.Point(40, 55);
            this.lblNumberOfMoves.Name = "lblNumberOfMoves";
            this.lblNumberOfMoves.Size = new System.Drawing.Size(123, 17);
            this.lblNumberOfMoves.TabIndex = 8;
            this.lblNumberOfMoves.Text = "Number of Moves:";
            // 
            // lblNumberOfPushes
            // 
            this.lblNumberOfPushes.AutoSize = true;
            this.lblNumberOfPushes.Location = new System.Drawing.Point(39, 98);
            this.lblNumberOfPushes.Name = "lblNumberOfPushes";
            this.lblNumberOfPushes.Size = new System.Drawing.Size(129, 17);
            this.lblNumberOfPushes.TabIndex = 9;
            this.lblNumberOfPushes.Text = "Number of Pushes:";
            // 
            // pnlController
            // 
            this.pnlController.Controls.Add(this.btnRight);
            this.pnlController.Controls.Add(this.btnUp);
            this.pnlController.Controls.Add(this.btnDown);
            this.pnlController.Controls.Add(this.btnLeft);
            this.pnlController.Enabled = false;
            this.pnlController.Location = new System.Drawing.Point(15, 247);
            this.pnlController.Name = "pnlController";
            this.pnlController.Size = new System.Drawing.Size(273, 130);
            this.pnlController.TabIndex = 10;
            // 
            // pnlRightSide
            // 
            this.pnlRightSide.Controls.Add(this.lblNumberOfMoves);
            this.pnlRightSide.Controls.Add(this.pnlController);
            this.pnlRightSide.Controls.Add(this.txtMovesNumber);
            this.pnlRightSide.Controls.Add(this.txtPushesNumber);
            this.pnlRightSide.Controls.Add(this.lblNumberOfPushes);
            this.pnlRightSide.Location = new System.Drawing.Point(1400, 51);
            this.pnlRightSide.Name = "pnlRightSide";
            this.pnlRightSide.Size = new System.Drawing.Size(291, 530);
            this.pnlRightSide.TabIndex = 11;
            // 
            // PlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1691, 727);
            this.Controls.Add(this.pnlRightSide);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlController.ResumeLayout(false);
            this.pnlRightSide.ResumeLayout(false);
            this.pnlRightSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMovesNumber;
        private System.Windows.Forms.TextBox txtPushesNumber;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel pnlBoard;
        private System.Windows.Forms.Label lblNumberOfMoves;
        private System.Windows.Forms.Label lblNumberOfPushes;
        private System.Windows.Forms.Panel pnlController;
        private System.Windows.Forms.Panel pnlRightSide;
    }
}