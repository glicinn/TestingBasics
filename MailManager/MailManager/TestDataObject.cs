using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailStub
{
    internal class TestDataObject
    {
        public List<string> GetEmails()
        {
            List<string> list = new List<string>();
            list.Add("dimaderen1@gmail.com");
            list.Add("timurmarz@mail.ru");
            list.Add("sashka1488@gmail.com");
            list.Add("matheush@yandex.ru");

            return list;
        }
    }
}
