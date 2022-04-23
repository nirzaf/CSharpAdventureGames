namespace game.gameclasses {
    public class ThingHolder : Thing {
        private ThingList _things = new ThingList();

        public ThingHolder(string aName, string aDescription, ThingList tl)
            : base(aName, aDescription) {
            _things = tl;
        }

        public ThingHolder(string aName, string aDescription, bool aCanTake, ThingList tl)
            : base(aName, aDescription, aCanTake) {
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

        public string Describe() {
            return $"Name: {Name}, Description {Description}" +
                 " which contains -> {_things.Describe()}";
        }

    } // ThingHolder
}
