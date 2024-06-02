
using DesignPrinciplesSOLID;
using System.Reflection.Emit;
using System.Reflection;

//
// Single Responsibility Principle (SRP)
// A class should have only one reason to change, meaning it should have only one job or responsibility.
//
var report = new ReportGenerator().GenerateReport();
new ReportSaver().SaveReport(report);


//
//  Open / Closed Principle(OCP)
//  Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
//
var bonus = new PermanentEmployee().CalculateBonus(100000);
bonus = new TemporaryEmployee().CalculateBonus(100000);

//
//  Liskov Substitution Principle (LSP)
//  Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
//
Sparrow sparrow = new Sparrow();
Ostrich ostrich = new Ostrich();

new LiskovSubstitutionPrinciple().Fly(sparrow);
new LiskovSubstitutionPrinciple().Fly(ostrich);

//
//  Interface Segregation Principle (ISP)
//  Clients should not be forced to depend on interfaces they do not use.
//
new MultiFunctionPrinter().Print();
new MultiFunctionPrinter().Scan();

new SimplePrinter().Print();

IPrinter printer = new SimplePrinter(); ;
printer.Print();
printer = new MultiFunctionPrinter(); 
printer.Print();

//
//  Dependency Inversion Principle (DIP)
//  High - level modules should not depend on low-level modules. Both should depend on abstractions.
//
new OrderProcessor(new FileLogger()).ProcessOrder();
new OrderProcessor(new ConsoleLogger()).ProcessOrder();
