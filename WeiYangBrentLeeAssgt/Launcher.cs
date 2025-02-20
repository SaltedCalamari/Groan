using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeiYangBrentLeeAssgt
{
    public partial class Launcher : Form
    {
        public string Name0, Name1; // Declare var
        public int TargetScore;
        public bool IsPveMode;
        public Launcher()
        {
            InitializeComponent();
        }

        private void OnePlayer_Click(object sender, EventArgs e) // For Pve Mode
        {
            Name0 = SinglePlayerName.Text;
            Name1 = "Robot";
            IsPveMode = true;

            if (String.IsNullOrWhiteSpace(Name0)) // When the name fleid was blank or null
            {
                MessageBox.Show("Please input player name!"); 
                return;
            }
            try
            {
                TargetScore = Convert.ToInt32(TargetScoreBox.Text);
            }
            catch
            {
                MessageBox.Show("Please input a correct score!"); // Alphabet is not acceptable as a score
                return;
            }
            new Groan(this).Show();

        }

        private void DPlayer_Click(object sender, EventArgs e) // For Pvp Mode
        {
            Name0 = FirstPlayerName.Text;
            Name1 = SecondPlayerName.Text;
            IsPveMode = false;
            if (String.IsNullOrWhiteSpace(Name0) || String.IsNullOrWhiteSpace(Name1)) {
                MessageBox.Show("Please input player name!");
                return;
            }

            try
            {
                TargetScore = Convert.ToInt32(TargetScoreBox.Text);
            }
            catch
            {
                MessageBox.Show("Please input a correct score!");
                return;
            }
            new Groan(this).Show();
        }

    }
}
