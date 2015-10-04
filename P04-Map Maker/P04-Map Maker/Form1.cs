using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04_Map_Maker {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            GetRadio();
        }

        #region

        List<RadioButton> tiles = new List<RadioButton>();
        Node[] nodes = new Node[19];

        #endregion

        void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //create about window
            AboutBox about = new AboutBox();
            about.Show();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {}

        void GetRadio() {
            tiles.Add(tile1);
            tiles.Add(tile2);
            tiles.Add(tile3);
            tiles.Add(tile4);
            tiles.Add(tile5);
            tiles.Add(tile6);
            tiles.Add(tile7);
            tiles.Add(tile8);
            tiles.Add(tile9);
            tiles.Add(tile10);
            tiles.Add(tile11);
            tiles.Add(tile12);
            tiles.Add(tile13);
            tiles.Add(tile14);
            tiles.Add(tile15);
            tiles.Add(tile16);
            tiles.Add(tile17);
            tiles.Add(tile18);
            tiles.Add(tile19);

            //string message = "";
            //foreach (RadioButton button in tiles) {
            //    message += $" {button.Name}";
            //}
            //MessageBox.Show(message);
        }

        private void button1_Click( object sender, EventArgs e ) {
            label5.Text = RadioButtonSwitch.Active.ToString();
        }

        private void Form1_Load( object sender, EventArgs e ) {

        }
    }

    public enum NodeType {
        Grain,
        Brick,
        Wood,
        Wool
    }

    public struct Node {
        public string Name { get; set; }
        public NodeType Type { get; set; }
        public int Activation { get; set; }
        public int Count { get; set; }
    }
}