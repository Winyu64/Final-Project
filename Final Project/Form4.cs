using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label22.Text = DateTime.Now.ToShortDateString(); //label22 = วัน/เดือน/ปี
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                textBox1.Text = "0";
                numericUpDown1.Value = 0;
            }
            if (checkBox1.Checked == false)
            {
                numericUpDown1.Enabled = false;
                textBox1.Text = "0";
                numericUpDown1.Value = 0;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                numericUpDown2.Enabled = true;
                textBox2.Text = "0";
                numericUpDown2.Value = 0;
            }
            if (checkBox2.Checked == false)
            {
                numericUpDown2.Enabled = false;
                textBox2.Text = "0";
                numericUpDown2.Value = 0;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                numericUpDown3.Enabled = true;
                textBox3.Text = "0";
                numericUpDown3.Value = 0;
            }
            if (checkBox3.Checked == false)
            {
                numericUpDown3.Enabled = false;
                textBox3.Text = "0";
                numericUpDown3.Value = 0;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                numericUpDown4.Enabled = true;
                textBox4.Text = "0";
                numericUpDown4.Value = 0;

            }
            if (checkBox4.Checked == false)
            {
                numericUpDown4.Enabled = false;
                textBox4.Text = "0";
                numericUpDown4.Value = 0;
            }
        }

        double a1, a2, a3, a4, b1, b2, b3, b4, sum1, sum2, sum3, sum4, price1, list1, m1, m2;
        private void button1_Click(object sender, EventArgs e)
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            textBox1.Text = numericUpDown1.Value.ToString();
            textBox2.Text = numericUpDown2.Value.ToString();
            textBox3.Text = numericUpDown3.Value.ToString();
            textBox4.Text = numericUpDown4.Value.ToString();

            if (checkBox1.Checked)
            {
                b1 = double.Parse(textBox1.Text);
                a1 = 10;
                sum1 = b1 * a1;
            }
            else
            {
                b1 = double.Parse(textBox1.Text);
                a1 = 10;
                sum1 = b1 * a1;
            }

            if (checkBox2.Checked)
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 10;
                sum2 = b2 * a2;
            }
            else
            {
                b2 = double.Parse(textBox2.Text);
                a2 = 10;
                sum2 = b2 * a2;
            }

            if (checkBox3.Checked)
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 10;
                sum3 = b3 * a3;
            }
            else
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 10;
                sum3 = b3 * a3;
            }

            if (checkBox4.Checked)
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 10;
                sum4 = b4 * a4;
            }
            else
            {
                b4 = double.Parse(textBox4.Text);
                a4 = 10;
                sum4 = b4 * a4;
            }

            list1 = b1 + b2 + b3 + b4;
            price1 = sum1 + sum2 + sum3 + sum4;

            // นำค่ามาใส่ textBox
            textBox7.Text = list1.ToString();
            textBox8.Text = price1.ToString();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                m1 = int.Parse(textBox9.Text);
                m2 = m1 - price1;
                textBox10.Text = m2.ToString();
            }
            else
                MessageBox.Show("กรุณาใส่ จำนวนเงิน");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = label22.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox7.Text;
                dataGridView1.Rows[n].Cells[2].Value = textBox8.Text;

                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else
                MessageBox.Show("กรุณาคิดเงินด้วยค่ะ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(.csv)|*.csv";
            openFile.Title = "Please select file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = null;

                DataTable dt = new DataTable();
                string[] colName = { "วัน/เดือน/ปื", "จำนวน", "ราคาขายออก" };

                foreach (string col in colName)
                {
                    dt.Columns.Add(col);
                }

                foreach (string file in openFile.FileNames)
                {
                    try
                    {
                        if (File.Exists(file) == true)
                        {
                            //import file data
                            StreamReader csv = new StreamReader(file);
                            string textLine; //string line data
                            string[] splitLine; // use array to save split data

                            do
                            {
                                textLine = csv.ReadLine();
                                splitLine = textLine.Split(",");
                                dt.Rows.Add(splitLine);
                            }
                            while (csv.Peek() != -1);
                            csv.Close();
                            csv.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                dataGridView1.DataSource = dt;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "CSV(.csv)|*.csv";
            openFile.Title = "Please select file";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = null;

                DataTable dt = new DataTable();
                string[] colName = { "วัน/เดือน/ปื", "จำนวน", "ราคาที่ขายออก" };

                foreach (string col in colName)
                {
                    dt.Columns.Add(col);
                }

                foreach (string file in openFile.FileNames)
                {
                    try
                    {
                        if (File.Exists(file) == true)
                        {
                            //import file data
                            StreamReader csv = new StreamReader(file);
                            string textLine; //string line data
                            string[] splitLine; // use array to save split data

                            do
                            {
                                textLine = csv.ReadLine();
                                splitLine = textLine.Split(",");
                                dt.Rows.Add(splitLine);
                            }
                            while (csv.Peek() != -1);
                            csv.Close();
                            csv.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                dataGridView1.DataSource = dt;
            }
        }
    }
}
