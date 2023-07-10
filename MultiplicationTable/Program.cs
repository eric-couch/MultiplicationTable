namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter ceiling of multiplication table: ");
            int ceiling = int.Parse(Console.ReadLine());
            if (ceiling > 10)
            {
                Console.WriteLine("that's too big!");
            } else
            {
                Console.Write("\t");
                for (int col = 0; col <= ceiling; col++)
                {
                    Console.Write($"{col}\t");
                }
                Console.WriteLine("");
                for (int i = 0; i < ceiling; i++)
                {
                    Console.Write($"{i}\t");
                    for (int j = 0; j <= ceiling; j++)
                    {
                        Console.Write($"{i * j}\t");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}