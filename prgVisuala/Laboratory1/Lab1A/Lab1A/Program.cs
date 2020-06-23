using System;
namespace Lab1A
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
            for (int i = 0; i < NumberOfStudents; i++)
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
            string[] Group = new string[] {
                "Grupa 2I", "Grupa 2IM", "Grupa 2MI", "Grupa 2FI"
            };
            enterStudents(st, Group);
            showAllStudents(st, Group);
            Console.ReadKey();
        }
        static void enterStudents(TStudent[] st, string[] Group)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Group[i]);
                Console.Write("Nr. de studenti: ");
                int NumberOfStudents = Convert.ToInt32(Console.ReadLine());
                st[i].Name = new string[NumberOfStudents];
                st[i].FirstName = new string[NumberOfStudents];
                st[i].DateBirth = new string[NumberOfStudents];
                st[i].Sex = new string[NumberOfStudents];
                st[i].YearRegistration = new int[NumberOfStudents];
                st[i].Specialty = new string[NumberOfStudents];
                st[i].NM = new float[NumberOfStudents];
                st[i].Scholarship = new float[NumberOfStudents];
                st[i].SessionNotes = new int[NumberOfStudents, 4];
                for (int j = 0; j < NumberOfStudents; j++)
                {
                    Console.Write("Numele studentului {0}:", j + 1);
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
                    st[i].FormulaScholarship(NumberOfStudents);
                }
            }
            Console.WriteLine("\nAti introdus cu succes!\n");
        }
        static void showAllStudents(TStudent[] st, string[] Group)
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
        }
    }
}
