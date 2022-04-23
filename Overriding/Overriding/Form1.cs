using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MethodTest {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void testBtn_Click(object sender, EventArgs e) {
            Treasure treasureob = new Treasure("Diamond ring");
            MagicTeasure magictreasureob = new MagicTeasure("Elvish Shield");
            Weapon weaponob = new Weapon("Battle Axe");

            List<Treasure> oblist = new List<Treasure>();
            oblist.Add(treasureob);
            oblist.Add(magictreasureob);
            oblist.Add(weaponob);

            textBox1.AppendText("=== Calling each object specifically ===\r\n\r\n");
            textBox1.AppendText(treasureob.Describe1());
            textBox1.AppendText(treasureob.Describe2());
            textBox1.AppendText(treasureob.Describe3());
            textBox1.AppendText(magictreasureob.Describe1());
            textBox1.AppendText(magictreasureob.Describe2());
            textBox1.AppendText(magictreasureob.Describe3());
            textBox1.AppendText(weaponob.Describe1());
            textBox1.AppendText(weaponob.Describe2());
            textBox1.AppendText(weaponob.Describe3());
            
            
            textBox1.AppendText("\r\n=== Calling each object as an instance of base class Treasure ===\r\n");
            foreach (Treasure aTreasure in oblist) {
                textBox1.AppendText("\r\nThis object's class type is: " + aTreasure.ToString() + "\r\n");
                textBox1.AppendText(aTreasure.Describe1());
                textBox1.AppendText(aTreasure.Describe2());
                textBox1.AppendText(aTreasure.Describe3());
            } 
           
        }
    }
}
