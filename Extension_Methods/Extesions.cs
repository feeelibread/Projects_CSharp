using System;

namespace Extension_Methods
{
    public static class Extesions
    {
        public static string SplitShibata(this String campo, char delimitedChar)
        {
            string delimitedChars = ",)+(|)+(;".Replace(delimitedChar.ToString(), "");
            string[] delimitedCharArray = delimitedChars.Split(")+(");
            foreach (var item in delimitedCharArray)
            {
                if (item != "")
                {
                    campo = campo.Replace(item, delimitedChar.ToString());
                }
               
            }
            return campo;
        }
    }
}
