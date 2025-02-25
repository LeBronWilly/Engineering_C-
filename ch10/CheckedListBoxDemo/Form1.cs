﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i)) //判斷第i個項目是否被勾選
                    msg += $"{checkedListBox1.Items[i]} ,";
            }
            if (msg == "")
            {
                MessageBox.Show("你沒選擇水果", "你在幹嘛喇");
            }
            else
            {
                MessageBox.Show(msg, "選擇水果");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.CheckOnClick = true;
        }
    }
}
