## 📌 Object-Oriented Programming in C#

### **🔍 Research & Learn**

**1. What are the four main pillars of OOP in C#?**

- `Encapsulation:` Hiding internal state and requiring all communication to be done through an object's methods.
- `Abstraction`: Hiding complex implementation details and showing only essential features.
- `Inheritance`: Reuse of code by forming new classes from existing ones.
- `Polymorphism`: Objects of different types can be used as instances of a single base type.

**2. How do concepts like inheritance, polymorphism, and encapsulation manifest in C# code?**

**🔐 Encapsulation**

```csharp
class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public decimal GetBalance() => balance;
}
```

**🧬 Inheritance**

```csharp
class Animal
{
    public virtual void Speak() => Console.WriteLine("Animal speaks");
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine("Woof!");
}
```

**🎭 Polymorphism**

```csharp
Animal myDog = new Dog();
myDog.Speak();  // Output: Woof!
```

**3. Which design patterns leverage OOP principles to improve code structure?**

- Factory Pattern (Abstraction + Polymorphism)
- Singleton Pattern (Encapsulation + Controlled Instantiation)
- Observer Pattern (Polymorphism + Decoupling)
- Decorator Pattern (Inheritance + Composition)
- Strategy Pattern (Polymorphism + Encapsulation)

### **📝 Reflection**

**1. Which OOP principle did you find most challenging and why?**

> Polymorphism was the most challenging as understanding virtual functions and overriding in runtime scenarios took more thinking and debugging experience.

**2. How does applying OOP concepts enhance code reusability and maintainability?**

> OOP promotes modular design. For example, inheritance reduces duplicate code, while encapsulation ensures internal logic update does not affect external code. This enhances reusability and maintainability.

**3. Reflect on a scenario where using OOP made a project easier to manage.**

> In a system of pet monitoring, the designation of a Pet base class and subclasses such as Dog, Cat, etc., simplified managing multiple animal types having common interfaces to simplify alerting logic and generation of reports.

### **🛠️ Task**

**1. Create a simple class hierarchy in C# demonstrating inheritance and polymorphism.**

- A class hierarchy (Inheritance + Polymorphism)
- The Factory Pattern
- Inline documentation

**2. Implement one design pattern (e.g., Factory or Singleton) in your example.**

```csharp
abstract class Vehicle
{
    public abstract void Drive();
}

class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Driving a car.");
    }
}

class Bike : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Riding a bike.");
    }
}
```

```csharp
class VehicleFactory
{
    public static Vehicle CreateVehicle(string type)
    {
        return type switch
        {
            "car" => new Car(),
            "bike" => new Bike(),
            _ => throw new ArgumentException("Unknown vehicle type")
        };
    }
}
```

```csharp
class Program
{
    static void Main()
    {
        Vehicle myVehicle = VehicleFactory.CreateVehicle("bike");
        myVehicle.Drive();  // Output: Riding a bike.
    }
}
```
