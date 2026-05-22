Random rnd = new Random();

BankCard card1 = new BankCard("123-456", 100);
card1.ShowInfo();
card1.AddMoney(50);
card1.ShowInfo();
card1.RemoveMoney(30);
card1.ShowInfo();

Car myCar = new Car("Toyota", "Camry", 2021, "Black", 2.5, 25000);
myCar.StartEngine();
myCar.Drive(50);
myCar.Refuel(20);
myCar.Repaint("White");
myCar.TurnOnHeadlights();
myCar.ShowCarInfo();

class BankCard
{
    public string CardNumber { get; private set; }
    public decimal Balance { get; private set; }

    public BankCard(string cardNumber, decimal startBalance)
    {
        CardNumber = cardNumber;
        Balance = startBalance;
    }

    public void AddMoney(decimal money)
    {
        if (money > 0)
        {
            Balance += money;
            Console.WriteLine($"Add balance to {CardNumber} with {money} $");
        }
    }

    public void RemoveMoney(decimal money)
    {
        if (money > 0 && Balance >= money)
        {
            Balance -= money;
            Console.WriteLine($"Removed {money} $ from {CardNumber}");
        }
        else
        {
            Console.WriteLine("Not enough money or invalid amount");
        }
    }

    public void RandomNumberCard()
    {
        Random r = new Random();
        CardNumber = r.Next(1000, 9999) + "-" + r.Next(1000, 9999);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Card Number: {CardNumber}");
        Console.WriteLine($"Balance: {Balance}");
    }
}

class Car
{
    public string Brand;
    public string Model;
    public int Year;
    public string Color;
    public double EngineVolume;
    public int Mileage;
    public int FuelAmount;
    public int FuelCapacity;
    public int MaxSpeed;
    public int CurrentSpeed;
    public bool IsEngineRunning;
    public bool AreHeadlightsOn;
    public int Price;
    public string LicensePlate;
    public int WheelCount;

    public Car(string brand, string model, int year, string color, double engineVolume, int price)
    {
        Brand = brand;
        Model = model;
        Year = year;
        Color = color;
        EngineVolume = engineVolume;
        Price = price;
        FuelCapacity = 60;
        FuelAmount = 30;
        MaxSpeed = 220;
        CurrentSpeed = 0;
        IsEngineRunning = false;
        AreHeadlightsOn = false;
        Mileage = 10000;
        LicensePlate = "AA0000AA";
        WheelCount = 4;
    }

    public void StartEngine()
    {
        if (!IsEngineRunning && FuelAmount > 0)
        {
            IsEngineRunning = true;
            Console.WriteLine("Engine started");
        }
    }

    public void StopEngine()
    {
        IsEngineRunning = false;
        CurrentSpeed = 0;
        Console.WriteLine("Engine stopped");
    }

    public void Drive(int distance)
    {
        if (IsEngineRunning && FuelAmount > 5)
        {
            Mileage += distance;
            FuelAmount -= 5;
            CurrentSpeed = 60;
            Console.WriteLine("Driving... Mileage: " + Mileage);
        }
    }

    public void Refuel(int liters)
    {
        FuelAmount += liters;
        if (FuelAmount > FuelCapacity) FuelAmount = FuelCapacity;
        Console.WriteLine("Refueled. Current fuel: " + FuelAmount);
    }

    public void Repaint(string newColor)
    {
        Color = newColor;
        Console.WriteLine("Car repainted to " + Color);
    }

    public void TurnOnHeadlights()
    {
        AreHeadlightsOn = true;
        Console.WriteLine("Headlights are on");
    }

    public void TurnOffHeadlights()
    {
        AreHeadlightsOn = false;
        Console.WriteLine("Headlights are off");
    }

    public void ChangeLicensePlate(string newPlate)
    {
        LicensePlate = newPlate;
        Console.WriteLine("New plate: " + LicensePlate);
    }

    public void Brake()
    {
        CurrentSpeed = 0;
        Console.WriteLine("Car stopped");
    }

    public void ShowCarInfo()
    {
        Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}, Color: {Color}, Mileage: {Mileage}, Price: {Price}$");
    }
}