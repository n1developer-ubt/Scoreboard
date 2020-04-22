using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard
{
    public partial class GameScreen : Form
    {
        public GameScreen()
        {
            InitializeComponent();
            ShotTimerLabel.TextChanged += ShotTimerLabelOnTextChanged;
        }

        private void ShotTimerLabelOnTextChanged(object sender, EventArgs e)
        {
            try
            {
                int data = Convert.ToInt16(ShotTimerLabel.Text);

                if (data <= 5)
                    ShotTimerLabel.ForeColor = Color.Red;
                else
                {
                    ShotTimerLabel.ForeColor = Color.White;
                }
            }
            catch (Exception exception)
            {
                
            }
        }


        private void GameScreen_Load(object sender, EventArgs e)
        {
            HomePlayerLabel.Text = HomeScreen.Homeplayer;
            AwayPlayerLabel.Text = HomeScreen.AwayPlayer;

            HomePlayerScroreLabel.Text = HomeScreen.GameScore1.ToString(); 
            AwayPlayerScoreLabel.Text  =  HomeScreen.GameScore2.ToString();

            SetScoreLabel1.Text = HomeScreen.SetScore1.ToString();
            SetScoreLabel2.Text = HomeScreen.SetScore2.ToString();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void GameScreen_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            UBTStandardLibrary.DragControl.DragAndDrop(e,Handle);
        }
    }
}
