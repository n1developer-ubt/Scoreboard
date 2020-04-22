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
                File.WriteAllText(FilePath,$"{data.LPGScore}\n{data.LPSScore}\n{data.RPGScore}\n{data.RPSScore}\n{data.GameClock}\n{data.ShotClock}");
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
    }
}
