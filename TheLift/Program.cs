namespace TheLift
{
    internal class Program
    {
        static void Main()
        {
            int wagonCapacity = 4;
            int people = int.Parse(Console.ReadLine());
            List<int> currentState = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> finalState = new List<int>();
            for (int i = 0; i < currentState.Count; i++)
            {
                if (currentState[i] >= 0 && currentState[i] < wagonCapacity)
                {
                    if (people >= (wagonCapacity - currentState[i]))
                    {
                        finalState.Add(currentState[i] + wagonCapacity - currentState[i]);
                        people -= finalState[i] - currentState[i];
                    }
                    else
                    {
                        finalState.Add(currentState[i] + people);
                        people -= finalState[i] - currentState[i];
                    }
                }
                if (currentState[i] == wagonCapacity)
                {
                    finalState.Add(wagonCapacity);
                    continue;
                }
            }
            bool isLiftEmpty = true; //bool isLiftEmpty = !finalState.Any(i => i == wagonCapacity);
            foreach (int i in finalState)
            {
                if (i == wagonCapacity)
                {
                    isLiftEmpty = false;
                }
                else
                {
                    isLiftEmpty = true;
                }
            }
            if (people == 0 && isLiftEmpty == true) //finalState.Any(i => i < 4)
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", finalState));
            }
            else if (people > 0 && isLiftEmpty == false)//finalState.All(i => i == 4)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
                Console.WriteLine(string.Join(" ", finalState));
            }
            else if (isLiftEmpty == false && people == 0)
            {
                Console.WriteLine(string.Join(" ", finalState));
            }
        }
    }
}
