namespace _07._ConcatNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string delimeter = Console.ReadLine();
            Console.WriteLine($"{firstName}{delimeter}{lastName}"); 

            /*
            string firstName = Console.ReadLine();
            char[] delimiter = new char[2];
            for(int i = 0; i <= delimiter.Length - 1; i++)
            {
                delimiter[i] = char.Parse(Console.ReadLine());
            }
            string charString = new string(delimiter);
            string lastName = Console.ReadLine();
            Console.WriteLine($"{firstName}{charString}{lastName}");*/
        }
    }
}
