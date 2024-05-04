


using interfac;
using interfaceTesting;
using System.ComponentModel;

Executive executive = new Executive() { Name = "Alice", Designation = "Programmer" };
Manager manager = new Manager() { Name = "Bob", Designation = "Sales Manager" };
CSuite cSuite = new CSuite() { Name = "Daisy", Designation = "CFO" };

var employees = new List<IEmployee>();

employees.Add(new Executive()
{
    Name = "Alex",
    Designation = "Programmer"
});
employees.Add(new Manager()
{
    Name = "Bob",
    Designation = "Sales Manager"
});
employees.Add(new CSuite()
{
    Name = "Daisy",
    Designation = "CFO"
});

#region Display Employees Info
Console.WriteLine("-----Display Employee's Information-----");
foreach (IEmployee employee in employees)
{
    DisplayEmployeeInfo(employee);
}
Console.WriteLine();
#endregion
static void DisplayEmployeeInfo(IEmployee employee)
{
    Console.WriteLine($"{employee.Name} is a {employee.Designation}");
}

