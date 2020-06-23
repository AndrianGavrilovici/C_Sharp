using System;
namespace Worker {
    class _workers {
        private string Name;
        private int Experience;
        private int Hourly;
        private int HasWorked;
        private int Salary;
        private double Premy = 0;
        public _workers (string Name, int Experience, int Hourly, int HasWorked) {
            this.Name = Name;
            this.Experience = Experience;
            this.Hourly = Hourly;
            this.HasWorked = HasWorked;
            Salary = Hourly * HasWorked;
            if (Experience < 1)
                Premy = 0;
            else if (Experience < 3)
                Premy = Salary * 0.05;
            else if (Experience < 5)
                Premy = Salary * 0.08;
            else if (Experience > 5)
                Premy = Salary * 0.15;
        }
        public void Print () {
            Console.WriteLine ($"Name: {Name}");
            Console.WriteLine ($"Experience is: {Experience}");
            Console.WriteLine ($"Hourly wage is: {Hourly}");
            Console.WriteLine ($"{Name} has worked: {HasWorked} hours");
            Console.WriteLine ($"Salary is: {Salary}");
            Console.WriteLine ($"Premy is: {Premy}");
        }
    }
    class MainClass {
        static void Main () {
            Console.Clear ();
            string name; int exp, hours, shours;
            Console.Write ("Enter worker's name: ");
            name = Convert.ToString (Console.ReadLine ());
            Console.Write ("Enter worker's experience: ");
            exp = EnterInt ();
            Console.Write("Enter worker's hourly wag: ");
            hours = EnterInt ();
            Console.Write("Enter how much hours Denis has worked: ");
            shours = EnterInt ();
            _workers work = new _workers (name, exp, hours, shours);
            work.Print ();
        }
        private static int EnterInt () {
            return Convert.ToInt32 (Console.ReadLine ());
        }
    }
}