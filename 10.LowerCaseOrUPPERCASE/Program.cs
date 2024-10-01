using System.Diagnostics.Metrics;

namespace _10.LowerCaseOrUPPERCASE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char word = char.Parse(Console.ReadLine());
            if (char.IsUpper(word))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(word))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

