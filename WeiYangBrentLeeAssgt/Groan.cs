using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WeiYangBrentLeeAssgt
{
    public partial class Groan : Form
    {
        private readonly Launcher launcher;
        private readonly Random random;
        private readonly Bitmap[] DICE_FACES = // Images of the Dices
            {   Properties.Resources._1,
                Properties.Resources._2,
                Properties.Resources._3,
                Properties.Resources._4,
                Properties.Resources._5,
                Properties.Resources._6 
            };

        private bool player = false; // Tagging the current player, false is player A, true is player B
        private int dice1, dice2;
        private int score1, score2;
        private int turnScore1, turnScore2;

        public Groan(Launcher a) // Player's info
        {
            InitializeComponent();

            random = new Random();
            launcher = a;
            a.Hide();
            LbPlayer1.Text += " " + a.Name0;
            LbPlayer2.Text += " " + a.Name1;
            LbWinScore.Text += " " + a.TargetScore;

        }

        private void Groan_FormClosed(object sender, FormClosedEventArgs e)
        {
            launcher.Show();
        }

        private void RollButton_Click(object sender, EventArgs e) // Roll button
        {
            RollDice();  

            if (player)
            {
                // Player 2
                CommentBox.Text = (launcher.Name1 + " " + "decides to roll again.");
            }
            else
            {
                // Player 1
                CommentBox.Text = (launcher.Name0 + " " + "decides to roll again.");
            }
            UpdateUI(); // For updating the UI

            if (IsSnakeEye()) // When snake eyes happens, player lost everything
            {
                if (player)
                {
                    CommentBox.Text = ("Snake Eye: " + launcher.Name1 + " lost everything! " + launcher.Name0 + "'s turn");
                    score2 = 0; // Total score goes back to 0
                    turnScore2 = 0; // Round score also goes back to 0
                }
                else
                {
                    CommentBox.Text = ("Snake Eye: " + launcher.Name0 + " lost everything! " + launcher.Name1 + "'s turn");
                    score1 = 0;
                    turnScore1 = 0;
                }
                SwitchPlayer(); // Pass the round to the other player
                UpdateUI();
            } 
            else if (IsGroan()) // When Groan happens, player lost dice
            {
                if (player)
                {
                    CommentBox.Text = ("Groan: " + launcher.Name1 + " loses dice. " + launcher.Name0 + "'s turn");
                    turnScore2 = 0; // Only round score will go back to 0, Total score not affected
                }
                else
                {
                    CommentBox.Text = ("Groan: " + launcher.Name0 + " loses dice. " + launcher.Name1 + "'s turn");
                    turnScore1 = 0;
                }
                SwitchPlayer(); 
                UpdateUI();
            }
            else
            {
                // Add score
                if (player)
                {
                    turnScore2 += dice1 + dice2;
                    // Player 2
                    if (score2 + turnScore2 >= launcher.TargetScore)
                    {
                        // Player 2 win
                        CommentBox.Text = (launcher.Name1 + " Win!");
                        MessageBox.Show(launcher.Name1 + " Win!"); // Message box jumps out and annouce the winner
                        launcher.Show();
                        Close();
                        return; // Back to the launcher page
                    }
                    UpdateUI();
                }
                else
                {
                    turnScore1 += dice1 + dice2;
                    // Player 1
                    if (score1 + turnScore1 >= launcher.TargetScore)
                    {
                        // Player 1 win
                        CommentBox.Text = (launcher.Name0 + " Win!");
                        MessageBox.Show(launcher.Name0 + " Win!");
                        launcher.Show();
                        Close();
                        return;
                    }
                    UpdateUI();
                }

                if (IsRobotTurn()) // Robot's turn
                {
                    UpdateUI();
                    Application.DoEvents();
                    Thread.Sleep(1500);
                    Application.DoEvents();
                    bool continueRoll = true;

                    if (turnScore2 > 15) // Robot will pass if it collected more than 15 points
                    {
                        continueRoll = false;
                    }

                    if (continueRoll)
                    {
                        
                        RollButton_Click(null, null); // Press the roll button
                    }
                    else
                    {
                        PassButton_Click(null, null); // Press the pass button
                    }
                    UpdateUI();
                }
                
            }
         
        }

        private void PassButton_Click(object sender, EventArgs e)
        {
            // Switch player
            if (player)
            {
                // Player 2
                CommentBox.Text = (launcher.Name1 + " " + "decides to pass dice. " + launcher.Name0 + "'s turn");
                score2 += turnScore2;
                turnScore2 = 0;
            }
            else
            {
                // Player 1
                CommentBox.Text = (launcher.Name0 + " " + "decides to pass dice. " + launcher.Name1 + "'s turn");
                score1 += turnScore1;
                turnScore1 = 0;
            }
            UpdateUI();
            SwitchPlayer();
        }

        private void SetDiceFace(PictureBox pBox, int num)
        {
            pBox.Image = DICE_FACES[num - 1];
        }

        private int NextDiceNum()
        {
            return random.Next(1, 7); // Random dice number 1-6
        }

        private void RollDice() // When dice rolling
        {
            RollButton.Enabled = false; // Roll button disabled
            PassButton.Enabled = false; // Pass button disabled
            for (int i = 0; i < 7; ++i)
            {
                SetDiceFace(Dice1, NextDiceNum());
                SetDiceFace(Dice2, NextDiceNum());
                Thread.Sleep(100); // Give delays
                Application.DoEvents();
            }
            dice1 = NextDiceNum();
            SetDiceFace(Dice1, dice1);
            dice2 = NextDiceNum();
            SetDiceFace(Dice2, dice2);
            RollButton.Enabled = !IsRobotTurn();
            PassButton.Enabled = !IsRobotTurn();
        }

        private bool IsSnakeEye() // Snake eye (if both dice are 1)
        {
            return dice1 == 1 && dice2 == 1;
        }

        private bool IsGroan() // Groan (either one of the dice are 1)
        {
            return dice1 == 1 || dice2 == 1;
        }

        private void UpdateUI() // For updating the UI and score
        {
            LbP1TScore.Text = ("Total score: " + score1);
            LbP2TScore.Text = ("Total score: " + score2);
            LbP1Score.Text = ("Score: " + turnScore1);
            LbP2Score.Text = ("Score: " + turnScore2);
        }


        private bool IsRobotTurn() // Detect if its pve mode
        {
            return player && launcher.IsPveMode;
        }
        private void SwitchPlayer() // For switching players
        {
            player = !player;
            if (IsRobotTurn())
            {
                // Robot's turn
                RollButton.Enabled = false; // Will disable both of the button when its robot's turn
                PassButton.Enabled = false;
                Thread.Sleep(1500);
                Application.DoEvents();
                RollButton_Click(null, null);
            }
            else
            {
                RollButton.Enabled = true; // Will enable back the buttons when its your turn
                PassButton.Enabled = true;
            }
        }
    }
}
