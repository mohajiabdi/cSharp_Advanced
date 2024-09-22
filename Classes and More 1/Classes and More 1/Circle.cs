using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_More_1
{
    internal class Circle
    {
        private double _diameter;

        public Circle()
        {
            _diameter = 0.0;
        }

        //Diameter Property
        public double Diameter
        {
            get
            {
                return _diameter;
            }
            set
            {
                _diameter = value;
            }
        }

            //Radius Property (Read Only..)

            public double Radius
        {
            get
            {
                return _diameter /2;
            }
        }
        }
    }

