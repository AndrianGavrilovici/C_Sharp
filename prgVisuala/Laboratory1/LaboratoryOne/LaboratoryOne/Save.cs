using System;
using System.IO;

namespace LaboratoryOne
{
    class Save
    {
        public Save(TStudent[] st)
        {
            StreamWriter sr = new StreamWriter(@"STUD.txt");
            for (int i = 0; i < 4; i++)
            {
                sr.WriteLine(st[i].Name.Length);
                for (int j = 0; j < st[i].Name.Length; j++)
                {
                    sr.Write(st[i].Name[j] + "\n" + st[i].FirstName[j] + "\n" + st[i].DateBirth[j] + "\n" + st[i].Sex[j] + "\n" + st[i].YearRegistration[j] + "\n" + st[i].Specialty[j] + "\n" + st[i].SessionNotes[j, 0] + "\n" + st[i].SessionNotes[j, 1] + "\n" + st[i].SessionNotes[j, 2] + "\n" + st[i].SessionNotes[j, 3] + "\n" + st[i].NM[j] + "\n" + st[i].Scholarship[j] + "\n");
                }
            }
            sr.Close();
            Console.WriteLine("A fost salvat cu succes!\n");
        }
    }
}
