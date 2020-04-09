using CipherPractice.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace CipherPractice
{
    public class CeasarCipher : ICipher
    {
        private int offset = 0;

        public CeasarCipher(int desiredOffset)
        {
            if(desiredOffset > 0)
            {
                offset = desiredOffset;
            }
            else
            {
                throw new NotSupportedException("offset is invalid");
            }
        }
        public string Encrypt(string message)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in message.ToCharArray())
            {
                if (isValidCharacter(item))
                {
                    if (item.IsLowerCase())
                    {
                        sb.Append(shiftForwardLowerCaseLetter(item, offset));
                        continue;
                    }
                    if (item.IsUpperCase())
                    {
                        sb.Append(shiftForwardUpperCaseLetter(item, offset));
                        continue;
                    }
                    sb.Append(item);
                }
                else
                {
                    throw new Exception("message must be alphanumeric only");
                }
            }
            return sb.ToString();
        }

        public string Decrypt(string encryptedMessage)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in encryptedMessage.ToCharArray())
            {
                if (isValidCharacter(item))
                {
                    if (item.IsLowerCase())
                    {
                        sb.Append(shiftBackwardLowerCaseLetter(item, offset));
                        continue;
                    }
                    if (item.IsUpperCase())
                    {
                        sb.Append(shiftBackwardUpperCaseLetter(item, offset));
                        continue;
                    }
                    sb.Append(item);
                }
                else
                {
                    throw new Exception("message must be alphanumeric only");
                }
            }
            return sb.ToString();
        }

        private char shiftForwardLowerCaseLetter(char item, int offset)
        {
            int totalValue = (int)item + offset;
            if(totalValue > 122)
            {
                return (char)((totalValue - 122) + 97);
            }
            return (char)totalValue;
        }
        private char shiftForwardUpperCaseLetter(char item, int offset)
        {
            int totalValue = (int)item + offset;
            if (totalValue > 90)
            {
                return (char)((totalValue - 90) + 65);
            }
            return (char)totalValue;
        }

        private char shiftBackwardLowerCaseLetter(char item, int offset)
        {
            int totalValue = (int)item - offset;
            if (totalValue < 97)
            {
                return (char)(122 - (97-totalValue));
            }
            return (char)totalValue;
        }
        private char shiftBackwardUpperCaseLetter(char item, int offset)
        {
            int totalValue = (int)item - offset;
            if (totalValue < 65)
            {
                return (char)(65 - (90 - totalValue ));
            }
            return (char)totalValue;
        }

        private bool isValidCharacter (char character)
        {
            return character.IsLowerCase() || character.IsUpperCase() || character.IsSpace();
        }
    }
}
