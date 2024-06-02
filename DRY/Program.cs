using DesignPrinciplesDRY;

//
//  DRY (Don't Repeat Yourself)
//  Avoiding code duplication by abstracting common functionality.
//

var emp1 = new Employee { Name = "John", Salary = 100000 };
var emp2 = new Employee { Name = "Alen", Salary = 150000 };
BonusCalculator calculator = new BonusCalculator();

double bonus1 = calculator.CalculateBonus(emp1, 0.1);
double bonus2 = calculator.CalculateBonus(emp2, 0.1);

Console.WriteLine($"Bonus for {emp1.Name} is {bonus1}");
Console.WriteLine($"Bonus for {emp2.Name} is {bonus2}");
