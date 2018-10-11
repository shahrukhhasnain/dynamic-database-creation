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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DAL.showtable(textBox1.Text,textBox2.Text)==1)
            {
                //BindingSource bsource = new BindingSource();
                //dataGridView1.DataSource = bsource;
                DataSet ds = new System.Data.DataSet();
                dataGridView1.DataSource = ds.Tables[1];
                
            }
            else
            {
                MessageBox.Show("Galti hogai");
            }
        }
    }
}
