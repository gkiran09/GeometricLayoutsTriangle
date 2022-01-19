using GeometricLayoutTriangle.Controllers;
using GeometricLayoutTriangle.Domain;

namespace GeometricLayoutTriangle.BusinessLogic.Interfaces
{
    public interface ITriangleCalculator
    {
        Triangle CalculateTriangle(string row, int column);
        string GetRowColumn(Point p1, Point p2, Point p3);
    }
}