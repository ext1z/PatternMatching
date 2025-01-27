//repo name: PatternMatching

//1. Паттерн типов с обработкой сложных объектов
//Создайте классы:

//Employee с полями Name (строка) и Position (строка).
//Manager, унаследованный от Employee, с дополнительным полем NumberOfProjects.
//Developer, унаследованный от Employee, с дополнительным полем ProgrammingLanguages.
//Напишите метод DescribeEmployee(object employee), который:

//Использует паттерн типов для проверки типа объекта.
//Для объектов типа Manager возвращает строку: "Менеджер [Name], проектов: [NumberOfProjects]".
//Для объектов типа Developer возвращает строку: "Разработчик [Name], языки: [ProgrammingLanguages]".
//Для других типов возвращает: "Неизвестный тип сотрудника".



// Time 35:00




class Program
{
    static void Main(string[] args)
    {
        Employee managerBob = new Manager("ManagerBob", "Little manager", 1);
        Employee developerTom = new Developer("TomDeveloper", "Senior", "C");

        var result = DescribeEmployee(managerBob);
        var result2 = DescribeEmployee(developerTom);
        var result3 = DescribeEmployee(new Manager("Petr", "Stajer", 22));

        Console.WriteLine(result);
        Console.WriteLine(result2);
        Console.WriteLine(result3);

    }

    static string DescribeEmployee(Employee emplyoee)
    {
        switch (emplyoee)
        {
            case Manager manager:
                return $"Менеджер с именем : {manager.Name}, проекты : {manager.NumberOfProjects}";
            case Developer developer:
                return $"Разработчик с именем : {developer.Name}, язык программирования : {developer.ProgrammingLanguages}";
            default:
                return "Неизвестный тип сотрудника";
        }
    }

}

class Employee
{
    public string Name { get; set; }
    public string Position { get; set; }

    public Employee(string name, string position)
    {
        Name = name;
        Position = position;
    }
}


class Manager : Employee
{
    public int NumberOfProjects { get; set; }

    public Manager(string name, string position, int numberOfProjects) : base(name, position)
    {
        NumberOfProjects = numberOfProjects;
    }
}

class Developer : Employee
{
    public string ProgrammingLanguages { get; set; }

    public Developer(string name, string position, string programmingLanguages) : base(name, position)
    {
        ProgrammingLanguages = programmingLanguages;
    }
}
