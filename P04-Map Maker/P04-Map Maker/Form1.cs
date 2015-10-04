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
        }

        #region
        
        Node[] nodes = new Node[19];

        #endregion

        void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            //create about window
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void typeBox_SelectedIndexChanged( object sender, EventArgs e ) {

        }

        private void activationBox_SelectedIndexChanged( object sender, EventArgs e ) {

        }

        private void countBox_ValueChanged( object sender, EventArgs e ) {

        }

        private void nameBox_TextChanged( object sender, EventArgs e ) {

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