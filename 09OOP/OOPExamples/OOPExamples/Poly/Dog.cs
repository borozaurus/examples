using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Poly
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void GiveVoice()
        {
            System.Console.WriteLine($"{_name} woof-woof");
        }

        public void EatBone()
        {
            System.Console.WriteLine($"mniam mniam");
        }

        public override void Move()
        {
            base.Move();
            System.Console.WriteLine(" VERY FAST");
        }
    }
}
