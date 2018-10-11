using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;


namespace DynamicDatabaseCreation
{
    public partial class Form9 : Form
    {
        SqlDataAdapter sda;
        //SqlCommandBuilder scb;
        DataTable dt;

        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con1 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + textBox1 + "; Integrated Security = true;";
            SqlConnection con = new SqlConnection(con1);
           // con.Close();
            con.Open();
            string show = "select * from " + textBox2 + ";";
            sda = new SqlDataAdapter(show, con);
            //SqlCommand cmd = new SqlCommand(show, con);
            //cmd.ExecuteNonQuery();
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
