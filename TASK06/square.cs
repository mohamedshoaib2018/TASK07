using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK07
{
    internal class Square : shapes
    {
        public double Width { get; set; }

        public Square(double width, string name, int id) 
        {
            Width = width; 
            Name = name;
            Id = id;
        }
        public override void CalculateArea()
        {
            double Area = Width * Width;
            Console.WriteLine($"The Square Area = {Area}");
        }
    }
}
