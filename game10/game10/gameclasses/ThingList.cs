using System;
using System.Collections.Generic;

namespace game.gameclasses {

    [Serializable]
    public class ThingList : List<Thing> {

        public string Describe() {
            string s = "";
            if (this.Count == 0) {
                s = "nothing.\r\n";
            } else {
                foreach (Thing t in this) {
                    s = s + t.Name + ". " + t.Description + "; ";
                }
            }

            return s;
        }

        public Thing ThisOb(string aName) {
            Thing athing = null;
            string thingName = "";
            string aNameLowCase = aName.Trim().ToLower();
            foreach (Thing t in this) {
                thingName = t.Name.Trim().ToLower();
                if (thingName.Equals(aNameLowCase)) {
                    athing = t;
                }
            }
            return athing;
        }

    }
}
