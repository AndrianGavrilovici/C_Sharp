using System;
namespace SquaresNumbers {
    class MainClass {
        static void Main () {
            for (int i = 1;i <= 10;i++){
                Console.WriteLine (i + " \t " + Math.Pow (i, 2));
                
            }
        }
    }
}