using System;
using System.Globalization;
using System.Net;
using System.Threading;
using Newtonsoft.Json;

namespace APIConsoleApplication
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            const String BaseUrl = "http://localhost:5001/api/";

            int i;
            bool loop = true;
            string option;

            while (loop)
            {
                Console.WriteLine("What sign Do you prefer to denoted the decimals?");
                Console.WriteLine("──>' X,y '   OR   ' X.y '<──");
                option = Console.ReadLine().ToString();
            
                if (option.Equals(","))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("ca-ES");
                    loop = false;
                }
                else if (option.Equals("."))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-GB");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("Something wrong happened!  (╯°□°)╯ ");
                    Console.WriteLine("PLZ... Repeat the process  (⊙_☉) ");
                }
            }

            loop = true;

            while (loop)
            {

                Console.WriteLine("┌───────────────────────────────┐");
                Console.WriteLine("| Select your favourite option: |");
                Console.WriteLine("| 1. Add                        |");
                Console.WriteLine("| 2. Substraction               |");
                Console.WriteLine("| 3. Multiply                   |");
                Console.WriteLine("| 4. Divide                     |");
                Console.WriteLine("|                               |");
                Console.WriteLine("| 5. EXIT                       |");
                Console.WriteLine("└───────────────────────────────┘");
                Console.Write("├───> ");

                i = int.Parse(System.Console.ReadLine());
                switch (i)
                {
                    case 1:
                        {
                            Console.WriteLine("├───>1 ");
                            String Url = BaseUrl + "add";
                            Tuple<double, double> numbers = GetNumbers();

                            // Call to Post Event
                            PostDataEvent(numbers.Item1, numbers.Item2, Url);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("├───>2 ");
                            String Url = BaseUrl + "sub";
                            Tuple<double, double> numbers = GetNumbers();


                            // Call to Post Event
                            PostDataEvent(numbers.Item1, numbers.Item2, Url);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("├───>3 ");
                            String Url = BaseUrl + "mult";
                            Tuple<double, double> numbers = GetNumbers();

                            // Call to Post Event
                            PostDataEvent(numbers.Item1, numbers.Item2, Url);
                            break;
                        }
                    case 4:
                        {
                            Console.Write("├───>4 ");
                            String Url = BaseUrl + "div";
                            Tuple<double, double> numbers = GetNumbers();

                            // Call to Post Event
                            PostDataEvent(numbers.Item1, numbers.Item2, Url);
                            break;
                        }
                    case 5:
                        {
                            System.Console.WriteLine("See you ...... (^_^)");
                            loop = false;
                            Console.ReadKey();
                            break;
                        }
                }
            }
        }

        public static Tuple<double, double> GetNumbers()
        {

            Console.WriteLine("Please enter Num1: \n");
            double num1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter Num2: \n");
            double num2 = Double.Parse(Console.ReadLine());

            return Tuple.Create(num1, num2);
        }

        public static void PostDataEvent(double Num1, double Num2, String Url)
        {
            using (var client = new WebClient())
            {
                EventModel objtb = new EventModel(); //Setting parameter to post  
                objtb.Num1 = Num1;
                objtb.Num2 = Num2;
                client.Headers.Add("Content-Type:application/json");
                client.Headers.Add("Accept:application/json");
                var result = client.UploadString(Url, JsonConvert.SerializeObject(objtb));

                Console.WriteLine("Result: " + result.ToString());
            }
        }


    }
}
