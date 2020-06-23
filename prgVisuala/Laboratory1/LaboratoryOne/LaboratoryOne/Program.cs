using System;
namespace LaboratoryOne
{
    class Program
    {
        static void Main()
        {
            TStudent[] st = new TStudent[4];
            string[] Group = new string[] {
                "Grupa 2I", "Grupa 2IM", "Grupa 2MI", "Grupa 2FI"
            };
            Console.Write("1) Scrie o lista noua\n2) Extrage si Afiseaza\n3) Salveaza\n4) Exit\nRS: ");
            ushort key = Convert.ToUInt16(Console.ReadLine());
            switch( key )
            {
                case 1:
                    new EnterStudents(st, Group);
                    Console.Clear();
                    Main();
                    break;
                case 2:
                    new ReadAndShow(st, Group);
                    Console.Clear();
                    Main();
                    break;
                case 3:
                    new Save(st);
                    Console.Clear();
                    Main();
                    break;
                case 4:
                    Console.WriteLine("GoodBye!");
                    Console.ReadKey();
                    Environment.Exit(1);
                    break;
            }
        }
    }
}
