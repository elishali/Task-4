namespace ConsoleAppTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tapsiriq1();

            //Tapsiriq2();

            //Tapsiriq3();

            //Tapsiriq4();

            //Tapsiriq5();

            //Tapsiriq6();

            //Tapsiriq9();

            //Tapsiriq10();

            //Tapsiriq15();
        }

        private static void Tapsiriq15()
        {
        /* IF operatoru ile yoxla.
        Verilmish ededdin 1-ile 365 arasinda olugunu yoxla (1 ve 365 ozude daxil olmaq sherti ile)
         Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster*/

        l1:
            Console.Write("Eded daxil et (1-365) - e qeder: ");
            int eded;
            if (!int.TryParse(Console.ReadLine(), out eded))
            {
                goto l1;
            }

            // 1-ile-365 arasinda oldugunu yoxla
            if (eded >= 1 && eded <= 365)
            {

                // Ededin düşdüyü ayı ve günü tap
                int ay, gun;

                if (eded <= 31)
                {
                    ay = 1; gun = eded;
                }
                else if (eded <= 59)
                {
                    ay = 2; gun = eded - 31;
                }
                else if (eded <= 90)
                {
                    ay = 3; gun = eded - 59;
                }
                else if (eded <= 120)
                {
                    ay = 4; gun = eded - 90;
                }
                else if (eded <= 151)
                {
                    ay = 5; gun = eded - 120;
                }
                else if (eded <= 181)
                {
                    ay = 6; gun = eded - 151;
                }
                else if (eded <= 212)
                {
                    ay = 7; gun = eded - 181;
                }
                else if (eded <= 243)
                {
                    ay = 8; gun = eded - 212;
                }
                else if (eded <= 273)
                {
                    ay = 9; gun = eded - 243;
                }
                else if (eded <= 304)
                {
                    ay = 10; gun = eded - 273;
                }
                else if (eded <= 334)
                {
                    ay = 11; gun = eded - 304;
                }
                else
                {
                    ay = 12; gun = eded - 334;
                }

                // Burcu tap
                string burc = "";

                if ((ay == 1 && gun >= 21) || (ay == 2 && gun <= 19))
                {
                    burc = "Dolca";
                }
                else if ((ay == 2 && gun >= 20) || (ay == 3 && gun <= 20))
                {
                    burc = "Balıqlar";
                }
                else if ((ay == 3 && gun >= 21) || (ay == 4 && gun <= 20))
                {
                    burc = "Qoc";
                }
                else if ((ay == 4 && gun >= 21) || (ay == 5 && gun <= 21))
                {
                    burc = "Buga";
                }
                else if ((ay == 5 && gun >= 22) || (ay == 6 && gun <= 21))
                {
                    burc = "Ekizler";
                }
                else if ((ay == 6 && gun >= 22) || (ay == 7 && gun <= 22))
                {
                    burc = "Xerceng";
                }
                else if ((ay == 7 && gun >= 23) || (ay == 8 && gun <= 22))
                {
                    burc = "Sir";
                }
                else if ((ay == 8 && gun >= 23) || (ay == 9 && gun <= 23))
                {
                    burc = "Qiz";
                }
                else if ((ay == 9 && gun >= 24) || (ay == 10 && gun <= 23))
                {
                    burc = "Terazi";
                }
                else if ((ay == 10 && gun >= 24) || (ay == 11 && gun <= 24))
                {
                    burc = "Akreb";
                }
                else if ((ay == 11 && gun >= 22) || (ay == 12 && gun <= 21))
                {
                    burc = "Oxatan";
                }
                else if ((ay == 12 && gun >= 22) || (ay == 1 && gun <= 20))
                {
                    burc = "Oglak";
                }
                else
                {
                    Console.WriteLine("Eded 1-ile-365 arasinda deyil.");
                }

                Console.WriteLine($"Daxil etdiyin eded ilin {ay}-ci ayina dushur ve hemin ayin {gun}-ci gunu olur.");
                Console.WriteLine($"Hemin güne uygun burc: {burc} burcudur.");
            }
        }

        private static void Tapsiriq10()
        {
            /* IF operatoru ile yoxla.
                  6 dene eded verilib. Bu ededlerden hansi en boyukdur.*/


            int[] sayi = { 5, 54, 8, 45, 38, 90 };

            int max = sayi[0];

            for (int i = 0; i < sayi.Length; i++)
            {

                if (sayi[i] > max)
                {
                    max = sayi[i];

                }

            }
            Console.WriteLine(max);

        }

        private static void Tapsiriq9()
        {
        /*SWITCH operatoru ile yoxla.
        Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
        Eger bu eded
             1 olarsa-"Yanvar" sozunu
            2 olarsa-"Fevral" sozunu
            ...
            12 olarsa-"Dekabr" sozunu yaz*/

        l1:
            Console.WriteLine("Istenilen ay-i reqemle daxil edin: ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                goto l1;
            }
            switch (number)
            {
                case 1:
                    Console.WriteLine("Yanvar");
                    break;
                case 2:
                    Console.WriteLine("Fevral");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Aprel");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("Iyun");
                    break;
                case 7:
                    Console.WriteLine("Iyul");
                    break;
                case 8:
                    Console.WriteLine("Avqust");
                    break;
                case 9:
                    Console.WriteLine("Sentyabr");
                    break;
                case 10:
                    Console.WriteLine("Oktyabr");
                    break;
                case 11:
                    Console.WriteLine("Noyabr");
                    break;
                case 12:
                    Console.WriteLine("Dekabr");
                    break;
                default:
                    Console.WriteLine("Zehmet olmasa gedin aylari oyrenin:");
                    break;
            }
        }

        private static void Tapsiriq6()
        {
            /*Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana*/

            double number = ReadNumber(3);
            Console.WriteLine(number);




        }

        private static void Tapsiriq5()
        {
            /*Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman
                 hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.*/
            int number = ReadNumber(2);
            Console.WriteLine(number);


        }

        private static void Tapsiriq4()
        {
            /*Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana*/

            int number = ReadNumber(2);
            Console.WriteLine(number);


            if (number == 0)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyir");
            }
        }

        private static void Tapsiriq3()
        {
        /* Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana*/
        l1:
            Console.Write("Eded daxil edin: ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                goto l1;
            }

            if (number % 10 == 7)
            {
                Console.WriteLine("Beli");
            }
            else
            {
                Console.WriteLine("Xeyir");
            }
        }

        private static void Tapsiriq2()
        {
        /*2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart.
            Eks halda  "bolunmur" sozunu cap et*/
        l1:
            Console.Write("1 ci ededi daxil edin: ");
            int number1;
            if (!int.TryParse(Console.ReadLine(), out number1))
            {
                goto l1;
            }
        l2:
            Console.Write("2 ci ededi daxil edin: ");
            int number2;
            if (!int.TryParse(Console.ReadLine(), out number2))
            {
                goto l2;
            }
            int cavab;

            if (number1 % number2 == 0)
            {
                cavab = number1 / number2;
                Console.WriteLine(cavab);
            }
            else
            {
                Console.WriteLine("Bolunmur:");
            }

        }

        private static void Tapsiriq1()
        {

        /*verilmish ededin tek ve ya cut eded oldugunu yoxla*/
        l1:
            Console.Write("Istenilen ededi daxil edin: ");
            int number;
            if (!int.TryParse(Console.ReadLine(), out number))
            {
                goto l1;
            }

            if (number % 2 == 0)
            {
                Console.WriteLine("Eded cutdur");
            }
            else
            {
                Console.WriteLine("Eded tekdir");
            }
        }


        static int ReadNumber(int digitLength)
        {
            if (digitLength <= 0)
            {
                throw new Exception($"{digitLength} kimi reqem sayi olmaz:");

            }

            int eded1;
        l1:
            Console.Write($"{digitLength} reqemli eded daxil edin: ");

            if (!int.TryParse(Console.ReadLine(), out eded1))
            {
                goto l1;
            }
            int len = (int)Math.Log10(eded1) + 1;

            if (len != digitLength)
            {
                goto l1;
            }
            return eded1;

        }

    }

}