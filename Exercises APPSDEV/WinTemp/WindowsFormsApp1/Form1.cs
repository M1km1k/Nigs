﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackbarC_Scroll(object sender, EventArgs e)
        {

            lblC.Text = trackbarC.Value.ToString();

            lblF.Text = ((double.Parse(lblC.Text) * 9 / 5) + 32).ToString();
            lblK.Text = (double.Parse(lblC.Text) + 273.16).ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
