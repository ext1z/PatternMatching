//2.Паттерн свойств с вложенными объектами
//Создайте классы:

//Order с полями Id (int) и Customer (объект Customer).
//Customer с полями Name (строка) и IsPremium (bool).
//Напишите метод ProcessOrder(Order order), который:

//Использует паттерн свойств для проверки:
//Если клиент премиум-класса, возвращает: "Обрабатывается премиум-заказ для [Name]".
//Если клиент обычный и ID заказа больше 1000, возвращает: "Обрабатывается крупный заказ для [Name]".
//В остальных случаях возвращает: "Обычный заказ".

// Time 20:00 minute



class Program
{
    static void Main(string[] args)
    {
        Customer customerBob = new Customer("Bob", false);
        Customer customerTommy = new Customer("Tommy", true);

        Order orderForBob = new Order(555, customerBob);
        Order orderForTommy = new Order(1000, customerBob);
        Order orderForTommy2 = new Order(++orderForTommy.Id, customerTommy);

        Console.WriteLine(ProcessOrder(orderForBob));
        Console.WriteLine(ProcessOrder(orderForTommy));
        Console.WriteLine(ProcessOrder(orderForTommy2));
    }


    static string ProcessOrder(Order order)
    {
        if (order is Order { Customer: {IsPremium: true }})
        {
            return $"Обрабатывается премиум-заказ для {order.Customer.Name}";

        }
        else if(order is Order { Id: > 1000})
        {
            return $"Обрабатывается крупный заказ для {order.Customer.Name}";
        }
        else
        {
            return $"Обычный заказ для {order.Customer.Name}";
        }
    }

}

class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }

    public Order(int id, Customer customer)
    {
        Id = id;
        Customer = customer;
    }

}


class Customer
{
    public string Name { get; set; }
    public bool IsPremium { get; set; }

    public Customer(string name, bool isPremium)
    {
        Name = name;
        IsPremium = isPremium;
    }
}