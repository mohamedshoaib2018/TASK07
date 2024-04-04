using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK07
{
    internal class Circle : shapes
    {
        
        double pi = 22 / 7;
        public double Diameter { get;set; }
        
        public Circle(double diameter,string name, int id)
        {
            Diameter = diameter;
            Name = name;
            Id = id;
        }
        
        public override void CalculateArea()
        {
            double Area = (Diameter/2)*pi;
            Console.WriteLine($"The Circle Area = {Area}");
        }

        
    }
}
