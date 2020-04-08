using System;
using System.Collections.Generic;
using System.Text;

namespace CipherPractice
{
   public interface ICipher
    {
        public string Encrypt(string message);
        public string Decrypt(string encryptedMessage);
    }
}
