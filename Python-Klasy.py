# 2. Wypożyczalnia samochodów


class Car:
    def __init__(self, model: str, price: float, car_type: str): # price - cena za dzień
        self.model = model
        self.price = price
        self.car_type = car_type
    def display_info(self):
        print(f"Samochód: {self.model}")
        print(f"Cena za dzień: {self.price}")
        print(f"Klasa samochodu: {self.car_type}")
class Customer:
    def __init__(self, name: str, customer_id: str):
        self.name = name
        self.customer_id = customer_id
class Rental:
    def __init__(self, customer: str, car: str, days: int):
        self.customer = customer
        self.car = car
        self.days = days
    def cost(self):
        return self.days * self.car.price
    def display_info(self):
        print(f"Klient: {self.customer.name}, ID: {self.customer.customer_id}")
        print(f"Auto: {self.car.model} z grupy: {self.car.car_type}")
        print(f"Cena za jeden dzień: {self.car.price} zł")
        print(f"Liczba dni: {self.days}")
        print(f"Łączny koszt: {self.cost()} zł")

if __name__ == "__main__": # test lokalny
    customer1 = Customer("Jan Kowalski","#001")
    customer2 = Customer("Adrian Nowak","#002")
    car1 = Car("2020 BMW M3", 1999.99, "S")
    car2 = Car("2018 Fiat 500", 199.99, "B")
    car3 = Car("2019 Nissan 370z", 599.99, "S")
    rental1 = Rental(customer1, car1, 4)
    rental2 = Rental(customer2, car2, 8)
    print("---")
    car3.display_info()
    print("---")
    rental1.display_info()
    print("---")
    rental2.display_info()
    print("---")