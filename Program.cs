namespace OppInheritance;
class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Drive();
        Console.WriteLine($"Brand {myCar.brand} Model name {myCar.modelName}");
        Employee employee = new Employee();
        Teachers teachers = new Teachers();
        Employee teacherChildInstance = new Teachers();
        employee.Departament();
        teachers.Departament();
        teacherChildInstance.Departament();
        ImplementationClass instance = new ImplementationClass();
        instance.SampleMethod();
    }
}
