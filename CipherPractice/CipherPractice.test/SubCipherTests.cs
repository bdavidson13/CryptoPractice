using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CipherPractice.test
{
    [TestClass]
    public class SubCipherTests
    {
        private Dictionary<char, char> validMapping;
        private Dictionary<char, char> invalidMapping;

        [TestInitialize]
        public void setup()
        {
            validMapping = createValidMapping();
            new SubCipherTests();
        }


        [TestMethod]
        public void TestThatEncryptedMessageDecryptsToSameMessage()
        {
            string message = "hello crypto world";
            SubsititutionCipher cipher = new SubsititutionCipher(validMapping);
            string encryptedMessage = cipher.Encrypt(message);
            string decryptedMessage = cipher.Decrypt(encryptedMessage);
            Assert.AreEqual(message, decryptedMessage, String.Concat(message, " is not the same as ", decryptedMessage));
        }



        private Dictionary<char, char> createValidMapping()
        {
            Dictionary<char, char> mapping = new Dictionary<char, char>();
            mapping.Add('a', 'q');
            mapping.Add('b', 'w');
            mapping.Add('c', 'e');
            mapping.Add('d', 'r');
            mapping.Add('e', 't');
            mapping.Add('f', 'y');
            mapping.Add('g', 'u');
            mapping.Add('h', 'i');
            mapping.Add('i', 'o');
            mapping.Add('j', 'p');
            mapping.Add('k', 'a');
            mapping.Add('l', 's');
            mapping.Add('m', 'd');
            mapping.Add('n', 'f');
            mapping.Add('o', 'g');
            mapping.Add('p', 'h');
            mapping.Add('q', 'j');
            mapping.Add('r', 'k');
            mapping.Add('s', 'l');
            mapping.Add('t', 'z');
            mapping.Add('u', 'x');
            mapping.Add('v', 'c');
            mapping.Add('w', 'v');
            mapping.Add('x', 'b');
            mapping.Add('y', 'n');
            mapping.Add('z', 'm');
            return mapping;
        }
    }
}
