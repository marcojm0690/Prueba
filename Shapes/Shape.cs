using System;
namespace Prueba.Shapes
{
    /// <summary>
    /// Summary description for Class1
    /// 
    /// I use an abstract class because a Shape is an abstract concept that I can use to define objects like
    /// circle, square, etc. and all are part of the same hierarchy
    /// </summary>
    public abstract class Shape
    {

        public Shape(int id, double xPos, double yPos)
        {
            Id = id;
            xPosition = xPos;
            yPosition = yPos;
        }
        public int Id { get; set; }
        public double xPosition { get; set; }
        public double yPosition { get; set; }
        public abstract double Area { get; }
        public override string ToString()
        {
            return String.Format("shape {0}: {1} with centre at ({2}, {3}) and Area {4}", this.Id, this.GetType().Name, this.xPosition, this.yPosition, Area);
        }
        public static double GetArea(Shape shape)
        {
            return shape.Area;
        }
        public abstract bool IsInShape(double xCoordinate, double yCoordinate);
    }
}