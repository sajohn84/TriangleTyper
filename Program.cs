using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTyper
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideAInput;
            int sideBInput;
            int sideCInput;

            Console.WriteLine("Enter the length of side A: ");
            sideAInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of side B: ");
            sideBInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of side C: ");
            sideCInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your triangle is {0} triangle.", triangleMethod(sideAInput, sideBInput, sideCInput));
            Console.ReadLine();
        }


        static string triangleMethod(int sideAInput, int sideBInput, int sideCInput)
        {
            int sideA = 3;
            int sideB = 1;
            int sideC = 3;
            string triangleType = "";

            if (sideA == sideB && sideB == sideC)
            {
                triangleType = "an Equilateral";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                triangleType = "an Isosceles";
            }
            else
            {
                triangleType = "a Scalene";
            }
            return triangleType;
        }


    }
}
