using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailStub
{
    public class MailManager
    {
        public bool FindEMail(string emailName)
        {
            TestDataObject obj = new TestDataObject();

            List<string> emails = obj.GetEmails();

            foreach (var email in emails)
            {
                if (email.Contains(emailName))
                {
                    return true;
                }

            }
            return false;
        }
    }
}
