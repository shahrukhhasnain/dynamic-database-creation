using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Windows.Forms;

namespace DynamicDatabaseCreation
{
    class DAL
    {
        public static int createdb(string dbsource, string dbname)
        {
           
            try
            {
                string con = "Data Source = " + dbsource + "; Integrated Security = true;";
                SqlConnection conn = new SqlConnection(con);
                string dbcreate = "create database " + dbname + ";";
                conn.Close();
                conn.Open();
                SqlCommand com = new SqlCommand(dbcreate, conn);
                com.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                string abc = ex.ToString();
                return 0;
            }
        }
        public static int createtable(string tbname,string dbname,string colname,string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = "+dbname+"; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                //string tabcreate = "create table " + tbname + "(name varchar(50),email varchar(50),phone int);";
                string tabcreate = "create table " + tbname + "("+colname+" "+dt+" );";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }
        public static int createtable2(string tbname, string dbname, string colname, string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                string tabcreate2 = "create table " + tbname + "(" + colname + " " + dt + " not null unique);";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate2, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }

        public static int createtable3(string tbname, string dbname, string colname, string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                string tabcreate3 = "create table " + tbname + "(" + colname + " " + dt + " unique);";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate3, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }
        public static int createtable4(string tbname, string dbname, string colname, string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                string tabcreate4 = "create table " + tbname + "(" + colname + " " + dt + " not null);";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate4, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }
        public static int createtable6(string tbname, string dbname, string colname, string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                string tabcreate4 = "create table " + tbname + "(" + colname + " " + dt + " IDENTITY(1,1));";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate4, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }
        public static int createtable7(string tbname, string dbname, string colname, string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                string tabcreate4 = "create table " + tbname + "(" + colname + " " + dt + " not null IDENTITY(1,1));";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate4, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }
        public static int createtable5(string tbname, string dbname, string colname, string dt)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con2 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn2 = new SqlConnection(con2);
                string tabcreate4 = "create table " + tbname + "(" + colname + " " + dt + " Primary Key("+colname+"));";
                conn2.Close();
                conn2.Open();
                SqlCommand com2 = new SqlCommand(tabcreate4, conn2);
                com2.ExecuteNonQuery();
                return 1;
            }
            catch (Exception exx)
            {
                string a = exx.ToString();
                return 0;
            }
        }

        public static int AlterTable(string dbname, string tbname, string colname, string dtname)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string Altertab = "alter table "+tbname+" add "+colname+" "+dtname+";";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(Altertab, conn4);
                com4.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                return 0;
            }
        }
        public static int AlterTable2(string dbname, string tbname, string colname, string dtname)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string Altertab = "alter table " + tbname + " add " + colname + " " + dtname + " not null unique;";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(Altertab, conn4);
                com4.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                return 0;
            }
        }
        public static int AlterTable3(string dbname, string tbname, string colname, string dtname)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string Altertab = "alter table " + tbname + " add " + colname + " " + dtname + " not null;";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(Altertab, conn4);
                com4.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                return 0;
            }
        }
        public static int AlterTable4(string dbname, string tbname, string colname, string dtname)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string Altertab = "alter table " + tbname + " add " + colname + " " + dtname + " unique;";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(Altertab, conn4);
                com4.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                return 0;
            }
        }

        public static int AlterColumn(string dbname, string tbname, string colname, string dtname)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con5 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn5 = new SqlConnection(con5);
                string Altercol = "alter table " + tbname + " alter column " + colname + " " + dtname + ";";
                conn5.Close();
                conn5.Open();
                SqlCommand com5 = new SqlCommand(Altercol, conn5);
                com5.ExecuteNonQuery();
                return 1;
            }
            catch (Exception bx)
            {
                string a = bx.ToString();
                return 0;
            }
        }

        public static int CreatePrimaryKey(string dbname, string tbname, string colname)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string Altertab = "alter table " + tbname + " add PRIMARY KEY(" + colname + ");";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(Altertab, conn4);
                com4.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                return 0;
            }
        }
        public static int CreateForeignKey(string dbname, string tbname, string colname,string reftb,string refcol)
        {
            //string dbname = "SHABS-PC\SQLEXPRESS";
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string Altertab = "alter table " + tbname + " add FOREIGN KEY(" + colname + ") REFERENCES "+reftb+"("+refcol+");";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(Altertab, conn4);
                com4.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                return 0;
            }
        }


        public static int deletetb(string dbname,string tbname)
        {
            try
            {
                string con6 = "Data source = SHABS-PC\\SQLEXPRESS; database = "+dbname+"; Integrated Security = true;";
                SqlConnection conn6 = new SqlConnection(con6);
                string deletetb = "drop table " + tbname + ";";
                conn6.Close();
                conn6.Open();
                SqlCommand com6 = new SqlCommand(deletetb, conn6);
                com6.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                return 0;
            }
        }

        public static int truncatetb(string dbname, string tbname)
        {
            try
            {
                string con7 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn7 = new SqlConnection(con7);
                string truncatetb = "truncate table " + tbname + ";";
                conn7.Close();
                conn7.Open();
                SqlCommand com7 = new SqlCommand(truncatetb, conn7);
                com7.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ea)
            {
                string a = ea.ToString();
                return 0;
            }
        }

        public static int deletedb(string dbname)
        {
            try
            {
                string con3= "Data source = SHABS-PC\\SQLEXPRESS; Integrated Security = true;";
                SqlConnection conn3 = new SqlConnection(con3);
                string deletedb = "drop database "+dbname+";";
                conn3.Close();
                conn3.Open();
                SqlCommand com3 = new SqlCommand(deletedb, conn3);
                com3.ExecuteNonQuery();
                return 1;
            }
            catch (Exception e)
            {
                string a = e.ToString();
                return 0;
            }
        }
        public static int showtable(string dbname , string tbname)
        {
            try
            {
                string con4 = "Data source = SHABS-PC\\SQLEXPRESS; database = " + dbname + "; Integrated Security = true;";
                SqlConnection conn4 = new SqlConnection(con4);
                string showtb = "select * from "+tbname+";";
                conn4.Close();
                conn4.Open();
                SqlCommand com4 = new SqlCommand(showtb, conn4);
                com4.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = com4;
                DataTable dbtable = new DataTable();
                sda.Fill(dbtable);
                sda.Update(dbtable);
                return 1;
            }
            catch (Exception ax)
            {
                string a = ax.ToString();
                //return 0;
                //MessageBox.Show(ax.Message);
                return 0;
            }
        }
    }
}