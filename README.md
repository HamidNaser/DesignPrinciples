### 🚀 SOLID Principles

✅ Single Responsibility Principle (SRP)
A class should have only one reason to change, meaning it should have only one job or responsibility.

```csharp
public class ReportGenerator
{
    public string GenerateReport()
    {
        // Generate the report
        return "Report content";
    }
}

public class ReportSaver
{
    public void SaveReport(string reportContent)
    {
        // Save the report to a file
        System.IO.File.WriteAllText("report.txt", reportContent);
    }
}
```

✅ Open/Closed Principle (OCP)
Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.

```csharp
public abstract class Employee
{
    public abstract double CalculateBonus(double salary);
}

public class PermanentEmployee : Employee
{
    public override double CalculateBonus(double salary)
    {
        return salary * 0.1;
    }
}

public class TemporaryEmployee : Employee
{
    public override double CalculateBonus(double salary)
    {
        return salary * 0.05;
    }
}
```

✅ Liskov Substitution Principle (LSP)
Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.

```csharp
public abstract class Bird
{
    public abstract void Fly();
}

public class Sparrow : Bird
{
    public override void Fly()
    {
        // Implement flying for Sparrow
    }
}

public class Ostrich : Bird
{
    public override void Fly()
    {
        throw new NotImplementedException(); // Ostriches can't fly
    }
}
```

✅ Interface Segregation Principle (ISP)
Clients should not be forced to depend on interfaces they do not use.

```csharp
public interface IPrinter
{
    void Print();
}

public interface IScanner
{
    void Scan();
}

public class MultiFunctionPrinter : IPrinter, IScanner
{
    public void Print()
    {
        // Print logic
    }

    public void Scan()
    {
        // Scan logic
    }
}

public class SimplePrinter : IPrinter
{
    public void Print()
    {
        // Print logic
    }
}
```

✅ Dependency Inversion Principle (DIP)
High-level modules should not depend on low-level modules. Both should depend on abstractions.

```csharp
public interface ILogger
{
    void Log(string message);
}

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        System.IO.File.WriteAllText("log.txt", message);
    }
}

public class OrderProcessor
{
    private readonly ILogger _logger;

    public OrderProcessor(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessOrder()
    {
        // Process order
        _logger.Log("Order processed");
    }
}
```

### 🚀 DRY (Don't Repeat Yourself)
Avoiding code duplication by abstracting common functionality.

```csharp
public class Employee
{
    public string Name { get; set; }
    public double Salary { get; set; }
}

public class BonusCalculator
{
    public double CalculateBonus(Employee employee, double bonusPercentage)
    {
        return employee.Salary * bonusPercentage;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp = new Employee { Name = "John", Salary = 1000 };
        BonusCalculator calculator = new BonusCalculator();
        double bonus = calculator.CalculateBonus(emp, 0.1);
        Console.WriteLine($"Bonus for {emp.Name} is {bonus}");
    }
}
```

### 🚀 KISS (Keep It Simple, Stupid)
Keep the code simple and avoid unnecessary complexity.

```csharp
public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero is not allowed.");
        }
        return a / b;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();
        Console.WriteLine(calculator.Add(3, 4));
        Console.WriteLine(calculator.Subtract(10, 5));
        Console.WriteLine(calculator.Multiply(2, 3));
        Console.WriteLine(calculator.Divide(8, 2));
    }
}
```
