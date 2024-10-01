using System;

namespace Corso_11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            #region cast impliciti

            //Tipi primitivi
            int tinyInteger = 10;
            long bigInteger = tinyInteger; //OK

            float tinyReal = 10.0f;
            double bigReal = tinyReal; //OK

            double bigReal2 = Double.MaxValue;
            float tinyReal2 = bigReal2; //KO

            //Oggetti
            string text = "123";
            IConvertible convertible = text; //OK

            NotSupportedException derivedException = new NotSupportedException();
            Exception baseException = derivedException; //OK

            //Struct KO!!!

            #endregion

            #region cast espliciti

            //Tipi primitivi
            double precise = Math.Cos(Math.PI * 1.23456) / Math.Sin(1.23456);
            float coarse = (float)precise;

            float epsilon = (float)Double.Epsilon; //Potresti perdere dati...

            float max = (float)Double.MaxValue; //Perderai dati!!!

            string text2 = "123";
            double value = (double)text2; //Errore del compilatore, non si può!!!

            //Oggetti
            string text = (string)AppDomain.CurrentDomain; //Errore del compilatore, non si può!!!
            Exception exception = (Exception)"abc"; //Errore del compilatore, non si può!!!

            object obj = GetNextObjectFromInput(); //Restituisce "qualcosa"
            string text3 = (string)obj; //Potrebbe sollevarsi un InvalidCastException!!!

            obj = GetNextObjectFromInput(); //Restituisce "qualcosa"
            Exception exception = (Exception)obj; //Potrebbe sollevarsi un InvalidCastException!!!

            #endregion

            #region converter

            //DateTime myd = "12/07/2017";
            DateTime myDate = DateTime.Parse("12/07/2017");
            //myDate = DateTime.ParseExact("2017-07-12", "yyyy-MM-dd", format);

            if (DateTime.TryParse("12/rs06/2017", out myDate))
            {

            }

            System.Int32 myInteger = Int32.Parse("123");

            var myDoubleConverted = System.Convert.ToDouble("12.234");

            double real = 1.6;
            int castedInteger = (int)real; // 1
            int convertedInteger = Convert.ToInt32(real); // 2

            #endregion
        }
    }
}
