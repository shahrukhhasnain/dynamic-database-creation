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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                if (DAL.AlterTable2(textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Well Done");
                }
                else
                {
                    MessageBox.Show("OOPPSss");
                }
            }
            else if(checkBox1.Checked)
            {
                if (DAL.AlterTable3(textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Well Done");
                }
                else
                {
                    MessageBox.Show("OOPPSss");
                }
            }
            else if (checkBox2.Checked)
            {
                if (DAL.AlterTable4(textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Well Done");
                }
                else
                {
                    MessageBox.Show("OOPPSss");
                }
            }
            else
            {
                if (DAL.AlterTable(textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text) == 1)
                {
                    MessageBox.Show("Well Done");
                }
                else
                {
                    MessageBox.Show("OOPPSss");
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DAL.AlterColumn(textBox3.Text, textBox1.Text, textBox2.Text, comboBox1.Text) == 1)
            {
                MessageBox.Show("Well Done");
            }
            else
            {
                MessageBox.Show("OOPPSss");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
