using System;
namespace Program7 {
    class ProgramFunction {
        static void Main () {
            WriteHello ( "Hi, Enter two numbers: " );

            int num = Convert.ToInt32 (Console.ReadLine ());
            int num_2 = Convert.ToInt32 (Console.ReadLine ());
            int result = Multiply (num, num_2);
            Console.WriteLine ( "Result is : " + result );
            Console.ReadKey ();
        }
        public static void WriteHello ( string str ) {
            Console.WriteLine ( str );
        }
        public static int Multiply ( int num1, int num2 ) {
            return num1 * num2;
        }
    }
}