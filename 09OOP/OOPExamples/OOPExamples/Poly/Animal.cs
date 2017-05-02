using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExamples.Poly
{
    public abstract class Animal
    {
        protected string _name;

        protected Animal(string name)
        {
            _name = name;
        }

        public abstract void GiveVoice();

        public virtual void Move()
        {
            System.Console.WriteLine($"{_name} is moving .....");

        }
    }

    public static class Test02
    {
        public static void DoTest()
        {
            var animals = new List<Animal>()
            {
                new Dog("Azor"),
                new Cat("Flafy"),
                new GermanShepard("Nora")
            };

            foreach (var animal in animals)
            {
                animal.GiveVoice();
                animal.Move();
            }

            /////////////////////////////////////////////////
            var myAnimal = animals[0];
            if (myAnimal is Dog)
            {
                Console.WriteLine("My animal is dog");
                Dog myDog = (Dog) myAnimal;
                myDog.EatBone();
            }

            /////////////////////////////////////////////////
            foreach (var animal in animals)
            {
                var myDog = animal as Dog;
                if (myDog != null)
                {
                    myDog.EatBone();
                }
            }
        }
    }
}
