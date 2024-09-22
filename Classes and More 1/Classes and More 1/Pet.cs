using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_More_1
{
    internal class Pet
    {
        //Field Of Petname (Blackfield Name)
        private string _Name;

        public Pet()
        {
            _Name = "";
        }

        //Name Property 
        public string magac
        {
            get
                { 
                return _Name;
            }
            set {
                _Name = value;
            }
        }
    }
}
