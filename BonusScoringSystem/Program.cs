namespace BonusScoringSystem
{
    internal class Program
    {
        static void Main()
        {
            uint students = uint.Parse(Console.ReadLine());
            uint lectures = uint.Parse(Console.ReadLine());
            uint additionalBonus = uint.Parse(Console.ReadLine());
            double totalBonus = 0;
            uint maxResult =uint.MinValue;
            uint bestLectures = 0;
            for (int i = 0; i < students; i++)
            {
                if ((double)lectures > 0)
                {
                    uint countAttendences = uint.Parse(Console.ReadLine());
                    totalBonus = (countAttendences / (double)lectures) * (5 + additionalBonus);
                    if (totalBonus >= maxResult)
                    {
                        maxResult = (uint)(Math.Round(totalBonus));
                        bestLectures = countAttendences;
                    }
                }
            }
            Console.WriteLine($"Max Bonus: {maxResult}.");
            Console.WriteLine($"The student has attended {bestLectures} lectures.");
        }
    }
}
