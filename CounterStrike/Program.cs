namespace CounterStrike
{
    internal class Program
    {
        static void Main()
        {
            int initialEnergy = int.Parse(Console.ReadLine());
            string anyDistance = "";
            int countWonBattles = 0;
            while (true)
            {
                anyDistance = Console.ReadLine();
                if (anyDistance == "End of battle")
                {
                    Console.WriteLine($"Won battles: {countWonBattles}. Energy left: {initialEnergy}");
                    return;
                }
                if (int.Parse(anyDistance) <= initialEnergy)
                {
                    initialEnergy -= int.Parse(anyDistance);
                    countWonBattles++;
                    if (countWonBattles % 3 == 0)
                    {
                        initialEnergy += countWonBattles;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {countWonBattles} won battles and {initialEnergy} energy");
                    return;
                }
            }
        }
    }
}
