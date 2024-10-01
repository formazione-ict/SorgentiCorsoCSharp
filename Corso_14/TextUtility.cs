using System;
using System.Linq;

namespace Corso_14
{
    public class TextUtility
    {
        char[] validChar = { 'A', 'B', 'C', 'D', 'E', 'F', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public void CheckCode(string pCodeToValidate)
        {
            foreach(var singleChar in pCodeToValidate)
            {

                if (!validChar.ToList().Contains(singleChar))
                    throw new IndexOutOfRangeException($"Il codice {pCodeToValidate} non è conforme alle specifiche.");
            }
        }


    }
}
