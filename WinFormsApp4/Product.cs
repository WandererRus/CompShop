using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public  class Product
    {
        public string Name { get; set; }
        public string Characters { get; set; }
        public string Desc { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return Name + " " + Characters + " " + Desc;
        }
    }
}
