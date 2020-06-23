using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    public struct TStudent
    {
        public string[] Name;
        public string[] FirstName;
        public string[] DateBirth;
        public string[] Sex;
        public int[] YearRegistration;
        public string[] Specialty;
        public int[,] SessionNotes;
        public float[] NM;
        public float[] Scholarship;
        public void FormulaScholarship(int NumberOfStudents)
        { 
           for(int i = 0; i < NumberOfStudents; i++)
            {
                NM[i] = (SessionNotes[i, 0] + SessionNotes[i, 1] + SessionNotes[i, 2] + SessionNotes[i, 3]) / 4f;
                if (NM[i] < 7) Scholarship[i] = 0;
                else if (NM[i] <= 7 || NM[i] < 8.5) Scholarship[i] = 450;
                else if (NM[i] >= 8.5) Scholarship[i] = NM[i] * 200;
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TStudent[] st = new TStudent[4];
            Menu(st);
            Console.WriteLine("cacova huia");
            Console.ReadKey();
        }
        static void Menu(TStudent[] st)
        {
            Console.Clear();
            string[] Group = new string[] {
                "Grupa 2I", "Grupa 2IM", "Grupa 2MI", "Grupa 2FI"
            };
            ushort key;
            Console.WriteLine("1) Extrage din fisier\n2) Adauga studenti\n3) Scrie lista noua\n4) Lista studentilor fiecarei grupe\n5) Lista studentilor restantieri\n6) Lista studentilor cu nota medie > 9\n7) Lista studentilor fara bursa\n8) Lista studentilor de gen feminin\n9) Lista studentilor dupa prenumele dat\n10) Afiseaza pe ecran toata informatia\n11) Salveaza in fisier");
            colorRed();
            Console.WriteLine("12) Exit");
            resetColor();
            Console.Write("RS: ");
            key = Convert.ToUInt16(Console.ReadLine());
            switch( key )
            {
                case 1:
                    Console.Clear();
                    ReadInFile(st);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 2:
                    AddStudents(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 3:
                    EnterStudents(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 4:
                    ShowStudents(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 5:
                    Debtors(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 6:
                    NoteHingerThan9(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 7:
                    StudentsWithoutScholarship(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 8:
                    FemaleGender(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 9:
                    SearchForFirstName(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 10:
                    ShowAllProprietesStudents(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 11:
                    SaveInFile(st);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st);
                    break;
                case 12:
                    colorRed();
                    Console.WriteLine("Goodbye!\n");
                    resetColor();
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
        }
        static void colorRed () {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void colorBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void colorGreen () {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        static void resetColor () {
            Console.ResetColor();
        }
        static void ReadInFile(TStudent[] st, int addNum = 0, int start = 0)
        {
            bool _Start = false;
            int _addNum = addNum;
            if(start != 0)
            {
                start--;
                _Start = true;
            }
            using (StreamReader sr = File.OpenText (@"STUD.txt"))
            {
                for (int i = 0; i < 4; i++)
                {
                    if(i == start && _Start)_addNum = addNum;
                    else _addNum = 0;
                    int NumberOfStudents = Convert.ToInt32(sr.ReadLine ());
                    st[i].Name = new string[NumberOfStudents + _addNum];
                    st[i].FirstName = new string[NumberOfStudents + _addNum];
                    st[i].DateBirth = new string[NumberOfStudents + _addNum];
                    st[i].Sex = new string[NumberOfStudents + _addNum];
                    st[i].YearRegistration = new int[NumberOfStudents + _addNum];
                    st[i].Specialty = new string[NumberOfStudents + _addNum];
                    st[i].SessionNotes = new int[NumberOfStudents + _addNum, 4];
                    st[i].NM = new float[NumberOfStudents + _addNum];
                    st[i].Scholarship = new float[NumberOfStudents + _addNum];
                    for(int j = 0; j < NumberOfStudents; j++)
                    {   
                        st[i].Name[j] = Convert.ToString(sr.ReadLine());
                        st[i].FirstName[j] = Convert.ToString(sr.ReadLine());
                        st[i].DateBirth[j] = Convert.ToString(sr.ReadLine());
                        st[i].Sex[j] = Convert.ToString(sr.ReadLine());
                        st[i].YearRegistration[j] = Convert.ToInt32(sr.ReadLine());
                        st[i].Specialty[j] = Convert.ToString(sr.ReadLine());
                        st[i].SessionNotes[j, 0] = Convert.ToInt32(sr.ReadLine());
                        st[i].SessionNotes[j, 1] = Convert.ToInt32(sr.ReadLine());
                        st[i].SessionNotes[j, 2] = Convert.ToInt32(sr.ReadLine());
                        st[i].SessionNotes[j, 3] = Convert.ToInt32(sr.ReadLine());
                        st[i].NM[j] = Convert.ToSingle(sr.ReadLine());
                        st[i].Scholarship[j] = Convert.ToSingle(sr.ReadLine());
                        st[i].FormulaScholarship(NumberOfStudents);
                    }
                }
                sr.Close ();
            }
            colorGreen();
            Console.WriteLine("\nDatele au fost extrase din fisier cu succes!\n");
            resetColor();
            return;
        }
        static void AddStudents(TStudent[] st, string[] Group)
        {
            int[] _lengthStudents = new int[4];
            SaveInFile(st);
            for(int i = 0; i < 4; i++)
            {
                Console.Write("Cati studenti vreti sa adaugati in {0}?\nRS: ", Group[i]);
                int addNum = Convert.ToInt32(Console.ReadLine());
                int num = st[i].Name.Length + addNum;
                _lengthStudents[i] = st[i].Name.Length;
                
                ReadInFile(st, addNum, i + 1);
                for(int j = _lengthStudents[i]; j < num; j++)
                {
                    Console.Write("Numele studentului {0}:", j+1);
                    st[i].Name[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Prenumele studentului {0}:", j + 1);
                    st[i].FirstName[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Data nasterii studentului {0}:", j + 1);
                    st[i].DateBirth[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Genul studentului {0}:", j + 1);
                    st[i].Sex[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Anul inmatricularii studentului {0}:", j + 1);
                    st[i].YearRegistration[j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Specialitatea studentului {0}:", j + 1);
                    st[i].Specialty[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Nota 1 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nota 2 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nota 3 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 2] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nota 4 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 3] = Convert.ToInt32(Console.ReadLine());
                    st[i].FormulaScholarship(num);
                }
            }
        }
        static void EnterStudents(TStudent[] st, string[] Group)
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                Console.Write("Nr. de studenti: ");
                int NumberOfStudents = Convert.ToInt32(Console.ReadLine ());
                st[i].Name = new string[NumberOfStudents];
                st[i].FirstName = new string[NumberOfStudents];
                st[i].DateBirth = new string[NumberOfStudents];
                st[i].Sex = new string[NumberOfStudents];
                st[i].YearRegistration = new int[NumberOfStudents];
                st[i].Specialty = new string[NumberOfStudents];
                st[i].NM = new float[NumberOfStudents];
                st[i].Scholarship = new float[NumberOfStudents];
                st[i].SessionNotes = new int[NumberOfStudents, 4];
                for(int j = 0; j < NumberOfStudents; j++)
                {   
                    Console.Write("Numele studentului {0}:", j+1);
                    st[i].Name[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Prenumele studentului {0}:", j+1);
                    st[i].FirstName[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Data nasterii studentului {0}:", j + 1);
                    st[i].DateBirth[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Genul studentului {0}:", j + 1);
                    st[i].Sex[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Anul inmatricularii studentului {0}:", j + 1);
                    st[i].YearRegistration[j] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Specialitatea studentului {0}:", j + 1);
                    st[i].Specialty[j] = Convert.ToString(Console.ReadLine());
                    Console.Write("Nota 1 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 0] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nota 2 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 1] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nota 3 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 2] = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nota 4 studentului {0}:", j + 1);
                    st[i].SessionNotes[j, 3] = Convert.ToInt32(Console.ReadLine());
                    st[i].FormulaScholarship(NumberOfStudents);
                }  
            }
            colorGreen();
            Console.WriteLine("\nAti introdus cu succes!\n");
            resetColor();
            return;
        }
        static void ShowStudents(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("Lista studentilor fiecarei grupe:");
            for(int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if(st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici un student in Grupa Aceasta");
                for(int j = 0; j < st[i].Name.Length; j++)
                    Console.WriteLine("{0} {1}", st[i].Name[j], st[i].FirstName[j]);
            }
            colorGreen();
            Console.WriteLine("\nLista studentilor a fost afisata cu succes!\n");
            resetColor();
            
            return;
        }
        static void Debtors(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("\nLista restantierilor:");
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if (st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici un student in Grupa Aceasta");
                ushort Verification = 0;
                for (int j = 0; j < st[i].Name.Length; j++)
                    if (st[i].NM[j] < 5)
                    {
                        Console.WriteLine("{0} {1}", st[i].Name[j], st[i].FirstName[j]);
                        Verification++;
                    }
                if (st[i].Name.Length != 0 && Verification == 0)
                    Console.WriteLine("In grupa aceasta nu exista restantieri");

            }
            colorGreen();
            Console.WriteLine("\nLista restantierilor a fost afisata cu succes!\n");
            resetColor();
            return;
        }
        static void NoteHingerThan9(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("\nLista studentilor cu nota medie mai mare decat 9:");
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if(st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici un student in Grupa Aceasta\n");
                ushort Verification = 0;
                for (int j = 0; j < st[i].Name.Length; j++)
                    if (st[i].NM[j] > 9)
                    {
                        Console.WriteLine("{0} {1}", st[i].Name[j], st[i].FirstName[j]);
                        Verification++;
                    }

                if (st[i].Name.Length != 0 && Verification == 0)
                    Console.WriteLine("In grupa aceasta nu exista studenti cu NM > 9");
            }
            colorGreen();
            Console.WriteLine("\nLista studentilor cu NM > 9 a fost afisata cu succes!\n");
            resetColor();
            return;
        }
        static void StudentsWithoutScholarship(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("\nLista studentilor fara bursa:");
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if(st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici un student in Grupa Aceasta");
                ushort Verification = 0;
                for (int j = 0; j < st[i].Name.Length; j++)
                    if (st[i].Scholarship[j] == 0)
                    {
                        Console.WriteLine("{0} {1}", st[i].Name[j], st[i].FirstName[j]);
                        Verification++;
                    }
                if (st[i].Name.Length != 0 && Verification == 0)
                    Console.WriteLine("In grupa aceasta nu sunt studenti fara bursa");
            }
            colorGreen();
            Console.WriteLine("\nLista studentilor fara bursa a fost afisata cu succes!\n");
            resetColor();
            return;
        }
        static void FemaleGender(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("\nLista studentilor de gen feminin:");
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if(st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici o studenta in Grupa Aceasta\n");
                ushort Verification = 0;
                for (int j = 0; j < st[i].Name.Length; j++)
                    if (st[i].Sex[j].Equals("Feminin"))
                    {
                        Console.WriteLine("{0} {1}", st[i].Name[j], st[i].FirstName[j]);
                        Verification++;
                    }
                if (st[i].Name.Length != 0 && Verification == 0)
                    Console.WriteLine("In grupa aceasta nu sunt studenti de gen feminin");
            }
            colorGreen();
            Console.WriteLine("\nLista studentilor de gen feminin a fost afisata cu succes!\n");
            resetColor();
            return;
        }
        static void SearchForFirstName(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.Write("Introduceti prenumele: ");
            string Search = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\nLista dupa prenumele dat:");
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if (st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici un student in Grupa Aceasta");
                ushort Verification = 0;
                for (int j = 0; j < st[i].Name.Length; j++)
                    if (st[i].FirstName[j].Equals(Search))
                    {
                        Console.WriteLine("{0} {1}", st[i].Name[j], st[i].FirstName[j]);
                        Verification++;
                    }
                if (st[i].Name.Length != 0 && Verification == 0)
                    Console.WriteLine("In grupa aceasta nu sunt studenti cu asa prenume");
            }
            colorGreen();
            Console.WriteLine("\nLista studentilor dupa prenumele dat a fost afisata cu succes!\n");
            resetColor();
            return;
        }
        static void ShowAllProprietesStudents(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("\nToata informatia despre studenti:");
            for(int i = 0; i < 4; i++)
            {
                colorBlue();
                if(st[i].Name.Length != 0)Console.WriteLine(Group[i]);
                resetColor();
                for (int j = 0; j < st[i].Name.Length; j++)
                {
                    Console.WriteLine("Numele studentului {0}: {1}", j + 1, st[i].Name[j]);
                    Console.WriteLine("Prenumele studentului {0}: {1}", j + 1, st[i].FirstName[j]);
                    Console.WriteLine("Data nasterii studentului {0}: {1}", j + 1, st[i].DateBirth[j]);
                    Console.WriteLine("Genul studentului {0}: {1}", j + 1, st[i].Sex[j]);
                    Console.WriteLine("Anul inmatricularii studentului {0}: {1}", j + 1, st[i].YearRegistration[j]);
                    Console.WriteLine("Specialitatea studentului {0}: {1}", j + 1, st[i].Specialty[j]);
                    Console.WriteLine("Nota 1 studentului {0}: {1}", j + 1, st[i].SessionNotes[j, 0]);
                    Console.WriteLine("Nota 2 studentului {0}: {1}", j + 1, st[i].SessionNotes[j, 1]);
                    Console.WriteLine("Nota 3 studentului {0}: {1}", j + 1, st[i].SessionNotes[j, 2]);
                    Console.WriteLine("Nota 4 studentului {0}: {1}", j + 1, st[i].SessionNotes[j, 3]);
                    Console.WriteLine("Media studentului {0}: {1}", j + 1, st[i].NM[j]);
                    Console.WriteLine("Bursa studentului {0}: {1}\n", j + 1, st[i].Scholarship[j]);
                }
            }
            colorGreen();
            Console.WriteLine("\nToata informatia despre studenti a fost afisata cu succes!\n");
            resetColor();
            return;
        }
        static void SaveInFile(TStudent[] st)
        {
            Console.Clear();
            StreamWriter sr = new StreamWriter(@"STUD.txt");
            for (int i = 0; i < 4; i++) {
                sr.WriteLine(st[i].Name.Length);
                for (int j = 0; j < st[i].Name.Length; j++)
                {
                    sr.Write(st[i].Name[j]+"\n"+st[i].FirstName[j]+"\n"+st[i].DateBirth[j]+"\n"+st[i].Sex[j]+"\n"+st[i].YearRegistration[j]+"\n"+st[i].Specialty[j]+"\n"+st[i].SessionNotes[j, 0]+"\n"+st[i].SessionNotes[j, 1]+"\n"+st[i].SessionNotes[j, 2]+"\n"+st[i].SessionNotes[j, 3]+"\n"+st[i].NM[j]+"\n"+st[i].Scholarship[j]+"\n");
                }
            }
            sr.Close ();
            colorGreen();
            Console.WriteLine("Ati salvat cu succes!\n");
            resetColor();
            return;

        }
    }
}
