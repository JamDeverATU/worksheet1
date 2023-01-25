namespace Q1b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersWhile();
        }

        static void PrintIntegersWhile()
        {
            int i = 40;
            while (i < 60)
            {
                Console.WriteLine(i);
                i++;
            }
        }
    }
}