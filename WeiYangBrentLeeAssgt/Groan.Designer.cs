
namespace WeiYangBrentLeeAssgt
{
    partial class Groan
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
            this.LbP1TScore = new System.Windows.Forms.Label();
            this.LbP1Score = new System.Windows.Forms.Label();
            this.LbPlayer1 = new System.Windows.Forms.Label();
            this.LbPlayer2 = new System.Windows.Forms.Label();
            this.LbP2TScore = new System.Windows.Forms.Label();
            this.LbP2Score = new System.Windows.Forms.Label();
            this.Dice1 = new System.Windows.Forms.PictureBox();
            this.Dice2 = new System.Windows.Forms.PictureBox();
            this.RollButton = new System.Windows.Forms.Button();
            this.CommentBox = new System.Windows.Forms.TextBox();
            this.PassButton = new System.Windows.Forms.Button();
            this.LbWinScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).BeginInit();
            this.SuspendLayout();
            // 
            // LbP1TScore
            // 
            this.LbP1TScore.AutoSize = true;
            this.LbP1TScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbP1TScore.Location = new System.Drawing.Point(91, 475);
            this.LbP1TScore.Name = "LbP1TScore";
            this.LbP1TScore.Size = new System.Drawing.Size(153, 23);
            this.LbP1TScore.TabIndex = 0;
            this.LbP1TScore.Text = "Total Score:";
            // 
            // LbP1Score
            // 
            this.LbP1Score.AutoSize = true;
            this.LbP1Score.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbP1Score.Location = new System.Drawing.Point(91, 507);
            this.LbP1Score.Name = "LbP1Score";
            this.LbP1Score.Size = new System.Drawing.Size(85, 23);
            this.LbP1Score.TabIndex = 1;
            this.LbP1Score.Text = "Score:";
            // 
            // LbPlayer1
            // 
            this.LbPlayer1.AutoSize = true;
            this.LbPlayer1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayer1.Location = new System.Drawing.Point(91, 441);
            this.LbPlayer1.Name = "LbPlayer1";
            this.LbPlayer1.Size = new System.Drawing.Size(114, 23);
            this.LbPlayer1.TabIndex = 2;
            this.LbPlayer1.Text = "Player 1:";
            // 
            // LbPlayer2
            // 
            this.LbPlayer2.AutoSize = true;
            this.LbPlayer2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPlayer2.Location = new System.Drawing.Point(370, 441);
            this.LbPlayer2.Name = "LbPlayer2";
            this.LbPlayer2.Size = new System.Drawing.Size(114, 23);
            this.LbPlayer2.TabIndex = 3;
            this.LbPlayer2.Text = "Player 2:";
            // 
            // LbP2TScore
            // 
            this.LbP2TScore.AutoSize = true;
            this.LbP2TScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbP2TScore.Location = new System.Drawing.Point(370, 475);
            this.LbP2TScore.Name = "LbP2TScore";
            this.LbP2TScore.Size = new System.Drawing.Size(153, 23);
            this.LbP2TScore.TabIndex = 4;
            this.LbP2TScore.Text = "Total Score:";
            // 
            // LbP2Score
            // 
            this.LbP2Score.AutoSize = true;
            this.LbP2Score.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbP2Score.Location = new System.Drawing.Point(370, 507);
            this.LbP2Score.Name = "LbP2Score";
            this.LbP2Score.Size = new System.Drawing.Size(85, 23);
            this.LbP2Score.TabIndex = 5;
            this.LbP2Score.Text = "Score:";
            // 
            // Dice1
            // 
            this.Dice1.Location = new System.Drawing.Point(135, 155);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(160, 160);
            this.Dice1.TabIndex = 6;
            this.Dice1.TabStop = false;
            // 
            // Dice2
            // 
            this.Dice2.Location = new System.Drawing.Point(387, 155);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(160, 160);
            this.Dice2.TabIndex = 7;
            this.Dice2.TabStop = false;
            // 
            // RollButton
            // 
            this.RollButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollButton.Location = new System.Drawing.Point(135, 76);
            this.RollButton.Name = "RollButton";
            this.RollButton.Size = new System.Drawing.Size(186, 59);
            this.RollButton.TabIndex = 8;
            this.RollButton.Text = "Roll";
            this.RollButton.UseVisualStyleBackColor = true;
            this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
            // 
            // CommentBox
            // 
            this.CommentBox.Enabled = false;
            this.CommentBox.Font = new System.Drawing.Font("Copperplate Gothic Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommentBox.Location = new System.Drawing.Point(56, 570);
            this.CommentBox.Name = "CommentBox";
            this.CommentBox.Size = new System.Drawing.Size(583, 29);
            this.CommentBox.TabIndex = 9;
            // 
            // PassButton
            // 
            this.PassButton.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassButton.Location = new System.Drawing.Point(352, 76);
            this.PassButton.Name = "PassButton";
            this.PassButton.Size = new System.Drawing.Size(186, 59);
            this.PassButton.TabIndex = 10;
            this.PassButton.Text = "Pass";
            this.PassButton.UseVisualStyleBackColor = true;
            this.PassButton.Click += new System.EventHandler(this.PassButton_Click);
            // 
            // LbWinScore
            // 
            this.LbWinScore.AutoSize = true;
            this.LbWinScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWinScore.Location = new System.Drawing.Point(182, 26);
            this.LbWinScore.Name = "LbWinScore";
            this.LbWinScore.Size = new System.Drawing.Size(250, 23);
            this.LbWinScore.TabIndex = 11;
            this.LbWinScore.Text = "Target Score To Win:";
            // 
            // Groan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 639);
            this.Controls.Add(this.LbWinScore);
            this.Controls.Add(this.PassButton);
            this.Controls.Add(this.CommentBox);
            this.Controls.Add(this.RollButton);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.LbP2Score);
            this.Controls.Add(this.LbP2TScore);
            this.Controls.Add(this.LbPlayer2);
            this.Controls.Add(this.LbPlayer1);
            this.Controls.Add(this.LbP1Score);
            this.Controls.Add(this.LbP1TScore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Groan";
            this.Text = "Groan The Dice Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Groan_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dice2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbP1TScore;
        private System.Windows.Forms.Label LbP1Score;
        private System.Windows.Forms.Label LbPlayer1;
        private System.Windows.Forms.Label LbPlayer2;
        private System.Windows.Forms.Label LbP2TScore;
        private System.Windows.Forms.Label LbP2Score;
        private System.Windows.Forms.PictureBox Dice1;
        private System.Windows.Forms.PictureBox Dice2;
        private System.Windows.Forms.Button RollButton;
        private System.Windows.Forms.TextBox CommentBox;
        private System.Windows.Forms.Button PassButton;
        private System.Windows.Forms.Label LbWinScore;
    }
}