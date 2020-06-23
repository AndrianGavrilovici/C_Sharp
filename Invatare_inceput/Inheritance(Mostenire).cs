using System;
namespace Program15 {
    class Animal {
        public string Name { get; set; }
        Animal ( string name ) {
            Name = name;
        }
    }
    class Dog : Animal { /*Este mostenire de la Animal */
        private float speed;
        Dog ( float speed, string name ) : base ( name ) {
            this.speed = speed;

        }
    }
    class Inheritance {
        static void Main () {
            Dog tom = new Dog ( 12.23f, "Tom" );
            tom.Name = "Tom";
            Console.WriteLine (  );
        }
    }
}