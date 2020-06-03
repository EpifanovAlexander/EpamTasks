using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDetailsAndProviders
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            dataGridViewAll.AutoGenerateColumns = true;
            dataGridViewAll.DataSource = GetTable("Select Dname AS Деталь,Dprice AS Цена From Details");
        }

        private void View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = (Main)Application.OpenForms["Main"];
            main.Show();
        }

        private void tabControlAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "";
            switch (tabControlAll.SelectedIndex)
            {
                case 0:
                    {
                        command = "Select Dname AS Деталь,Dprice AS Цена From Details";
                        break;
                    }
                case 1:
                    {
                        command = "Select pname AS Фамилия From Providers";
                        break;
                    }
                case 2:
                    {
                        command = "Select pname AS Фамилия,Dname AS Деталь,volume AS Объём,date AS [Время сдачи]" +
                                  " FROM Delivery Join Providers ON Delivery.pnum = Providers.pnum" +
                                  " Join Details ON Delivery.dnum = Details.Dnum";
                        break;
                    }
            }
            dataGridViewAll.DataSource = GetTable(command);
        }

        private static DataTable GetTable(string sqlCommand)
        {
            string connectionString = "Integrated Security=SSPI;Persist Security Info=False;" +
                "Initial Catalog=ProvidersAndDetails;Data Source=localhost";

            SqlCommand command = new SqlCommand(sqlCommand, new SqlConnection(connectionString));
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }        
    }
}
