using System;
using System.Collections.Generic;
using System.Linq;

namespace Corso_04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Init
            Random rnd = new Random(DateTime.Now.Second);
            //Array mono-dimensionale
            int[] sequence = new int[]
            {
                rnd.Next(1024), //0
                rnd.Next(1024), //1
                rnd.Next(1024), //2
                45,
                rnd.Next(1024),
                345,
                45,
                34              //7
            };

            int[] sequence2 = new int[6];

            Console.WriteLine($"Terzo item: {sequence[2]}");

            //Array bi-dimensionale di stringhe
            string[,] items2 = new string[4, 2]
            {
                { "frutta", "pesca" },
                { "frutta", "mela" },
                { "ortaggio", "insalata" },
                { "ortaggio", "patata" }
            };

            Console.WriteLine($"Secondo ortaggio: {items2[3, 1]}");

            //Array tri-dimensionale
            int[,,] items3 = new int[2, 2, 3]
            {
                {
                    { 1, 2, 3 },
                    { 4, 5, 6 }
                },
                {
                    { 7, 8, 9 },
                    { 10, 11, 12 }
                }
            };

            Console.WriteLine($"Coordinata X: {items3[1, 0, 2]}");

            //Array degli array
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            //Ciclo
            Console.WriteLine("\n\nInizio ciclo \"noto\"");
            for (int i = 0; i < items2.GetLength(0); i++)
            {
                Console.WriteLine($"{i} Item: {items2[i, 1]} ({items2[i, 0]})");
            }

            //Ciclo annidato
            Console.WriteLine("\n\nCiclo annidato");
            for (int i = 0; i < items2.GetLength(0); i++)
            {
                for (int r = items2.GetLength(1) - 1; r >= 0; r--)
                {
                    if (r == 1)
                    {
                        Console.Write($"{i}) Item: {r} > {items2[i, r]}");
                    }
                    else
                    {
                        Console.WriteLine($"({r} > {items2[i, r]})");
                    }
                }
            }

            //Dictionary
            Console.WriteLine($"\n\nDizionario");
            Dictionary<int, string> colors = new Dictionary<int, string>();

            colors.Add(91, "Bianco");
            colors.Add(92, "Rosso");
            colors.Add(93, "Verde");
            colors.Add(94, "Giallo");
            colors.Add(95, "Blu");
            colors.Add(96, "Viola");

            foreach (var color in colors)
            {
                switch (color.Value)
                {
                    case "Bianco":
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        break;
                    case "Rosso":
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Red;
                        }
                        break;
                    case "Verde":
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        break;
                    case "Giallo":
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                        }
                        break;
                    case "Blu":
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        break;
                    case "Viola":
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Magenta;
                        }
                        break;
                }

                Console.Write($"{color.Key}) {color.Value}");
                Console.ResetColor();
                Console.WriteLine("");
            }

            //Recupero del valore di un dictionary
            Console.WriteLine($"Terzo item: {colors[93]}");

            //Rimuovi item
            colors.Remove(94);

            //Ricerca sequenziale
            string searchValue = "Giallo";
            bool found = false;

            if (colors.ContainsValue(searchValue))
            {
                foreach (var color in colors)
                {
                    if (color.Value == searchValue)
                    {
                        Console.WriteLine($"{color.Key}) {color.Value}");
                        found = true;
                    }
                }
            }

            if (!found)
                Console.WriteLine($"Item '{searchValue}' non è stato trovato.");

            //Ciclo while
            Console.WriteLine("Ricerca del Blu con ciclo while");

            int index = 91;
            found = true;
            bool skip = false;

            while ((!found) && (!skip))
            {
                if (colors.ContainsKey(index))
                {
                    if (colors[index] == "Blu")
                    {
                        found = true;
                        Console.WriteLine($"Check {index} > trovato - {colors[index]}");
                    }
                    else
                    {

                        Console.WriteLine($"Check {index} > non è - {colors[index]}");
                    }
                }

                if (index > colors.Keys.Max())
                    skip = true;

                index++;
            }

            //Ciclo do-while
            Console.WriteLine("Ricerca del Blu con ciclo do-while");

            index = 91;
            found = true;
            skip = false;

            do
            {
                if (colors.ContainsKey(index))
                {
                    if (colors[index] == "Blu")
                    {
                        found = true;
                        Console.WriteLine($"Check {index} > trovato - {colors[index]}");
                    }
                    else
                    {
                        Console.WriteLine($"Check {index} > non esiste - {colors[index]}");
                    }
                }

                if (index > colors.Keys.Max())
                    skip = true;

                index++;

            } while ((!found) && (!skip));
        }
    }
}
