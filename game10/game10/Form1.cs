using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
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
            OutputTB.Text = $"Welcome to the Great Adventure!\r\nYou are in the {adv.Player.Location.Name}. It is {adv.Player.Location.Description}\r\n";
            OutputTB.AppendText("Where do you want to go now?\r\n");
            OutputTB.AppendText("Click a direction button: N, S, W or E.\r\n");
            ShowLocation();
        }

        private void Wr(String s) {
            // utility method to append text to textbox
            OutputTB.AppendText(s);
        }

        private void WrLn(String s) {
            // simple utility method that appends carriage-return/linefeed before calling Wr()
            Wr(s + "\r\n");
        }

        private void ShowLocation() {
            Wr(adv.Player.Name);
            Wr(" are currently in this room: ");
            WrLn(adv.Player.Location.Describe());
        }

        private void ShowInventory() {
            WrLn("You have " + adv.Player.Things.Describe());
        }

        private void LookBtn_Click(object sender, EventArgs e) {
            ShowLocation();
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
            ShowLocation();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) {
            InitGame();
        }



    }
}
