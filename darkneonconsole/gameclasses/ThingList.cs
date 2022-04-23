using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.gameclasses {

    [Serializable]
    public class ThingList : List<Thing> {

        public string Describe() {
            // return a string showing things each on a new line
            string s = "";
            if (this.Count > 0) {
                foreach (Thing t in this) {
                    s = s + t.Name + "\r\n";
                }
            } else {
                s = "nothing";
            }
            return s;
        }

        public Thing GetOb(string aName) {
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
