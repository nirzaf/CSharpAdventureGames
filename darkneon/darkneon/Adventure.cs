using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using game.gameclasses;

namespace game {
    /// <summary>
    /// ---------------------------------
    /// DarkNeon Adventure Game Framework 
    /// ---------------------------------
    /// Copyright (c) Huw Collingbourne
    /// This game is based on the adventure game framework created by Huw Collingbourne
    /// This code may be used 'as is' or modified to create new games as long
    /// as this copyright notice and website links are included.
    /// http://www.bitwisebooks.com
    /// http://www.bitwisemag.com
    /// </summary>
    /// 

    /// The Adventure class contains the 'world' of the game:
    /// It creates and initializes the player and the map.

    [Serializable]
    public partial class Adventure {
        private RoomList _map;
        private Actor _player;
        /*
         * ADDED: Pull/Push/Put..in
         * TODO: Puzzles: 
         * Drop cheese. rat eats it and knocks something off the rafter
         * pull lever (opens door to new room)
         * put coin in slot
         * press button
         * Squirrel holding coin. Drops coin when you drop acorn
         * Drop cheese in attic to feed rat. Rat knocks off something (from rafter)
         * */

        public Adventure() {
            InitVocab();        //!! Be sure to initialize the vocabulary list...

            /*
             * 
             *                                  Attic -- Bedroom
             *                                     ^
             *                                     |
             *                           DesertedShop -- Kitchen
             *                                |    |
             *                                |    V
             *                                |  Basement
             *                                |
             *                   ------  DaggerStreet --------- Ripper Mews
             *                   |            |                   |
             * GoreStreet -- Alleyway -- OpiumTerrace  -------- GardenN       
             *    |                                               |  Oak Tree    Balcony
             *    |                                               |  ^              ^
             *    |                                               |  |              |
             *  DeadEnd               VegetableGarden --------- GardenS --------- PalmHouse
             *                                               
             *  
            * */

            // Initialize _map with Rooms
            _map = new RoomList {
                /*                  N                   S                   W                   E               Up              Down   */
                { Rm.GoreStreet, new Room("Gore Street", "a narrow, twisty street that smells of decay.\r\nThere is a sign on the wall",
                                Rm.NOEXIT,          Rm.DeadEnd,         Rm.NOEXIT,           Rm.Alleyway,
                                new ThingList())  },
                { Rm.Alleyway, new Room("Alleyway", "a dismal alleyway enclosed by the crumbling walls of tall buildings",
                                Rm.NOEXIT,          Rm.NOEXIT,          Rm.GoreStreet,       Rm.OpiumTerrace,
                                new ThingList ()) },
                { Rm.DeadEnd, new Room("Dead End", "a sinister little street that leads nowhere.\r\nThere is a button on the wall",
                                Rm.GoreStreet,      Rm.NOEXIT,          Rm.NOEXIT,           Rm.OpiumTerrace,
                                new ThingList()) },
                { Rm.OpiumTerrace, new Room("Opium Terrace", "a dark, dripping terrace illuminated by a hissing gas lamp.\r\nThere is a sign on the wall",
                                Rm.NOEXIT,          Rm.NOEXIT,          Rm.Alleyway,         Rm.GardenN,
                                new ThingList()) },
                { Rm.DaggerStreet, new Room("Dagger Street", "a long, winding street with exits to North and South. There is a narrow alleyway to the west." +
                                            "\r\nOn the northern side stands a deserted shop. There is a sign on the wall",
                                Rm.NOEXIT,          Rm.OpiumTerrace,    Rm.Alleyway,         Rm.RipperMews,
                                new ThingList()) },
                { Rm.RipperMews, new Room("Ripper Mews", "a delightful little street filled with the scent of gardenia.\r\nThere is a sign on the wall",
                                Rm.NOEXIT,          Rm.GardenN,         Rm.DaggerStreet,     Rm.NOEXIT,
                                new ThingList()) },
                { Rm.GardenN, new Room("Garden", "a lovely garden. A gardenia bush blossoms next to the gate. Walkways lead to other parts of the garden.\r\n" +
                                        "A squirrel suddenly runs across the grass in front of you. It seems to be holding a pearl." +
                                        "\r\nThe squirrel squeals then runs off into the distance.",
                                Rm.RipperMews,      Rm.GardenS,         Rm.OpiumTerrace,     Rm.NOEXIT,
                                new ThingList()) },
                { Rm.GardenS, new Room("Garden", "a lovely garden. A mighty oak tree towers above you. Walkways lead to other parts of the garden",
                                Rm.GardenN,         Rm.NOEXIT,          Rm.VegetableGarden,   Rm.PalmHouse,     Rm.OakTree,     Rm.NOEXIT,
                                new ThingList()) },
                { Rm.OakTree, new Room("Oak tree", "a mighty oak tree that towers over the garden. You have a glorious view of a splendid Palm House to your East," +
                                        "the vegetable garden to the West and other parts of the garden to the North. You vaguely see other parts of the city" +
                                        "in the distance, but the buildings are obscured by drifting fog.",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.NOEXIT,            Rm.NOEXIT,        Rm.NOEXIT,      Rm.GardenS,
                                new ThingList()) },
                 { Rm.VegetableGarden, new Room("Vegetable garden", "a garden filled with sprouting vegetables in bewildering variety",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.NOEXIT,            Rm.GardenS,
                                new ThingList()) },
                 { Rm.PalmHouse, new Room("Palm House", "a tall, elegant structure made of glass panes set in an cast-iron frame. The atmosphere is hot and humid." +
                                        "\r\nHuge palm trees rise high overhead. An elaborate cast-iron staircase leads up to a bacony",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.GardenS,            Rm.NOEXIT,       Rm.Balcony,     Rm.NOEXIT,
                                new ThingList()) },
                 { Rm.Balcony, new Room("Balcony", "a balcony at the height of the tallest palms. All you can see are palm fronds everywhere. The windows are too misty to see through",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.NOEXIT,            Rm.NOEXIT,       Rm.NOEXIT,     Rm.PalmHouse,
                                new ThingList()) },
                 { Rm.DesertedShop, new Room("Deserted shop", "a musty old shop. There is nothing here but dust",
                                Rm.NOEXIT,         Rm.DaggerStreet,     Rm.NOEXIT,            Rm.Kitchen,       Rm.Attic,     Rm.Basement,
                                new ThingList()) },
                 { Rm.Basement, new Room("Basement", "a dank, dripping basement that smells of fungus",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.NOEXIT,            Rm.NOEXIT,       Rm.DesertedShop,     Rm.NOEXIT,
                                new ThingList()) },
                 { Rm.Attic, new Room("Attic", "a cramped space under the roof. A hungry-looking rat is sitting on a rafter",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.NOEXIT,            Rm.Bedroom,       Rm.NOEXIT,     Rm.DesertedShop,
                                new ThingList()) },
                 { Rm.Bedroom, new Room("Bedroom", "a tiny room containing a small, damp bed and a huge wooden chest",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.Attic,            Rm.NOEXIT,
                                new ThingList()) },
                 { Rm.Kitchen, new Room("Kitchen", "an untidy kitchen that smells of rancid cheese",
                                Rm.NOEXIT,         Rm.NOEXIT,           Rm.DesertedShop,            Rm.NOEXIT,
                                new ThingList()) }

            };

            // NOTE: Add Things to selected Rooms (after Rooms are created and added to map)
            _map[Rm.GoreStreet].AddThings(new ThingList {
                        new Thing("leaflet", "The leaflet says: 'Ripper Strikes Again!'"),
                        new Thing("sign", "The sign says 'Gore Street'", false, false),
                        new ContainerThing("sack", "a smelly old sack", true, true, true, true, new ThingList())
                });
            _map[Rm.Alleyway].AddThings(new ThingList {
                        new ContainerThing("bin", "It is a smelly bin.", false, true, true, true,
                            new ThingList{
                                new Thing("bone", "A bone that looks as though it has been gnawed by a dog"),
                                new Thing("coin", "A small, silver coin of unknown denomination")
                            }),
                        new Thing("knife", "It is a blood-stained carving knife")
                    });
            _map[Rm.OpiumTerrace].AddThing(new Thing("lamp", "The hissing gas lamp is fixed high up on a wall. It produces a sickly, green, flickering light", false, false));
            _map[Rm.OpiumTerrace].AddThing(new Thing("sign", "The sign says 'Opium Terrace'", false, false));
            _map[Rm.DaggerStreet].AddThing(new Thing("sign", "The sign says 'Dagger Street'", false, false));
            _map[Rm.DaggerStreet].AddThing(new Thing("shop", "It is a deserted shop", false, false));
            _map[Rm.OakTree].AddThing(new Thing("acorn", "A very ordinary-looking acorn"));
            _map[Rm.Bedroom].AddThing(new Thing("bed", "A nasty, rather damp bed", false, true));
            _map[Rm.Bedroom].AddThing(new ContainerThing("chest", "A wooden chest", false, true, true, false,
                 new ThingList{
                                new Thing("key", "A small brass key")
                            }));
            _map[Rm.DesertedShop].AddThing(new Thing("dust", "It is very ordinary-looking dust.", false, true));
            _map[Rm.Attic].AddThing(new Thing("rat", "A scabby, hungry-looking rat with yellow teeth and green eyes.\r\nIt is sitting on the rafter sniffing the air and squeaking.", false, false));
            _map[Rm.Kitchen].AddThing(new Thing("cheese", "A smelly lump of cheese"));
            _map[Rm.Balcony].AddThing(new Thing("lever", "A lever fixed to the wall", false, true));
            _map[Rm.Balcony].AddThing(new Thing("sign", "The sign says: 'Coin operated'", false, true));
            _map[Rm.Balcony].AddThing(new ContainerThing("slot", "A lever fixed to the wall", false, false, false, true, new ThingList()));
            _map[Rm.DeadEnd].AddThing(new Thing("button", "A glowing green button on the wall", false, true));
            _player = new Actor("You", "The Player", _map.RoomAt(Rm.GoreStreet), new ThingList());
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
                case Dir.UP:
                    exit = r.Up;
                    break;
                case Dir.DOWN:
                    exit = r.Down;
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

        private void TransferOb(Thing t, ThingList fromlist, ThingList tolist) {
            fromlist.Remove(t);
            tolist.Add(t);
        }

        // NOTE: Looks for ob in any open containers in current room
        // if found returns a pair of objects: Key = Thing, Value = ThingList containing Thing
        private KeyValuePair<Thing, ThingList> ObInContainerHere(string obname) {
            ContainerThing ct = null;
            Thing t = null;
            ThingList tl = null;
            foreach (Thing ob in _player.Location.Things) {
                if (ob is ContainerThing) {
                    ct = (ContainerThing)ob;
                    if (ct.IsOpen) {
                        tl = ct.Things;
                        t = ct.Things.GetOb(obname);
                    }
                }
            }
            return new KeyValuePair<Thing, ThingList>(t, tl);
        }

        private Thing ObHere(string obname) {
            // look for ob in current room and player's inventory
            // return ob if found, else return null
            KeyValuePair<Thing, ThingList> kv;
            Thing t = null;           
            t = _player.Location.Things.GetOb(obname);
            if (t == null) {
                t = _player.Things.GetOb(obname);
            }
            if (t == null) {
                kv = ObInContainerHere(obname);
                t = kv.Key;              
            }
            return t;
        }

        private string TryToOpen(ContainerThing t) {
            string s = "";
            if (!t.Openable) {
                s = $"Can't open the {t.Name}";
            } else {
                if (t.IsOpen) {
                    s = $"The {t.Name} is already open.";
                } else {
                    t.IsOpen = true;
                    s = $"You open the {t.Name}";
                }
            }
            return s;
        }


        private string TryToClose(ContainerThing t) {
            string s = "";
            if (!t.Openable) {
                s = $"Can't close the {t.Name}";
            } else {
                if (t.IsOpen) {
                    t.IsOpen = false;
                    s = $"You close the {t.Name}";
                } else {
                    s = $"The {t.Name} is already closed.";
                }
            }
            return s;
        }

        // --- Public methods
        public string MovePlayerTo(Dir direction) {
            string s;
            if (MoveTo(_player, direction) == Rm.NOEXIT) {
                s = "There is no exit in that direction\r\n";
            } else {
                s = _player.Location.Describe();
            }
            return s;
        }

        public string Look() {
            return "You are in " + _player.Location.Describe();
        }

        public string PutObInContainer(string obname, string containername) {
            string s = "";
            Thing t = _player.Things.GetOb(obname);
            Thing container = ObHere(containername);
            if (t == null) {
                s = $"You haven't got the {obname}!";
            } else if (container == null) {
                s = $"There is no {containername} here!";
            } else if (!(container is ContainerThing)) {
                s = $"You can't put the {obname} into the {containername}!";
            } else if (!((ContainerThing)container).IsOpen) {
                s = $"You can't put the {obname} into a closed {containername}!";
            } else {
                TransferOb(t, _player.Things, ((ContainerThing)container).Things);
                s = $"You put the {obname} into the {containername}.";
            }
            return s;
        }


        // NOTE: Now allows things to be taken from open Containers!
        public string TakeOb(string obname) {
            KeyValuePair<Thing, ThingList> kv;
            Thing t;
            ThingList tl;
            string s = "";
            t = _player.Location.Things.GetOb(obname);                   // See if ob is 'in room'
            tl = _player.Location.Things;
            if (obname == "") {
                obname = "nameless object"; // if no object specified
            }
            if (t == null) {                                            // if not, see if it's in a container in room
                kv = ObInContainerHere(obname);
                t = kv.Key;
                tl = kv.Value;
            }
            if (t == null) {
                s = $"There is no {obname} here!";
            } else {
                if (t.Takable) {
                    TransferOb(t, tl, _player.Things);
                    s = t.Name + " taken!";
                } else {
                    s = $"You can't take the {t.Name}!";
                }
            }
            return s;
        }

        public string DropOb(string obname) {
            Thing t = _player.Things.GetOb(obname);
            string s = "";
            if (t == null) {
                s = "You haven't got one!";
            } else {
                TransferOb(t, _player.Things, _player.Location.Things);
                s = t.Name + " dropped!";
            }
            return s;
        }


        public string LookAtOb(string obname) {
            Thing t;
            string s = "";
            if (obname == "") {
                s = "You'll have to say what you want to look at!";
            } else {
                t = ObHere(obname);
                if (t == null) {
                    s = $"There is no {obname} here!";
                } else {
                    s = t.Describe();
                }
            }
            return s;
        }

        public string OpenOb(string obname) {
            Thing t;
            string s = "";
            if (obname == "") {
                s = "You'll have to say what you want to open!";
            } else {
                t = ObHere(obname);
                if (t == null) {
                    s = $"There is no {obname} here!";
                } else {
                    if (t is ContainerThing) {
                        s = TryToOpen((ContainerThing)t);
                    } else {
                        s = $"Cannot open the {obname}";
                    }
                }
            }
            return s;
        }


        public string CloseOb(string obname) {
            Thing t;
            string s = "";
            if (obname == "") {
                s = "You'll have to say what you want to close!";
            } else {
                t = ObHere(obname);
                if (t == null) {
                    s = $"There is no {obname} here!";
                } else {
                    if (t is ContainerThing) {
                        s = TryToClose((ContainerThing)t);
                    } else {
                        s = $"Cannot close the {obname}";
                    }
                }
            }
            return s;
        }

        public string PullOb(string obname) {
            Thing t;
            string s = "";
            t = ObHere(obname);
            if (t == null) {
                s = $"There is no {obname} here!";
            } else {
                s = PullSpecial(t);                
                if (s == "") {
                    if (t.Movable) {
                        s = $"The {obname} moves slightly when you pull it.";
                    } else {
                        s = $"You try to pull the {obname} but nothing happens.";
                    }
                }
            }
            return s;
        }


        public string PushOb(string obname) {
            Thing t;
            string s = "";
            t = ObHere(obname);
            if (t == null) {
                s = $"There is no {obname} here!";
            } else {
                if (t.Movable) {
                    s = $"The {obname} moves slightly when you push it.";
                } else {
                    s = $"You try to push the {obname} but nothing happens.";
                }
            }
            return s;
        }


    }
}


