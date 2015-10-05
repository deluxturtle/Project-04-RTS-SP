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
        int activeNum = 0;

        #endregion

        public Form1() {
            InitializeComponent();

            for (int i = 0; i < 19; i++) {
                nodes[i] = new Node();
            }


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
            if (RadioButtonSwitch.Active == activeNum) {
                Console.WriteLine("Current Name: " + nodes[RadioButtonSwitch.Active].Name + "  Index: " + RadioButtonSwitch.Active);

                nodes[RadioButtonSwitch.Active].Name = nameBox.Text;

                Console.WriteLine("New Name: " + nodes[RadioButtonSwitch.Active].Name);
            }

        }

        void radioButtonSwitch_CheckedChanged(object sender, EventArgs e) {
            RadioButtonSwitch me = (RadioButtonSwitch)sender;
            //Console.Write("Am I checked: " + me.Checked + " I am number: " + me.ID);


            //tiffany
            foreach (Control control in this.groupBox1.Controls) {
                if (control is RadioButtonSwitch ) {
                    RadioButtonSwitch radio = control as RadioButtonSwitch;
                    if (radio.Checked) {
                        Console.WriteLine("Pulling the button that is clicked");
                        Console.WriteLine(radio.ID);
                        activeNum = radio.ID;
                        ChangeFields( radio.ID);
                    }
                }
            }

            //HorribleRadioLogic();

            //RadioButtonSwitch me = (RadioButtonSwitch) sender;
            //if (me.Checked) {
            //    //countBox.Value = nodes[RadioButtonSwitch.Active].Count;
            //    //nameBox.Text = nodes[RadioButtonSwitch.Active].Name;
            //    //typeBox.SelectedItem = nodes[RadioButtonSwitch.Active].Type;
            //    //activationBox.SelectedItem = nodes[RadioButtonSwitch.Active].Activation;

            //    //MessageBox.Show(me.Checked.ToString());

            //    ChangeFields(RadioButtonSwitch.Active);
            //}
        }

        private void loadToolStripMenuItem_Click( object sender, EventArgs e ) {
            nodes[0].Name = "test";
            label1.Text = RadioButtonSwitch.Active.ToString();
        }

        /// <summary>
        /// Changes the fields to the properties of the node matching index
        /// </summary>
        /// <param name="index">The index of the node.</param>
        void ChangeFields(int index) {
            Console.WriteLine("Chaning fields...");
            countBox.Value = nodes[index].Count;
            nameBox.Text = nodes[index].Name;
            typeBox.SelectedItem = nodes[index].Type;
            activationBox.SelectedItem = nodes[index].Activation;
        }

        /// <summary>
        /// runs through the radio buttons finding which is checked, then calls ChangeField based on the proper index
        /// </summary>
        void HorribleRadioLogic() {
            if (radioButtonSwitch1.Checked) {
                ChangeFields(0);
            } else if (radioButtonSwitch2.Checked) {
                ChangeFields( 1 );
            } else if ( radioButtonSwitch3.Checked ) {
                ChangeFields( 2 );
            } else if ( radioButtonSwitch4.Checked ) {
                ChangeFields( 3 );
            } else if ( radioButtonSwitch5.Checked ) {
                ChangeFields( 4 );
            } else if ( radioButtonSwitch6.Checked ) {
                ChangeFields( 5 );
            } else if ( radioButtonSwitch7.Checked ) {
                ChangeFields( 6 );
            } else if ( radioButtonSwitch8.Checked ) {
                ChangeFields( 7 );
            } else if ( radioButtonSwitch9.Checked ) {
                ChangeFields( 8 );
            } else if ( radioButtonSwitch10.Checked ) {
                ChangeFields( 9 );
            } else if ( radioButtonSwitch11.Checked ) {
                ChangeFields( 10 );
            } else if ( radioButtonSwitch12.Checked ) {
                ChangeFields( 11 );
            } else if ( radioButtonSwitch13.Checked ) {
                ChangeFields( 12);
            } else if ( radioButtonSwitch14.Checked ) {
                ChangeFields( 13);
            } else if ( radioButtonSwitch15.Checked ) {
                ChangeFields( 14);
            } else if ( radioButtonSwitch16.Checked ) {
                ChangeFields( 15);
            } else if ( radioButtonSwitch17.Checked ) {
                ChangeFields( 16);
            } else if ( radioButtonSwitch18.Checked ) {
                ChangeFields( 17);
            } else if ( radioButtonSwitch19.Checked ) {
                ChangeFields( 18);
            }
        }
    

    }

    public enum NodeType {
        Grain,
        Brick,
        Wood,
        Wool,
        TEST
    }

    public class Node {
        //tiffany made class
        public string Name { get; set; }
        public NodeType Type { get; set; }
        public int Activation { get; set; }
        public int Count { get; set; }

        public Node() {
            Name = "testName";
            Type = NodeType.TEST;
            Activation = 1;
            Count = 1;
        }

    }


}