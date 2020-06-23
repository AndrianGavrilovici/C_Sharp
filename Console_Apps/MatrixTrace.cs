using System;
namespace MatrixTrace {
    class MainClass {
        static void Main () {
            Console.Clear ();
            Console.WriteLine ("Enter the number of rows and columns of the matrix: ");
            int n = Convert.ToInt32 (Console.ReadLine ());
            int[,] array = new int [n, n];
            Random random = new Random();
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    array [i, j] = random.Next (1, 100);
                }
            }
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    Console.Write ("{0} \t", array [i, j]);
                }
                Console.WriteLine ();
            }
            int Trace = 0;
            for (int i = 0; i < n; i++)
                Trace  += array [i, i];
            Console.WriteLine ("Trace = " + Trace);
        }
    }
}