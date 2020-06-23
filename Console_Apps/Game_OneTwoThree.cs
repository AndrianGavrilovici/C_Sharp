using System;
using System.Text;
namespace Game {
    class OneTwoThree {
        public OneTwoThree () {
            string[] items = new string[3];
            items[0] = "Stone";
            items[1] = "Scissors";
            items[2] = "Paper";
            string CPU = items[new Random().Next(items.Length)];
            Console.WriteLine ( "1) Stone \n2) Scissors \n3) Paper" );
            Console.Write ( "Your choice is ? : " );
            string User = items[Convert.ToInt32(Console.ReadLine()) - 1 ];
            Console.WriteLine ( "\nUser: " + User );
            Console.WriteLine ( "CPU: " + CPU );

            if ( (User == items[0] && CPU == items[1]) || (User == items[1] && CPU == items[2]) || (User == items[2] && CPU == items[0]) ) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ( "You Win!" );
            }
            else if ( (CPU == items[0] && User == items[1]) || (CPU == items[1] && User == items[2]) || (CPU == items[2] && User == items[0]) ) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ( "You Lose!" );
            }
            else {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine ( "You Draw!" );
            }
            Console.ResetColor();
            Console.WriteLine ( "Continue? y/n " );
            char key = Convert.ToChar (Console.ReadLine ());
            if (key != 'n' && key != 'N') new OneTwoThree ();
        }
        static void Main () {
            OneTwoThree start = new OneTwoThree ();
            Console.WriteLine ( "Developing by Gavrilovici" );
        }
    }
}
/* Console.ForegroundColor = ConsoleColor.Blue; - face terminalul albastru

    Console.ResetColor(); - restarteaza culoarea terminalului
*/