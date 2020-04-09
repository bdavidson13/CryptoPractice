using System;
using System.Collections.Generic;
using System.Text;

namespace CipherPractice.Helper
{
    public static class Extentions
    {
        public static bool IsLowerCase(this char character)
        {
            return character >= 97 && character <= 122;
        }
        public static bool IsUpperCase(this char character)
        {
            return character >= 65 && character <= 90;
        }
        public static bool IsSpace(this char character)
        {
            return  character == 32;
        }
    }
}
