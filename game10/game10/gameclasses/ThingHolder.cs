using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.gameclasses {

    [Serializable]
    public class ThingHolder : Thing {
        private ThingList _things = new ThingList();

        public ThingHolder(string aName, string aDescription, ThingList tl)
            : base(aName, aDescription) {
            _things = tl;
        }

        public ThingHolder(string aName, string aDescription, bool aCanTake, ThingList tl)
            : base(aName, aDescription, aCanTake) {
            _things = tl;
        }

        public ThingList Things {
            get => _things;
            set => _things = value;
        }

        public void AddThing(Thing aThing) {
            _things.Add(aThing);
        }

        public void AddThings(ThingList aThingList) {
            _things.AddRange(aThingList);
        }

        public override string Describe() {
            return $"{Name}, {Description}: contains {_things.Describe()}";
        }

    } // ThingHolder
}
