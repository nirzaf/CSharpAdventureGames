using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace game {
    class GameRunner {
        Adventure adv; // the Adventure object
        public GameRunner() {
            InitGame();
        }
        private void InitGame() {
            adv = new Adventure();
            StartGame();
        }

        private void StartGame() {
            string input;
            string output = "";
            Console.WriteLine($"Welcome to the Dark Neon City --- a futuristic Victorian adventure game");
            Console.WriteLine(adv.Look());
            Console.WriteLine("Where do you want to go now?");
            Console.WriteLine("Enter a command. To Quit the game, enter Q.");
            // Run main program loop until user enters Q to quit
            do {
                Console.Write("> ");
                input = Console.ReadLine().ToLower();
                output = save_or_load(input);
                if (output == "") {
                    output = adv.RunCommand(input);
                }
                Console.WriteLine(output);
            } while (output != "q");
        }


        public string save_or_load(string input) {
            // Test if save or load was entered. 
            string output = "";
            if (input.Trim() == "save") {
                output = SaveGame();
            } else if (input.Trim() == "load") {
                output = LoadGame();
            }
            return output;
        }

        // Save/Load added for Console app
        public string SaveGame() {
            FileStream fs;
            BinaryFormatter binfmt;
            string filename;
            string msg = "saved";
            Console.Write("Enter filename to save: ");
            filename = Console.ReadLine();
            // NOTE: If an invalid filename is entered (e.g. if it contains '/' chars)
            // or if the file name is empty ""
            // program will crash. As an exercise, write a more robust function that
            // verifies the file name is correct before using it!
            // You may also want to check if a file exists (so the user can select a
            // different file name) before sacing data to it
            fs = new FileStream(filename, FileMode.Create);
            binfmt = new BinaryFormatter();
            try {
                binfmt.Serialize(fs, adv);
            } catch (SerializationException e) {
                msg = "Save failed: " + e.Message;
            } finally {
                fs.Close();
            }
            return msg;
        }

        public string LoadGame() {
            FileStream fs;
            BinaryFormatter binfmt;
            string filename;
            string msg = "loaded";
            Console.Write("Enter filename to load: ");
            filename = Console.ReadLine();
            // NOTE: If an invalid filename is entered (e.g. if it contains '/' chars)
            // or if the file name is empty ""
            // program will crash. As an exercise, write a more robust function that
            // verifies the file name is correct before using it!
            fs = new FileStream(filename, FileMode.Open);
            binfmt = new BinaryFormatter();
            try {
                adv = (Adventure)binfmt.Deserialize(fs);
            } catch (SerializationException e) {
                msg = "Load failed: " + e.Message;
            } finally {
                fs.Close();
            }
            return msg;
        }
    }
}
