namespace _1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split(' ');
            string[] p2 = Console.ReadLine().Split(' ');

            double x1, y1, x2, y2;
            double resultado;

            x1 = double.Parse(p1[0]);
            y1 = double.Parse(p1[1]);
            x2 = double.Parse(p2[0]);
            y2 = double.Parse(p2[1]);

            resultado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{resultado:F4}");
        }
    }
}
