using System;
using System.Collections.Generic;
using System.IO;
namespace ZooShop {                          
    class AnimalsZoo {
        private string[] Animals = new string [0];
        private string[] Sex = new string [2];
        private int[,] Quantity = new int [0, 2];
        private int[] Price = new int [0];
        public string[] Animals1 { 
            get { return Animals; }
            set { Animals = value; }
        }
        public string[] Sex1 { 
            get { return Sex; }
            set { Sex = value; } 
        }
        public int[,] Quantity1 {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public int[] Price1 { 
            get { return Price; }
            set { Price = value; }
        }
        public AnimalsZoo () {
            ReadInFile ();
            Sort ();
        }
        public void clear () {
            Console.Clear ();
        }
        public void ReadInFile () {
            
            Sex [0] = "Male"; Sex [1] = "Female";
            using (StreamReader sr = File.OpenText (@"DummyFile.txt")) {
                int _lengthNum = Convert.ToInt32 (sr.ReadLine ());
                Animals = new string [_lengthNum];
                Quantity = new int [_lengthNum, 2];
                Price = new int [_lengthNum];
                for (int i = 0; i < _lengthNum; i++) {
                   Animals [i] = sr.ReadLine ();
                   Quantity [i, 0] = Convert.ToInt32 (sr.ReadLine ());
                   Quantity [i, 1] = Convert.ToInt32 (sr.ReadLine ());
                   Price [i] = Convert.ToInt32 (sr.ReadLine ());
                }
                sr.Close ();
            }
        }
        private void Sort () {
            for (int i = 0; i < Price.Length - 1; i++) {
                for (int j = 0; j < Price.Length - i - 1; j++) {
                    if(Price [j] < Price [j + 1]) {
                        SortTemp (j);
                    }
                }
            }
        }

        private void SortTemp (int j) {
            string anim = Animals[j];
            Animals[j] = Animals[j + 1];
            Animals[j + 1] = anim;
            int quan1 = Quantity[j, 0];
            int quan2 = Quantity[j, 1];
            Quantity[j, 0] = Quantity[j + 1, 0];
            Quantity[j, 1] = Quantity[j + 1, 1];
            Quantity[j + 1, 0] = quan1;
            Quantity[j + 1, 1] = quan2;
            int pr = Price[j];
            Price[j] = Price[j + 1];
            Price[j + 1] = pr;
        }
        public void SaveInFile (int addNum = 0) {
            Sort ();
            /*de scris in fisier */
            StreamWriter sr = new StreamWriter(@"DummyFile.txt");
            sr.WriteLine(Animals.Length+addNum);
            for (int i = 0; i < Animals.Length; i++) {
                sr.Write(Animals[i]+"\n"+Quantity[i, 0]+"\n"+Quantity[i, 1]+"\n"+Price[i]+"\n");
            }
            sr.Close ();
        }
        public ushort keyInt (int different1, int different2) {
            ushort key;
            do {
                PrintChoice ();
                do {
                    key = Convert.ToUInt16 (Console.ReadLine ());
                }while (key == '\n');
                if (key < different1 || key > different2) {
                    colorRed ();
                    Console.WriteLine ("You entered incorrectly!");
                    resetColor ();
                }
            }while (key < different1 || key > different2);
            return key;
        }
        public void SearchAnimal () {
            clear ();
            PrintAll ();
            Console.WriteLine ("Enter the species of the animal");
            PrintChoice ();
            string _animal = Convert.ToString (Console.ReadLine ());
            Console.WriteLine ("Sex:\n1) Male\n2) Female");
            int _sex = keyInt (1, 2) - 1;
            int _animalNum = 0;
            ushort key;
            if (Verification (_animal, ref _animalNum)) {
                Console.WriteLine("Animal: {0}", Animals1 [_animalNum]);
                Console.WriteLine("Sex: {0}", Sex1 [_sex]);
                Console.WriteLine("Quantity: {0}", Quantity1 [_animalNum, _sex]);
                Console.WriteLine("Price: {0}$", Price1 [_animalNum]);
                Console.WriteLine("Do you go to the beginning? \n1) Yes \n2) Exit");
                if ((key = keyInt (1, 2)) == 1) new Start ();
                else Exit ();
            }
            else {
                colorRed ();
                Console.WriteLine ("Sorry. There is no such animal in our store.");
                resetColor ();
                Console.WriteLine ("Try again? \n1) Yes \n2) Go to the beginning");
                if ((key = keyInt (1, 2)) == 1) SearchAnimal ();
                else new Start ();
            }
        }
        public void Buy () {
            clear ();
            PrintAll ();
            Console.WriteLine ("Enter the species of the animal");
            PrintChoice ();
            string _animal = Convert.ToString (Console.ReadLine ());
            Console.WriteLine ("Sex:\n1) Male\n2) Female");
            ushort _sex = keyInt (1, 2);
            _sex--;
            int _animalNum = 0;
            ushort key;
            if (Verification (_animal, ref _animalNum)) {
                Console.WriteLine ("How much do you want to buy?");
                PrintChoice ();
                int buyQuantity = Convert.ToInt32(Console.ReadLine());
                int buyPrice = Price [_animalNum] * buyQuantity;
                Console.WriteLine ("Will cost {0}$.\nBuy? 1) Yes 2) Go to the beginning", buyPrice);
                if ((key = keyInt (1, 2)) == 2) new Start ();
                card ();
                _remove (_sex, _animalNum, buyQuantity);
                colorGreen ();
                Console.WriteLine ("\nYou have successfully bought!\n");
                resetColor ();
                Console.WriteLine ("Do you buy more?\n1) Yes \n2) Go to the beginning");
                if ((key = keyInt (1, 2)) == 1) Buy ();
                else new Start ();
            }
            else {
                colorRed ();
                Console.WriteLine ("Sorry. There is no such animal in our store.");
                resetColor ();
                Console.WriteLine ("Try again? \n1) Yes \n2) Go to the beginning");
                if ((key = keyInt (1, 2)) == 1) SearchAnimal ();
                else new Start ();
            }
        }
        public void _remove(ushort _sex, int _animalNum, int _deleteSpecies) {
            Quantity1[_animalNum, _sex] -= _deleteSpecies;
            SaveInFile();
        }
        private void card () {
            Console.WriteLine ("Cardowner");
            Console.WriteLine ("First Name, Last Name: ");
            string cardowner = Convert.ToString (Console.ReadLine ());
            string card;
            do {
                Console.WriteLine ("Card number:");
                card = Convert.ToString (Console.ReadLine ());
                if (card.IndexOf (' ') != 4)
                    Console.WriteLine ("You entered incorrectly!");
            } while (card.IndexOf (' ') != 4);
            string expiration;
            do {
                Console.WriteLine ("Card expiration date:");
                expiration = Convert.ToString (Console.ReadLine ());
                if (expiration.IndexOf ('/') != 2)
                    Console.WriteLine ("You entered incorrectly!");
            } while (expiration.IndexOf ('/') != 2);
            string CVV2;
            do {
                Console.WriteLine ("CVV2 code: ");
                CVV2 = Convert.ToString (Console.ReadLine ());
                if (CVV2.Length > 3 || CVV2.Length < 3)
                    Console.WriteLine ("The CVV2 code is 3 digits!\nYou have entered {0} !", CVV2.Length);
            } while (CVV2.Length > 3 || CVV2.Length < 3);
            
            using (StreamWriter sr = File.CreateText(@"Card.txt")) {
                sr.WriteLine ("Cardowner: {0}\nCard number: {1}\nCard expiration date: {2}\nCVV2 code: {3}\n", cardowner, card, expiration, CVV2);
                sr.Close ();
            }
        }
        public bool Verification (string _animal, ref int _animalNum) {
            bool _EXIST = true;
            for (int i = 0; i < Animals1.Length; i++) {
                if (String.Equals (Animals1 [i], _animal)) {
                    _animalNum = i;
                    _EXIST = true;
                    break;
                }
                else
                    _EXIST = false;
            }
            return _EXIST;
        }
        public void PrintAll () {
            Console.WriteLine ("Show all animals? \n1) Yes \n2) No");
            ushort key = keyInt (1, 2);
            if (Animals1.Length == 0) {
                colorRed ();
                Console.WriteLine ("No exist animals");
                resetColor ();
                return;
            }
            if (key != 1) return;
            Console.WriteLine ("Only species or all information \n1) Only species \n2) All information");
            key = keyInt (1, 2);
            for (int i = 0; i < Animals1.Length; i++) {
                Console.WriteLine ("______{0}______", Animals1 [i]);
                if (key == 2) {
                    if (Quantity1 [i,0] != 0)
                        Console.WriteLine ("Sex:{0} - Quantity:{1} - Price:{2}$", Sex1 [0], Quantity1 [i,0], Price1 [i]);
                    if (Quantity1 [i,1] != 0)
                    Console.WriteLine ("Sex:{0} - Quantity:{1} - Price:{2}$", Sex1 [1], Quantity1 [i,1], Price1 [i]);
                }
            }
        }
        public void PrintChoice () {
            colorGreen ();
            Console.Write ("Choice: ");
            resetColor ();
        }
        public void Exit () {
            colorRed ();
            Console.WriteLine ("\nGoodbye!");
            colorGreen ();
            Console.WriteLine ("Developing by Gavrilovici");
            resetColor ();
            Console.ReadKey ();
            Environment.Exit (-1);
        }
        public void colorRed () {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;
        }
        public void colorDarkGreen () {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void colorGreen () {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public void resetColor () {
            Console.ResetColor();
        }
    }
    class Administrator : AnimalsZoo {
        private static string password = "admin";
        private string _passInput;
        private static int incorrect = 3;
        private string PassInput () {
            Console.WriteLine ("Enter password:");
            PrintChoice ();
            string _passInput = Convert.ToString (Console.ReadLine ());
            return _passInput;
        }
        public Administrator () {
            if (incorrect == 0) {
                colorRed ();
                Console.WriteLine ("You have entered your password incorrectly 3 times!");
                resetColor ();
                incorrect = 3;
                new Start ();
            }
            _passInput = PassInput ();
                if (!_passInput.Equals (password)) {
                    colorRed ();
                    Console.WriteLine ("Sorry, you have entered an incorrect password.");
                    colorGreen ();
                    Console.WriteLine ("You have {0} more attempts.", incorrect - 1);
                    resetColor ();
                    incorrect--;
                    new Administrator ();
                }
                else if (_passInput.Equals (password)) {
                    incorrect = 3;
                    colorGreen ();
                    Console.WriteLine ("\nAccepted -> You have successfully entered the administrator's menu");
                    resetColor ();
                    System.Threading.Thread.Sleep(1200);

                    _adminMenu ();
                }
            }
        private void _adminMenu () {
            switch (AdminMenu ()) {
                case 1: 
                    clear ();
                    SearchAnimal (); 
                    break;
                case 2: 
                    clear ();
                    PrintAll (); 
                    Console.WriteLine ("Do you go to the beginning? \n1) Yes \n2) Exit");
                    ushort key = keyInt (1, 2);
                    if (key == 1) new Start ();
                    else Exit ();
                    break;
                case 3: 
                    AddNew (); break;
                case 4:
                    EditAmount (); break;
                case 5:
                    EditingThePrice (); break;
                case 6:
                    DeleteAnimal (); break;
                case 7:
                    DeleteAllAnimals (); break;
                case 8:
                    new Start (); break;
                case 9:
                    Exit (); break;
            }
        }
        private int AdminMenu () {
            clear ();
            colorGreen ();
            Console.WriteLine ("Welcome to the admin menu -->\n");
            resetColor ();
            
            Console.WriteLine ("1) Look for an animal \n2) See all animals \n3) Add another animal \n4) Edit the amount of animals \n5) Price editing \n6) Delete category animal \n7) Delete all animals");
            colorDarkGreen ();
            Console.WriteLine ("8) Back");
            colorRed ();
            Console.WriteLine ("9) Exit");
            resetColor ();
            ushort key = keyInt (1, 9);
            return key;
        }
        private void AddNew () {
            clear ();
            PrintAll();
            Console.WriteLine("How many animals do you add?");
            PrintChoice();
            int addNum = Convert.ToInt32(Console.ReadLine());
            int num = Animals1.Length + addNum;
            int _lengthA = Animals1.Length;
            SaveInFile(addNum);
            Animals1 = new string[num];
            Price1 = new int[num];
            Quantity1 = new int[num, 2];
            ReadInFile();
            AtribueNewAnimals(addNum, _lengthA);
            SaveInFile();
            Console.WriteLine ("Do you add?\n1) Yes\n2) Go to the admin menu");
            ushort key;
            if ((key = keyInt (1, 2)) == 1) AddNew ();
            else _adminMenu();
        }

        private void AtribueNewAnimals(int addNum, int _lengthA) {
            int[] a = new int [2];
            a [0] = addNum; a [1] = _lengthA;
            for (int i = 0; i < addNum; i++) {
                Console.WriteLine("Specify animal {0}: ", i + 1);
                PrintChoice();
                Animals1[_lengthA + i] = Convert.ToString(Console.ReadLine());
                for (int j = 0; j < Animals1.Length - addNum; j++) {
                    if (Animals1[_lengthA + i].Equals (Animals1 [j])) {
                        Console.WriteLine("The {0} animal already exists", Animals1[_lengthA + i]);
                        AtribueNewAnimals (a [0], a [1]);
                    }
                }
                Console.WriteLine("Quantity Male {0}: ", Animals1[_lengthA + i]);
                PrintChoice();
                Quantity1[_lengthA + i, 0] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Quantity Female {0}: ", Animals1[_lengthA + i]);
                PrintChoice();
                Quantity1[_lengthA + i, 1] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price {0}: ", Animals1[_lengthA + i]);
                PrintChoice();
                Price1[_lengthA + i] = Convert.ToInt32(Console.ReadLine());
                colorGreen ();
                Console.WriteLine("\nIt was added!\n");
                resetColor ();
            }
        }

        private void EditAmount () {
            PrintAll ();
            ushort key;
            Console.WriteLine ("Adding or Removing \n1) Adding \n2) Remove");
            key = keyInt (1, 2);
            Console.WriteLine ("\nEnter animal species");
            PrintChoice ();
            string _animal = Convert.ToString (Console.ReadLine ());
            Console.WriteLine ("Sex:\n1) Male\n2) Female");
            ushort _sex = keyInt (1, 2);
            _sex--;
            int _animalNum = 0;
            if (Verification (_animal, ref _animalNum)) {
                Console.WriteLine ("There are {0} quantities of this animal", Quantity1[_animalNum, _sex]);
                if (key == 1) {
                    Console.WriteLine ("\nHow much you want to add?");
                    PrintChoice ();
                    int _addSpecies = Convert.ToInt32 (Console.ReadLine ());
                    Quantity1[_animalNum, _sex] += _addSpecies;
                    colorGreen ();
                    Console.WriteLine ("\nYou have successfully added!");
                    resetColor ();
                    SaveInFile ();
                }
                else
                {
                    Console.WriteLine("\nHow much you want to delete?");
                    PrintChoice();
                    int _deleteSpecies = Convert.ToInt32(Console.ReadLine());
                    _remove(_sex, _animalNum, _deleteSpecies);
                    colorGreen ();
                    Console.WriteLine ("\nYou deleted successfully!");
                    resetColor ();
                }
                PrintAll ();
                Console.WriteLine ("Do you want to edit the quantity? \n1) Yes \n2) Go to the admin menu");
                key = keyInt (1, 2);
                if (key == 1) EditAmount ();
                else _adminMenu ();
            }
            else {
                colorRed ();
                Console.WriteLine ("Sorry. There is no such animal in our store.");
                resetColor ();
                Console.WriteLine ("\nTry again? \n1) Yes \n2) Go to the admin menu");
                key = keyInt (1, 2);
                if (key == 1) EditAmount ();
                else _adminMenu ();
            }
        }
        private void EditingThePrice () {
            clear ();
            PrintAll ();
            ushort key;
            Console.WriteLine ("\nEnter animal species");
            PrintChoice ();
            string _animal = Convert.ToString (Console.ReadLine ());
            int _animalNum = 0;
            if (Verification (_animal, ref _animalNum)) {
                Console.WriteLine ("\nEnter the new {0} animal price", _animal);
                PrintChoice ();
                int _newPrice = Convert.ToInt32 (Console.ReadLine ());
                Price1 [_animalNum] = _newPrice;
                colorGreen ();
                Console.WriteLine ("\nThe price has been successfully edited!");
                resetColor ();
                SaveInFile ();
                PrintAll ();
                Console.WriteLine ("Do you want to edit the Price? \n1) Yes \n2) Go to the admin menu");
                key = keyInt (1, 2);
                if (key == 1) EditingThePrice ();
                else _adminMenu ();
            }
            else {
                colorRed ();
                Console.WriteLine ("Sorry. There is no such animal in our store.");
                resetColor ();
                Console.WriteLine ("\nTry again? \n1) Yes \n2) Go to the admin menu");
                PrintChoice ();
                key = keyInt (1, 2);
                if (key == 1) EditingThePrice ();
                else _adminMenu ();
            }
        }
        private void DeleteAnimal () {
            clear ();
            if (Animals1.Length == 0) {
                Console.WriteLine ("No exist animals");
                return;
            }
            PrintAll ();
            ushort key;
            Console.WriteLine ("\nEnter animal species");
            PrintChoice ();
            string _animal = Convert.ToString (Console.ReadLine ());
            int _animalNum = 0;
            if (Verification (_animal, ref _animalNum)) {
                Console.WriteLine ("Sex:\n1) Male \n2) Female \n3) Both");
                key = keyInt (1, 3);
                switch (key) {
                    case 1:
                        Quantity1 [_animalNum, 0] = 0;
                        colorGreen ();
                        Console.WriteLine ("\nYou deleted successfully!");
                        resetColor ();
                        SaveInFile ();
                        break;
                    case 2:
                        Quantity1 [_animalNum, 1] = 0;
                        colorGreen ();
                        Console.WriteLine ("\nYou deleted successfully!");
                        resetColor ();
                        SaveInFile ();
                        break;
                    case 3:
                        TempAnimals (_animalNum);
                        colorGreen ();
                        Console.WriteLine ("\nYou deleted successfully!");
                        resetColor ();
                        SaveInFile ();
                        break;
                }
                PrintAll ();
                Console.WriteLine ("Do you want to delete animal? \n1) Yes \n2) Go to the admin menu");
                key = keyInt (1, 2);
                if (key == 1) DeleteAnimal ();
                else _adminMenu ();
            }
            else {
                colorRed ();
                Console.WriteLine ("Sorry. There is no such animal in our store.");
                resetColor ();
                Console.WriteLine ("\nTry again? \n1) Yes \n2) Go to the admin menu");
                key = keyInt (1, 2);
                if (key == 1) DeleteAnimal ();
                else _adminMenu ();
            }
        }
        private void TempAnimals (int _animalNum) {
            string[] _Animals = new string [Animals1.Length - 1];
            int[] _Price = new int [Price1.Length - 1];
            int[,] _Quantity = new int [Animals1.Length - 1, 2];
            int contour = 0;
            for (int i = 0; i < Animals1.Length; i++) {
                if (i == _animalNum) {
                    i++;
                    if (i >= Animals1.Length) break;
                }
                _Animals [contour] = Animals1 [i];
                _Quantity [contour, 0] = Quantity1 [i, 0];
                _Quantity [contour, 1] = Quantity1 [i, 1];
                _Price [contour] = Price1 [i];
                contour++;
            }
            Animals1 = new string [_Animals.Length];
            Price1 = new int [_Price.Length];
            Quantity1 = new int [_Animals.Length, 2];
            for (int i = 0; i < Animals1.Length; i++) {
                Animals1 [i] = _Animals [i];
                Quantity1 [i, 0] = _Quantity [i, 0];
                Quantity1 [i, 1] = _Quantity [i, 1];
                Price1 [i] = _Price [i];
            }
        }
        private void DeleteAllAnimals () {
            clear ();
            if (Animals1.Length == 0) {
                Console.WriteLine ("No exist animals");
                return;
            }
            Console.WriteLine ("Delete all animals? \n1) Yes \n2) No");
            ushort key = keyInt (1, 2);
            if (key == 1) {
                colorRed ();
                Console.WriteLine ("Are you sure? \n1) Yes \n2) No");
                PrintChoice ();
                key = keyInt (1, 2);
                resetColor ();
                if (key == 1) {
                    Animals1 = new string [0];
                    Sex1 = new string [0];
                    Price1 = new int [0];
                    Quantity1 = new int [0, 0];
                    colorRed ();
                    Console.WriteLine ("\nYou deleted successfully!");
                    resetColor ();
                    SaveInFile ();
                    Console.WriteLine ("Go to the admin menu?\n1) Yes\n2) Exit");
                    if ((key = keyInt (1, 2)) == 1) _adminMenu ();
                    else Exit ();
                } else _adminMenu ();
            } else _adminMenu ();
        }
    }
    class Start {
        AnimalsZoo animals = new AnimalsZoo ();
        public Start () { MainMenu (); }
        public void MainMenu () {
            animals.clear ();
            animals.colorDarkGreen ();
            Console.WriteLine ("1) User menu");
            Console.WriteLine ("2) Administrator menu");
            animals.colorRed ();
            Console.WriteLine ("3) Exit");
            animals.resetColor ();
            ushort key = animals.keyInt (1, 3);
            if (key == 1) {
                switch (UserMenu ()) {
                    case 1:
                        animals.SearchAnimal (); break;
                    case 2:
                        animals.PrintAll (); 
                        Console.WriteLine ("Do you go to the beginning?? \n1) Yes \n2) Exit");
                        key = animals.keyInt (1, 2);
                        if (key == 1) new Start ();
                        else animals.Exit ();
                        break;
                    case 3:
                        animals.Buy ();
                        break;
                    case 4:
                        MainMenu (); break;
                    case 5:
                        animals.Exit (); break;
                }
            }
            else if (key == 2) {
                animals.clear ();
                new Administrator ();
            }
            else {
                animals.Exit ();
            }
        }
        private ushort UserMenu () {
            animals.clear ();
            Console.WriteLine ("1) Look for an animal \n2) See all animals \n3) Buy");
            animals.colorDarkGreen ();
            Console.WriteLine ("4) Back");
            animals.colorRed ();
            Console.WriteLine ("5) Exit");
            animals.resetColor ();
            ushort key = animals.keyInt (1, 5);
            return key;
        }
    }
    class MainClass {
        static void Main () {
            new Start ();
        }
    }
}
/*
Environment.Exit (-1);  -- exit program 
*/