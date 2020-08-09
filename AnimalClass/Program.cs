using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AnimalClass
{
   public abstract class Animal
   {
        protected object AAnimal;
        protected abstract void Move();
        protected abstract void Eat(string FoodType);
        public Animal(object anmal)
        {
            this.AAnimal = anmal;
        }
   }
    public class Dog : Animal
    {
      public Dog(object anmal):base(anmal)
      {
            AAnimal = anmal;
      }

        protected override void Eat(string FoodType)
        {
            Console.WriteLine(" Dog foodtype is Meat"+FoodType);
        }

        protected override void Move()
        {
            Console.WriteLine("Dog move fastly");
        }

    }
    public class Cat : Animal
    {
        public Cat(string animal):base(animal)
        {
            AAnimal = animal;
        }

        protected override void Eat(string FoodType)
        {
            Console.WriteLine("cat foodtype is Meat" + FoodType);


        }

        protected override void Move()
        {
            Console.WriteLine("Cat move fastly");

        }
    }
    public class Goat : Animal
    {
        public Goat(string animal) : base(animal)
        {
            AAnimal = animal;
        }
        protected override void Eat(string FoodType)
        {
            Console.WriteLine("Goat foodtype is harbivore" + FoodType);

        }

        protected override void Move()
        {
            Console.WriteLine("Goat move fastly");
        }
    }
    public class Human : Animal
    {
        public Human(string animal) : base(animal)
        {
            AAnimal = animal;
        }
        protected override void Eat(string FoodType)
        {
            Console.WriteLine("human foodtype is both " + FoodType);
        }

        protected override void Move()
        {
            Console.WriteLine("Goat move Slowly");
        }
    }
    public class Lion : Animal
    {
        public Lion(string animal) : base(animal)
        {
            AAnimal = animal;
        }

        protected override void Eat(string FoodType)
        {
            Console.WriteLine("Lion foodtype is Meat" + FoodType);

        }

        protected override void Move()
        {
            Console.WriteLine("Lion move very fastly");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var arraylist = new ArrayList();
            int count = 1;
            object addanimal=null;
            while(count!=5)
            {
                Console.WriteLine("enter a number to select the animal... ");
                int choice=Convert.ToInt32(Console.ReadLine());
                if(choice==1)
                {
                    Console.WriteLine("Add animal Dog... ");
                     string add = Console.ReadLine();
                     d = new Dog(add);
                    arraylist.Add(d);
                    count++;
                }
                if (choice == 2)
                {
                    Console.WriteLine("Add animal cat... ");
                    object add = Console.ReadLine();
                     addanimal = new Cat(add);
                    arraylist.Add(d);
                    count++;
                }
                if (choice == 3)
                {
                    Console.WriteLine("Add animal Goat... ");
                    object add = Console.ReadLine();
                     d = new Goat(add);
                    arraylist.Add(d);
                    count++;
                }
                if (choice == 4)
                {
                    Console.WriteLine("Add  human... ");
                    object add = Console.ReadLine();
                     addanimal = new Human(add);
                    arraylist.Add(d);
                    count++;
                }
                if (choice == 5)
                {
                    Console.WriteLine("Add animal Lion... ");
                    object add = Console.ReadLine();
                     addanimal = new Lion(add);
                    arraylist.Add(d);
                    count++;
                }
                
            }
           //completed it.....
            Console.ReadLine();
        }
    }
}
