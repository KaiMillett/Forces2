﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        double sin(double x)
        {
            return (Math.Sin(x * Math.PI / 180.0));
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.Cos(x * Math.PI / 180.0));
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);

            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);

            Label.            
        }

    }
}

