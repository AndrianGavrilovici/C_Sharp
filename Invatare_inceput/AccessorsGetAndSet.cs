using System;
namespace Program14 {
    class Student {
        private string name;
        private int course;
        private bool scholarship;
        public int Course {/* pentru a putea modifica private */
            get {/*citeste */
                return course;
            }
            set {/*schimba */
                if ( value < 1 ) 
                    course = 1;
                else if ( value > 5 )
                    course = 5;
                else course = value;
            }
        }
        public int _Course { /*el singur gaseste ce trebuie sa faca(sa scrie sau sa citeasca) */
            private get; //nu se poate citi..
            set; //se poate numai seta
        }
        public Student () {
            name = "Anatolie";
            course = 2;
            scholarship = false;
            Print ();
        }
        public Student ( string name, int course, bool scholarship ) {
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
    class AccessorsGetAndSet {
        static void Main () {
            Student Anatolie = new Student ();
            Console.WriteLine ();
            Console.WriteLine ( Anatolie.Course );
            Anatolie.Course = 3;
            Console.WriteLine ( Anatolie.Course );
            Anatolie._Course = 8;
            //Console.WriteLine ( Anatolie._Course );
        }
    }
}