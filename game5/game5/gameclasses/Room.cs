namespace game.gameclasses {
    public class Room : Thing {
        private int _n;
        private int _s;
        private int _w;
        private int _e;


        public Room(string aName, string aDescription, int aN, int aS, int aW, int aE)
           : base(aName, aDescription) {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }


        public int N {
            get => _n;
            set => _n = value;
        }

        public int S {
            get => _s;
            set => _s = value;
        }

        public int W {
            get => _w;
            set => _w = value;
        }

        public int E {
            get => _e;
            set => _e = value;
        }
    }
}
