using System;

namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string obj, int position)
        {
            if (obj.Length <= position)
            {
                return obj;
            }
            else
            {
                return obj.Substring(0, position) + "...";
            }
        }
    }
}
