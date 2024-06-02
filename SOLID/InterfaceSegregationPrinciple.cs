using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesSOLID
{
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
            Console.WriteLine("Printing in MultiFunctionPrinter.");
        }

        public void Scan()
        {
            Console.WriteLine("Scaning in MultiFunctionPrinter.");
        }
    }

    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing in SimplePrinter.");
        }
    }

}
