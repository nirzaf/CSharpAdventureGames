using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game.gameclasses;

namespace game {
    /// <summary>
    /// The Adventure class contains the 'world' of the game:
    /// It creates and initializes the player and the map.
    /// </summary>
    /// 
    public class Adventure {
        private RoomList _map;
        private Actor _player;

        public Adventure() {
            /*
            * 
            * Troll Room -- Forest
            *    |
            *  Cave  -----  Dungeon  
            * */

            _map = new RoomList();
            /*                                                                                          N          S          W          E          */
            _map.Add(Rm.TrollRoom, new Room("Troll Room", "a dank, dark room that smells of troll", Rm.NOEXIT, Rm.Cave, Rm.NOEXIT, Rm.Forest));
            _map.Add(Rm.Forest, new Room("Forest", "a light, airy forest shimmering with sunlight", Rm.NOEXIT, Rm.NOEXIT, Rm.TrollRoom, Rm.NOEXIT));
            _map.Add(Rm.Cave, new Room("Cave", "a vast cave with walls covered by luminous moss", Rm.TrollRoom, Rm.NOEXIT, Rm.NOEXIT, Rm.Dungeon));
            _map.Add(Rm.Dungeon, new Room("Dungeon", "a gloomy dungeon. Rats scurry across its floor", Rm.NOEXIT, Rm.NOEXIT, Rm.Cave, Rm.NOEXIT));

            _player = new Actor("You", "The Player", _map.RoomAt(Rm.TrollRoom));

        }

        //// --- Player
        public Actor Player {        
            get => _player;
        } // Player

        private void MoveActorTo(Actor anActor, Room aRoom) {
            anActor.Location = aRoom;
        }

        private Rm MoveTo(Actor anActor, Dir direction) {
            Room r = anActor.Location;
            Rm exit;

            switch (direction) {
                case Dir.NORTH:
                    exit = r.N;
                    break;
                case Dir.SOUTH:
                    exit = r.S;
                    break;
                case Dir.EAST:
                    exit = r.E;
                    break;
                case Dir.WEST:
                    exit = r.W;
                    break;
                default:
                    exit = Rm.NOEXIT;
                    break;
            }
            if (exit != Rm.NOEXIT) {
                MoveActorTo(anActor, _map.RoomAt(exit));
            }
            return exit;
        }

        public string MovePlayerTo(Dir direction) {
            string s;
            if (MoveTo(_player, direction) == Rm.NOEXIT) {
                s = "There is no exit in that direction\r\n";
            } else {               
                s = $"You are now in the {_player.Location.Name}\r\n";
            }
            return s;
        }
    }
}


