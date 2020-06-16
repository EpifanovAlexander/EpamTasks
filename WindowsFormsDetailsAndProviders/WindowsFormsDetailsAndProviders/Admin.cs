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
    public partial class Admin : Form
    {
        private Administrator CurrentAdmin;
        private DataTable dataTable;

        DetailsTableService DetailsTS = new DetailsTableService();
        ProvidersTableService ProvidersTS = new ProvidersTableService();
        DeliveryTableService DeliveryTS = new DeliveryTableService();


        public Admin(Administrator admin)
        {
            InitializeComponent();

            CurrentAdmin = admin;
            grBHello.Text = $"Добро пожаловать, {admin.Name}!";

            ShowTable();
        }


        // Обработчики кнопок
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = dataTable.NewRow();
            dataTable.Rows.Add(row);
            dataGridViewAll.DataSource = dataTable;
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAll.SelectedRows)
            {
                dataGridViewAll.Rows.Remove(row);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (tabControlAll.SelectedIndex)
            {
                case 0:
                    {
                        Check(DetailsTS.Update(dataTable));
                        break;
                    }
                case 1:
                    {
                        Check(ProvidersTS.Update(dataTable));
                        break;
                    }
                case 2:
                    {
                        Check(DeliveryTS.Update(dataTable));
                        break;
                    }
            }
        }


        public void Check(bool condition)
        {
            if (condition)
            {
                MessageBox.Show("База данных обновлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("База данных не была обновлена!" + Environment.NewLine + "Проверьте правильность введённых значений",
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Общее
        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = (Main)Application.OpenForms["Main"];
            main.Show();
        }

        private void tabControlAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowTable();
        }

        private void ShowTable()
        {
            switch (tabControlAll.SelectedIndex)
            {
                case 0:
                    {
                        dataTable = DetailsTS.GetTable();
                        dataTable.Columns["Dnum"].ReadOnly = true;
                        break;
                    }
                case 1:
                    {
                        dataTable = ProvidersTS.GetTable();
                        dataTable.Columns["pnum"].ReadOnly = true;
                        break;
                    }
                case 2:
                    {
                        dataTable = DeliveryTS.GetTable();
                        dataTable.Columns["Dnum"].ReadOnly = false;
                        dataTable.Columns["pnum"].ReadOnly = false;
                        break;
                    }
            }
            dataGridViewAll.DataSource = dataTable;
        }
    }
}
