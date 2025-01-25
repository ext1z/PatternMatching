


//3.Паттерны кортежей с вычислениями
//Напишите метод CalculateDiscount, который принимает кортеж (double total, bool isPremium), где:

//total — общая сумма заказа.
//isPremium — признак премиум-клиента.
//Используйте паттерны кортежей для определения скидки:

//Если(total > 1000, isPremium == true), скидка 20%.
//Если (total > 500, isPremium == false), скидка 10%.
//Если (total <= 500, isPremium == false), скидка 5%.
//Для остальных случаев скидка 0%.
//Метод должен возвращать строку с итоговой суммой и размером скидки.

// Time : 15:00 minute


class Program
{
    static void Main(string[] args)
    {
        var order1 = new {Total  = (double)2000, IsPremium = true};
        var order2 = new {Total  = (double)499, IsPremium = false};
        var order3 = new {Total  = (double)500, IsPremium = false};

        Console.WriteLine(CalculateDiscount(order1.Total,order1.IsPremium));
        Console.WriteLine(CalculateDiscount(order2.Total,order2.IsPremium));
        Console.WriteLine(CalculateDiscount(order3.Total,order3.IsPremium));
        Console.WriteLine(CalculateDiscount(300,true));

    }

    static string CalculateDiscount(double total, bool isPremium) => (total, isPremium) switch
    {
        ( > 1000, true) => $"Скидка 20% : Итого {total - (total * 20/100)}",
        ( > 500, false) => $"Скидка 10% : Итого {total - (total * 10/100)}",
        ( <= 500, false) => $"Скидка 5% : Итого {total - (total * 5/100)}",
        _=> $"Итого : {total}"
    };
}


