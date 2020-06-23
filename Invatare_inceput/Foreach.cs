using System;
namespace Program7 {
    class Program_foreach {
        static void Main () {

            float[] numbers = {1.23f, 23.23f, 23.57f};
            //le ia pe toate fara a pune dimensiunea
            foreach (float el in numbers) {
                Console.WriteLine (el);
            }
        }
    }
}