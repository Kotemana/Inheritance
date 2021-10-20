using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Cat : Animal
    {
        public bool HasBalls { get; set; }
        public override void SaySomething()
        {
            //string voice = HasBalls ? "meows" : "miiiiws";
            string voice;
            if (HasBalls)
            {
                voice = "meows";
            }
            else
            {
                voice = "miiiiws";
            }
            Console.WriteLine($"{Name} {voice}");
        }
    }
}
