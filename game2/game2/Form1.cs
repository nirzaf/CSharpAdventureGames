using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            /*
             * 
             * Troll Room -- Forest
             *    |
             *  Cave  -----  Dungeon  
             * */

            Room room0;
            Room room1;
            Room room2;
            Room room3;
            

            room0 = new Room();
            room1 = new Room();
            room2 = new Room();
            room3 = new Room();
            

            room0.name = "Troll Room";
            room0.n = -1;
            room0.s = 2;
            room0.w = -1;
            room0.e = 1;

            room1.name = "Forest";
            room1.n = -1;
            room1.s = -1;
            room1.w = 0;
            room1.e = -1;

            room2.name = "Cave";
            room2.n = 0;
            room2.s = -1;
            room2.w = -1;
            room2.e = 3;

            room3.name = "Dungeon";
            room3.n = -1;
            room3.s = -1;
            room3.w = 2;
            room3.e = -1;

            outputTB.Text = $"The {room0.name} has these exits: N={room0.n} S={room0.s} W={room0.w} E={room0.e}\r\n";
            outputTB.AppendText($"The {room1.name} has these exits: N={room1.n} S={room1.s} W={room1.w} E={room1.e}\r\n");
            outputTB.AppendText($"The {room2.name} has these exits: N={room2.n} S={room2.s} W={room2.w} E={room2.e}\r\n");
            outputTB.AppendText($"The {room3.name} has these exits: N={room3.n} S={room3.s} W={room3.w} E={room3.e}\r\n");
        }

        
    }
}
