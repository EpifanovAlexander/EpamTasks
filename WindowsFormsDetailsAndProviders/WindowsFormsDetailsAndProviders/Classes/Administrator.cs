using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsDetailsAndProviders.Classes
{
    public class Administrator
    {
        private string name;
        private string pass;

        public string Name
        {
            get => name;
            set
            {
                if (value != null) name = value;
            }
        }

        public string Pass
        {
            get => pass;
            set
            {
                if (value != null) pass = value;
            }
        }

        public Administrator(string _name, string password)
        {
            Name = _name;
            Pass = password;
        }
    }
}
