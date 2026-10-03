namespace _1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int velocidade, tempo;
            double combustivel, km;

            tempo = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            km = velocidade * tempo;
            combustivel = km / 12;

            Console.WriteLine($"{combustivel:F3}");
        }
    }
}
