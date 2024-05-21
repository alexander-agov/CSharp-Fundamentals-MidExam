namespace GuineaPig
{
    internal class Program
    {
        static void Main()
        {
            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;
            for (int i = 1; i <= 30; i++)
            {
                if (food >= 300)
                {
                    food -= 300;
                }
                else
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
                if (i % 2 == 0)
                {
                    if (hay >= 5 * food / 100)
                    {
                        hay -= 5 * food / 100;
                    }
                    else
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        return;
                    }
                }
                if (i % 3 == 0)
                {
                    if (cover >= weight / 3)
                    {
                        cover -= weight / 3;
                    }
                    else
                    {
                        Console.WriteLine("Merry must go to the pet store!");
                        return;
                    }
                }
                if (food <= 0 || hay <= 0 || cover <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(food / 1000):f2}, Hay: {(hay / 1000):f2}, Cover: {(cover / 1000):f2}.");
        }
    }
}
