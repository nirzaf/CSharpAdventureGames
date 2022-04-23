using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.gameclasses {
    [Serializable]
    public class ContainerThing : ThingHolder {

        private bool _openable;
        private bool _isopen;

        public ContainerThing(string aName, string aDescription, ThingList tl)
            : base(aName, aDescription, tl) {
            _openable = false;
            _isopen = true;
        }

        // For an openable object
        public ContainerThing(string aName, string aDescription, bool isTakable, bool isMovable, bool isOpenable, bool open, ThingList tl)
           : base(aName, aDescription, isTakable, isMovable, tl) {            
            _openable = isOpenable;
            _isopen = open;
        }

        public void Open() {
            _isopen = true;
        }

        public void Close() {
            _isopen = false;
        }

        public override string Describe() {
            string desc = "";
            string thingsdesc = "";
            desc = $"This is {Description}";
            thingsdesc = Things.Describe();
            if (thingsdesc != "") {
                desc += $"\r\nIn the {Name} you can see:\r\n" + thingsdesc;
            }
            return desc;
        }

        public bool Openable { get => _openable; set => _openable = value; }
        public bool IsOpen { get => _isopen; set => _isopen = value; }
    }
}