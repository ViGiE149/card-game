
namespace Card_Game_X
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.computerScore = new System.Windows.Forms.Label();
            this.playerScore = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tiesCount = new System.Windows.Forms.Label();
            this.dishBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.roundCount = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardsLeft = new System.Windows.Forms.Label();
            this.playerCard = new System.Windows.Forms.PictureBox();
            this.computerCard = new System.Windows.Forms.PictureBox();
            this.statusP = new System.Windows.Forms.Label();
            this.statusC = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Computer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // computerScore
            // 
            this.computerScore.AutoSize = true;
            this.computerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScore.Location = new System.Drawing.Point(96, 131);
            this.computerScore.Name = "computerScore";
            this.computerScore.Size = new System.Drawing.Size(17, 18);
            this.computerScore.TabIndex = 2;
            this.computerScore.Text = "0";
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Black;
            this.playerScore.Location = new System.Drawing.Point(602, 131);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(19, 20);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ties";
            // 
            // tiesCount
            // 
            this.tiesCount.AutoSize = true;
            this.tiesCount.Location = new System.Drawing.Point(351, 97);
            this.tiesCount.Name = "tiesCount";
            this.tiesCount.Size = new System.Drawing.Size(13, 13);
            this.tiesCount.TabIndex = 5;
            this.tiesCount.Text = "0";
            // 
            // dishBtn
            // 
            this.dishBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dishBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dishBtn.Location = new System.Drawing.Point(297, 400);
            this.dishBtn.Name = "dishBtn";
            this.dishBtn.Size = new System.Drawing.Size(131, 54);
            this.dishBtn.TabIndex = 6;
            this.dishBtn.Text = "DISH";
            this.dishBtn.UseVisualStyleBackColor = true;
            this.dishBtn.Click += new System.EventHandler(this.dishBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(305, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Round :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // roundCount
            // 
            this.roundCount.AutoSize = true;
            this.roundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundCount.ForeColor = System.Drawing.Color.Orange;
            this.roundCount.Location = new System.Drawing.Point(414, 24);
            this.roundCount.Name = "roundCount";
            this.roundCount.Size = new System.Drawing.Size(27, 29);
            this.roundCount.TabIndex = 8;
            this.roundCount.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.endToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.toolStripMenuItem4});
            this.toolStripMenuItem1.Image = global::Card_Game_X.Properties.Resources.op;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(56, 20);
            this.toolStripMenuItem1.Text = "       ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::Card_Game_X.Properties.Resources.help_icon_22;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem2.Text = "Help";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = global::Card_Game_X.Properties.Resources.about;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem3.Text = "About";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(104, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Card_Game_X.Properties.Resources.exit;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem4.Text = "Exit";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.endToolStripMenuItem.Text = "re-start";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // cardsLeft
            // 
            this.cardsLeft.AutoSize = true;
            this.cardsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardsLeft.Location = new System.Drawing.Point(350, 305);
            this.cardsLeft.Name = "cardsLeft";
            this.cardsLeft.Size = new System.Drawing.Size(44, 20);
            this.cardsLeft.TabIndex = 12;
            this.cardsLeft.Text = ".......";
            this.cardsLeft.Click += new System.EventHandler(this.cardsLeft_Click);
            // 
            // playerCard
            // 
            this.playerCard.Location = new System.Drawing.Point(502, 152);
            this.playerCard.Name = "playerCard";
            this.playerCard.Size = new System.Drawing.Size(206, 246);
            this.playerCard.TabIndex = 10;
            this.playerCard.TabStop = false;
            this.playerCard.Click += new System.EventHandler(this.playerCard_Click);
            // 
            // computerCard
            // 
            this.computerCard.Location = new System.Drawing.Point(12, 150);
            this.computerCard.Name = "computerCard";
            this.computerCard.Size = new System.Drawing.Size(202, 246);
            this.computerCard.TabIndex = 9;
            this.computerCard.TabStop = false;
            this.computerCard.Click += new System.EventHandler(this.computerCard_Click);
            // 
            // statusP
            // 
            this.statusP.AutoSize = true;
            this.statusP.BackColor = System.Drawing.Color.Transparent;
            this.statusP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusP.ForeColor = System.Drawing.Color.Lime;
            this.statusP.Location = new System.Drawing.Point(498, 122);
            this.statusP.Name = "statusP";
            this.statusP.Size = new System.Drawing.Size(0, 24);
            this.statusP.TabIndex = 15;
            // 
            // statusC
            // 
            this.statusC.AutoSize = true;
            this.statusC.BackColor = System.Drawing.Color.Transparent;
            this.statusC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusC.ForeColor = System.Drawing.Color.Lime;
            this.statusC.Location = new System.Drawing.Point(137, 122);
            this.statusC.Name = "statusC";
            this.statusC.Size = new System.Drawing.Size(0, 24);
            this.statusC.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 489);
            this.ControlBox = false;
            this.Controls.Add(this.statusC);
            this.Controls.Add(this.statusP);
            this.Controls.Add(this.cardsLeft);
            this.Controls.Add(this.playerCard);
            this.Controls.Add(this.computerCard);
            this.Controls.Add(this.roundCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dishBtn);
            this.Controls.Add(this.tiesCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.computerScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cards Mayhem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playerCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label computerScore;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tiesCount;
        private System.Windows.Forms.Button dishBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label roundCount;
        private System.Windows.Forms.PictureBox computerCard;
        private System.Windows.Forms.PictureBox playerCard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.Label cardsLeft;
        private System.Windows.Forms.Label statusP;
        private System.Windows.Forms.Label statusC;
    }
}

