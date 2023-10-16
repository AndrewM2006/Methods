using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Methods
{
    static class MyMethods
    {
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a*a + b*b);
        }
        public static double GetLeg(double a, double c)
        {
            return Math.Sqrt(c * c - a * a);
        }
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y);
        }
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(GetRun(x2, x1) * GetRun(x2, x1) + GetRise(y2, y1) * GetRise(y2, y1));
        }
        public static double GetDistance(Point p1, Point p2)
        {
            return GetDistance(p1.X, p1.Y, p2.X, p2.Y);
        }
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return GetRise(y1, y2) / GetRun(x1, x2);
        }
        public static double GetSlope(Point p1, Point p2)
        {
            return GetSlope(p1.X, p1.Y, p2.X, p2.Y);
        }
        public static double GetYIntercept (double slope, double x , double y)
        {
            return y - slope * x;
        }
        public static double GetYIntercept(Point p1, Point p2)
        {
            return GetYIntercept(GetSlope(p1, p2), p1.X, p1.Y);
        }
        public static double GetYIntercept(double slope, Point p)
        {
            return GetYIntercept(slope, p.X, p.Y);
        }
        public static bool IsRight (double a, double b, double c)
        {
            if (a*a+b*b==c*c) return true;
            else return false;
        }
        public static List<int> GetRandomList(int min, int max, int count)
        {
            Random generator = new Random();
            List<int> randomNumbers = new List<int>();
            for (int i = 0; i <= count; i++)
            {
                randomNumbers.Add(generator.Next(min, max));
            }
            return randomNumbers;
        }
        public static int[] GetRandomArray(int min, int max, int size)
        {
            Random generator = new Random();
            int[] randomNumbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                randomNumbers[i] = generator.Next(min, max+1);
            }
            return randomNumbers;
        }
        public static string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
