using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.gameclasses {

    [Serializable]
    public class Thing {
        private string _name;
        private string _description;
        private bool _takable;
        private bool _movable;        

        public Thing(string aName, string aDescription) {
            // standard constructor: 
            _name = aName;
            _description = aDescription;
            _takable = true; // set default value
            _movable = true; // set default value
        }

        public Thing(string aName, string aDescription, bool isTakable, bool isMovable) {
            // alternative constructor
            _name = aName;
            _description = aDescription;
            _takable = isTakable;
            _movable = isMovable;
        }

        public string Name   //  Name property
          {
            get => _name;
            set => _name = value;
        }

        public string Description   // Description property
        {
            get => _description;
            set => _description = value;
        }

        public bool Takable {
            get => _takable;
            set => _takable = value;
        }
        public bool Movable {
            get => _movable;
            set => _movable = value;
        }
       
        public virtual string Describe() {
            return Name + " " + Description;
        }
    }

}
