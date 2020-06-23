using System;
namespace Program3 {   
    class ProgramOperatorIf {
        static void Main () {
            double num;
            Console.WriteLine ( "How old are you?" );
            num = Convert.ToDouble ( Console.ReadLine() );
            if (num >= 18.0d)//daca ai mai mult de 18
                Console.WriteLine ( "You are older than 18" );
            else Console.WriteLine ( "You're smaller than that 18" );
            string name = num == 15 ? "First" : "Second" ;
            Console.WriteLine ( (name) );
            Console.ReadKey ();
        }
    }
}