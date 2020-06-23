using System;
using System.IO;
namespace LaboratoryOne
{
    class ReadAndShow
    {
        public ReadAndShow(TStudent[] st, string[] Group)
        {
            readInFile(st);
            Menu(st, Group);
        }
        static void Menu(TStudent[] st, string[] Group)
        {
            Console.Clear();
          
            ushort key;
            Console.WriteLine("1) Lista studentilor fiecarei grupe\n2) Lista studentilor restantieri\n3) Lista studentilor cu nota medie > 9\n4) Lista studentilor fara bursa\n5) Lista studentilor de gen feminin\n6) Lista studentilor dupa prenumele dat\n7) Afiseaza pe ecran toata informatia");
            colorRed();
            Console.WriteLine("9) Iesire");
            resetColor();
            Console.Write("RS: ");
            key = Convert.ToUInt16(Console.ReadLine());
            switch (key)
            {
                case 1:
                    ShowStudents(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 2:
                    Debtors(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 3:
                    NoteHingerThan9(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 4:
                    StudentsWithoutScholarship(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 5:
                    FemaleGender(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 6:
                    SearchForFirstName(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 7:
                    ShowAllProprietesStudents(st, Group);
                    Console.Write("Apasati un buton pentru a continua...");
                    Console.ReadKey();
                    Menu(st, Group);
                    break;
                case 8:
                    colorRed();
                    Console.WriteLine("Goodbye!\n");
                    resetColor();
                    break;
            }
        }
        static void colorRed()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        static void colorBlue()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        static void colorGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        static void resetColor()
        {
            Console.ResetColor();
        }
        static void readInFile(TStudent[] st)
        {
            using (StreamReader sr = File.OpenText(@"STUD.txt"))
            {
                for (int i = 0; i < 4; i++)
                {
                    int NumberOfStudents = Convert.ToInt32(sr.ReadLine());
                    st[i].Name = new string[NumberOfStudents];
                    st[i].FirstName = new string[NumberOfStudents];
                    st[i].DateBirth = new string[NumberOfStudents];
                    st[i].Sex = new string[NumberOfStudents];
                    st[i].YearRegistration = new int[NumberOfStudents];
                    st[i].Specialty = new string[NumberOfStudents];
                    st[i].SessionNotes = new int[NumberOfStudents, 4];
                    st[i].NM = new float[NumberOfStudents];
                    st[i].Scholarship = new float[NumberOfStudents];
                    for (int j = 0; j < NumberOfStudents; j++)
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
                sr.Close();
            }
            Console.WriteLine("\nDatele au fost extrase din fisier cu succes!\n");
        }
        static void ShowStudents(TStudent[] st, string[] Group)
        {
            Console.Clear();
            Console.WriteLine("Lista studentilor fiecarei grupe:");
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
                if (st[i].Name.Length == 0)
                    Console.WriteLine("Nu este nici un student in Grupa Aceasta");
                for (int j = 0; j < st[i].Name.Length; j++)
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
                if (st[i].Name.Length == 0)
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
                if (st[i].Name.Length == 0)
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
                if (st[i].Name.Length == 0)
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
            Console.WriteLine("\nToata informatia despre studenti:");
            for (int i = 0; i < 4; i++)
            {
                if (st[i].Name.Length != 0) Console.WriteLine(Group[i]);
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
            Console.WriteLine("\nToata informatia despre studenti a fost afisata cu succes!\n");
            return;
        }
    }
}
