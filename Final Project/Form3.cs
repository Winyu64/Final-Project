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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            label22.Text = DateTime.Now.ToShortDateString(); //label22 = วัน/เดือน/ปี

            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
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

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox5.Checked == true)
            {
                numericUpDown5.Enabled = true;
                textBox5.Text = "0";
                numericUpDown5.Value = 0;
            }
            if (checkBox5.Checked == false)
            {
                numericUpDown5.Enabled = false;
                textBox5.Text = "0";
                numericUpDown5.Value = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox6.Checked == true)
            {
                numericUpDown6.Enabled = true;
                textBox6.Text = "0";
                numericUpDown6.Value = 0;
            }
            if (checkBox6.Checked == false)
            {
                numericUpDown6.Enabled = false;
                textBox6.Text = "0";
                numericUpDown6.Value = 0;
            }
        }

        // กำหนดตัวแปลที่ต้องใช่
        double a1, a2, a3, a4, a5, a6, b1, b2, b3, b4, b5, b6, sum1, sum2, sum3, sum4, sum5, sum6, p1, l1, m1, m2;

        private void button1_Click(object sender, EventArgs e) // เป็นปุ่มคำนวนราคาของ
        {
            a1 = 0;
            a2 = 0;
            a3 = 0;
            a4 = 0;
            a5 = 0;
            a6 = 0;
            textBox1.Text = numericUpDown1.Value.ToString();
            textBox2.Text = numericUpDown2.Value.ToString();
            textBox3.Text = numericUpDown3.Value.ToString();
            textBox4.Text = numericUpDown4.Value.ToString();
            textBox5.Text = numericUpDown5.Value.ToString();
            textBox6.Text = numericUpDown6.Value.ToString();

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
                a3 = 40;
                sum3 = b3 * a3;
            }
            else
            {
                b3 = double.Parse(textBox3.Text);
                a3 = 40;
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

            if (checkBox5.Checked)
            {
                b5 = double.Parse(textBox5.Text);
                a5 = 20;
                sum5 = b5 * a5;
            }
            else
            {
                b5 = double.Parse(textBox5.Text);
                a5 = 20;
                sum5 = b5 * a5;
            }

            if (checkBox6.Checked)
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 30;
                sum6 = b6 * a6;
            }
            else
            {
                b6 = double.Parse(textBox6.Text);
                a6 = 30;
                sum6 = b6 * a6;
            }

            l1 = b1 + b2 + b3 + b4 + b5 + b6;
            p1 = sum1 + sum2 + sum3 + sum4 + sum5 + sum6;

            // นำค่ามาใส่ textBox
            textBox7.Text = l1.ToString(); // จำนวน
            textBox8.Text = p1.ToString(); // ราคาของ
        }

        private void button2_Click(object sender, EventArgs e) // ปุ่มลบ
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;

        }

        private void button3_Click(object sender, EventArgs e) // ปุ่มคำนวนเงินทอน
        {
            if (textBox9.Text != "")
            {
                m1 = int.Parse(textBox9.Text);
                m2 = m1 - p1;
                textBox10.Text = m2.ToString();
            }
            else
                MessageBox.Show("กรุณาใส่ จำนวนเงิน");
        }

        
        private void button4_Click(object sender, EventArgs e) // ปุ่มส่งค่าจาก textBox ไปยัง dataGridView
        {
            if (textBox10.Text != "")
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = label22.Text;   // วัน/เดือน/ปี
                dataGridView1.Rows[n].Cells[1].Value = textBox7.Text;  // จำนวนรายการ
                dataGridView1.Rows[n].Cells[2].Value = textBox8.Text;  // ราคาขายออก

                textBox7.Text = "";
                textBox8.Text = "";
                textBox9.Text = "";
                textBox10.Text = "";
            }
            else
                MessageBox.Show("กรุณาชำระเงินด้วยค่ะ");
        }

        private void button5_Click(object sender, EventArgs e) // ปุ่มกลับไปหน้าเมนูการขาย
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // ปุ่ม save ข้อมูลจาก dataGridView ไปเก็บยัง ไฟล์ CSV
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(sfd.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // ปุ่ม open ฟล์ CSV ไปแสดงบน dataGridView
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
    }
}
