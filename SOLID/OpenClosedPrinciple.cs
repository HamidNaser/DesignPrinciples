using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesSOLID
{
    internal class OpenClosedPrinciple
    {
    }

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

}
