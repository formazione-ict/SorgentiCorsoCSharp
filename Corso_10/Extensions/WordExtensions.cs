using System;

namespace Corso_10.Extensions
{
    public static class StringExtensions
    {

        public static int WordCount(this String pWord)
        {
            return pWord.Split(new char[] { ' ', '.', ',', ';' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }


        public static int SyllableCount(this String pWord, String pSyllable)
        {
            int output = 0;

            //Case insensitive
            pSyllable = pSyllable.ToLower();
            pWord = pWord.ToLower();

            //Searching
            if (pSyllable.Length == 2)
            {
                int index = 0;
                do
                {
                    index = pWord.IndexOf(pSyllable, index, StringComparison.CurrentCulture);

                    if (index == -1)
                        break;
                    else
                    {
                        output++;
                        index++;
                    }

                } while (index < pWord.Length);
            }

            return output;
        }

    }
}
