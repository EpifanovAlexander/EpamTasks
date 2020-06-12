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
                name = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public string Pass
        {
            get => pass;
            set
            {
               pass = value ?? throw new ArgumentNullException(nameof(value));
            }
        }

        public Administrator(string _name, string password)
        {
            Name = _name;
            Pass = password;
        }
    }
}
