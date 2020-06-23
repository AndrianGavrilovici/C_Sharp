using System;
namespace Program13 {

    class Animal {
        public static int count = 0;
        /*static va fi accesibil numai pn aceasta clasa */
        public string name;
        public int age;
        public float hapiness;

        public Animal () {
            Console.WriteLine ( "\n______Am folosit constructorul______" );
            name = "Spotty";
            age  = 7;
            hapiness = 0.6f;
            count++;
            Print ();
        }
        public Animal ( string name, int age, float hapiness ) {/*Aceasta este constructor */
            Console.WriteLine ( "\n______Am folosit constructorul cu argumente______" );
            this.name = name;
            this.age = age;
            this.hapiness = hapiness;
            /*this arata ca este variabila clasei */
            count++;
            Print ();
        }
        public void Print () {/*Aceasta este functie */
            Console.WriteLine ( "Ati apelat la functia Print din clasa Animal :)" );
            Console.WriteLine ( "Name: " + name );
            Console.WriteLine ( "Age: " + age );
            Console.WriteLine ( "Hapiness: " + hapiness );
        }
    }
    class ProgramOperatorThis {
        static void Main () {
            Animal cat = new Animal ();/* Am declarat clasa animal */

            Animal dog = new Animal ( "Tom", 12, 0.99f );
            Console.WriteLine ( "Count of animals: " + (Animal.count) );
        }
    }
}