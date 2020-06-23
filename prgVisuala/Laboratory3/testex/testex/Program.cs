using System;

namespace testex {
    class Program {
        static void Main(string[] args) {
                
                int dataCurenta, lunaCurenta, anulCurent;
                dataCurenta = Convert.ToInt32(DateTime.Now.ToString("dd"));
                lunaCurenta = Convert.ToInt32(DateTime.Now.ToString("MM"));
                anulCurent = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                
                Console.WriteLine("data_curenta: {0}", DateTime.Now.ToString("dd"));
                Console.WriteLine("luna_curenta: {0}", DateTime.Now.ToString("MM"));
                Console.WriteLine("anul_curent: {0}", anulCurent);

                int dataNasterii, lunaNasterii, anulNasterii;

                Console.Write("data: ");
                dataNasterii = Convert.ToInt32(Console.ReadLine());
                Console.Write("luna: ");
                lunaNasterii = Convert.ToInt32(Console.ReadLine());
                Console.Write("anul: ");
                anulNasterii = Convert.ToInt32(Console.ReadLine());

                int dataFinala = 0, lunaFinala = 0, anulFinal = 0;
                anulFinal = Convert.ToInt32(anulCurent - anulNasterii);

                //luna curenta mai mare ca luna nasterii
                if (lunaCurenta > lunaNasterii) {
                    lunaFinala = Convert.ToInt32(lunaCurenta - lunaNasterii);
                    
                    ControlData(ref dataNasterii, ref dataCurenta, ref dataFinala, ref lunaFinala, ref anulFinal);
                }
                //luna nasterii mai mare ca luna curenta
                else if (lunaNasterii > lunaCurenta) {
                    int b_temp = Convert.ToInt32(lunaNasterii - lunaCurenta);
                    lunaFinala = Convert.ToInt32(12 - b_temp);
                    anulFinal--;
                    //Controlarea datei
                    if (dataNasterii > dataCurenta)
                        lunaFinala++;
                    ControlData(ref dataNasterii, ref dataCurenta, ref dataFinala, ref lunaFinala, ref anulFinal);
                }
                //luni egale
                else {
                    //data nasterii mai mare ca data curenta
                    ControlData(ref dataNasterii, ref dataCurenta, ref dataFinala, ref lunaFinala, ref anulFinal);
                }
                Console.WriteLine("aveti: {0} ani {1} luni {2} zile", anulFinal, lunaFinala, dataFinala);                
                Console.ReadLine();         
        }
        private static void ControlData(ref int dataNasterii, ref int dataCurenta, ref int dataFinala, ref int lunaFinala, ref int anulFinal) {
            //data curenta mai mare ca data nasterii
            if (dataCurenta > dataNasterii) {
                dataFinala = dataCurenta - dataNasterii;
            }
            //data nasterii mai mare ca data curenta
            else if (dataNasterii > dataCurenta) {
                
                if (lunaFinala > 0)
                    lunaFinala--;
                else {
                    anulFinal--;
                    lunaFinala = 11;
                }
                int temp = dataNasterii - dataCurenta;
                dataFinala = 31 - temp;
            }
        }
    }
}
