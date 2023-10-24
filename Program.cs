using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string menuOption;
                Console.WriteLine("1. Get Hypotenuse 2. Get Leg 3. Get Rise 4. Get Run 5. Get Distance");
                Console.WriteLine("6. Get Slope 7. Get Y-Intercept 8. Is Right? 9. Get Random List 10. Get Random Array");
                Console.WriteLine("11. Reverse Word 12. Rootchecker 13. Circumference 14. Triangle Area 15. Parallelogram Area");
                Console.WriteLine("16. Trapazoid Area 17. Circle Area 18. Rectangle Area 19. Cone Surface Area 20. Cylinder Surface Area");
                Console.WriteLine("21. Sphere Surface Area 22. Sphere Volume 23. Cylinder Volume 24. Cone Volume 25. Pyramid Volume");
                Console.WriteLine("Press Q to Quit");
                menuOption = Console.ReadLine();
                if (menuOption == "1")
                {
                    Console.WriteLine("Enter each leg of the triangle...");
                    Console.WriteLine(MyMethods.GetHypotenuse(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the hypotenuse.");
                }
                else if (menuOption == "2")
                {
                    Console.WriteLine("Enter a leg of the triangle, and then the hypotenuse...");
                    Console.WriteLine(MyMethods.GetLeg(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the other leg.");
                }
                else if (menuOption == "3")
                {
                    Console.WriteLine("Enter each Y coordinate...");
                    Console.WriteLine(MyMethods.GetRise(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the  rise.");
                }
                else if (menuOption == "4")
                {
                    Console.WriteLine("Enter each X coordinate...");
                    Console.WriteLine(MyMethods.GetRun(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the run.");
                }
                else if (menuOption == "5")
                {
                    Console.WriteLine("Enter the X and then Y coordinate of the first and then the second point (4 individual lines)...");
                    Console.WriteLine(MyMethods.GetDistance(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the distance.");
                }
                else if (menuOption == "6")
                {
                    Console.WriteLine("Enter the X and then Y coordinate of the first and then the second point (4 individual lines)...");
                    Console.WriteLine(MyMethods.GetSlope(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the slope.");
                }
                else if (menuOption == "7")
                {
                    Console.WriteLine("Enter the slope of the line, then the X and then the Y coordinate on the line...");
                    Console.WriteLine(MyMethods.GetYIntercept(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the y intercept.");
                }
                else if (menuOption == "8")
                {
                    Console.WriteLine("Enter the length of each side of the traingle, from smallest to largest...");
                    if (MyMethods.IsRight(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) == true)
                    {
                        Console.WriteLine("The triangle is right angled");
                    }
                    else
                    {
                        Console.WriteLine("The triangle is not right angled");
                    }
                }
                else if (menuOption == "9")
                {
                    Console.WriteLine("Enter the min and then the max and then the size of the list");
                    List<int> list;
                    list = MyMethods.GetRandomList(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    foreach (int i in list)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (menuOption == "10")
                {
                    Console.WriteLine("Enter the min and then the max values before then entering the size of the array");
                    int[] numbers = MyMethods.GetRandomArray(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.WriteLine(numbers[i]);
                    }
                }
                else if (menuOption == "11")
                {
                    Console.WriteLine("Enter the word to be reversed...");
                    Console.WriteLine(MyMethods.Reverse(Console.ReadLine()));
                }
                else if (menuOption == "12")
                {
                    Console.WriteLine("Enter the a value then the b then the c of the equation...");
                    Console.WriteLine(MyMethods.RootChecker(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the number of real roots.");
                }
                else if (menuOption == "13")
                {
                    Console.WriteLine("Enter the radius of the circle");
                    Console.WriteLine(MyMethods.Circumference(Convert.ToDouble(Console.ReadLine())) + " is the circumference of the circle.");
                }
                else if (menuOption == "14")
                {
                    Console.WriteLine("Enter a base length and then a height...");
                    Console.WriteLine(MyMethods.TriangleArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the area of the triangle.");
                }
                else if (menuOption == "15")
                {
                    Console.WriteLine("Enter a base length and then a height...");
                    Console.WriteLine(MyMethods.ParallelogramArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the area of the parallelogram.");
                }
                else if (menuOption == "16")
                {
                    Console.WriteLine("Enter the top base length, then the bottom base length and then a height...");
                    Console.WriteLine(MyMethods.TrapezoidArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the area of the trapezoid.");
                }
                else if (menuOption == "17")
                {
                    Console.WriteLine("Enter the radius of the circle");
                    Console.WriteLine(MyMethods.CircleArea(Convert.ToDouble(Console.ReadLine())) + " is the area of the circle.");
                }
                else if (menuOption == "18")
                {
                    Console.WriteLine("Enter a length and then a width...");
                    Console.WriteLine(MyMethods.RectangleArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the area of the rectangle.");
                }
                else if (menuOption == "19")
                {
                    Console.WriteLine("Enter a radius length and then a height...");
                    Console.WriteLine(MyMethods.ConeSurfaceArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the surface area of the cone.");
                }
                else if (menuOption == "20")
                {
                    Console.WriteLine("Enter a radius length and then a height...");
                    Console.WriteLine(MyMethods.CylinderSurfaceArea(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the surface area of the cylinder.");
                }
                else if (menuOption == "21")
                {
                    Console.WriteLine("Enter the radius of the sphere");
                    Console.WriteLine(MyMethods.SphereSurfaceArea(Convert.ToDouble(Console.ReadLine())) + " is the surface area of the sphere.");
                }
                else if (menuOption == "22")
                {
                    Console.WriteLine("Enter a radius length and then a height...");
                    Console.WriteLine(MyMethods.CylinderVolume(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the volume of the cylinder.");
                }
                else if (menuOption == "24")
                {
                    Console.WriteLine("Enter a radius length and then a height...");
                    Console.WriteLine(MyMethods.ConeVolume(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the volume of the cone.");
                }
                else if (menuOption == "22")
                {
                    Console.WriteLine("Enter the radius of the sphere");
                    Console.WriteLine(MyMethods.SphereVolume(Convert.ToDouble(Console.ReadLine())) + " is the volume of the sphere.");
                }
                else if (menuOption == "25")
                {
                    Console.WriteLine("Enter the area of the base and then the height of the pyramid");
                    Console.WriteLine(MyMethods.PyramidVolume(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())) + " is the volume of the pyramid.");
                }
                else if (menuOption == "Q" || menuOption == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
        }
    }
}
