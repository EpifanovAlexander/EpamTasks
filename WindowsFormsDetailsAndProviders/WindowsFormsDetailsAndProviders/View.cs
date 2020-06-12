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
using WindowsFormsDetailsAndProviders.Classes;

namespace WindowsFormsDetailsAndProviders
{
    public partial class View : Form
    {
        TableService tableService = new TableService();

        public View()
        {
            InitializeComponent();
            dataGridViewAll.AutoGenerateColumns = true;
            dataGridViewAll.DataSource = tableService.GetTable("Select Dname AS Деталь,Dprice AS Цена From Details");
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
            dataGridViewAll.DataSource = tableService.GetTable(command);
        }      
    }
}
