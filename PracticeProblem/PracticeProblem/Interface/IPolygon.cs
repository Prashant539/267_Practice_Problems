using PracticeProblem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem.Interface
{
    public interface IPolygon
    {
        void CalculateArea();

    }

    class Square : IPolygon
    {
        public void CalculateArea()
        {
            int l = 20;
            int area = l * l;
            Console.WriteLine("Area of Square: " + area);
        }
    }
   
}





