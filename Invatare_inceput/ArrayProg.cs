using System;   //functiile principale
using System.Collections.Generic;   //foloseste Liste (lists)
namespace Program6 {
    class Program_Array {
        static void Main () {

            //Use int array
            int[] array = new int[6];
            array [0] = 24;
            array [1] = 7;
            array [2] = 2;
            array [3] = 4;
            array [4] = 8;
            array [5] = 56;
            for (int i = 0;i < array.Length; i++)
                Console.WriteLine ( array [i] + ", " );

            //Use string array
            string[] names = new string[3] {
                "Tom", "Jonh", "George"
            };
            for (int i = 0;i < names.Length; i++)
                Console.WriteLine ( names [i] + ", " );

            //Use Lists
            List<int> numbers = new List<int> ();
            numbers.Add (23);
            numbers.Add (34);
            numbers.Add (56);
            for (int i = 0;i < numbers.Count; i++)
                Console.Write ( numbers [i] + ", " );
            Console.WriteLine();
            numbers.RemoveAt (0);
            for (int i = 0;i < numbers.Count; i++)
                Console.Write ( numbers [i] + ", " );
            Console.WriteLine ( "\nAm eliminat primul numar" );
            numbers.Remove (56);
            for (int i = 0;i < numbers.Count; i++)
                Console.Write ( numbers [i] + ", " );
            Console.WriteLine ( "\nAm eliminat numarul 56" );

            //Use 2x Array
            int[,] Number = new int[5,5];
            Number [1, 2] = 97;
            Console.WriteLine ( Number [1, 2] );

            Console.WriteLine();
        }
    }
}