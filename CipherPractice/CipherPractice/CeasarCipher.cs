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
            foreach(var item in message.ToCharArray())
            {
                if (isValidCharacter(item))
                {

                }
                else
                {
                    throw new Exception("message must be alphanumeric only");
                }
            }
        }

        public string Decrypt(string encryptedMessage)
        {
            throw new NotImplementedException();
        }

        private bool isValidCharacter (char character)
        {
            return character.IsLowerCase() || character.IsUpperCase() || character.IsSpace();
        }
    }
}
