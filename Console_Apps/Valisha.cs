using System;/*include biblioteca sisitem */
namespace valiusha {
    class proiect1 {
        static void Main () {
                Console.WriteLine ("salut valiusa!\n");
                int num1,num2;
                Console.Write ("introduce nr1: ");
                num1 = Convert.ToInt32 (Console.ReadLine ());
                Console.Write("Introduce nr2: ");
                num2=Convert.ToInt32(Console.ReadLine());
                Console.Write("alege operatia +,-,*,/: ");
                char op=Convert.ToChar(Console.ReadLine());
                if(op == '+'){
                    Console.WriteLine($"{num1} + {num2} = {num1+num2}\n");
                }
                else if(op == '-'){
                    Console.WriteLine($"{num1} - {num2} = {num1-num2}\n");
                }
                else if(op == '*'){
                    Console.WriteLine($"{num1} * {num2} = {num1*num2}\n");
                }
                else {
                    Console.WriteLine($"{num1} / {num2} = {(num1/num2)},{(num1%num2)}\n");
                }
                Main ();
        }
    }
}