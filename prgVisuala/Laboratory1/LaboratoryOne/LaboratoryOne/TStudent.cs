using System;
namespace LaboratoryOne
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
}
