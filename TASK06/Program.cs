using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TASK07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //shapes myshape = new shapes();
            Circle myCircle = new Circle(1.25,"Circle",100230);
            myCircle.CalculateArea();
            myCircle.ShowShapeData();
            Console.WriteLine(shapes.Opacity.Solid);
            Console.WriteLine(shapes.Color.Yellow);
            Console.WriteLine("\n\n");

            Square mySquare = new Square(3, "Square", 100365);
            mySquare.CalculateArea();
            mySquare.ShowShapeData();
            Console.WriteLine(shapes.Opacity.Transparent);
            Console.WriteLine(shapes.Color.Green);
            Console.WriteLine("\n\n");

            Rectangle myRec = new Rectangle(0.5, 8, "Rectangle", 11256);
            myRec.CalculateArea();
            myRec.ShowShapeData();
            Console.WriteLine(shapes.Opacity.SemiSolid);
            Console.WriteLine(shapes.Color.Blue);
            Console.WriteLine("\n\n");
        }
    }
}
