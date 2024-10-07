using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone_Inventory
{
    internal class Phone
    {
        
      

        //Default Constructor 
        public Phone() {
            Brand = "";
            Model = "";
            Price = 0m;
        }

        // auto Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

   
}
