using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CipherPractice
{
                                    //TODO
    /*****************************************************************************************
     * Right now we only have 26 lower case characters. We can't use uppercase. I would like *
     * to be able to use upper and lowercase characters.                                     *                                
     *                                                                                       *
     * Right now we don't encrypt the spaces so the length of words is evident. I would like *
     * to encrypt spaces as well so it's just one long string                                *
     ****************************************************************************************/
    public class SubsititutionCipher : ICipher
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
