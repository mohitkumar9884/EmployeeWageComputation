namespace EmployeeWageComputation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int FULL_TIME = 0;
            const int PART_TIME = 2;
            const int RATE_PER_HOUR = 20;
            const int WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 80;
            int empHr = 0;
            int empWage = 0;
            int totalWage= 0;
            int day = 1;
            int totalWorkingHrs= 0;

            Console.WriteLine("Welcome To EmployeeWageComputation");
            Random random = new Random();
            while (day <= WORKING_DAYS && totalWorkingHrs<= MAX_WORKING_HRS)
            {
                int employeeInput = random.Next(0, 3);// 0 or 1 or 2
                //Console.WriteLine("Random value:{0}", employeeInput);
                switch (employeeInput)
                {
                    case FULL_TIME:
                        //code block
                        //Console.WriteLine("FullTime Employee Is Present");
                        empHr = 8;
                        break;
                    case PART_TIME:
                        //code block
                        //Console.WriteLine("PartTime Employee Is Present");
                        empHr = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee Is Not Present");
                        empHr = 0;
                        break;
                }
                empWage = empHr * RATE_PER_HOUR;
                totalWage = totalWage + empWage;
                Console.WriteLine("Day{0} Employee WAGE Is:{1}", day, empWage);
                day++;
                totalWorkingHrs = totalWorkingHrs + empHr;
                if (totalWorkingHrs > MAX_WORKING_HRS)
                    totalWorkingHrs = totalWorkingHrs - empHr;
            }
            Console.WriteLine("Total Wage for {0} days and Hrs:{1} is:{2}", (day - 1),(totalWorkingHrs),totalWage);
        }
    }
    
}