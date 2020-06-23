using System;
namespace Program4 {
    class ProgramOperatorSwith {
        static void Main () {
            Random randNum = new Random ();
            int num;
            num = randNum.Next ( 1,6 );
            switch (num)
            {
                case 1:
                    Console.WriteLine ( "Num is -" + (num) );
                    break;
                case 2:
                    Console.WriteLine ( "Num is equal to " + (num) );
                    break;
                default:
                    Console.WriteLine ( "Nothing! " + (num) );
                    break;
            }
        }
    }
}