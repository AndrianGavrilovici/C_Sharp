/*Sa se creeze un fisier text care va contine toate numerele intregi(in ordine crescatoare) cu modulul mai mic decat 200, cate 4 in fiecare rand*/
using System;
using System.IO;
namespace exOne {
    class Program {
        static void Main(string[] args) {
            Random rand = new Random();
            Console.Write ("Cate numere vreti sa se aleaga?\nRS: ");
            int num = Convert.ToInt32 (Console.ReadLine());
            int[] number = new int[num];
            for (int i = 0; i < num; i++) {
                number[i] = Convert.ToInt32(rand.Next(1, 200));
            }
            sort (number);
            saveInFile (number);
            foreach (int fromNumber in number) {
                Console.WriteLine (fromNumber);
            }
            Console.ReadKey ();
        }
        static void sort(int[] number) {
            for (int i = 0; i < number.Length - 1; i++) 
                for (int j = 0; j < number.Length - i - 1; j++) 
                    if (number[j] > number[j + 1]) {
                        int tempNum = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = tempNum;
                    }
        }
        static void saveInFile(int[] number) {
            StreamWriter fromNumber = new StreamWriter(@"STUD.txt");
            int count = 0;
            foreach (int num in number) {
                if (count == 4) {
                    count = 0;
                    fromNumber.WriteLine("");
                }
                if (count < 4) {
                    fromNumber.Write(num + " ");
                    count++;
                }
            }
            fromNumber.Close ();
            Console.WriteLine("Ati salvat cu succes!\n");
        }
    }
}
