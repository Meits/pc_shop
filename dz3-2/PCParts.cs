using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3_2
{
    class PCParts
    {
        public string Name { get; set; }
        public string Characteristic { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }

        public PCParts()
        {
            this.Name = "";
            this.Characteristic = "";
            this.Description = "";
            this.Price = "";
        }

        public PCParts(string name, string characteristic, string description, string price)
        {
            this.Name = name;
            this.Characteristic = characteristic;
            this.Description = description;
            this.Price = price;
        }
    }
}
