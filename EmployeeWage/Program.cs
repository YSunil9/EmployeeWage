namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.RefactorEmp("Wipro",20,27,165);
            employeeWage.RefactorEmp("Infosys", 18, 20,132);
        }


    }
}