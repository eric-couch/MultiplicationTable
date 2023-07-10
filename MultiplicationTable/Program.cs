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
                Console.Write("\n ");
                for (int col = 0; col <= ceiling; col++)
                {
                    Console.Write($"--------");
                }
                Console.WriteLine("");
                for (int col = 0; col < ceiling; col++)
                {
                    Console.Write($"{col} |\t");
                    for (int row = 0; row <= ceiling; row++)
                    {
                        Console.Write($"{col * row}\t");
                    }
                    Console.WriteLine();
                }
            }
            
        }
    }
}