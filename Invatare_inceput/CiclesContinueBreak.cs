using System;
namespace Program {
    class Program5_Cicle_Break_Continue {
        static void Main () {
            Console.WriteLine ( "______Use for______" );
            for (int i = 1; i < 10; i++)
                Console.WriteLine ( i + "\n" );
            for (int i = 10; i >= 1; i--)
                Console.WriteLine ( i + "\n" );
            Console.WriteLine ( "______Use while______" );
            int j = 0;
            while ( j <= 10 ) {
                Console.Write ( j + " " );
                j++;
            }
            Console.WriteLine ( "\n______Use do_while______" );
            int Number;
            do {
               Console.Write ( "Enter number: " ); 
               Number = Convert.ToInt32 (Console.ReadLine ());
            } while ( Number != 5 );
            Console.WriteLine ( "______Use operator continue______" );
            for (int i = 0; i < 9; i++) {
                if ( i < 4 ) {
                    Console.WriteLine ( "A lasat nr " + ( i ) );
                    continue;
                }
                Console.WriteLine ( i + " " );
            }
        }
    }
}