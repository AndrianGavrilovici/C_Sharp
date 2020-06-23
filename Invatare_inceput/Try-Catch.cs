using System;
namespace Program10 {
    class ProgramTryCatch {
        static void Main () {

            Console.WriteLine ( "Enter number: " );
            
            try {
                int num = Convert.ToInt32 (Console.ReadLine ());
                Console.WriteLine ( "Num is: " + num );
            } catch ( FormatException ) {
                Console.WriteLine ( "Format Exception" );
                throw;
            } catch ( IndexOutOfRangeException ) {
                Console.WriteLine ( "Index Out Of Range Exception" );
            } finally {
                Console.WriteLine ( "La final" );
            }
        }
    }
}
/* FormatException - daca nu este scris formatul corect
   
   Exception - daca nu este scris tot corect
   
   DivideByZeroException - daca se imparte la 0

   IndexOutOfRangeException - daca nu mai este in array spatiu, adica daca este int[1,2], dar noi ne adresam la [2,3]

    finally - ramane la urma .. se foloseste
 */