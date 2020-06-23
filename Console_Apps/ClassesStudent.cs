using System;
namespace Program2 {
    class Student {
        private string name;
        private string course;
        private bool scholarship;
        public Student () {
            name = "Anatolie";
            course = "ITI";
            scholarship = false;
            Print ();
        }
        public Student ( string name, string course, bool scholarship ) {
            this.name = name;
            this.course = course;
            this.scholarship = scholarship;
            Print ();
        }
        public void Print (){
            Console.WriteLine ( "Name: " + name );
            Console.WriteLine ( "Course: " + course );
            Console.WriteLine ( "Scholarship: " + scholarship );
        }
    }
    class TpaUseClasses {
        static void Main () {
            Student Anatolie = new Student ();
            Console.WriteLine ();
            Student Dumitru = new Student ( "Dumitru", "ITI", true );
            Console.WriteLine ();
            Student Slavic = new Student ( "Slavic", "ITI", false );
        }
    }
}