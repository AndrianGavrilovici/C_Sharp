using System;   //functiile principale
using System.Collections.Generic;   //foloseste Liste (lists)
namespace Program6 {
    class Program_Array {
        static void Main () {
            int length = 10;
            int[,] Number = new int[length,length];
            for (int i = 0;i < length;i++) {
                for (int j = 0;j < length;j++) {
                    Number [i, j] = i + j;
                    Console.Write ( Number [i, j] + " " );
                }
                Console.WriteLine ();
            }

            Console.WriteLine();
        }
    }
}