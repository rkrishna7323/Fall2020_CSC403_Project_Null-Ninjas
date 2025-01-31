﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project
{
    public partial class WinScreen : Form
    {
        public modeSelection modes;
        public FrmLevel frmLevel;
        public WinScreen()
        {
            this.ControlBox = false;
            this.BackgroundImage = Properties.Resources.WinScreenPicture;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
