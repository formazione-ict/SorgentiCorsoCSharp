using System;
using System.Collections.Generic;
using System.Globalization;
using Corso_10.Enums;
using Corso_10.Extensions;

namespace Corso_10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Digitare una frase: ");
            //var words = Console.ReadLine();

            //Console.WriteLine($"Numero di parole: {words.WordCount()}");

            //var message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam quis consectetur odio. Pellentesque nec lorem non mi gravida malesuada. Suspendisse neque sem, aliquam in elementum in, mollis eget lorem. Duis fermentum consequat feugiat. Maecenas suscipit neque et erat sollicitudin pharetra ut vitae tortor. Aenean interdum, diam a mattis porttitor, turpis lacus lobortis leo, ut tempor mi eros sed enim. Mauris fringilla nunc eget felis interdum pretium.";

            //Console.WriteLine($"Numero della sillaba 're': {message.SyllableCount("re")}");

            //var coupleItems = new { words, message };

            //Console.WriteLine($"{coupleItems.message} and {coupleItems.words}");


            #region var 

            //var myName;

            //var birthDay = new DateTime(1977, 8, 3);

            //var calendar = new List<DateTime>();

            //foreach (var date in calendar)
            //{
            //    Console.WriteLine($"{date.ToShortDateString()}");
            //}

            //var items = new Dictionary<String, String>();

            //foreach(var item in items)
            //{

            //}


            #endregion

            #region casting

            //int i = 1920;
            //float f = 0;
            //f = i;  //Conversione implicita, nessuno problema
            //f = 0.5123123F;
            //i = (int)f;  //Conversione esplicita, perdita di dati potenziale

            #endregion

            #region Converter

            //var number = Convert.ToSingle(i);
            //var floatNUmber = Convert.ToInt32(f);

            //CultureInfo culture = new CultureInfo("en-US");
            //var birthDay2 = Convert.ToDateTime("12-23-2003", culture);
            //Console.WriteLine(birthDay2.ToString());

            #endregion

            #region enums

            //int sunday = (int)Days.Sun;
            //Console.WriteLine($"Domenica: {sunday.ToString()} => {Days.Sun}");

            // Bitwise OR of 0001 and 0100 is 0101.
            CarOptions options = CarOptions.SunRoof | CarOptions.FogLights;

            Console.WriteLine(options);
            // 0101 is 5.
            Console.WriteLine((int)options);

            #endregion
        }
    }
}
