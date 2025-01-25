
//4.Реляционные и логические паттерны для сложных условий
//Напишите метод CategorizeAge(int age), который:

//Использует реляционные и логические паттерны для определения:
//Если возраст 0 <= age < 12, возвращает: "Ребёнок".
//Если возраст 13 <= age < 18, возвращает: "Подросток".
//Если возраст 18 <= age < 65, возвращает: "Взрослый".
//Если возраст >= 65, возвращает: "Пожилой".
//Если возраст отрицательный, выбрасывает исключение.

// Time 15:00


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CheckAge(2));
        Console.WriteLine(CheckAge(14));
        Console.WriteLine(CheckAge(20));
        Console.WriteLine(CheckAge(68));
    }


    static string CheckAge(int? age)
    {
        return age switch
        {
            <= 0 => throw new Exception("Возраст не может быть меньше или равен 0"),
            > 0 and <= 12 => "Ребенок",                 
            > 12 and < 18 => "Подросток",              
            >= 18 and < 65 => "Взрослый",              
            >= 65 => "Пожилой",                        
            _ => throw new Exception("Неизвестный возраст") 
        };
    }


}