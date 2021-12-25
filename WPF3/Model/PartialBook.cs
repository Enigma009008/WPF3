using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF3.Model
{
    public partial class Book
    {
        public string GetPhoto
        {
            get
            {
                return $"{Environment.CurrentDirectory}\\images\\{Photo}";
            }
            set
            {
                Photo = value;
            }
        }
    }
}


