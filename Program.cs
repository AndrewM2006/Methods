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
                    Console.WriteLine(MyMethods.GetHypotenuse(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the hypotenuse.");
                }
                else if (menuOption == "2")
                {
                    Console.WriteLine("Enter a leg of the triangle, and then the hypotenuse...");
                    Console.WriteLine(MyMethods.GetLeg(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the other leg.");
                }
                else if (menuOption == "3")
                {
                    Console.WriteLine("Enter each Y coordinate...");
                    Console.WriteLine(MyMethods.GetRise(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the  rise.");
                }
                else if (menuOption == "4")
                {
                    Console.WriteLine("Enter each X coordinate...");
                    Console.WriteLine(MyMethods.GetRun(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the run.");
                }
                else if (menuOption == "5")
                {
                    Console.WriteLine("Enter the X and then Y coordinate of the first and then the second point (4 individual lines)...");
                    Console.WriteLine(MyMethods.GetDistance(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the distance.");
                }
                else if (menuOption == "6")
                {
                    Console.WriteLine("Enter the X and then Y coordinate of the first and then the second point (4 individual lines)...");
                    Console.WriteLine(MyMethods.GetSlope(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the slope.");
                }
                else if (menuOption == "7")
                {
                    Console.WriteLine("Enter the slope of the line, then the X and then the Y coordinate on the line...");
                    Console.WriteLine(MyMethods.GetYIntercept(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) + " is the y intercept.");
                }
                else if (menuOption == "8")
                {
                    Console.WriteLine("Enter the length of each side of the traingle, from smallest to largest...");
                    if (MyMethods.IsRight(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())) == true)
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
                    
                }
                else if (menuOption == "12")
                {
                    
                }
                else if (menuOption == "13")
                {
                    
                }
                else if (menuOption == "14")
                {

                }
                else if (menuOption == "15")
                {

                }
                else if (menuOption == "16")
                {

                }
                else if (menuOption == "17")
                {

                }
                else if (menuOption == "18")
                {

                }
                else if (menuOption == "19")
                {

                }
                else if (menuOption == "20")
                {

                }
                else if (menuOption == "21")
                {

                }
                else if (menuOption == "22")
                {

                }
                else if (menuOption == "23")
                {

                }
                else if (menuOption == "24")
                {

                }
                else if (menuOption == "25")
                {

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
