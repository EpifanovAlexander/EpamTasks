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
        private DataSet data;
        private SqlDataAdapter adapter;
        private SqlCommandBuilder commandBuilder;
        private string connectionString = "Integrated Security=SSPI;Persist Security Info=False;" +
                "Initial Catalog=ProvidersAndDetails;Data Source=localhost";
        private string command = "Select * From Details";

        public Admin(Administrator admin)
        {
            InitializeComponent();

            this.CurrentAdmin = admin;

            GetTable(command);
            grBHello.Text = $"Добро пожаловать, {admin.Name}!";
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main main = (Main)Application.OpenForms["Main"];
            main.Show();
        }

        private void tabControlAll_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlAll.SelectedIndex)
            {
                case 0:
                    {
                        command = "Select * From Details";
                        break;
                    }
                case 1:
                    {
                        command = "Select * From Providers";
                        break;
                    }
                case 2:
                    {
                        command = "Select * FROM Delivery";
                        break;
                    }
            }
            GetTable(command);
        }

        private void GetTable(string sqlCommand)
        {
            SqlCommand Sql = new SqlCommand(sqlCommand, new SqlConnection(connectionString));

            adapter = new SqlDataAdapter(Sql);
            data = new DataSet();

            adapter.Fill(data);
            dataGridViewAll.DataSource = data.Tables[0];

            switch (tabControlAll.SelectedIndex)
            {
                case 0:
                    {
                        dataGridViewAll.Columns["Dnum"].ReadOnly = true;
                        break;
                    }
                case 1:
                    {
                        dataGridViewAll.Columns["pnum"].ReadOnly = true;
                        break;
                    }
                case 2:
                    {
                        dataGridViewAll.Columns["Dnum"].ReadOnly = false;
                        dataGridViewAll.Columns["pnum"].ReadOnly = false;
                        break;
                    }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewAll.SelectedRows)
            {
                dataGridViewAll.Rows.Remove(row);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow row = data.Tables[0].NewRow();
            data.Tables[0].Rows.Add(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    adapter = new SqlDataAdapter(command, connection);
                    commandBuilder = new SqlCommandBuilder(adapter);

                    switch (tabControlAll.SelectedIndex)
                    {
                        case 0:
                            {
                                adapter.InsertCommand = new SqlCommand("sp_CreateDetail", connection);
                                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@dname", SqlDbType.NChar, 50, "Dname"));
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@dprice", SqlDbType.Int, 10, "Dprice"));
                                break;
                            }
                        case 1:
                            {
                                adapter.InsertCommand = new SqlCommand("sp_CreateProvider", connection);
                                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NChar, 50, "pname"));
                                break;
                            }
                        case 2:
                            {
                                adapter.InsertCommand = new SqlCommand("sp_CreateNewDelivery", connection);
                                adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Pnum", SqlDbType.Int, 10, "pnum"));
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Dnum", SqlDbType.Int, 10, "dnum"));
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Volume", SqlDbType.Int, 10, "volume"));
                                adapter.InsertCommand.Parameters.Add(new SqlParameter("@Date", SqlDbType.DateTime, 100, "date"));
                                break;
                            }
                    }
                    adapter.Update(data);
                    MessageBox.Show("База данных обновлена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("База данных не была обновлена!"+Environment.NewLine+"Проверьте правильность введённых значений", 
                                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
