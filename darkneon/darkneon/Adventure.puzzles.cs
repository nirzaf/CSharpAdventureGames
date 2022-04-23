using game.gameclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game {
    partial class Adventure {

        // ===============================================================
        //                        --- Special actions for puzzles  ---
        // ===============================================================

      private string PullSpecial(Thing t) {
            // return "" if no special action
            string s = "";
            if(t.Name == "lever") { }
            return s;
        }
    }
}
