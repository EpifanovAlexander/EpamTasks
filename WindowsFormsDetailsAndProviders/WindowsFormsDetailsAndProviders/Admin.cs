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
        TableService tableService = new TableService();


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
            if (tableService.UpdateTable(tabControlAll.SelectedIndex, dataTable))
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
                        dataTable = tableService.GetTable("Select * From Details");
                        dataTable.Columns["Dnum"].ReadOnly = true;
                        break;
                    }
                case 1:
                    {
                        dataTable = tableService.GetTable("Select * From Providers");
                        dataTable.Columns["pnum"].ReadOnly = true;
                        break;
                    }
                case 2:
                    {
                        dataTable = tableService.GetTable("Select * FROM Delivery");
                        dataTable.Columns["Dnum"].ReadOnly = false;
                        dataTable.Columns["pnum"].ReadOnly = false;
                        break;
                    }
            }
            dataGridViewAll.DataSource = dataTable;
        }
    }
}
