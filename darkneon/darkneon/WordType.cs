namespace game {
    public class WordAndType {
        string _word;
        WT _wordtype;

        public WordAndType(string wd, WT wt) {
            _word = wd;
            _wordtype = wt;
        }

        public string Word {
            get {
                return _word;
            }
            set {
                _word = value;
            }
        }

        public WT Type {
            get {
                return _wordtype;
            }
            set {
                _wordtype = value;
            }
        }

    }

}
