namespace _09.CharsToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] characters = new char[3];
            for (int i = 0; i <= characters.Length - 1; i++)
            {
                characters[i] = char.Parse(Console.ReadLine());
            }
            string charString = new string(characters);
            Console.Write(charString);
        }
    }
}
