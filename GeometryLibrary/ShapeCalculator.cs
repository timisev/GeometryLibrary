namespace GeometryLibrary
{
    public class ShapeCalculator
    {
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        public static double CalculateTriangleArea(double side1, double side2, double side3)
        {
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public static bool IsRightTriangle(double side1, double side2, double side3)
        {
            double[] sides = { side1, side2, side3 };
            Array.Sort(sides);

            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}