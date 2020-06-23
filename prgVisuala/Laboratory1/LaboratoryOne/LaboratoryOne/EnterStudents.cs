using System;
namespace LaboratoryOne
{
    class EnterStudents
    {
        public EnterStudents(TStudent[] st, string[] Group)
        {
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                colorBlue();
                Console.WriteLine(Group[i]);
                resetColor();
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
            colorGreen();
            Console.WriteLine("\nAti introdus cu succes!\n");
            resetColor();
            return;
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
    }
}
