namespace DetailPrinter
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Ivan");

            Employee employee2 = new Employee("Petar");

            List<string> documents = new List<string>()
            {
                "Salary.doc", "Schedule.doc","Remuneration.doc"
            };
            Manager manager = new Manager("Dimitar", documents);

            List<Employee> employees = new List<Employee>()
            {
                employee, manager, employee2
            };


            DetailsPrinter printer = new DetailsPrinter(employees);
            printer.PrintDetails();
        }
    }
}
