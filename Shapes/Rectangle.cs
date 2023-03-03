
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
    public class Rectangle : Shape
    {
        public double Height { get; }
        public double Width { get; }
        public override double Area => Height * Width;
        public Rectangle(int id, double xPos, double yPos, double length, double width) : base(id, xPos, yPos)
        {
            Height = length;
            Width = width;
        }


        public override bool IsInShape(double xCoordinate, double yCoordinate)
        {
            bool inShape = false;
            if ((xPosition == xCoordinate) && (yPosition == yCoordinate))
                inShape = true;

            if ((yPosition == (yPosition + Height)) && (yCoordinate == (yPosition + Height)))
            {
                if (((xPosition + Width) <= xCoordinate) && (xCoordinate <= xPosition))
                    inShape = true;

                if ((xPosition <= xCoordinate) && (xCoordinate <= (xPosition + Width)))
                    inShape = true;
            }

            if ((yPosition < yCoordinate) && ((yPosition + Height) >= yCoordinate) || ((yPosition + Height) < yCoordinate) && (yPosition >= yCoordinate))
            {
                if (xPosition + (yCoordinate - yPosition) / ((yPosition + Height) - yPosition) * ((xPosition + Width) - xPosition) <= xCoordinate)
                    inShape = true;
            }
            return inShape;
        }

    }
}
