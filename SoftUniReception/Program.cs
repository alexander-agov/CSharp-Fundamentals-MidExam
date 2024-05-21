namespace SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int employeeOne = int.Parse(Console.ReadLine());
            int employeeTwo = int.Parse(Console.ReadLine());
            int employeeThree = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int allStudentsPerHour = employeeOne + employeeTwo + employeeThree;
            int restStudents = 0;
            while (students > 0)
            {
                students -= allStudentsPerHour;
                restStudents++;
                if (restStudents % 4 == 0)
                {
                    restStudents++;
                }
            }
            Console.WriteLine($"Time needed: {restStudents}h.");
        }
    }
}

