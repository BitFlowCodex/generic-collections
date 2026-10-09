namespace generic_collections;

class Program
{
    private static Stack<Employee> employeesStack = new Stack<Employee>();
    private static List<Employee> employeesList = new List<Employee>();

    static void Main(string[] args)
    {
        Employee employee1 = new Employee(
            id: 1,
            name: "Alex Mercer",
            gender: "Male",
            salary: 3500.0
        );

        Employee employee2 = new Employee(
            id: 2,
            name: "Paula Collins",
            gender: "Female",
            salary: 4230.1
        );

        Employee employee3 = new Employee(
            id: 3,
            name: "Olivia Parker",
            gender: "Female",
            salary: 6210.5
        );

        Employee employee4 = new Employee(
            id: 4,
            name: "Pär Andersson",
            gender: "Male",
            salary: 2599.8
        );

        Employee employee5 = new Employee(
            id: 5,
            name: "Leo Harrison",
            gender: "Male",
            salary: 8540.2
        );

        // Del 1
        employeesStack.Push(employee1);
        employeesStack.Push(employee2);
        employeesStack.Push(employee3);
        employeesStack.Push(employee4);
        employeesStack.Push(employee5);

        Console.WriteLine("-------------------------------------------");

        foreach (Employee employee in employeesStack)
        {
            PrintEmployee(employee);
            Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");
        }

        Console.WriteLine("-------------------------------------------");

        while (employeesStack.Count > 0)
        {
            Employee employee = employeesStack.Pop();

            PrintEmployee(employee);
            Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");

        }

        employeesStack.Push(employee1);
        employeesStack.Push(employee2);
        employeesStack.Push(employee3);
        employeesStack.Push(employee4);
        employeesStack.Push(employee5);

        Console.WriteLine("-------------------------------------------");

        Employee employeePeek1 = employeesStack.Peek();
        PrintEmployee(employeePeek1);
        Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");

        Employee employeePeek2 = employeesStack.Peek();
        PrintEmployee(employeePeek2);
        Console.WriteLine($"Items left in the Stack = {employeesStack.Count}");

        Console.WriteLine("-------------------------------------------");

        if (employeesStack.Contains(employee3))
        {
            Console.WriteLine("Emp3 is in stack");
        }
        else
        {
            Console.WriteLine("Emp3 is not in stack");
        }

        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("-------------------------------------------");

        // Del 2
        employeesList.Add(employee1);
        employeesList.Add(employee2);
        employeesList.Add(employee3);
        employeesList.Add(employee4);
        employeesList.Add(employee5);

        if (employeesList.Contains(employee2))
        {
            Console.WriteLine($"Employee2 object exists in the list");
        }
        else
        {
            Console.WriteLine($"Employee2 object does not exist in the list");
        }

        Console.WriteLine("-------------------------------------------");

        Employee? maleEmployee = employeesList.Find(value => value.Gender == "Male");

        if (maleEmployee != null)
        {
            PrintEmployee(maleEmployee);
        }

        Console.WriteLine("-------------------------------------------");

        List<Employee> allMaleEmployees = employeesList.FindAll(value => value.Gender == "Male");

        foreach (Employee employee in allMaleEmployees)
        {
            PrintEmployee(employee);
        }
    }

    static void PrintEmployee(Employee employee)
    {
        Console.WriteLine($"ID = {employee.Id}, Name = {employee.Name}, Gender = {employee.Gender}, Salary = {employee.Salary}");
    }
}
