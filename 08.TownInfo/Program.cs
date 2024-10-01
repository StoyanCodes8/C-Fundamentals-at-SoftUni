namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string placeOfCivilization = Console.ReadLine();
            int population = int.Parse(Console.ReadLine());
            short squareFeet = short.Parse(Console.ReadLine());
            if(squareFeet >= 400)
            {
                Console.WriteLine($"City of {placeOfCivilization} has population of {population} and area of {squareFeet} square km.");
            }
            else 
            {
                Console.WriteLine($"The town of {placeOfCivilization} has population of {population} and area of {squareFeet} square km.");
            }

        }
    }
}
