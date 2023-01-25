namespace Q1d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintExcludingFor();
        }

        static void PrintExcludingFor()
        {
            for (int i = 40; i < 60; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}