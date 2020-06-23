using System;
namespace exOne {
    class Student {
        private string nume;
        private string prenume;
        private int ziuaNasterii;
        private int lunaNasterii;
        private int anulNasterii;
        private double inaltimea;
        private double greutatea;
        private int anulInmatricularii;
        private int[] note = new int[3];

        public Student(string nume, string prenume, int ziuaNasterii, int lunaNasterii, int anulNasterii, double inaltimea, double greutatea, int anulInmatricularii
            , int[] note) {
            this.nume = nume;
            this.prenume = prenume;
            this.ziuaNasterii = ziuaNasterii;
            this.lunaNasterii = lunaNasterii;
            this.anulNasterii = anulNasterii;
            this.inaltimea = inaltimea;
            this.greutatea = greutatea;
            this.anulInmatricularii = anulInmatricularii;
            for (int i = 0; i < this.note.Length; i++) {
                this.note[i] = note[i];
            }
        }
        public string DV() {
                int ziuaCurenta, lunaCurenta, anulCurent;
                ziuaCurenta = Convert.ToInt32(DateTime.Now.ToString("dd"));
                lunaCurenta = Convert.ToInt32(DateTime.Now.ToString("MM"));
                anulCurent = Convert.ToInt32(DateTime.Now.ToString("yyyy"));
                int ziuaFinala = 0, lunaFinala = 0, anulFinal = 0;
                anulFinal = Convert.ToInt32(anulCurent - anulNasterii);
                //luna curenta mai mare ca luna nasterii
                if (lunaCurenta > lunaNasterii) {
                    lunaFinala = Convert.ToInt32(lunaCurenta - lunaNasterii);                    
                    ControlData(ref ziuaNasterii, ref ziuaCurenta, ref ziuaFinala, ref lunaFinala, ref anulFinal);
                }
                //luna nasterii mai mare ca luna curenta
                else if (lunaNasterii > lunaCurenta) {
                    int b_temp = Convert.ToInt32(lunaNasterii - lunaCurenta);
                    lunaFinala = Convert.ToInt32(12 - b_temp);
                    anulFinal--;
                    //Controlarea datei
                    if (ziuaNasterii > ziuaCurenta)
                        lunaFinala++;
                    ControlData(ref ziuaNasterii, ref ziuaCurenta, ref ziuaFinala, ref lunaFinala, ref anulFinal);
                }
                //luni egale
                else {
                    //data nasterii mai mare ca data curenta
                    ControlData(ref ziuaNasterii, ref ziuaCurenta, ref ziuaFinala, ref lunaFinala, ref anulFinal);
                }
                return anulFinal.ToString() + " ani " + lunaFinala.ToString() + " luni " + ziuaFinala.ToString() + " zile";
        }
        private static void ControlData(ref int ziuaNasterii, ref int ziuaCurenta, ref int ziuaFinala, ref int lunaFinala, ref int anulFinal) {
            //data curenta mai mare ca data nasterii
            if (ziuaCurenta > ziuaNasterii) {
                ziuaFinala = ziuaCurenta - ziuaNasterii;
            }
            //data nasterii mai mare ca data curenta
            else if (ziuaNasterii > ziuaCurenta) {
                
                if (lunaFinala > 0)
                    lunaFinala--;
                else {
                    anulFinal--;
                    lunaFinala = 11;
                }
                int temp = ziuaNasterii - ziuaCurenta;
                ziuaFinala = 31 - temp;
            }
        }
        public int AN(){
            return Convert.ToInt32(DateTime.Now.ToString("yyyy")) - anulInmatricularii;
        }
        public double NM(){
            return (note[0] + note[1] + note[2]) / 3.0;
        }
        public bool Bursa(){
            if (NM() > 7)
                return true;
            else return false;
        }
    }
    class Program {
        static void Main(string[] args) {
            string nume;
            string prenume;
            int ziuaNasterii;
            int lunaNasterii;
            int anulNasterii;
            double inaltimea;
            double greutatea;
            int anulInmatricularii;
            int[] note = new int[3];
            
            Console.Write("Nume: ");
            nume = Convert.ToString(Console.ReadLine());
            Console.Write("Prenume: ");
            prenume = Convert.ToString(Console.ReadLine());
            Console.Write("Ziua nasterii: ");
            ziuaNasterii = Convert.ToInt32(Console.ReadLine());
            Console.Write("Luna nasterii: ");
            lunaNasterii = Convert.ToInt32(Console.ReadLine());
            Console.Write("Anul nasterii: ");
            anulNasterii = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inaltimea: ");
            inaltimea = Convert.ToDouble(Console.ReadLine());
            Console.Write("Greutatea: ");
            greutatea = Convert.ToDouble(Console.ReadLine());
            Console.Write("Anul inmatricularii: ");
            anulInmatricularii = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < note.Length; i++) {
                Console.Write("Nota {0}: ", i + 1);
                note[i] = Convert.ToInt32(Console.ReadLine());
            }

            Student student = new Student(nume, prenume, ziuaNasterii, lunaNasterii, anulNasterii, inaltimea, greutatea, anulInmatricularii, note);

            Console.WriteLine("Nume: {0}", nume);
            Console.WriteLine("Prenume: {0}", prenume);
            Console.WriteLine("Are: {0}", student.DV());
            Console.WriteLine("Ani in universitate: {0}", student.AN());
            Console.WriteLine("Nota medie: {0}", student.NM());
            string bursa;
            if (student.Bursa()) bursa = "Are!";
            else bursa = "Nu are!";
            Console.WriteLine("Bursa: {0}", bursa);
            Console.ReadKey();
        }
    }
}
