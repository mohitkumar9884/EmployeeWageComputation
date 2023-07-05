namespace EmployeeWageComputation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int Is_Present = 0;
            const int RATE_PER_HOUR = 20;
            int empHr = 0;
            int empWage = 0;

            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            int employeeInput = random.Next(0, 2);// 0 or 1
            Console.WriteLine("Random value:{0}", employeeInput);

            if (employeeInput == Is_Present)
            {
                Console.WriteLine("Employee Is Present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee Is Not Present");
            }
            empWage = empHr*RATE_PER_HOUR;
            Console.WriteLine("Dialy Employee WAGE Is:{0}", empWage);

        }
    }
}