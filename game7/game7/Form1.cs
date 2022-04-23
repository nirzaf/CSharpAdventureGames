using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using game.gameclasses;

namespace game {
    public partial class Form1 : Form {
        Adventure adv; // the Adventure object

        public Form1() {
            InitializeComponent();
            InitGame();
            StartGame();
        }

        private void InitGame() {
            adv = new Adventure();
        }

        private void StartGame() {
            outputTB.Text = $"Welcome to the Great Adventure!\r\nYou are in the {adv.Player.Location.Name}. It is {adv.Player.Location.Description}\r\n";
            outputTB.AppendText("Where do you want to go now?\r\n");
            outputTB.AppendText("Click a direction button: N, S, W or E.\r\n");
        }

        private void LookBtn_Click(object sender, EventArgs e) {
            outputTB.Text = $"You are in the {adv.Player.Location.Name}. It is {adv.Player.Location.Description}\r\n";
        }

        private void MovePlayer(Rm newpos) {
            outputTB.Text = adv.MovePlayerTo(newpos);
        }

        private void NBtn_Click(object sender, EventArgs e) {
            MovePlayer(adv.Player.Location.N);
        }

        private void WBtn_Click(object sender, EventArgs e) {
            MovePlayer(adv.Player.Location.W);
        }

        private void EBtn_Click(object sender, EventArgs e) {
            MovePlayer(adv.Player.Location.E);
        }

        private void SBtn_Click(object sender, EventArgs e) {
            MovePlayer(adv.Player.Location.S);
        }
    }
}
