namespace Q1c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintIntegersDo();
        }

        static void PrintIntegersDo()
        {
            int i = 40;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 60);
           
        }



    }
}