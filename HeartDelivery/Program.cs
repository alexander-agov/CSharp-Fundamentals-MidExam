namespace HeartDelivery
{
    internal class Program
    {
        static void Main()
        {
            List<int> evenNumbers = Console.ReadLine().Split("@").Select(int.Parse).ToList();
            string input;
            int currentIndex = 0;
            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split();
                int jumpLength = int.Parse(command[1]);
                currentIndex += jumpLength;
                if (currentIndex >= evenNumbers.Count)
                {
                    currentIndex = 0;
                }
                if (evenNumbers[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    evenNumbers[currentIndex] -= 2;
                    if (evenNumbers[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            if (evenNumbers.All(x => x == 0))
            {
                Console.WriteLine($"Mission was successful.");
            }
            else
            {
                int houseCount = evenNumbers.Count(x => x > 0);
                Console.WriteLine($"Cupid has failed {houseCount} places.");
            }
        }
    }
}
