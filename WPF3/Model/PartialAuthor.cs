using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF3.Model
{
     public partial class Author
    {
        public string GetFullName
        {
            get
            {
                return $" {FirstName} {LastName} {MiddleName}";
            }
        }
    }
}
