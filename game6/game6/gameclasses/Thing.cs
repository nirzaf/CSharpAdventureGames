namespace game.gameclasses {
    public class Thing {
        private string _name;
        private string _description;

        public Thing(string aName, string aDescription) {
            // standard constructor: 
            _name = aName;
            _description = aDescription;
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
    }

}
