namespace _05.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            for (int i = 1; i <= userInput; i++)
            {
                int sum = 0;
                int currentNumber = 1;
                while(currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber /= 10;
                }

                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }   
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
