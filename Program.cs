using System;
// 2. Wypożyczalnia samochodów
class Car
{
    public string Model { get; set; }
    public float Price { get; set; }
    public string Car_type { get; set; }
    public Car(string model, float price, string carType)
    {
        Model = model;
        Price = price;
        Car_type = carType;
    }
    public void Info()
    {
        Console.WriteLine($" Samochód: {Model} \n Cena za dzień: {Price} zł \n Klasa samochodu: {Car_type} \n");
    }
}
class Customer
{
    public string Name { get; set; }
    public string Customer_ID { get; set; }
    public Customer(string name, string customerID)
    {
        Name = name;
        Customer_ID = customerID;
    }
}
class Rental
{
    public Customer Customer { get; set; }
    public Car Car {  get; set; }
    public int Days { get; set; }
    public Rental(Customer customer, Car car, int days)
    {
        Customer = customer;
        Car = car;
        Days = days;
    }
    public float Cost()
    {
        return Car.Price * Days;
    }
    public void Summary()
    {
        Console.WriteLine($" Klient: { Customer.Name } | ID: {Customer.Customer_ID} \n Auto: {Car.Model} z grupy {Car.Car_type} \n Cena za jeden dzień: {Car.Price} zł \n Liczba dni: {Days} dni \n Łączny koszt: {Cost()} zł \n");
    }
}
class Program
{
    static void Main()
    {
        Car car1 = new Car("2020 BMW M3", 1999.99f, "S");
        Car car2 = new Car("2018 Fiat 500", 199.99f, "B");
        Car car3 = new Car("2019 Nissan 370z", 599.99f, "S");
        Customer customer1 = new Customer("Jan Kowalski", "#001");
        Customer customer2 = new Customer("Adrian Nowak", "#002");
        Rental rental1 = new Rental(customer1, car1, 4);
        Rental rental2 = new Rental(customer2, car2, 8);
        Console.WriteLine("--- \n");
        car3.Info();
        Console.WriteLine("--- \n");
        rental1.Summary();
        Console.WriteLine("--- \n");
        rental2.Summary();
        Console.WriteLine("--- \n");
    }
}