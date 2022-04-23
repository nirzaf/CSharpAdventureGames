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
        private bool _cantake;

        public Thing(string aName, string aDescription) {
            // standard constructor: 
            _name = aName;
            _description = aDescription;
            _cantake = true; // sets _cantake to default value
        }

        public Thing(string aName, string aDescription, bool aCantake) {
            // alternative constructor
            _name = aName;
            _description = aDescription;
            _cantake = aCantake;
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

        public bool CanTake {
            get => _cantake;
            set => _cantake = value;
        }

        public virtual string Describe() {
            return Name + " " + Description;
        }
    }

}
