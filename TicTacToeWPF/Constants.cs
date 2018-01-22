using System;
using System.IO;
using System.Drawing;
namespace TicTacToeWPF
{       
    class Constants
    {   
        // Indices in combo box
        public const int HOT_SEAT_MODE = 0;
        public const int AI_EASY_MODE = 1;
        public const int AI_HARD_MODE = 2;
              
        public Image X_SYMBOL = Image.FromFile(@"3.png");
        // Player marks
        public const string O_SYMBOL = "0";
      //  public const string X = "X";
    }
}
