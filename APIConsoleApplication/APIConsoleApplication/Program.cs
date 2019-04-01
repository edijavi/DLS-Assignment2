using APIConsoleApplication.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace APIConsoleApplication
{
    class MainClass
    {
        const string Url = "http://localhost:44349/api/";

        public static void Main(string[] args)
        {
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
                            double j = Double.Parse(Console.ReadLine());
                            double q = Double.Parse(Console.ReadLine());
                            double ass = j + q;
                            double ass2 = j - q;
                            double ass3 = j * q;
                            double ass4 = j / q;
                            Console.WriteLine(ass);
                            Console.WriteLine(ass2);
                            Console.WriteLine(ass3);
                            Console.WriteLine(ass4);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("├───>2 ");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("├───>3 ");
                            break;
                        }
                    case 4:
                        {
                            Console.Write("├───>4 ");
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

        public static async Task<IEnumerable<Calc>> ObtenerResultadoAdd()
        {
            List<Calc> resultados;
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(Url + "add");
                await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Calc>>(response));
            }
            return resultados;
        }

        public static async Task<IEnumerable<Calc>> ObtenerResultadoSub()
        {
            List<Calc> resultados;
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(Url + "sub");
                await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Calc>>(response));
            }
            return resultados;
        }

        public static async Task<IEnumerable<Calc>> ObtenerResultadoMult()
        {
            List<Calc> resultados;
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(Url + "mult");
                await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Calc>>(response));
            }
            return resultados;
        }

        public static async Task<IEnumerable<Calc>> ObtenerResultadoDiv()
        {
            List<Calc> resultados;
            using (var client = new HttpClient())
            {
                var response = await client.GetStringAsync(Url + "div");
                await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<List<Calc>>(response));
            }
            return resultados;
        }
    }
}
