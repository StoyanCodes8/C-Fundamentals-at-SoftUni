namespace _06_ReversedCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userInput = int.Parse(Console.ReadLine());
            char[] array = new char[userInput];
            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = char.Parse(Console.ReadLine());
                /* if(i == array.Length - 1)
                 {
                     Console.WriteLine("Cycle End");
                 }
             */

            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }


        }
    }
}

