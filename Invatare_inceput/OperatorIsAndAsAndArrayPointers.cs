using System;
using System.Collections.Generic;
namespace Program16 {
    class Animal {
        public string Name { get; set; }
        public Animal ( string name ) {
            Name = name;
        }
        public void Print () {
            Console.WriteLine ( Name );
        }
    }
    class Dog : Animal { /*Este mostenire de la Animal */
        private float speed;
        public Dog ( float speed, string name ) : base ( name ) {
            this.speed = speed;
        }
    }
    class Cat : Animal { /*Este mostenire de la Animal */
        private float speed;
        public Cat ( float speed, string name ) : base ( name ) {
            this.speed = speed;
        }
    }
    class IsAndAsAndArrayPointers {
        static void Main () {
            
            List<Animal> animals = new List<Animal> ();
            animals.Add (new Dog (12.23f, "Alex"));
            animals.Add (new Dog (14.3f, "Tom"));
            animals.Add (new Cat (16.3f, "Meow"));

            foreach ( Animal animal in animals ) {
                if ( animal is Cat )//arata numai ce este in clasa aceasta
                    Console.WriteLine ( animal.Name );
                if ( animal is Cat )
                    ( animal as Cat ).Print ();
            }
            
            Console.WriteLine ();
        }
    }
}