using System;

namespace Inheritance
{

    // base class
    class Animal
    {
        public string name;

        // constructor
        public Animal()
        {
            name = "";

        }
        //parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }

    }

    class Dog : Animal
    {
        public string breed;
        public int age;
        public string gender;

        public Dog()
            : base()
        {
            breed = string.Empty;
            age = 0;
            gender = string.Empty;
        }

        public Dog(string name, string breed, int age, string gender)
            : base(name)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
            this.gender = gender;
        }

        public void dogDisplay()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
        }

        class Cat : Animal
        {
            public string breed;
            public int age;
            public string gender;

            public Cat()
                : base()
            {
                breed = string.Empty;
                age = 0;
                gender = string.Empty;
            }

            public Cat(string name, string breed, int age, string gender)
                : base(name)
            {
                this.name = name;
                this.breed = breed;
                this.age = age;
                this.gender = gender;
            }

            public void catDisplay()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Breed: {breed}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Gender: {gender}");
            }
        }



        class Program
        {
            static void Main(string[] args)
            {
                // object of base class
                Animal myPet = new Animal();
                myPet.name = "Sparky";
                myPet.display();
                Console.WriteLine();

                // derived class object using default constructor
                Dog dog1 = new Dog();
                dog1.name = "Rufus";
                dog1.breed = "Great Dane";
                dog1.age = 4;
                dog1.gender = "Male";
                dog1.dogDisplay();
                Console.WriteLine();


                //derived class object using parameterized constructor
                Dog dog2 = new Dog("Rusty", "Siberian Husky", 5, "Male");
                dog2.dogDisplay();
                Console.WriteLine();


                // derived class object using default constructor
                Cat cat1 = new Cat();
                cat1.name = "Garfield";
                cat1.breed = "Orange";
                cat1.age = 6;
                cat1.gender = "Male";
                cat1.catDisplay();
                Console.WriteLine();


                //derived class object using parameterized constructor
                Cat cat2 = new Cat("Zelda", "Calico", 1, "Female");
                cat2.catDisplay();

                Console.ReadLine();
            }

        }
    }
}