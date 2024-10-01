namespace _12_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 0;
            bool isSpecialNum = false;
            int userInput = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= userInput; currentNumber++)
            {
                number = currentNumber;
                while (currentNumber != 0)
                {
                    sum += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecialNum);
                sum = 0;
                currentNumber = number;
            }
        }
    }
}
/* 
          *  int userInput = int.Parse(Console.ReadLine());
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
             } */
