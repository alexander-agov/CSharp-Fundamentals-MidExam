
namespace MemoryGame
{
    internal class Program
    {
        static void Main()
        {
            List<string> board = Console.ReadLine().Split().ToList();
            string line = "";
            int moves = 0;
            while ((line = Console.ReadLine()) != "end")
            {
                moves++;
                string[] tokens = line.Split();
                int firstIndex = int.Parse(tokens[0]);
                int secondIndex = int.Parse(tokens[1]);
                if (firstIndex == secondIndex || firstIndex < 0 || firstIndex >= board.Count || secondIndex < 0
                    || secondIndex >= board.Count)
                {
                    string symbol = $"-{moves}a";
                    board.Insert(board.Count / 2, symbol);
                    board.Insert(board.Count / 2, symbol);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }
                if (board[firstIndex] == board[secondIndex])
                {
                    string matchingElement = board[firstIndex]; 
                    board.RemoveAt(firstIndex);
                    board.RemoveAt(secondIndex);
                    Console.WriteLine($"Congrats! You have found matching elements - {matchingElement}!");
                }
                else
                {
                    Console.WriteLine("Try again!");
                }
                if (board.Count == 0)
                {
                    Console.WriteLine($"You have won in {moves} turns!");
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :( ");
            Console.WriteLine(string.Join(" ", board));
        }
    }
}




