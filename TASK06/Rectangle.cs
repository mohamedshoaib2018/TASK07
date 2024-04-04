using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TASK07
{
    internal class Rectangle : shapes
    {
        public double Width {  get; set; }
        public double Height { get; set; }

        public Rectangle(double width,double height,string name, int id) 
        {
            Width = width;
            Height = height; 
            Name = name;
            Id = id;
        }
        public override void CalculateArea()
        {
            double Area = Width * Height;
            Console.WriteLine($"The Rectangle Area = {Area}");
        }
    }
}
