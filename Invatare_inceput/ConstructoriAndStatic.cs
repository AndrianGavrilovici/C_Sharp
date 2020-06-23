using System;
namespace Program12 {

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
        public Animal ( string _name, int _age, float _hapiness ) {
            Console.WriteLine ( "\n______Am folosit constructorul cu argumente______" );
            name = _name;
            age  = _age;
            hapiness = _hapiness;
            count++;
            Print ();
        }
        public void Print () {
            Console.WriteLine ( "Ati apelat la functia Print din clasa Animal :)" );
            Console.WriteLine ( "Name: " + name );
            Console.WriteLine ( "Age: " + age );
            Console.WriteLine ( "Hapiness: " + hapiness );
        }
    }
    class ProgramConstructorsAndStatic {
        static void Main () {
            Animal cat = new Animal ();/* Am declarat clasa animal */
            Console.WriteLine ( "\nFolosim func Print din prg Principal" );
            cat.Print ();//apelam func Print in prg principal
            Animal.count++;/* ne adresam la count cu clasa din cauza static */
            Animal dog = new Animal ( "Tom", 12, 0.99f );
            Console.WriteLine ( "Count of animals: " + (Animal.count - 1) );
        }
    }
}