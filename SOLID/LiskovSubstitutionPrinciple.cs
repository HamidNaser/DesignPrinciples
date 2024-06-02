using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciplesSOLID
{
    internal class LiskovSubstitutionPrinciple
    {
        public void Fly(Bird bird)
        {
            bird.Fly();
        }
    }

    public abstract class Bird
    {
        public abstract void Fly();
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Ostrich is flying.");
        }
    }

    public class Ostrich : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

}
