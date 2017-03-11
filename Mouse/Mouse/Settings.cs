using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mouse
{
    public class Settings
    {
        public static bool Gameover { get; set; }
        public static int Score { get; set; }
        public static string Name { get; set; }
        public static int FoodScore { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int pozX { get; set; }
        public static int pozY { get; set; }
        public static int NumberofGames { get; set; }
        public static bool FirstTime { get; set; }
        public static int Nr_Cheese { get; set; }
        public Settings()
        {
            Gameover = false;
            Score = 0;
            FoodScore = 10;
            Width = 65;
            Height = 65;
            pozX = 10;
            pozY = 8;
            NumberofGames = 0;
            FirstTime = true;
            Nr_Cheese = 5;
        }
    }
}
