using System;

namespace game.gameclasses {

    [Serializable]
    public class Room : ThingHolder {
        private Rm _n, _s, _w, _e;

        public Room(string aName, string aDescription,
            Rm aN, Rm aS, Rm aW, Rm aE, ThingList tl)
            : base(aName, aDescription, tl)
        {
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

        public override string Describe()
        {
            return $"[{Name}] This is {Description}" + "\r\nHere there is: " + Things.Describe();
        }
    }
}
