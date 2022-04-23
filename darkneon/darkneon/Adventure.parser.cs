using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game {
    partial class Adventure {

        // ===============================================================
        //                        --- Parser ---
        // ===============================================================

        Dictionary<string, WT> vocab = new Dictionary<string, WT>();

        private void InitVocab() {
            vocab.Add("acorn", WT.NOUN);
            vocab.Add("bed", WT.NOUN);
            vocab.Add("bin", WT.NOUN);            
            vocab.Add("bone", WT.NOUN);
            vocab.Add("button", WT.NOUN);
            vocab.Add("cheese", WT.NOUN);
            vocab.Add("chest", WT.NOUN);
            vocab.Add("coin", WT.NOUN);
            vocab.Add("door", WT.NOUN);
            vocab.Add("dust", WT.NOUN);
            vocab.Add("gardenia", WT.NOUN);
            vocab.Add("key", WT.NOUN);
            vocab.Add("knife", WT.NOUN);
            vocab.Add("lamp", WT.NOUN);
            vocab.Add("leaflet", WT.NOUN);
            vocab.Add("lever", WT.NOUN);
            vocab.Add("pearl", WT.NOUN);
            vocab.Add("rat", WT.NOUN);
            vocab.Add("sack", WT.NOUN);
            vocab.Add("shop", WT.NOUN);
            vocab.Add("sign", WT.NOUN);
            vocab.Add("slot", WT.NOUN);
            vocab.Add("squirrel", WT.NOUN);
            vocab.Add("take", WT.VERB);
            vocab.Add("drop", WT.VERB);
            vocab.Add("put", WT.VERB);
            vocab.Add("look", WT.VERB);
            vocab.Add("open", WT.VERB);
            vocab.Add("close", WT.VERB);
            vocab.Add("pull", WT.VERB);
            vocab.Add("push", WT.VERB);
            vocab.Add("n", WT.VERB);
            vocab.Add("s", WT.VERB);
            vocab.Add("w", WT.VERB);
            vocab.Add("e", WT.VERB);
            vocab.Add("up", WT.VERB);
            vocab.Add("down", WT.VERB);
            vocab.Add("a", WT.ARTICLE);
            vocab.Add("an", WT.ARTICLE);
            vocab.Add("the", WT.ARTICLE);
            vocab.Add("in", WT.PREPOSITION);
            vocab.Add("into", WT.PREPOSITION);
            vocab.Add("at", WT.PREPOSITION);
        }

        /* Command types:
       * VERB                           // e.g. N or Look
       * VERB+NOUN                      // e.g. Take X, Drop Y
       * VERB+PREPOSITION+NOUN          // e.g. Look at X
       * VERB+NOUN+PREPOSITION+NOUN     // e.g. Put X in Y
       * */

        private string ProcessVerbNounPrepositionNoun(List<WordAndType> command) {
            // "put in" is the only implemented command of this type
            WordAndType wt1 = command[0];
            WordAndType wt2 = command[1];
            WordAndType wt3 = command[2];
            WordAndType wt4 = command[3];
            string s = "";
            if ((wt1.Type != WT.VERB) || (wt3.Type != WT.PREPOSITION)) {
                s = $"Can't do this because I don't understand how to {wt1.Word} something {wt3.Word} something else!";
            } else if (wt2.Type != WT.NOUN) {
                s = $"Can't do this because '{wt2.Word}' is not an object!";
            } else if (wt4.Type != WT.NOUN) {
                s = $"Can't do this because '{wt4.Word}' is not an object!";
            } else {
                switch (wt1.Word + wt3.Word) {
                    case "putin":
                    case "putinto":         // allow either "put in" or "put into"...
                        s = PutObInContainer(wt2.Word, wt4.Word);
                        break;
                    default:
                        s = $"I don't know how to {wt1.Word} {wt2.Word} {wt3.Word} {wt4.Word}!";
                        break;
                }
            }
            return s;
        }

        private string ProcessVerbPrepositionNoun(List<WordAndType> command) {
            // "look at" is the only implemented command of this type
            WordAndType wt = command[0];
            WordAndType wt2 = command[1];
            WordAndType wt3 = command[2];
            string s = "";
            if ((wt.Type != WT.VERB) || (wt2.Type != WT.PREPOSITION)) {
                s = $"Can't do this because I don't understand '{wt.Word} {wt2.Word}' !";
            } else if (wt3.Type != WT.NOUN) {
                s = $"Can't do this because '{wt3.Word}' is not an object!\r\n";
            } else {
                switch (wt.Word + wt2.Word) {
                    case "lookat":
                        s = LookAtOb(wt3.Word);
                        break;
                    default:
                        s = $"I don't know how to {wt.Word} {wt2.Word} a {wt3.Word}!";
                        break;
                }
            }
            return s;
        }

        private string ProcessVerbNoun(List<WordAndType> command) {
            WordAndType wt = command[0];
            WordAndType wt2 = command[1];
            string s = "";
            if (wt.Type != WT.VERB) {
                s = $"Can't do this because '{wt.Word}' is not a command!";
            } else if (wt2.Type != WT.NOUN) {
                s = $"Can't do this because '{wt2.Word}' is not an object!";
            } else {
                switch (wt.Word) {
                    case "take":
                        s = TakeOb(wt2.Word);
                        break;
                    case "drop":
                        s = DropOb(wt2.Word);
                        break;
                    case "open":
                        s = OpenOb(wt2.Word);
                        break;
                    case "close":
                        s = CloseOb(wt2.Word);
                        break;
                    case "pull":
                        s = PullOb(wt2.Word);
                        break;
                    case "push":
                        s = PushOb(wt2.Word);
                        break;
                    default:
                        s = $"I don't know how to {wt.Word} a {wt2.Word}!";
                        break;
                }
            }
            return s;
        }


        private string ProcessVerb(List<WordAndType> command) {
            WordAndType wt = command[0];
            string s = "";
            if (wt.Type != WT.VERB) {
                s = $"Can't do this because '{wt.Word}' is not a command!";
            } else {
                switch (wt.Word) {
                    case "look":
                        s = Look();
                        break;
                    case "n":
                        s = MovePlayerTo(Dir.NORTH);
                        break;
                    case "s":
                        s = MovePlayerTo(Dir.SOUTH);
                        break;
                    case "w":
                        s = MovePlayerTo(Dir.WEST);
                        break;
                    case "e":
                        s = MovePlayerTo(Dir.EAST);
                        break;
                    case "up":
                        s = MovePlayerTo(Dir.UP);
                        break;
                    case "down":
                        s = MovePlayerTo(Dir.DOWN);
                        break;
                    default:
                        s = $"Sorry, I can't {wt.Word}!";
                        break;
                }
            }
            return s;
        }



        private string ProcessCommand(List<WordAndType> command) {
            string s = "";
            if (command.Count == 0) {
                s = "You must write a command!";
            } else if (command.Count > 4) {
                s = "That command is too long!";
            } else {
                s = "About to process command";
                switch (command.Count) {
                    case 1:
                        s = ProcessVerb(command);
                        break;
                    case 2:
                        s = ProcessVerbNoun(command);
                        break;
                    case 3:
                        s = ProcessVerbPrepositionNoun(command);
                        break;
                    case 4:
                        s = ProcessVerbNounPrepositionNoun(command);
                        break;
                    default:
                        s = "Unable to process command";
                        break;
                }
            }
            return s;
        }

        private string ParseCommand(List<string> wordlist) {
            List<WordAndType> command = new List<WordAndType>();
            WT wordtype;
            string errmsg = "";
            string s = "";

            foreach (string k in wordlist) {
                // Check to see if Key, s,
                // exists. If not, set WordType to ERROR
                if (vocab.ContainsKey(k)) {
                    wordtype = vocab[k];
                    if (wordtype == WT.ARTICLE) { // ignore articles such as "the" or "a"
                    } else {
                        command.Add(new WordAndType(k, wordtype));
                    }
                } else {    // if word isn't found in vocab
                    command.Add(new WordAndType(k, WT.ERROR));
                    errmsg = $"Sorry, I don't understand '{k}'";
                }
            }

            if (errmsg != "") {
                s = errmsg;
            } else {
                s = ProcessCommand(command);
            }
            return s;
        }


        public string RunCommand(string inputstr) {
            char[] delims = { ' ', '.' };
            List<string> strlist;
            string s = "";

            string lowstr = inputstr.Trim().ToLower();
            if (lowstr == "") {
                s = "You must enter a command";
            } else {
                strlist = new List<string>(inputstr.Split(delims, StringSplitOptions.RemoveEmptyEntries));
                s = ParseCommand(strlist);
            }
            return s;
        }
    }
}
