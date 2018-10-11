using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicDatabaseCreation
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                if (DAL.createtable2(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }

            }
            else if (checkBox2.Checked)
            {
                if (DAL.createtable3(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
            else if (checkBox4.Checked)
            {
                if (DAL.createtable6(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
            else if (checkBox1.Checked)
            {
                if (DAL.createtable4(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
            else if (checkBox1.Checked&&checkBox4.Checked)
            {
                if (DAL.createtable7(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
            else if (checkBox3.Checked)
            {
                if (DAL.createtable5(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
            else
            {
                if (DAL.createtable(textBox1.Text, textBox2.Text, textBox3.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Unsuccessfull");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
