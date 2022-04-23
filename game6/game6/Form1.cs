using game.gameclasses;
using System;
using System.Windows.Forms;

namespace game {
    public partial class Form1 : Form {

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

        private RoomList _map;

        private Actor _player;

        public Form1() {
            InitializeComponent();
            InitGame();
            StartGame();
        }

        private void InitGame() {
            room0 = new Room("Troll Room", "a dank, dark room that smells of troll", Rm.NOEXIT, Rm.Cave, Rm.NOEXIT, Rm.Forest);
            room1 = new Room("Forest", "a light, airy forest shimmering with sunlight", Rm.NOEXIT, Rm.NOEXIT, Rm.TrollRoom, Rm.NOEXIT);
            room2 = new Room("Cave", "a vast cave with walls covered by luminous moss", Rm.TrollRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.Dungeon);
            room3 = new Room("Dungeon", "a gloomy dungeon. Rats scurry across its floor", Rm.NOEXIT, Rm.NOEXIT, Rm.Cave, Rm.NOEXIT);

            _map = new RoomList();

            _map.Add(Rm.TrollRoom, room0);
            _map.Add(Rm.Forest, room1);
            _map.Add(Rm.Cave, room2);
            _map.Add(Rm.Dungeon, room3);

            _player = new Actor("You", "The Player", room0);
        }

        private void StartGame() {
            outputTB.Text = $"Welcome to the Great Adventure!\r\nYou are in the {_player.Location.Name}. It is {_player.Location.Description}\r\n";
            outputTB.AppendText("Where do you want to go now?\r\n");
            outputTB.AppendText("Click a direction button: N, S, W or E.\r\n");
        }

        private void LookBtn_Click(object sender, EventArgs e) {
            outputTB.Text = $"You are in the {_player.Location.Name}. It is {_player.Location.Description}\r\n";
        }

        private void MovePlayer(Rm newpos) {
            if (newpos == Rm.NOEXIT) {
                outputTB.Text = "There is no exit in that direction\r\n";
            } else {
                _player.Location = _map.RoomAt(newpos);
                outputTB.Text = $"You are now in the {_player.Location.Name}\r\n";
            }
        }

        private void NBtn_Click(object sender, EventArgs e) {
            MovePlayer(_player.Location.N);
        }

        private void WBtn_Click(object sender, EventArgs e) {
            MovePlayer(_player.Location.W);
        }

        private void EBtn_Click(object sender, EventArgs e) {
            MovePlayer(_player.Location.E);
        }

        private void SBtn_Click(object sender, EventArgs e) {
            MovePlayer(_player.Location.S);
        }
    }
}
