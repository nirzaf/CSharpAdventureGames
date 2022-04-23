using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodTest {
    class Treasure {
        private string _name;

        public string Name { get => _name; set => _name = value; }

        public Treasure(string aName) {
            _name = aName;
        }

        public String Describe1() {
            return $"The {Name} is a Treasure: Describe1\r\n";
        }

        public String Describe2() {
            return $"The {Name} is a Treasure: Describe2\r\n";
        }

        public virtual String Describe3() {
            return $"The {Name} is a Treasure: (virtual) Describe3\r\n";
        }
    }


    class MagicTeasure : Treasure {

        public MagicTeasure(string aName) : base(aName) { }

        public String Describe1() {
            return $"The {Name} is a MagicTreasure: Describe1\r\n";
        }

        public new String Describe2() { // <- 'new' keyword         
            return $"The {Name} is a MagicTreasure: (new) Describe2\r\n";
        }

        public override String Describe3() {
            return $"The {Name} is a MagicTreasure: (override) Describe3\r\n";
        }
    }


    class Weapon : Treasure {

        public Weapon(string aName) : base(aName) { }

        public String Describe1() {
            return $"The {Name} is a Weapon: Describe1\r\n";
        }

        public new String Describe2() { // <- 'new' keyword 
            return $"The {Name} is a Weapon: (new) Describe2\r\n";
        }

        public override String Describe3() {
            return $"The {Name} is a Weapon: (override) Describe3\r\n";
        }
    }

}
