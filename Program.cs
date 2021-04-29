using System;

namespace LineProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2;

            Console.WriteLine("Enter co-ordinates of First Line ");
            Console.WriteLine("Enter the value of x1:");      //enter the input x1
            x1 = Convert.ToDouble(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");      //Enter the value y1
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            double Length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula

            Console.WriteLine("Enter co-ordinates of Second Line ");
            Console.WriteLine("Enter the value of x1:");      //enter the input x1
            x1 = Convert.ToDouble(Console.ReadLine());         //Convert into Int with the help of convert.ToInt32() 
            Console.WriteLine("Enter the value of x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y1:");      //Enter the value y1
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the value of y2:");
            y2 = Convert.ToDouble(Console.ReadLine());

            double Length2 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)); //apply formula
            int compare = Length1.CompareTo(Length2); //use compareto method
            Boolean equal = Length1.Equals(Length2);


            if (Length1.CompareTo(Length2) == 0)
            {
                // Console.WriteLine("By Comparing the Both Lines are Same");

                if (Length1.Equals(Length2) == true)
                {
                    Console.WriteLine("By Comparing the Both Lines are Same");

                    Console.WriteLine("True");
                }
                

            }
            else
            {
                Console.WriteLine("Lines are not equal");
            }

            Console.WriteLine("The Length of Line1 is  " + Length1);  //finaly print output
            Console.WriteLine("The Length of Line2 is  " + Length2);  //finaly print output
            Console.Read();

        }
    }
}



