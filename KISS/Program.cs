
using DesignPrinciplesKISS;
using System.Reflection.Emit;
using System.Reflection;
using System;
//
//  KISS(Keep It Simple, Stupid)
//  Keep the code simple and avoid unnecessary complexity.
//
Calculator calculator = new Calculator();
Console.WriteLine(calculator.Add(3, 4));
Console.WriteLine(calculator.Subtract(10, 5));
Console.WriteLine(calculator.Multiply(2, 3));
Console.WriteLine(calculator.Divide(8, 2));