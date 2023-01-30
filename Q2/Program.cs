namespace q2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOddNumbers();
            AverageMinMax();
        }

        static void CountOddNumbers()
        {
            Console.WriteLine("Enter 5 integers:");
            int oddCount = 0;
            for (int i = 0; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 != 0)
                {
                    oddCount++;
                }
            }
            Console.WriteLine("Number of odd integers: " + oddCount);
        }


        static void AverageMinMax()
        {
            int num, sum = 0, smallest = int.MaxValue, largest = int.MinValue;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter an integer: ");
                num = int.Parse(Console.ReadLine());
                sum += num;

                if (num < smallest)
                {
                    smallest = num;
                }

                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine("Average: " + (double)sum / 5);
            Console.WriteLine("Smallest: " + smallest);
            Console.WriteLine("Largest: " + largest);
            Console.ReadLine();

        }






    }



}
