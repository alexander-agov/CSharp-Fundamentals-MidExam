namespace Numbers
{
    internal class Program
    {
        static void Main()
        {
            //List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            //double average;
            //double sum = 0;
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    sum += numbers[i];
            //}
            //average = sum / numbers.Count;
            //List<int> topNumbers = new List<int>();
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    if (numbers[i] > average)
            //    {
            //        topNumbers.Add(numbers[i]);
            //    }
            //}
            //topNumbers.Sort();
            //topNumbers.Reverse();
            //if (topNumbers.Count == 0)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    int count = Math.Min(5, topNumbers.Count);
            //    for (int i = 0; i < count; i++)
            //    {
            //        Console.Write($"{topNumbers[i]} ");
            //    }
            //}

            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            double average = numbers.Average();
            List<int> topFive = numbers.FindAll(x => x > average)
                .OrderByDescending(x => x)
                .Take(5)
                .ToList();
            Console.WriteLine(topFive.Count == 0 ? "No" : string.Join(" ", topFive));
        }
    }
}
