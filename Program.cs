namespace generic_collections;

class Program
{
    private static Stack<Employee> employees = new Stack<Employee>();

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

        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        Console.WriteLine("-------------------------------------------");

        foreach (Employee employee in employees)
        {
            Console.WriteLine($"Id: {employee.Id}, Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.WriteLine($"Items left in the Stack = {employees.Count}");
        }

        Console.WriteLine("-------------------------------------------");

        while (employees.Count > 0)
        {
            Employee employee = employees.Pop();

            Console.WriteLine($"Name: {employee.Name}, Gender: {employee.Gender}, Salary: {employee.Salary}");
            Console.WriteLine($"Items left in the Stack = {employees.Count}");

        }

        employees.Push(employee1);
        employees.Push(employee2);
        employees.Push(employee3);
        employees.Push(employee4);
        employees.Push(employee5);

        Console.WriteLine("-------------------------------------------");

        Employee employeePeek1 = employees.Peek();
        Console.WriteLine($"Name: {employeePeek1.Name}, Gender: {employeePeek1.Gender}, Salary: {employeePeek1.Salary}");
        Console.WriteLine($"Items left in the Stack = {employees.Count}");

        Employee employeePeek2 = employees.Peek();
        Console.WriteLine($"Name: {employeePeek2.Name}, Gender: {employeePeek2.Gender}, Salary: {employeePeek2.Salary}");
        Console.WriteLine($"Items left in the Stack = {employees.Count}");

        Console.WriteLine("-------------------------------------------");

        if (employees.Contains(employee3))
        {
            Console.WriteLine("Emp3 is in stack");
        }
        else
        {
            Console.WriteLine("Emp3 is not in stack");
        }
    }
}
