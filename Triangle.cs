using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4OOP
{
    internal class Triangle
    {
        // One double property for each side of a triangle
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        // Default constructor that assigns all sides of the triangles with their own values
        public Triangle(double sideA, double sideB, double sideC)
        {

        }

        // Constructor overload for same sided triangles
        public Triangle(double side)
        {
            SideA = side;
            SideB = side;
            SideC = side;
        }

        // Overload for when user only knows two sides
        public Triangle(double sideA, double sideB)
        {
            SideA = sideA; 
            SideB = sideB;
        }
        
        public double Area()
        {
            // Using Heron's formula
            double quotient = 1.0 / 2.0;
            double s = quotient * (this.SideA + this.SideB + this.SideC);

            return Math.Sqrt((s * (s - this.SideA) * (s - this.SideB) * (s - this.SideC)));

        }

        public bool RightTriangle {  get; set; }

        public double Hypotenuse()
        {

            // per default, bool as a field will always be assigned false, therefore
            // you have to tell user to change it if they wish to use this method
            if (this.RightTriangle == false)
            {
                Console.WriteLine("Looks like your triangle is not a right-angled one.");
                Console.WriteLine("Is this not correct? Change the RightTriangle property to \"true\" and try again.");

                // 0 is the default value of a double field, which is why
                // we cannot return null as an answer to the hypotenuse not existing.
                return 0;
            }
            else
            {
                // Since we now know that the triangle is right-angled, we can
                // use the Pythagorean theorem and return the result
                this.SideC = (Math.Sqrt(Math.Pow(this.SideA, 2) + Math.Pow(this.SideB, 2)));
                return this.SideC;
            }
            
            

                
        }
            
            

    }
}

