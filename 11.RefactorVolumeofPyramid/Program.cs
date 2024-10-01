namespace _11.RefactorVolumeofPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length, width, height, volume = 0;
          //  Console.WriteLine("Length: ");
            length = double.Parse(Console.ReadLine());
           // Console.WriteLine("Width: ");
            width = double.Parse(Console.ReadLine());
           // Console.WriteLine("Heigth: ");
            height = double.Parse(Console.ReadLine());
            // Изчисляваме площта на основата
            double baseArea = length * width;
            // Изчисляваме обема на пирамидата
            volume = (1.0 / 3.0) * baseArea * height;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:F2}");
        }
    }
}
