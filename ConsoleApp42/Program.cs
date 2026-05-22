Car car1 = new Car("BMW", 200, "Black", 45000, 3.0, "Gasoline");
car1.Drive();
car1.ShowInfo();
car1.StartEngine();
car1.Accelerate(50);
car1.Refuel(20);
car1.Repaint("Red");

class Car
{
    // 15 полів (змінних)
    public string brand;
    public int speed;
    public string color;
    public int price;
    public double engineVolume;
    public string fuelType;
    public int mileage;
    public int fuelAmount;
    public int tankCapacity;
    public bool isEngineRunning;
    public bool lightsOn;
    public string plateNumber;
    public int wheelCount;
    public int doorCount;
    public int horsePower;

    // Конструктор
    public Car(string name, int sp, string col, int pr, double engine, string fuel)
    {
        brand = name;
        speed = sp;
        color = col;
        price = pr;
        engineVolume = engine;
        fuelType = fuel;

        // Значення за замовчуванням
        mileage = 0;
        fuelAmount = 30;
        tankCapacity = 60;
        isEngineRunning = false;
        lightsOn = false;
        plateNumber = "AI1111AA";
        wheelCount = 4;
        doorCount = 4;
        horsePower = 150;
    }

    // 10 методів (функцій)
    public void Drive()
    {
        Console.WriteLine($"{brand} is driving.");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {brand}, Speed: {speed}, Color: {color}, Mileage: {mileage}");
    }

    public void StartEngine()
    {
        if (!isEngineRunning && fuelAmount > 0)
        {
            isEngineRunning = true;
            Console.WriteLine("Engine started.");
        }
    }

    public void StopEngine()
    {
        isEngineRunning = false;
        speed = 0;
        Console.WriteLine("Engine stopped.");
    }

    public void Accelerate(int amount)
    {
        if (isEngineRunning)
        {
            speed += amount;
            Console.WriteLine($"Speed increased to {speed} km/h");
        }
    }

    public void Brake()
    {
        speed = 0;
        Console.WriteLine("Car stopped.");
    }

    public void Refuel(int liters)
    {
        fuelAmount += liters;
        if (fuelAmount > tankCapacity) fuelAmount = tankCapacity;
        Console.WriteLine($"Refueled. Current fuel: {fuelAmount}L");
    }

    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine($"Car repainted to {color}.");
    }

    public void ToggleLights()
    {
        lightsOn = !lightsOn;
        Console.WriteLine($"Lights are on: {lightsOn}");
    }

    public void ChangePlate(string newPlate)
    {
        plateNumber = newPlate;
        Console.WriteLine($"New plate number: {plateNumber}");
    }
}
