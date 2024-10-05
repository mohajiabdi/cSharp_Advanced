using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cellphone_Inventory
{
    internal class Phone
    {
        //Fields Backing Field
        private string _brand;
        private string _model;
        private decimal _price;

        //Default Constructor 
        public Phone() {   }

        // auto Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }

   
}
