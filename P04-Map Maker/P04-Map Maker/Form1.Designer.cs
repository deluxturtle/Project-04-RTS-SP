namespace P04_Map_Maker {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonSwitch3 = new RadioButtonSwitch();
            this.radioButtonSwitch2 = new RadioButtonSwitch();
            this.radioButtonSwitch1 = new RadioButtonSwitch();
            this.radioButtonSwitch4 = new RadioButtonSwitch();
            this.radioButtonSwitch5 = new RadioButtonSwitch();
            this.radioButtonSwitch6 = new RadioButtonSwitch();
            this.radioButtonSwitch7 = new RadioButtonSwitch();
            this.radioButtonSwitch8 = new RadioButtonSwitch();
            this.radioButtonSwitch9 = new RadioButtonSwitch();
            this.radioButtonSwitch10 = new RadioButtonSwitch();
            this.radioButtonSwitch11 = new RadioButtonSwitch();
            this.radioButtonSwitch12 = new RadioButtonSwitch();
            this.radioButtonSwitch13 = new RadioButtonSwitch();
            this.radioButtonSwitch14 = new RadioButtonSwitch();
            this.radioButtonSwitch15 = new RadioButtonSwitch();
            this.radioButtonSwitch16 = new RadioButtonSwitch();
            this.radioButtonSwitch17 = new RadioButtonSwitch();
            this.radioButtonSwitch18 = new RadioButtonSwitch();
            this.radioButtonSwitch19 = new RadioButtonSwitch();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.newToolStripMenuItem.Text = "New";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.loadToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(360, 266);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 31);
            this.textBox2.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(334, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Activation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Count";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Grain",
            "Brick",
            "Wood",
            "Wool"});
            this.comboBox1.Location = new System.Drawing.Point(339, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5\t",
            "6"});
            this.comboBox2.Location = new System.Drawing.Point(339, 173);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 33);
            this.comboBox2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Map Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 31);
            this.textBox1.TabIndex = 28;
            // 
            // radioButtonSwitch3
            // 
            this.radioButtonSwitch3.AutoSize = true;
            this.radioButtonSwitch3.ID = 6758;
            this.radioButtonSwitch3.Location = new System.Drawing.Point(169, 136);
            this.radioButtonSwitch3.Name = "radioButtonSwitch3";
            this.radioButtonSwitch3.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch3.TabIndex = 32;
            this.radioButtonSwitch3.TabStop = true;
            this.radioButtonSwitch3.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch2
            // 
            this.radioButtonSwitch2.AutoSize = true;
            this.radioButtonSwitch2.ID = 1;
            this.radioButtonSwitch2.Location = new System.Drawing.Point(136, 136);
            this.radioButtonSwitch2.Name = "radioButtonSwitch2";
            this.radioButtonSwitch2.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch2.TabIndex = 31;
            this.radioButtonSwitch2.TabStop = true;
            this.radioButtonSwitch2.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch1
            // 
            this.radioButtonSwitch1.AutoSize = true;
            this.radioButtonSwitch1.ID = 0;
            this.radioButtonSwitch1.Location = new System.Drawing.Point(103, 136);
            this.radioButtonSwitch1.Name = "radioButtonSwitch1";
            this.radioButtonSwitch1.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch1.TabIndex = 30;
            this.radioButtonSwitch1.TabStop = true;
            this.radioButtonSwitch1.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch4
            // 
            this.radioButtonSwitch4.AutoSize = true;
            this.radioButtonSwitch4.ID = 6758;
            this.radioButtonSwitch4.Location = new System.Drawing.Point(157, 166);
            this.radioButtonSwitch4.Name = "radioButtonSwitch4";
            this.radioButtonSwitch4.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch4.TabIndex = 37;
            this.radioButtonSwitch4.TabStop = true;
            this.radioButtonSwitch4.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch5
            // 
            this.radioButtonSwitch5.AutoSize = true;
            this.radioButtonSwitch5.ID = 1;
            this.radioButtonSwitch5.Location = new System.Drawing.Point(124, 166);
            this.radioButtonSwitch5.Name = "radioButtonSwitch5";
            this.radioButtonSwitch5.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch5.TabIndex = 36;
            this.radioButtonSwitch5.TabStop = true;
            this.radioButtonSwitch5.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch6
            // 
            this.radioButtonSwitch6.AutoSize = true;
            this.radioButtonSwitch6.ID = 0;
            this.radioButtonSwitch6.Location = new System.Drawing.Point(91, 166);
            this.radioButtonSwitch6.Name = "radioButtonSwitch6";
            this.radioButtonSwitch6.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch6.TabIndex = 35;
            this.radioButtonSwitch6.TabStop = true;
            this.radioButtonSwitch6.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch7
            // 
            this.radioButtonSwitch7.AutoSize = true;
            this.radioButtonSwitch7.ID = 6758;
            this.radioButtonSwitch7.Location = new System.Drawing.Point(136, 195);
            this.radioButtonSwitch7.Name = "radioButtonSwitch7";
            this.radioButtonSwitch7.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch7.TabIndex = 40;
            this.radioButtonSwitch7.TabStop = true;
            this.radioButtonSwitch7.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch8
            // 
            this.radioButtonSwitch8.AutoSize = true;
            this.radioButtonSwitch8.ID = 1;
            this.radioButtonSwitch8.Location = new System.Drawing.Point(103, 195);
            this.radioButtonSwitch8.Name = "radioButtonSwitch8";
            this.radioButtonSwitch8.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch8.TabIndex = 39;
            this.radioButtonSwitch8.TabStop = true;
            this.radioButtonSwitch8.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch9
            // 
            this.radioButtonSwitch9.AutoSize = true;
            this.radioButtonSwitch9.ID = 0;
            this.radioButtonSwitch9.Location = new System.Drawing.Point(70, 195);
            this.radioButtonSwitch9.Name = "radioButtonSwitch9";
            this.radioButtonSwitch9.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch9.TabIndex = 38;
            this.radioButtonSwitch9.TabStop = true;
            this.radioButtonSwitch9.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch10
            // 
            this.radioButtonSwitch10.AutoSize = true;
            this.radioButtonSwitch10.ID = 6758;
            this.radioButtonSwitch10.Location = new System.Drawing.Point(157, 224);
            this.radioButtonSwitch10.Name = "radioButtonSwitch10";
            this.radioButtonSwitch10.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch10.TabIndex = 43;
            this.radioButtonSwitch10.TabStop = true;
            this.radioButtonSwitch10.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch11
            // 
            this.radioButtonSwitch11.AutoSize = true;
            this.radioButtonSwitch11.ID = 1;
            this.radioButtonSwitch11.Location = new System.Drawing.Point(124, 224);
            this.radioButtonSwitch11.Name = "radioButtonSwitch11";
            this.radioButtonSwitch11.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch11.TabIndex = 42;
            this.radioButtonSwitch11.TabStop = true;
            this.radioButtonSwitch11.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch12
            // 
            this.radioButtonSwitch12.AutoSize = true;
            this.radioButtonSwitch12.ID = 0;
            this.radioButtonSwitch12.Location = new System.Drawing.Point(91, 224);
            this.radioButtonSwitch12.Name = "radioButtonSwitch12";
            this.radioButtonSwitch12.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch12.TabIndex = 41;
            this.radioButtonSwitch12.TabStop = true;
            this.radioButtonSwitch12.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch13
            // 
            this.radioButtonSwitch13.AutoSize = true;
            this.radioButtonSwitch13.ID = 6758;
            this.radioButtonSwitch13.Location = new System.Drawing.Point(173, 254);
            this.radioButtonSwitch13.Name = "radioButtonSwitch13";
            this.radioButtonSwitch13.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch13.TabIndex = 46;
            this.radioButtonSwitch13.TabStop = true;
            this.radioButtonSwitch13.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch14
            // 
            this.radioButtonSwitch14.AutoSize = true;
            this.radioButtonSwitch14.ID = 1;
            this.radioButtonSwitch14.Location = new System.Drawing.Point(140, 254);
            this.radioButtonSwitch14.Name = "radioButtonSwitch14";
            this.radioButtonSwitch14.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch14.TabIndex = 45;
            this.radioButtonSwitch14.TabStop = true;
            this.radioButtonSwitch14.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch15
            // 
            this.radioButtonSwitch15.AutoSize = true;
            this.radioButtonSwitch15.ID = 0;
            this.radioButtonSwitch15.Location = new System.Drawing.Point(107, 254);
            this.radioButtonSwitch15.Name = "radioButtonSwitch15";
            this.radioButtonSwitch15.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch15.TabIndex = 44;
            this.radioButtonSwitch15.TabStop = true;
            this.radioButtonSwitch15.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch16
            // 
            this.radioButtonSwitch16.AutoSize = true;
            this.radioButtonSwitch16.ID = 6758;
            this.radioButtonSwitch16.Location = new System.Drawing.Point(173, 195);
            this.radioButtonSwitch16.Name = "radioButtonSwitch16";
            this.radioButtonSwitch16.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch16.TabIndex = 47;
            this.radioButtonSwitch16.TabStop = true;
            this.radioButtonSwitch16.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch17
            // 
            this.radioButtonSwitch17.AutoSize = true;
            this.radioButtonSwitch17.ID = 6758;
            this.radioButtonSwitch17.Location = new System.Drawing.Point(190, 166);
            this.radioButtonSwitch17.Name = "radioButtonSwitch17";
            this.radioButtonSwitch17.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch17.TabIndex = 48;
            this.radioButtonSwitch17.TabStop = true;
            this.radioButtonSwitch17.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch18
            // 
            this.radioButtonSwitch18.AutoSize = true;
            this.radioButtonSwitch18.ID = 6758;
            this.radioButtonSwitch18.Location = new System.Drawing.Point(206, 195);
            this.radioButtonSwitch18.Name = "radioButtonSwitch18";
            this.radioButtonSwitch18.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch18.TabIndex = 49;
            this.radioButtonSwitch18.TabStop = true;
            this.radioButtonSwitch18.UseVisualStyleBackColor = true;
            // 
            // radioButtonSwitch19
            // 
            this.radioButtonSwitch19.AutoSize = true;
            this.radioButtonSwitch19.ID = 6758;
            this.radioButtonSwitch19.Location = new System.Drawing.Point(190, 224);
            this.radioButtonSwitch19.Name = "radioButtonSwitch19";
            this.radioButtonSwitch19.Size = new System.Drawing.Size(27, 26);
            this.radioButtonSwitch19.TabIndex = 50;
            this.radioButtonSwitch19.TabStop = true;
            this.radioButtonSwitch19.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 311);
            this.Controls.Add(this.radioButtonSwitch19);
            this.Controls.Add(this.radioButtonSwitch18);
            this.Controls.Add(this.radioButtonSwitch17);
            this.Controls.Add(this.radioButtonSwitch16);
            this.Controls.Add(this.radioButtonSwitch13);
            this.Controls.Add(this.radioButtonSwitch14);
            this.Controls.Add(this.radioButtonSwitch15);
            this.Controls.Add(this.radioButtonSwitch10);
            this.Controls.Add(this.radioButtonSwitch11);
            this.Controls.Add(this.radioButtonSwitch12);
            this.Controls.Add(this.radioButtonSwitch7);
            this.Controls.Add(this.radioButtonSwitch8);
            this.Controls.Add(this.radioButtonSwitch9);
            this.Controls.Add(this.radioButtonSwitch4);
            this.Controls.Add(this.radioButtonSwitch5);
            this.Controls.Add(this.radioButtonSwitch6);
            this.Controls.Add(this.radioButtonSwitch3);
            this.Controls.Add(this.radioButtonSwitch2);
            this.Controls.Add(this.radioButtonSwitch1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Title Of Catan - Map Maker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private RadioButtonSwitch radioButtonSwitch1;
        private RadioButtonSwitch radioButtonSwitch2;
        private RadioButtonSwitch radioButtonSwitch3;
        private RadioButtonSwitch radioButtonSwitch4;
        private RadioButtonSwitch radioButtonSwitch5;
        private RadioButtonSwitch radioButtonSwitch6;
        private RadioButtonSwitch radioButtonSwitch7;
        private RadioButtonSwitch radioButtonSwitch8;
        private RadioButtonSwitch radioButtonSwitch9;
        private RadioButtonSwitch radioButtonSwitch10;
        private RadioButtonSwitch radioButtonSwitch11;
        private RadioButtonSwitch radioButtonSwitch12;
        private RadioButtonSwitch radioButtonSwitch13;
        private RadioButtonSwitch radioButtonSwitch14;
        private RadioButtonSwitch radioButtonSwitch15;
        private RadioButtonSwitch radioButtonSwitch16;
        private RadioButtonSwitch radioButtonSwitch17;
        private RadioButtonSwitch radioButtonSwitch18;
        private RadioButtonSwitch radioButtonSwitch19;
    }
}

