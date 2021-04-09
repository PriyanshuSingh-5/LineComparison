using System;

namespace LineProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter co-ordinates of First Line");

            Console.WriteLine("Enter value of x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());
            double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Enter co-ordinate of Second Line");

            Console.WriteLine("Enter value of X1:");
            int X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of X2:");
            int X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y1:");
            int Y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of Y2:");
            int Y2 = Convert.ToInt32(Console.ReadLine());
            double Length2 = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

            if (Length1.Equals(Length2))
            {
                Console.WriteLine("Length of Line1 = Length of Line2 ");
            }

            else if (Length1 > Length2)
            {
                Console.WriteLine("Length of Line1  is Greater Than Length of Line2");
            }
            else
            {
                Console.WriteLine("Length of Line1  is Less Than Length of Line2");
            }


            Console.WriteLine("The Length of Line1 is " + Length1);
            Console.WriteLine("The Length of Line2 is " + Length2);
            Console.Read();
        }
    }
}






















