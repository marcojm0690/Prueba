using System;
namespace Prueba.Shapes
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Circle : Shape
    {
        public Circle(int id, double xPos, double yPos, double radius)
        {
            Id = id;
            Radius = radius;
            xPosition = xPos;
            yPosition = yPos;
        }
        public override double Area => Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

        public double Diameter => Radius * 2;
        public double Radius { get; }

        public override bool IsInShape(double xCoordinate, double yCoordinate)
        {

            double distance;
            distance = Math.Sqrt((xPosition - xCoordinate) * (xPosition - xCoordinate) + (yPosition - yCoordinate) * (yPosition - yCoordinate));
            return distance < Radius;
        }
    }
}

