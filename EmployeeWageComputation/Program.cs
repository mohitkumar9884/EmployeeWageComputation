namespace EmployeeWageComputation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int FULL_TIME = 0;
            const int PART_TIME = 2;
            const int RATE_PER_HOUR = 20;
            int empHr = 0;
            int empWage = 0;

            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            int employeeInput = random.Next(0, 3);// 0 or 1 or 2

            Console.WriteLine("Random value:{0}", employeeInput);
            switch (employeeInput)
            {
                case FULL_TIME:
                    //code block
                    Console.WriteLine("FullTime Employee Is Present");
                    empHr = 8;
                    break;
                case PART_TIME:
                    //code block
                    Console.WriteLine("PartTime Employee Is Present");
                    empHr = 4;
                    break;
                default:
                    Console.WriteLine("Employee Is Not Present");
                    break;          
            }
            empWage = empHr*RATE_PER_HOUR;
            empWage = empHr * RATE_PER_HOUR;
            Console.WriteLine("Dialy Employee WAGE Is:{0}", empWage);
        }
    }
    
}