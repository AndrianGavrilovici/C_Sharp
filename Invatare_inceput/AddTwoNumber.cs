using System;
namespace Program2 {
    class ProgramAddTWoNumber {
        static void Main () {
            float score =  2.35f;
            int num, num1;
            Console.WriteLine ( "Enter first num: " );
            num = Convert.ToInt32 ( Console.ReadLine() );
            Console.WriteLine ( "\nEnter secont num: " );
            num1 = Convert.ToInt32 ( Console.ReadLine() );
            Console.WriteLine ( "The result is: " + (num + num1).ToString() );
            Console.ReadKey ();
        }
    }
}