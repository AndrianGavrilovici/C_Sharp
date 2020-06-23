using System;
namespace Program11 {

    class Animal {
        public string name = "Spotty";
        public int age = 7;
        public float hapiness = 0.6f;
        public void Print () {
            Console.WriteLine ( "Ati apelat la functia Print din clasa Animal :)" );
            Console.WriteLine ( "Name: " + name );
            Console.WriteLine ( "Age: " + age );
            Console.WriteLine ( "Hapiness: " + hapiness );
        }
    }
    class ProgramClasses {
        static void Main () {
            Animal cat = new Animal ();/* Am declarat clasa animal */
            Console.WriteLine ( cat.name );
            cat.name = "Tom";
            Console.WriteLine ( cat.name );
            /* apelam la func Print din clasa Animal */
            cat.Print ();
        }
    }
}