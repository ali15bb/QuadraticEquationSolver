namespace TriangleLib
{
    public class TriangleChecker
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }
    }
}
