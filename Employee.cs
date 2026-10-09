public class Employee
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Gender { get; set; }
  public double Salary { get; set; }

  public Employee(int id, string name, string gender, double salary)
  {
    Id = id;
    Name = name;
    Gender = gender;
    Salary = salary;
  }
}