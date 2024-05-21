using System;
using System.Net.Http.Headers;

namespace ManOWar
{
    internal class Program
    {
        static void Main()
        {
            List<int> PirateShipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> WarshipStatus = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealtCapacity = int.Parse(Console.ReadLine());
            string input;
            bool isStalemate = true;
            while ((input = Console.ReadLine()) != "Retire")
            {
                string[] command = input.Split();
                string action = command[0];
                switch (action)
                {
                    case "Fire":
                        int index = int.Parse(command[1]);
                        if (index < WarshipStatus.Count && index >= 0)
                        {
                            WarshipStatus[index] -= int.Parse(command[2]);
                            if (WarshipStatus[index] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                isStalemate = false;
                                return;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Defend":
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        int damage = int.Parse(command[3]);
                        if (startIndex < PirateShipStatus.Count && startIndex >= 0 &&
                            endIndex < PirateShipStatus.Count && endIndex > startIndex)
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                PirateShipStatus[i] -= damage;
                                if (PirateShipStatus[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    isStalemate = false;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Repair":
                        int health = int.Parse(command[2]);
                        if (int.Parse(command[1]) < PirateShipStatus.Count && int.Parse(command[1]) >= 0)
                        {
                            PirateShipStatus[int.Parse(command[1])] += int.Parse(command[2]);
                            if (PirateShipStatus[int.Parse(command[1])] > maxHealtCapacity)
                            {
                                PirateShipStatus[int.Parse(command[1])] = maxHealtCapacity;
                            }
                        }
                        else
                        {
                            continue;
                        }
                        break;
                    case "Status":
                        int count = PirateShipStatus.Count(x => x < maxHealtCapacity * 0.2);
                        Console.WriteLine($"{count} sections need repair.");
                        break;
                }
            }
            if (isStalemate == true)
            {
                Console.WriteLine($"Pirate ship status: {PirateShipStatus.Sum(x => x)}");
                Console.WriteLine($"Warship status: {WarshipStatus.Sum(y => y)}");
            }
        }
    }
}
