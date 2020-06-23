using System;
namespace Numbers {
    class ColoredNumbers {
        static void Main () {
            Console.Title = " Example ";//pune titlu la consola
            Console.Write ( "Number of numbers: " );
            int[] numbers = new int[Convert.ToInt32 (Console.ReadLine ())];
            Console.WriteLine ( "Typing from keyboard or random?\nRandom - y\tKeyboard - n" );
            char key = Convert.ToChar (Console.ReadLine ());
            if ( key == 'n' ) {
                for (int i = 0;i < numbers.Length;i++) {
                    Console.Write ( "Numbers ["+i+"] = " );
                    numbers [i] = Convert.ToInt32 (Console.ReadLine ());
                }
            } 
            else {
                Random random = new Random ();
                for (int i = 0;i < numbers.Length;i++)
                    numbers [i] = random.Next (1, 100);
            }
            for (int i = 0;i < numbers.Length;i++) {
                if (numbers [i] % 2 == 0) {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ( numbers [i] );
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ( numbers [i] );
                }
            }
            Console.ResetColor();
        }
    }
}