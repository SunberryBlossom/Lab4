namespace Lab4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates one instance with a circle that
            // has a radius of 5 units, and one with
            // a radius of 6 units
            Circle smallCircle = new Circle(5);
            Circle bigCircle = new Circle(6);

            smallCircle.AreaCalculator();
            bigCircle.AreaCalculator();

            //------------- EXTRA CHALLENGES -----------//

            // One can see with breakpoints that the methods work :)
            smallCircle.Circum();
            smallCircle.SphereVolume();


            Triangle myTriangle = new Triangle(10);
            myTriangle.Area();

            myTriangle.RightTriangle = true;
            Console.WriteLine(myTriangle.Hypotenuse());
        }
    }
}
