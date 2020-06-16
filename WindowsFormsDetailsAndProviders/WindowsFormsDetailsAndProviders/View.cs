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
        DetailsTableService DetailsTS = new DetailsTableService();
        ProvidersTableService ProvidersTS = new ProvidersTableService();
        DeliveryTableService DeliveryTS = new DeliveryTableService();

        public View()
        {
            InitializeComponent();
            dataGridViewAll.AutoGenerateColumns = true;
            dataGridViewAll.DataSource = DetailsTS.EasyTable();
        }

        private void View_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = (Main)Application.OpenForms["Main"];
            main.Show();
        }

        private void tabControlAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlAll.SelectedIndex)
            {
                case 0: dataGridViewAll.DataSource = DetailsTS.EasyTable();
                        break;
                case 1: dataGridViewAll.DataSource = ProvidersTS.EasyTable();
                        break;
                case 2: dataGridViewAll.DataSource = DeliveryTS.EasyTable();
                        break;
            }
        }      
    }
}
