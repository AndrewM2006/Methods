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
        ///<summary>
        ///This method returns the length of the hypotenuse of a right triangle when two legs are provided.
        ///</summary>
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="b"> A double value representing the length of the second leg of a right triangle.</param>
        ///<returns>A double value representing the length of the hypotenuse of a right triangle.</returns>
        public static double GetHypotenuse(double a, double b)
        {
            return Math.Sqrt(a*a + b*b);
        }
        ///<summary>
        ///This method returns the length of the remaining leg of a right triangle when the hypotenuse and a leg are provided.
        ///</summary>
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="c"> A double value representing the length of the hypotenuse of a right triangle.</param>
        ///<returns>A double value representing the length of the remaining leg of a right triangle.</returns>
        public static double GetLeg(double a, double c)
        {
            return Math.Sqrt(c * c - a * a);
        }
        ///<summary>
        ///This method returns the rise (y2-y1) a of two y values provided.
        ///</summary>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two y-values provided.</returns>
        public static double GetRise(double y1, double y2)
        {
            return y2 - y1;
        }
        ///<summary>
        ///This method returns the rise (y2-y1) of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first coordinate.</param>
        ///<param name="p2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the rise (y2-y1) of two coordinates provided.</returns>
        public static double GetRise(Point p1, Point p2)
        {
            return GetRise(p1.Y, p2.Y);
        }
        ///<summary>
        ///This method returns the run (x2-x1) of two x values provided.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the rise (x2-x1) of two x-values provided.</returns>
        public static double GetRun(double x1, double x2)
        {
            return x2 - x1;
        }
        ///<summary>
        ///This method returns the run (x2-x1) of two coordinates provided.
        ///</summary>
        ///<param name="p1"> A Point value representing the first coordinate.</param>
        ///<param name="p2"> A Point value representing the second coordinate.</param>
        ///<returns>A double value representing the run (x2-x1) of two coordinates provided.</returns>
        public static double GetRun(Point p1, Point p2)
        {
            return GetRun(p1.X, p2.X);
        }
        ///<summary>
        ///This method returns the distance between 2 coordinates.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the distance between two coordinates provided.</returns>
        public static double GetDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(GetRun(x2, x1) * GetRun(x2, x1) + GetRise(y2, y1) * GetRise(y2, y1));
        }
        ///<summary>
        ///This method returns the distance between 2 coordinates.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the distance between two coordinates provided.</returns>
        public static double GetDistance(Point p1, Point p2)
        {
            return GetDistance(p1.X, p1.Y, p2.X, p2.Y);
        }
        ///<summary>
        ///This method returns the slope of a line passing through two coordinates.
        ///</summary>
        ///<param name="x1"> A double value representing the x-coordinate of the first coordinate.</param>
        ///<param name="y1"> A double value representing the y-coordinate of the first coordinate.</param>
        ///<param name="x2"> A double value representing the x-coordinate of the second coordinate.</param>
        ///<param name="y2"> A double value representing the y-coordinate of the second coordinate.</param>
        ///<returns>A double value representing the slope of a line containing the two coordinates provided.</returns>
        public static double GetSlope(double x1, double y1, double x2, double y2)
        {
            return GetRise(y1, y2) / GetRun(x1, x2);
        }
        ///<summary>
        ///This method returns the slope of a line passing through two coordinates.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the slope of a line containing the two coordinates provided.</returns>
        public static double GetSlope(Point p1, Point p2)
        {
            return GetSlope(p1.X, p1.Y, p2.X, p2.Y);
        }
        ///<summary>
        ///This method returns the y-intercept of a line passing through a point.
        ///</summary>
        ///<param name="slope"> A double value representing the slope of the line.</param>
        ///<param name="x"> A double value representing the x-coordinate of the point on the line.</param>
        ///<param name="y"> A double value representing the y-coordinate of the point on the line.</param>
        ///<returns>A double value representing the y-intercept of the line.</returns>
        public static double GetYIntercept (double slope, double x , double y)
        {
            return y - slope * x;
        }
        ///<summary>
        ///This method returns the y-intercept of a line passing through a point.
        ///</summary>
        ///<param name="p1"> A Point representing the first coordinate.</param>
        ///<param name="p2"> A Point representing the second coordinate.</param>
        ///<returns>A double value representing the y-intercept of the line.</returns>
        public static double GetYIntercept(Point p1, Point p2)
        {
            return GetYIntercept(GetSlope(p1, p2), p1.X, p1.Y);
        }
        ///<summary>
        ///This method returns the y-intercept of a line passing through a point.
        ///</summary>
        ///<param name="slope"> A double value representing the slope of the line.</param>
        ///<param name="p"> A Point representing the point on the line.</param>
        ///<returns>A double value representing the y-intercept of the line.</returns>
        public static double GetYIntercept(double slope, Point p)
        {
            return GetYIntercept(slope, p.X, p.Y);
        }
        ///<summary>
        ///This method returns if a triangle is right angled.
        ///</summary>
        ///<param name="a"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="b"> A double value representing the length of one leg of a right triangle.</param>
        ///<param name="c"> A double value representing the length of one leg of a right triangle.</param>
        ///<returns>A bool value representing if the triangle is right angled.</returns>
        public static bool IsRight (double a, double b, double c)
        {
            if (a*a+b*b==c*c) return true;
            else return false;
        }
        ///<summary>
        ///This method returns a list of random integers.
        ///</summary>
        ///<param name="min"> A double value representing the minimum value generated in the list.</param>
        ///<param name="max"> A double value representing the maximum value generated in the list.</param>
        ///<param name="count"> A double value representing the size of the list.</param>
        ///<returns>An int list of random numbers.</returns>
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
        ///<summary>
        ///This method returns an array of random integers.
        ///</summary>
        ///<param name="min"> A double value representing the minimum value generated in the array.</param>
        ///<param name="max"> A double value representing the maximum value generated in the array.</param>
        ///<param name="size"> A double value representing the size of the array.</param>
        ///<returns>An int array of random numbers.</returns>
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
        ///<summary>
        ///This method returns a string with the letters reversed.
        ///</summary>
        ///<param name="word"> A string value of the word before it is reversed.</param>
        ///<returns>A string value of the reversed string.</returns>
        public static string Reverse(string word)
        {
            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}
