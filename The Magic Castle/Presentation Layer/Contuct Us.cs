﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Magic_Castle.Presentation_Layer
{
    public partial class Contuct_Us : Form
    {
        public Contuct_Us()
        {
            InitializeComponent();
        }

        private void Contuct_Us_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            TMC_Homepage tMC_Homepage = new TMC_Homepage();
            tMC_Homepage.Show();
            this.Hide();
        }
    }
}
