﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // ไปยังหน้าขายข้าว
        {
            if (radioButton1.Checked) 
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (radioButton2.Checked)
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();

            }
        }

        private void button2_Click(object sender, EventArgs e) // ไปยังหน้าขายน้ำ
        {
            MessageBox.Show("ปิดการทำงาน");
            Close();
        }
    }
}
