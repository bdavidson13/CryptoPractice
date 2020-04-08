using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherPractice
{
    public class SubsititutionCipher
    {
        private Dictionary<char, char> cipherKey;

        public SubsititutionCipher(Dictionary<char, char> key)
        {
            if (isValidCipherKey(key))
            {
                cipherKey = key;
            }
            else
            {
                throw new NotSupportedException("cipherkey is invalid");
            }
        }
        public string Encrypt (string message)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in message.ToLower().ToCharArray())
            {
                sb.Append(item == ' '? item : cipherKey[item]);
            }
            return sb.ToString();
        }
        public string Decrypt (string encryptedMessage)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char item in encryptedMessage.ToLower().ToCharArray())
            {
                sb.Append(item == ' ' ? item : cipherKey.FirstOrDefault(x => x.Value == item).Key);
            }
            return sb.ToString();
        }

        private bool isValidCipherKey(Dictionary<char, char> key)
        {
            if (key.Count > 26)
            {
                return false;
            }
                bool valid = true;
            foreach(var pair in key)
            {
                if (!char.IsLetter(pair.Key) || !char.IsLetter(pair.Value))
                {
                    valid = false;
                    break;
                }
                if (key.Values.Where(val=> val == pair.Value).Count() > 1)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
