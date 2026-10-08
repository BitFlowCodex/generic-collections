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

        foreach (var employee in employees)
        {
            System.Console.WriteLine(employee.Id);
            System.Console.WriteLine(employee.Name);
            System.Console.WriteLine(employee.Gender);
            System.Console.WriteLine(employee.Salary);
            System.Console.WriteLine("\n");
        }
    }
}
