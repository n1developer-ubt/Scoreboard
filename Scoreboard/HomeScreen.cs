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
    public partial class HomeScreen : Form
    {
        private readonly GameData _currentGameData = new GameData();
        public static int SetScore1 = 0, SetScore2 = 0, GameScore1 = 0, GameScore2 = 0, i = 1;
        public static string Homeplayer, AwayPlayer;
        public static int Value1, Value2;
        public static int flag = 0,flag1=0,ShotCheck,Pause;
        
        public static int StartValue,SwitchValue;
        
        GameScreen Gm = new GameScreen();
        
        System.Media.SoundPlayer Player1 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Player2 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Player3 = new System.Media.SoundPlayer();
        System.Media.SoundPlayer Player4 = new System.Media.SoundPlayer(); 
        
        public HomeScreen()
        {
            InitializeComponent();
            Player1.SoundLocation = "15minutewarning.wav";
            Player2.SoundLocation = "1minutewarning.wav";
            Player3.SoundLocation = "5432or1secondbeep.wav";
            Player4.SoundLocation = "Timeout.wav";
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            
            Gm.Show();
        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void ResetPlayers()
        {
            HomePlayertextbox.Clear();
            AwayPlayertextbox.Clear();
            Homeplayer = null;
            AwayPlayer = null;
        }
        void ResetScores()
        {
            SetScore1 = 0;
            SetScore2 = 0;
            GameScore1 = 0;
            GameScore2 = 0;
        }
        
        

        private void ResetPlayerButton_Click(object sender, EventArgs e)
        {
            ResetPlayers();
        }

        private void ResetScoreButton_Click(object sender, EventArgs e)
        {
            ResetScores();
            SetScoretextBox1.Clear();
            SetScoretextBox2.Clear();
            GameScoretextBox1.Clear();
            GameScoretextBox2.Clear();
            Gm.SetScoreLabel1.Text = SetScore1.ToString();
            Gm.SetScoreLabel2.Text = SetScore2.ToString();
            Gm.HomePlayerScroreLabel.Text = GameScore1.ToString();
            Gm.AwayPlayerScoreLabel.Text = GameScore2.ToString();

            EXradioButtonNo1.Checked = true;
            EXradioButtonNo2.Checked = true;
            HomePlayertextbox.Focus();
        }

        private void StartButton1_Click(object sender, EventArgs e)
        {
            StartGameClock();
            StartShotClock();
        }

        private void StartGameClock()
        {
            GameTimer.Start();
            if (flag == 0)
            {
                GameTimetextBox.Text = StartValue.ToString() + @":00";
            }
            StartButton1.Enabled = false;
            Pausebutton1.Enabled = true;
        }

        private void PauseGameClock()
        {
            GameTimer.Stop();
            StartButton1.Enabled = true;
            Pausebutton1.Enabled = false;
        }

        private void ResetGameClock()
        {
            ShotCheck = 0;
            GameTimer.Start();
            flag = 0;
            if (flag == 0)
            {
                GameTimetextBox.Text = StartValue.ToString() + @":00";
            }
        }
        private void StartShotClock()
        {
            flag1 = 0;
            ShotClockTimer.Start();
            if (Pause == 1)
            {

            }
            else
            {
                if (flag1 == 0 && ShotCheck == 0)
                {
                    ShotClocktextBox.Text = Value1.ToString();
                }
                if (flag1 == 0 && ShotCheck == 1)
                {
                    ShotClocktextBox.Text = Value2.ToString();
                }
            }
            Startbutton2.Enabled = false;
            Pausebutton2.Enabled = true;
            //Gm.BringToFront();
        }

        private void PauseShotClock()
        {
            ShotClockTimer.Stop();
            Pause = 1;
            Startbutton2.Enabled = true;
            Pausebutton2.Enabled = false;
        }

        private void ResetShotClock()
        {
            Second2 = 0;
            Pause = 0;
            ShotClockTimer.Start();
            flag1 = 0;
            if (flag1 == 0 && ShotCheck == 0)
            {
                ShotClocktextBox.Text = Value1.ToString();
            }
            if (flag1 == 0 && ShotCheck == 1)
            {
                ShotClocktextBox.Text = Value2.ToString();
            }
        }

        private void Pausebutton1_Click(object sender, EventArgs e)
        {
            PauseGameClock();
            PauseShotClock();
        }

        private void Resetbutton1_Click(object sender, EventArgs e)
        {
           ResetGameClock();
           ResetShotClock();
        }

        private void SetScoreAddBtn_Click(object sender, EventArgs e)
        {
            SetScore1 = SetScore1 + i;
            SetScoretextBox1.Text = SetScore1.ToString();
            Gm.SetScoreLabel1.Text = SetScore1.ToString();
        }

        private void SetScoreDecBtn_Click(object sender, EventArgs e)
        {
            SetScore1 = SetScore1 - i;
            SetScoretextBox1.Text = SetScore1.ToString();
            Gm.SetScoreLabel1.Text = SetScore1.ToString();
        }

        private void SetScoreAddP2Btn_Click(object sender, EventArgs e)
        {
            SetScore2 = SetScore2 + i;
            SetScoretextBox2.Text = SetScore2.ToString();
            Gm.SetScoreLabel2.Text = SetScore2.ToString();
        }

        private void SetScoreDecP2Btn_Click(object sender, EventArgs e)
        {
            SetScore2 = SetScore2 - i;
            SetScoretextBox2.Text = SetScore2.ToString();
            Gm.SetScoreLabel2.Text = SetScore2.ToString();
        }

        private void GameScoreAddBtn_Click(object sender, EventArgs e)
        {
            GameScore1 = GameScore1 + i;
            GameScoretextBox1.Text = GameScore1.ToString();
            Gm.HomePlayerScroreLabel.Text = GameScore1.ToString();
        }

        private void GameScoreDecBtn_Click(object sender, EventArgs e)
        {
            GameScore1 = GameScore1 - i;
            GameScoretextBox1.Text = GameScore1.ToString();
            Gm.HomePlayerScroreLabel.Text = GameScore1.ToString();
        }

        private void GameScoreAddBtn1_Click(object sender, EventArgs e)
        {
            GameScore2 = GameScore2 + i;
            GameScoretextBox2.Text = GameScore2.ToString();
            Gm.AwayPlayerScoreLabel.Text = GameScore2.ToString();
        }

        private void GameScoreDecBtn1_Click(object sender, EventArgs e)
        {
            GameScore2 = GameScore2 - i;
            GameScoretextBox2.Text = GameScore2.ToString();
            Gm.AwayPlayerScoreLabel.Text = GameScore2.ToString();
        }

        private void HomePlayertextbox_TextChanged(object sender, EventArgs e)
        {
            if (HomePlayertextbox.Text != "")
            {
                Gm.HomePlayerLabel.Text = HomePlayertextbox.Text;
            }
            else
            {
                Gm.HomePlayerLabel.Text = "Home Player";
            }
        }

        private void AwayPlayertextbox_TextChanged(object sender, EventArgs e)
        {
            if (AwayPlayertextbox.Text != "")
            {
                Gm.AwayPlayerLabel.Text = AwayPlayertextbox.Text;
            }
            else
            {
                Gm.AwayPlayerLabel.Text = "Away Player";
            }
        }

        private void EXradioButtonYes1_CheckedChanged(object sender, EventArgs e)
        {
            Gm.ExtLabel1.Visible = true;
        }

        private void EXradioButtonNo1_CheckedChanged(object sender, EventArgs e)
        {
            Gm.ExtLabel1.Visible = false;
        }

        private void EXradioButtonYes2_CheckedChanged(object sender, EventArgs e)
        {
            Gm.ExtLabel2.Visible = true;
        }

        private void EXradioButtonNo2_CheckedChanged(object sender, EventArgs e)
        {
            Gm.ExtLabel2.Visible = false;
        }

        private void TitletextBox_TextChanged(object sender, EventArgs e)
        {
            if (TitletextBox.Text!="")
            {
                Gm.TitleLabel.Text = TitletextBox.Text;              
            }
            else
            {
                Gm.TitleLabel.Text = "";
            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Value1Upbutton_Click(object sender, EventArgs e)
        {
            Value1 = Value1 + i;
            if (Value1 == 60 || Value1 == -1)
            {
                Value1 = 0;
            }
            Value1Textbox.Text = Value1.ToString();

        }

        private void Value1Downbutton_Click(object sender, EventArgs e)
        {
            Value1 = Value1 - i;
            if (Value1 == 60 || Value1 == -1)
            {
                Value1 = 0;
            }
            Value1Textbox.Text = Value1.ToString();
        }

        private void Value2Upbutton_Click(object sender, EventArgs e)
        {
            Value2 = Value2 + i;
            if (Value2 == 60 || Value2 == -1)
            {
                Value2 = 0;
            }
            Value2textBox.Text= Value2.ToString();
        }

        private void Value2Downbutton_Click(object sender, EventArgs e)
        {
            Value2 = Value2 - i;
            if (Value2 == 60 || Value2 == -1)
            {
                Value2 = 0;
            }
            Value2textBox.Text = Value2.ToString();
        }

        int Second2=60;
        
        private void ShotClockTimer_Tick(object sender, EventArgs e)
        {
            if (flag1==0 && Pause==0)
            {
                if (ShotCheck==0)
                {
                    Second2 = Value1;
                    flag1 = 1;
                }
                if (ShotCheck==1)
                {
                    Second2 = Value2;
                    flag1 = 1;
                }
                Pause = 1;
            }
            if (Second2!=0)
            {
                Second2--;
                ShotClocktextBox.Text = Second2.ToString();
                if (Second2 <= 5)
                {
                    ShotClocktextBox.BackColor = ShotClocktextBox.BackColor;
                    ShotClocktextBox.ForeColor = Color.Red;
                    Player3.Play();
                }
                
                if (Second2==0)
                {
                    Player4.Play();
                    ShotClocktextBox.Text = "00";
                }
            }
            else
            {
                ShotClocktextBox.BackColor = ShotClocktextBox.BackColor;
                ShotClocktextBox.ForeColor = Color.Black;
                ShotClockTimer.Stop();
            }
        }

        private void Startbutton2_Click(object sender, EventArgs e)
        {
            StartShotClock();
            StartGameClock();
        }

        private void Pausebutton2_Click(object sender, EventArgs e)
        {
            PauseShotClock();
            PauseGameClock();
        }

        private void StartValueUpbutton_Click(object sender, EventArgs e)
        {
            StartValue = StartValue + i;
            if (StartValue==60 || StartValue==-1)
            {
                StartValue = 0;
            }
            if (StartValue == 59)
            {

                StartValuetextBox.Text = StartValue.ToString() + @":59";
            }
            else
            {
                StartValuetextBox.Text = StartValue.ToString() + @":00";
            }

        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            UBTStandardLibrary.DragControl.DragAndDrop(e, Handle);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Resetbutton2_Click(null,null);
            }
        }

        private void SetScoretextBox2_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox b)
            {
                string acc = b.AccessibleName;

                switch (acc)
                {
                    case "lgs":
                        _currentGameData.LPGScore = b.Text;
                        break;
                    case "lss":
                        _currentGameData.LPSScore= b.Text;
                        break;
                    case "rgs":
                        _currentGameData.RPGScore = b.Text;
                        break;
                    case "rss":
                        _currentGameData.RPSScore = b.Text;
                        break;
                    default:return;
                }
                ObsFileGenerator.Write(_currentGameData);
            }

        }

        private void StartValueDownbutton_Click(object sender, EventArgs e)
        {

            StartValue = StartValue - i;
            if (StartValue == 60 || StartValue == -1)
            {
                StartValue = 0;
            }

            if (StartValue == 59)
            {

                StartValuetextBox.Text = StartValue.ToString() + @":59";
            }
            else
            {
                StartValuetextBox.Text = StartValue.ToString() + @":00";
            }
            

        }

        private void SwitchValueUpbutton_Click(object sender, EventArgs e)
        {
            SwitchValue = SwitchValue + i;
            if (SwitchValue == 60 || SwitchValue == -1)
            {
                SwitchValue = 0;
            }

            if (SwitchValue == 59)
            {

                SwitchPointtextBox.Text = SwitchValue.ToString() + @":59";
            }
            else
            {
                SwitchPointtextBox.Text = SwitchValue.ToString() + @":00";
            }
        }

        private void SwitchValueDownbutton_Click(object sender, EventArgs e)
        {
            SwitchValue = SwitchValue - i;
            if (SwitchValue == 60 || SwitchValue == -1)
            {
                SwitchValue = 0;
            }

            if (SwitchValue == 59)
            {

                SwitchPointtextBox.Text = SwitchValue.ToString() + @":59";
            }
            else
            {
                SwitchPointtextBox.Text = SwitchValue.ToString() + @":00";
            }
        }
        int Second = 60;
        int Check;

        public void ResetTimer()
        {
            if (flag == 0)
            {
                Check = StartValue - 1;
                Second = 60;
                flag = 1;
            }
            if (Check != -1)
            {
                if (Check < SwitchValue)
                {
                    ShotCheck = 1;
                }
                if (Check==SwitchValue && Second==0)
                {
                    Player1.Play();
                }
                if (Check == 0 && Second ==60)
                {
                    Player2.Play();
                }
                Second--;
                GameTimetextBox.Text = Check.ToString("00") + @":" + Second.ToString("00");
                if (Second == 0)
                {
                    Second = 60;
                    Check--;
                    
                    if (Check == -1)
                    {
                        Player4.Play();
                        GameTimer.Stop();
                        GameTimetextBox.Text = "00:00";
                    }
                }
            }
            else
            {
                GameTimer.Stop();
            }
        }

        

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void GameTimetextBox_TextChanged(object sender, EventArgs e)
        {
            Gm.GametimeLabel.Text = GameTimetextBox.Text;
            _currentGameData.GameClock = GameTimetextBox.Text;
            ObsFileGenerator.Write(_currentGameData);
        }

        private void Resetbutton2_Click(object sender, EventArgs e)
        {
            ResetShotClock();
        }

        private void ShotClocktextBox_TextChanged(object sender, EventArgs e)
        {
            Gm.ShotTimerLabel.Text = ShotClocktextBox.Text;
            _currentGameData.ShotClock = ShotClocktextBox.Text;
            ObsFileGenerator.Write(_currentGameData);
        }
    }
}
