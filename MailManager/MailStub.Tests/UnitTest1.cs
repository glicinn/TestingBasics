using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MailStub.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EMailManager_FindEMailLogByName_1()
        {
            MailManager emailManager = new MailManager();
            string emailName = "dimaderen1@gmail.com";

            bool exists = emailManager.FindEMail(emailName);

            Assert.IsTrue(exists);
        }
    }
}
