﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Sample, Test, Text
            string strText = lblText.Text;

            lblContain.Text = strText.Contains("Tesxt").ToString();
            lblEquals.Text = strText.Equals("Text").ToString();
            lblLength.Text = strText.Length.ToString();
            lblReplace.Text = strText.Replace("Test", "I can").ToString();

            string[] strSplit = strText.Split(',');
            lblSplit1.Text = strSplit[0].ToString();
            lblSplit2.Text = strSplit[1].ToString();
            lblSplit3.Text = strSplit[2].ToString();

            lblSubstring.Text = strText.Substring(3, 5).ToString();
            lblToLower.Text = strText.ToLower().ToString();
            lblToUpper.Text = strText.ToUpper().ToString();
            lblTrim.Text = strText.Trim().ToString();
        }
    }
}
