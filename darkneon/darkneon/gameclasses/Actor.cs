using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.gameclasses {

    [Serializable]
    public class Actor : ThingHolder {
        private Room _location; // Room where Actor is at present

        public Actor(string aName, string aDescription, Room aRoom, ThingList tl) :
           base(aName, aDescription, tl) {
            _location = aRoom;
        }

        public Room Location {
            get => _location;
            set => _location = value;
        }

        public override string Describe() {
            return $"[{Name}] ({Description}) is in {_location.Describe()}";
        }
    }
}
