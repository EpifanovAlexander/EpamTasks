using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDetailsAndProviders.Classes;

namespace WindowsFormsDetailsAndProviders
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ViewTransparent();
        }

        private void picBoxEnter_Click(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();
            Administrator admin = new Administrator(txtBLogin.Text, masktxtBPass.Text);
            if (adminService.IsCorrect(admin))
            {
                Admin adminForm = new Admin(admin);
                adminForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Администраторов с таким логином и паролем нет в системе!" +
                                  Environment.NewLine + "Проверьте правильность введённых значений!", "Ошибка!",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picBoxView_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            Hide();
        }

        private void picBoxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLblForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Память у вас, как у рыбоньки!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            masktxtBPass.Text = "";
            txtBLogin.Text = "";
        }

        private void chBView_CheckedChanged(object sender, EventArgs e)
        {
            masktxtBPass.UseSystemPasswordChar = (chBView.Checked) ? false : true;
        }

        private void ViewTransparent()
        {
            picBoxEnter.Parent = picBoxBackground;
            picBoxView.Parent = picBoxBackground;
            picBoxExit.Parent = picBoxBackground;
            picBoxEnter.BackColor = Color.Transparent;
            picBoxView.BackColor = Color.Transparent;
            picBoxExit.BackColor = Color.Transparent;
        }

        private void picBoxEnter_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxEnter.Image = System.Drawing.Image.FromFile(@"..\..\images\EnterMouseMove.png");
            grBAutorization.Visible = true;
        }

        private void picBoxEnter_MouseLeave(object sender, EventArgs e)
        {
            picBoxEnter.Image = System.Drawing.Image.FromFile(@"..\..\images\EnterMouseLeave.png");
        }

        private void picBoxView_MouseLeave(object sender, EventArgs e)
        {
            picBoxView.Image = System.Drawing.Image.FromFile(@"..\..\images\ViewMouseLeave.png");
        }

        private void picBoxView_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxView.Image = System.Drawing.Image.FromFile(@"..\..\images\ViewMouseMove.png");
            grBAutorization.Visible = false;
        }

        private void picBoxExit_MouseLeave(object sender, EventArgs e)
        {
            picBoxExit.Image = System.Drawing.Image.FromFile(@"..\..\images\ExitMouseLeave.png");
        }

        private void picBoxExit_MouseMove(object sender, MouseEventArgs e)
        {
            picBoxExit.Image = System.Drawing.Image.FromFile(@"..\..\images\ExitMouseMove.png");
            grBAutorization.Visible = false;
        }
    }
}
