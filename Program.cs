using System;

namespace LineProblem
{
    class Program
    {
        static void Main(string[] args)
        {
       

                Console.WriteLine("enter x1 value:");
                string input1 = Console.ReadLine();
                int x1 = Convert.ToInt32(input1);

                Console.WriteLine("enter x2 value:");
                string input2 = Console.ReadLine();
            int x2 = Convert.ToInt32(input2);

            Console.WriteLine("enter y1 value:");
                string input3 = Console.ReadLine();
            int y1 = Convert.ToInt32(input3);

            Console.WriteLine("enter y2 value:");
                string input4 = Console.ReadLine();
            int y2 = Convert.ToInt32(input4);

            Length(x1, x2, y1, y2);

        }
        private static void Length( int x1,int x2, int y1,int y2)
        {
            double Length = Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            Console.WriteLine(Length);
        }
    }
}
