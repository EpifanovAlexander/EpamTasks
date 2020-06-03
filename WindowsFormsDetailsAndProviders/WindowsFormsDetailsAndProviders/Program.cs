using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsDetailsAndProviders.Classes;

namespace WindowsFormsDetailsAndProviders
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            List<Administrator> Admins = new List<Administrator>();
            Admins.Add(new Administrator("Dmitriy", "Dima"));
            Admins.Add(new Administrator("Silvia", "123456"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(Admins));
        }
    }
}
