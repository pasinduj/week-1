using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape, IShape
    {
        private int radius;

        public Circle(int r)
        {

            if (r > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }


            radius = r;
        }

        public override double GetArea()
        {
            return (Math.PI * radius * radius);
        }

    }

}
