using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Poly
{
    public class Cat :Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void GiveVoice()
        {
            System.Console.WriteLine($"{_name} just yowl");
        }
    }
}
