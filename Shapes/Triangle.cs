using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Shapes
{
    public class Triangle : Shape
    {

        public double Side { get; }
        public double Perimeter => FirstSide + SecondSide + ThirdSide;
        public override double Area => Math.Sqrt((Perimeter / 2) * ((Perimeter / 2) - FirstSide) * ((Perimeter / 2) - SecondSide) * ((Perimeter / 2) - ThirdSide));

        public double FirstSide;
        public double SecondSide;
        public double ThirdSide;
        public Triangle(int id, double xPos, double yPos, double firstSide, double secondSide, double thirdSide)
        {
            Id = id;
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            xPosition = xPos;
            yPosition = yPos;
        }

        public override bool IsInShape(double xCoordinate, double yCoordinate)
        {
            return false;
        }
    }
}
