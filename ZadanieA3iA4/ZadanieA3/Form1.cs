using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieA3
{
    public partial class Form1 : Form
    {
        //arrange connection with database
        private readonly Func<SqlConnection> dbConnectionNorthwind = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString);
        
        /// <summary>
        /// constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event Method of Button A3 Pracownicy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonA3_Click(object sender, EventArgs e)
        {
            //using connection with DataBase
            using (var connection = dbConnectionNorthwind())
            {
                connection.Open();//open connection

                //using SQL command
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Employees  Where Employees.FirstName Like 'M%'", connection))
                {
                    //Fill Data Grid Viev with data from DataBase
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    DataGridViewA3.DataSource = table;


                }

                connection.Close();//close connection
            }
        }

        /// <summary>
        /// Event Method of Button A5 pracownicy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonA5_Click(object sender, EventArgs e)
        {
            DataGridViewA3.Controls.Clear();

            //using connection with DataBase
            using (var connection = dbConnectionNorthwind())
            {
                connection.Open();//open connection

                //using SQL command
                using (SqlDataAdapter adapter = new SqlDataAdapter("Select * From  Products  Where Products.UnitPrice < 22.0 AND Products.UnitPrice > 8.0 ORDER BY Products.UnitPrice DESC", connection))
                {
                    //Fill Data Grid Viev with data from DataBase
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    DataGridViewA3.DataSource = table;


                }

                connection.Close();//close connection
            }
        }
    }
}
