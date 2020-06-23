using System;
namespace Program15 {
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
            Console.WriteLine ( "Speed: " + speed );
        }
    }
    class Inheritance {
        static void Main () {
            Dog tom = new Dog ( 12.23f, "Tom" );
            Console.WriteLine ( "Name: " + tom.Name );
            Dog jerry = new Dog ( 23.2f, "Jerry" );
            Console.WriteLine ( "Name: " + jerry.Name );
            Console.WriteLine ();
            jerry.Print ();
        }
    }
}