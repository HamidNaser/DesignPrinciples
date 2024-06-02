using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesDRY
{
    public class BonusCalculator
    {
        public double CalculateBonus(Employee employee, double bonusPercentage)
        {
            return employee.Salary * bonusPercentage;
        }
    }
}
