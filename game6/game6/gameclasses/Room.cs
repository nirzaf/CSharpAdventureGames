namespace game.gameclasses {
    public class Room : Thing {
        private Rm _n, _s, _w, _e;

        public Room(string aName, string aDescription,
            Rm aN, Rm aS, Rm aW, Rm aE)
            : base(aName, aDescription) {
            _n = aN;
            _s = aS;
            _w = aW;
            _e = aE;
        }

        public Rm N {
            get => _n;
            set => _n = value;
        }

        public Rm S {
            get => _s;
            set => _s = value;
        }

        public Rm W {
            get => _w;
            set => _w = value;
        }

        public Rm E {
            get => _e;
            set => _e = value;
        }

        public string Describe() {
            return $"[{Name}] This is {Description}";
        }
    }
}
