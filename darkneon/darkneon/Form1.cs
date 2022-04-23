using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        }

        private void InitGame() {
            adv = new Adventure();
            StartGame();
        }

        private void StartGame() {
            WrLn($"Welcome to the Dark Neon City --- a futuristic Victorian adventure game");
            WrLn(adv.Look());
            WrLn("Where do you want to go now?");
            WrLn("Click a direction button: N, S, W or E or enter a command");            
        }

        private void Wr(String s) {
            // utility method to append text to textbox
            OutputTB.AppendText(s);
        }

        private void WrLn(String s) {
            // simple utility method that appends carriage-return/linefeed before caling Wr()
            Wr(s + "\r\n");
        }

       

        private void ShowInventory() {
            WrLn("You have " + adv.Player.Things.Describe());
        }

        private void LookBtn_Click(object sender, EventArgs e) {
            WrLn(adv.Look());
        }

        private void MovePlayer(Dir direction) {
            WrLn(adv.MovePlayerTo(direction));
        }

        private void NBtn_Click(object sender, EventArgs e) {
            MovePlayer(Dir.NORTH);
        }

        private void WBtn_Click(object sender, EventArgs e) {
            MovePlayer(Dir.WEST);
        }

        private void EBtn_Click(object sender, EventArgs e) {
            MovePlayer(Dir.EAST);
        }

        private void SBtn_Click(object sender, EventArgs e) {
            MovePlayer(Dir.SOUTH);
        }

        private void UpBtn_Click(object sender, EventArgs e) {
            MovePlayer(Dir.UP);
        }

        private void DownBtn_Click(object sender, EventArgs e) {
            MovePlayer(Dir.DOWN);
        }

        private void TakeBtn_Click(object sender, EventArgs e) {
            WrLn(adv.TakeOb(InputTB.Text));
        }

        private void DropBtn_Click(object sender, EventArgs e) {
            WrLn(adv.DropOb(InputTB.Text));
        }

        private void InventoryBtn_Click(object sender, EventArgs e) {
            ShowInventory();
        }

        private void LookAtBtn_Click(object sender, EventArgs e) {
            WrLn(adv.LookAtOb(InputTB.Text));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream st;
            BinaryFormatter binfmt;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                if ((st = saveFileDialog1.OpenFile()) != null) {
                    // Save to disk
                    binfmt = new BinaryFormatter();
                    binfmt.Serialize(st, adv);
                    st.Close();
                    WrLn("Saved");
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            Stream st;
            BinaryFormatter binfmt;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                if ((st = openFileDialog1.OpenFile()) != null) {
                    binfmt = new BinaryFormatter();
                    adv = (Adventure)binfmt.Deserialize(st);
                    st.Close();
                }
            }
            OutputTB.Clear();
            adv.Look();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) {
            InitGame();
        }


        private void cmdTB_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                WrLn(adv.RunCommand(cmdTB.Text));
                cmdTB.Clear();
            }
        }

        private void cmdBtn_Click(object sender, EventArgs e) {
            WrLn(adv.RunCommand(cmdTB.Text));
        }

       
    }
}
