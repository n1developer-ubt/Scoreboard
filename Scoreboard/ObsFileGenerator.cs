using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scoreboard
{
    public static class ObsFileGenerator
    {
        private static string FilePath = Path.Combine(Application.StartupPath, "obs.txt");

        private static bool Writing = false;
        public static void Write(GameData data)
        {
            while (Writing);
            Writing = true;
            try
            {
                File.WriteAllText(Path.Combine(Application.StartupPath, "Left Player Name.txt"), data.LName);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Left Player Game Score.txt"), data.LPGScore);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Left Player Set Score.txt"), data.LPSScore);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Right Player Name.txt"), data.RName);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Right Player Game Score.txt"), data.RPGScore);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Right Player Set Score.txt"), data.RPSScore);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Shot Clock.txt"), data.ShotClock);
                File.WriteAllText(Path.Combine(Application.StartupPath, "Game Clock.txt"), data.GameClock);
                //File.WriteAllText(FilePath,$"{data.LPGScore}\n{data.LPSScore}\n{data.RPGScore}\n{data.RPSScore}\n{data.GameClock}\n{data.ShotClock}");
            }
            catch (Exception e)
            {
                
            }
            Writing = false;
        }
    }

    public class GameData
    {
        public string LPGScore { get; set; }
        public string RPGScore { get; set; }
        public string RPSScore { get; set; }
        public string LPSScore { get; set; }
        public string GameClock { get; set; }
        public string ShotClock { get; set; }
        public string LName { get; set; }
        public string RName { get; set; }
    }
}
