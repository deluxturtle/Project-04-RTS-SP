﻿using System;
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

        private void aboutToolStripMenuItem_Click( object sender, EventArgs e ) {
            //create about window
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void radioButton1_CheckedChanged( object sender, EventArgs e ) {

        }

        private void comboBox1_SelectedIndexChanged( object sender, EventArgs e ) {

        }
    }

    public enum NodeType {
        
    }

    public struct Node {
        public string Name { get; set; }
        public NodeType Type { get; set; }
        public int Activation { get; set; }
        public int Count { get; set; }
    }
}
