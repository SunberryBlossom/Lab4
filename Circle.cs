using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4OOP
{
    internal class Circle
    {
        double _radius;
        public double Radius 
        {
            get { return  _radius; }
            set { _radius = value; }
        }

        // Constructor that requires input for Radius property
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            // Takes the radius, squares it, multiplies with Pi
            // which is the formula of the Area of a circle
            // and returns it.
            return (Math.Pow(Radius, 2)) * Math.PI;
        }

        //-------------- EXTRA CHALLENGES ------------//

        // Property for Circumference

        double _sphereCircumference;
       
        public double SphereCircumference
        {
            get { return _sphereCircumference; }
            set { _sphereCircumference = value; }
        }

        public double Circum()
        {
            // always uses the object's radius through the this keyword.
            // Returns the circumference after being calculated with the
            // correct formula
            return (2 * Math.PI * Radius);
        }

        public double SphereVolume()
        {
            // quotient is a fraction needed for the formula to calculate sphere volume
            double quotient = 4.0 / 3.0;

            // returns result of the sphere volume formula with the object's radius
            return (quotient * Math.PI * Math.Pow(Radius, 3));
        }
    }
}
