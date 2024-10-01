namespace _04._CenturiestoMinutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double century = double.Parse(input);
            double years = century * 100;
            double days = years * 365.24;
            double hours = days * 24;
            double minutes = hours * 60;
            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


        }
    }
}
