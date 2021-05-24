using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management_System__BFM1_
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public bool Inhouse { get; set; }
        public int MachineID { get; set; }
        public bool Outsourced { get; set; }
        public string CompanyName
        {
            get
            {
                if (Outsourced)
                    return CompanyName;
                else
                    return "inhouse product";
            }

            set
            {
                CompanyName = value;
            }
        }


    }
}
