using System;
using System.Windows.Forms;

namespace game {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Room r = new Room();
            r.name = "Troll Room";
            r.n = 1;
            r.s = 2;
            r.w = 3;
            r.e = 4;
            outputTB.Text = $"You are in the {r.name}, There are exits leading to the following rooms: {r.n}, {r.s}, {r.w}, {r.e}";
        }
    }
}
