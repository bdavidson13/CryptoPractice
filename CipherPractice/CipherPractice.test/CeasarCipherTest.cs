using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
namespace CipherPractice.test
{
    [TestClass]
    public class CeasarCipherTest
    {
        [TestInitialize]
        public void Setup()
        {
            new CeasarCipherTest();
        }

        [TestCleanup]
        public void Cleanup()
        {

        }

        [TestMethod]
        public void TestThatEncryptedMessageDecryptsCorrectly()
        {
            string message = "Hello World";
            int offset = 3;
            CeasarCipher cipher = new CeasarCipher(offset);
            string encryptedMessage = cipher.Encrypt(message);
            string decryptedMessage = cipher.Decrypt(encryptedMessage);
            Assert.AreEqual(message, decryptedMessage, string.Concat("decrypted message : ", decryptedMessage, " does not match original message :", message));
        }
    }
}
