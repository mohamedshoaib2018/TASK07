using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TASK07
{
    abstract internal class shapes
    {
        string name;
        int id;
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
        public enum Opacity { Solid,SemiSolid,Transparent}
        public enum Color { Red,Green,Yellow,Blue,Orange}    
        abstract public void CalculateArea();
        public virtual void ShowShapeData(){ Console.WriteLine($"Shape Name is {Name}\nShape Id is {Id}"); }
        

        
       
    }
}
