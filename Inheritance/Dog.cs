using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Dog : Animal
    {
        public override void SaySomething()
        {
            Console.WriteLine($"{Name} barks");
        }
    }
}
