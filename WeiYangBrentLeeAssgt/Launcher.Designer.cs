
namespace WeiYangBrentLeeAssgt
{
    partial class Launcher
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
            this.OnePlayer = new System.Windows.Forms.Button();
            this.TwoPlayer = new System.Windows.Forms.Button();
            this.ChooseType = new System.Windows.Forms.Label();
            this.EName = new System.Windows.Forms.Label();
            this.P1EName = new System.Windows.Forms.Label();
            this.SinglePlayerName = new System.Windows.Forms.TextBox();
            this.FirstPlayerName = new System.Windows.Forms.TextBox();
            this.SecondPlayerName = new System.Windows.Forms.TextBox();
            this.P2EName = new System.Windows.Forms.Label();
            this.PVE = new System.Windows.Forms.GroupBox();
            this.PVP = new System.Windows.Forms.GroupBox();
            this.EnterTScore = new System.Windows.Forms.Label();
            this.TargetScoreBox = new System.Windows.Forms.TextBox();
            this.Recommend = new System.Windows.Forms.Label();
            this.PVE.SuspendLayout();
            this.PVP.SuspendLayout();
            this.SuspendLayout();
            // 
            // OnePlayer
            // 
            this.OnePlayer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnePlayer.Location = new System.Drawing.Point(63, 36);
            this.OnePlayer.Name = "OnePlayer";
            this.OnePlayer.Size = new System.Drawing.Size(242, 88);
            this.OnePlayer.TabIndex = 0;
            this.OnePlayer.Text = "Single Player";
            this.OnePlayer.UseVisualStyleBackColor = true;
            this.OnePlayer.Click += new System.EventHandler(this.OnePlayer_Click);
            // 
            // TwoPlayer
            // 
            this.TwoPlayer.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoPlayer.Location = new System.Drawing.Point(63, 55);
            this.TwoPlayer.Name = "TwoPlayer";
            this.TwoPlayer.Size = new System.Drawing.Size(242, 88);
            this.TwoPlayer.TabIndex = 1;
            this.TwoPlayer.Text = "2 Players";
            this.TwoPlayer.UseVisualStyleBackColor = true;
            this.TwoPlayer.Click += new System.EventHandler(this.DPlayer_Click);
            // 
            // ChooseType
            // 
            this.ChooseType.AutoSize = true;
            this.ChooseType.Font = new System.Drawing.Font("Copperplate Gothic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseType.Location = new System.Drawing.Point(238, 32);
            this.ChooseType.Name = "ChooseType";
            this.ChooseType.Size = new System.Drawing.Size(432, 26);
            this.ChooseType.TabIndex = 2;
            this.ChooseType.Text = "Please Choose Your Game Type";
            // 
            // EName
            // 
            this.EName.AutoSize = true;
            this.EName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EName.Location = new System.Drawing.Point(359, 48);
            this.EName.Name = "EName";
            this.EName.Size = new System.Drawing.Size(191, 20);
            this.EName.TabIndex = 3;
            this.EName.Text = "Enter Your Name:";
            // 
            // P1EName
            // 
            this.P1EName.AutoSize = true;
            this.P1EName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1EName.Location = new System.Drawing.Point(349, 32);
            this.P1EName.Name = "P1EName";
            this.P1EName.Size = new System.Drawing.Size(218, 20);
            this.P1EName.TabIndex = 4;
            this.P1EName.Text = "First Player\'s Name:";
            // 
            // SinglePlayerName
            // 
            this.SinglePlayerName.Font = new System.Drawing.Font("Copperplate Gothic Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinglePlayerName.Location = new System.Drawing.Point(363, 71);
            this.SinglePlayerName.Name = "SinglePlayerName";
            this.SinglePlayerName.Size = new System.Drawing.Size(353, 25);
            this.SinglePlayerName.TabIndex = 5;
            // 
            // FirstPlayerName
            // 
            this.FirstPlayerName.Font = new System.Drawing.Font("Copperplate Gothic Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstPlayerName.Location = new System.Drawing.Point(353, 55);
            this.FirstPlayerName.Name = "FirstPlayerName";
            this.FirstPlayerName.Size = new System.Drawing.Size(363, 25);
            this.FirstPlayerName.TabIndex = 6;
            // 
            // SecondPlayerName
            // 
            this.SecondPlayerName.Font = new System.Drawing.Font("Copperplate Gothic Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerName.Location = new System.Drawing.Point(353, 121);
            this.SecondPlayerName.Name = "SecondPlayerName";
            this.SecondPlayerName.Size = new System.Drawing.Size(363, 25);
            this.SecondPlayerName.TabIndex = 7;
            // 
            // P2EName
            // 
            this.P2EName.AutoSize = true;
            this.P2EName.Font = new System.Drawing.Font("Copperplate Gothic Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2EName.Location = new System.Drawing.Point(349, 98);
            this.P2EName.Name = "P2EName";
            this.P2EName.Size = new System.Drawing.Size(244, 20);
            this.P2EName.TabIndex = 8;
            this.P2EName.Text = "Second Player\'s Name:";
            // 
            // PVE
            // 
            this.PVE.Controls.Add(this.OnePlayer);
            this.PVE.Controls.Add(this.SinglePlayerName);
            this.PVE.Controls.Add(this.EName);
            this.PVE.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVE.Location = new System.Drawing.Point(67, 199);
            this.PVE.Name = "PVE";
            this.PVE.Size = new System.Drawing.Size(810, 158);
            this.PVE.TabIndex = 9;
            this.PVE.TabStop = false;
            this.PVE.Text = "PVE";
            // 
            // PVP
            // 
            this.PVP.Controls.Add(this.P1EName);
            this.PVP.Controls.Add(this.TwoPlayer);
            this.PVP.Controls.Add(this.P2EName);
            this.PVP.Controls.Add(this.FirstPlayerName);
            this.PVP.Controls.Add(this.SecondPlayerName);
            this.PVP.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PVP.Location = new System.Drawing.Point(67, 363);
            this.PVP.Name = "PVP";
            this.PVP.Size = new System.Drawing.Size(810, 182);
            this.PVP.TabIndex = 10;
            this.PVP.TabStop = false;
            this.PVP.Text = "PVP";
            // 
            // EnterTScore
            // 
            this.EnterTScore.AutoSize = true;
            this.EnterTScore.Font = new System.Drawing.Font("Copperplate Gothic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterTScore.Location = new System.Drawing.Point(173, 98);
            this.EnterTScore.Name = "EnterTScore";
            this.EnterTScore.Size = new System.Drawing.Size(363, 23);
            this.EnterTScore.TabIndex = 11;
            this.EnterTScore.Text = "Please enter the target score:";
            // 
            // TargetScoreBox
            // 
            this.TargetScoreBox.Font = new System.Drawing.Font("Copperplate Gothic Light", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetScoreBox.Location = new System.Drawing.Point(573, 96);
            this.TargetScoreBox.Name = "TargetScoreBox";
            this.TargetScoreBox.Size = new System.Drawing.Size(171, 25);
            this.TargetScoreBox.TabIndex = 12;
            // 
            // Recommend
            // 
            this.Recommend.AutoSize = true;
            this.Recommend.Font = new System.Drawing.Font("Copperplate Gothic Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recommend.Location = new System.Drawing.Point(126, 135);
            this.Recommend.Name = "Recommend";
            this.Recommend.Size = new System.Drawing.Size(713, 20);
            this.Recommend.TabIndex = 13;
            this.Recommend.Text = "Recommend range between 50 to 100 to have a better game experience";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 605);
            this.Controls.Add(this.Recommend);
            this.Controls.Add(this.TargetScoreBox);
            this.Controls.Add(this.EnterTScore);
            this.Controls.Add(this.PVP);
            this.Controls.Add(this.PVE);
            this.Controls.Add(this.ChooseType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Launcher";
            this.Text = "Game Launcher";
            this.PVE.ResumeLayout(false);
            this.PVE.PerformLayout();
            this.PVP.ResumeLayout(false);
            this.PVP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OnePlayer;
        private System.Windows.Forms.Button TwoPlayer;
        private System.Windows.Forms.Label ChooseType;
        private System.Windows.Forms.Label EName;
        private System.Windows.Forms.Label P1EName;
        private System.Windows.Forms.TextBox SinglePlayerName;
        private System.Windows.Forms.TextBox FirstPlayerName;
        private System.Windows.Forms.TextBox SecondPlayerName;
        private System.Windows.Forms.Label P2EName;
        private System.Windows.Forms.GroupBox PVE;
        private System.Windows.Forms.GroupBox PVP;
        private System.Windows.Forms.Label EnterTScore;
        private System.Windows.Forms.TextBox TargetScoreBox;
        private System.Windows.Forms.Label Recommend;
    }
}

