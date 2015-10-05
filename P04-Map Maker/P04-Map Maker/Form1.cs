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
        #region fields

        Node[] nodes = new Node[19];

        #endregion

        public Form1() {
            InitializeComponent();
            radioButtonSwitch1.Checked = true;
        }

        #region menu strip

        void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //create about window
            AboutBox about = new AboutBox();
            about.Show();
        }

        #endregion

        void typeBox_SelectedIndexChanged(object sender, EventArgs e) {}

        void activationBox_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        void countBox_ValueChanged(object sender, EventArgs e) {
            nodes[RadioButtonSwitch.Active].Count = (int)countBox.Value;
        }

        void nameBox_TextChanged(object sender, EventArgs e) {
            nodes[RadioButtonSwitch.Active].Name = nameBox.Text;
        }

        void radioButtonSwitch_CheckedChanged(object sender, EventArgs e) {
            RadioButtonSwitch me = (RadioButtonSwitch) sender;
            if (me.Checked) {
                countBox.Value = nodes[RadioButtonSwitch.Active].Count;
                nameBox.Text = nodes[RadioButtonSwitch.Active].Name;
                typeBox.SelectedItem = nodes[RadioButtonSwitch.Active].Type;
                activationBox.SelectedItem = nodes[RadioButtonSwitch.Active].Activation;
            }
        }

        private void loadToolStripMenuItem_Click( object sender, EventArgs e ) {
            nodes[0].Name = "test";
            label1.Text = " " + RadioButtonSwitch.Active;
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