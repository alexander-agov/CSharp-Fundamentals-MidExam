namespace BlackFlag
{
    internal class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double total = 0;
            for (int day = 1; day <= days; day++)
            {
                total += (double)dailyPlunder;
                if (day % 3 == 0)
                {
                    total += dailyPlunder * 0.5;
                }
                if (day % 5 == 0)
                {
                    total *= 0.7;
                }
            }
            if (expectedPlunder <= total)
            {
                Console.WriteLine($"Ahoy! {total:f2} plunder gained.");
            }
            else
            {
                double percentage = total / expectedPlunder * 100;
                Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
            }
        }
    }
}
