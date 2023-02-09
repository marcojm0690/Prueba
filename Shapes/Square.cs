
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Shapes
{
    /// <summary>
    /// Summary description for Class1
    /// </summary>
    public class Square : Shape
    {
        public double Side { get; }

        public override double Area => Math.Pow(Side, 2);
        public Square(int id, double xPos, double yPos, double length)
        {
            Id = id;
            Side = length;
            xPosition = xPos;
            yPosition = yPos;
        }

        public override bool IsInShape(double xCoordinate, double yCoordinate)
        {
            //double distance = Math.Sqrt((xPosition - xCoordinate) * (xPosition - xCoordinate) + (yPosition - yCoordinate) * (yPosition - yCoordinate));
            //return distance == 0;
            bool inShape = false;
            if ((xPosition == xCoordinate) && (yPosition == yCoordinate))
                inShape = true;

            if ((yPosition == (yPosition + Side)) && (yCoordinate == (yPosition + Side)))
            {
                if (((xPosition + Side) <= xCoordinate) && (xCoordinate <= xPosition))
                    inShape = true;

                if ((xPosition <= xCoordinate) && (xCoordinate <= (xPosition + Side)))
                    inShape = true;
            }

            if ((yPosition < yCoordinate) && ((yPosition + Side) >= yCoordinate) || ((yPosition + Side) < yCoordinate) && (yPosition >= yCoordinate))
            {
                if (xPosition + (yCoordinate - yPosition) / ((yPosition + Side) - yPosition) * ((xPosition + Side) - xPosition) <= xCoordinate)
                    inShape = true;
            }
            return inShape;
        }
    }
}
