namespace CompanyExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees: ");
            int EmployeesNumber = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();
            
            for (int counter=1; counter!=EmployeesNumber; counter++)
            {
                Console.WriteLine($"Emplyee #{counter} data:");
                Console.WriteLine("Outsourced (y/n)?");
                char YesOrNo = char.Parse(Console.ReadLine());
 
                if (YesOrNo == 'y')
                {
                    employees.Add(CollectOutsourcedEmployeeData());

                }else if(YesOrNo == 'n')
                {
                    employees.Add(CollectEmployeeData());
                }
            }

            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.name} - {employee.payment()}");
            }
            
        }
        public static Employee CollectEmployeeData()
        {
            Employee employee = new Employee();
            Console.WriteLine("Name:");
            employee.name = Console.ReadLine();

            Console.WriteLine("Hours:");
            employee.hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Value per hour:");
            employee.valuePerHour = double.Parse(Console.ReadLine());
            return employee;
        }

        public static Employee CollectOutsourcedEmployeeData()
        {
            Employee employee = new OutsourcedEmployee();
            Console.WriteLine("Name:");
            employee.name = Console.ReadLine();

            Console.WriteLine("Hours:");
            employee.hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Value per hour:");
            employee.valuePerHour = double.Parse(Console.ReadLine());
            return employee;
        }
    }
}