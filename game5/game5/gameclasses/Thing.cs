namespace game.gameclasses {
    public class Thing {
        private string _name;
        private string _description;

        public Thing(string aName, string aDescription) {
            // standard constructor: 
            _name = aName;
            _description = aDescription;
        }

        //  Name property
        public string Name {
            get => _name;
            set => _name = value;
        }

        // Description property
        public string Description {
            get => _description;
            set => _description = value;
        }
    }

}
