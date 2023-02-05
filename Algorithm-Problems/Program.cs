namespace Algorithm_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Algorithm-Problems!!!");
            Console.WriteLine("---------------------------------------------------------------------");
            while (true)
            {
                Console.WriteLine("\n 1. Program to return all permutations of a string");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        PermutationsOfString permute = new PermutationsOfString();
                        permute.Driver();
                        break;
                    default:
                        Console.WriteLine("Please choose the correct option");
                        break;
                }
            }
        }
    }
}