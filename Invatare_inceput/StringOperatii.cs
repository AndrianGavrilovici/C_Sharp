using System;
namespace Program9 {
    class Program_Rows {
        static void Main () {
            string str = "HellO WorlD";
            Console.WriteLine (String.IsNullOrEmpty (str));/* verifica daca este ceva in string (false - este) (true - nui nimic)*/

            Console.WriteLine (String.IsNullOrWhiteSpace (str));/* tot ferifica, numai daca este spatiu sau tab nu ea in consideratie(false - este) (true - nui nimic sau sunt numai spatii sau tab)*/

            String.Compare ("a", "b"); // returneaza -1

            Console.WriteLine (str.ToUpper ()); //face literele mari

            Console.WriteLine (str.ToLower ()); // face literele mici

            Console.WriteLine ("Sunt literele llO?" + str.Contains ("llO")); /* cauta daca sunt asa litere in str */

            Console.WriteLine ("Se incepe cu literele Hell?" + str.StartsWith ("Hell")); /* cauta daca se incepe cu asa litere */

            Console.WriteLine ("Se termina literele keD?" + str.EndsWith ("keD")); /* cauta daca se termina cu asa litere */

            Console.WriteLine (str.Insert (5, " keD")); /* adauga dupa a 5-a element literele keD */

            Console.WriteLine (str.Remove (5)); /* sterge tot dupa a 5-a element */

            Console.WriteLine (str.Replace ("llO", "llo")); /* inlocueste llo in loc de llO */

            /* Transformare string in char[] */
            char[] sym = str.ToCharArray ();
            
            /* Transformare unumite cuvinte aparte in variabile */
            string str1 = "Arsenal, Dinamo, Real";
            string[] clubs = str1.Split (',');
            Console.WriteLine ( clubs [1] );
        }
    }
}