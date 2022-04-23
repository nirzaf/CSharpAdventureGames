using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.gameclasses {

    [Serializable]
    public class ThingHolder : Thing {
        private ThingList _things = new ThingList();
     

        // for objects that can't be opened: openable=false, open=true
        public ThingHolder(string aName, string aDescription, ThingList tl)
            : base(aName, aDescription) {
            _things = tl;           
        }

        public ThingHolder(string aName, string aDescription, bool isTakable, bool isMovable, ThingList tl)
            : base(aName, aDescription, isTakable, isMovable ) {
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
            return $"Name: {Name}, Description {Description} - it contains -> {_things.Describe()}";
        }

    } // ThingHolder
}
