namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CountOddNumbers();
            Console.WriteLine();
            PrintTriangleUpsideDown();
        }

        static void CountOddNumbers()
        {
            {
                PrintTriangle(5);
                Console.ReadLine();
            }

            static void PrintTriangle(int n)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("# ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void PrintTriangleUpsideDown()
        {

            {
                PrintTriangle(5);
                Console.ReadLine();
            }

            static void PrintTriangle(int n)
            {
                for (int i = n; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("# ");
                    }
                    Console.WriteLine();
                }


            }


        }
    }
}

