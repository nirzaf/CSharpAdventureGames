using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This is a sample console application (no Windows Forms) to run the game in
 * an authentic retro style.
 * 
 * Since the user interface code is divided from the game code, I've had to make
 * very few changes to transform the WinForms game to a console game. The main changes
 * are:
 * 
 * 1) A Main loop has been added in Program.cs which gets user input and displays
 *    output until 'q' or 'quit' are entered.
 * 2) The words q, quit, i, inventory, save and load have been added to vocabulary
 * 3) A very simple ShowInventory() method has been added to Adventure.cs
 *    (previously this could only be done with a button-click)
 * 4) The Save and Load game methods have been rewritten (as these no
 *    longer use a save/load dialog)
 * 5) The Main interface to the game (replacing Form1.cs) is now in a new
 *    class called GameRunnr
 * */

namespace game {
    class Program {
        static void Main(string[] args) {            
            GameRunner gr = new GameRunner();
        }
    }
}
