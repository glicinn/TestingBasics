using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailStub
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string emailName = "dimaderen1@gmail.com";

            MailManager mgr = new MailManager();

            if (mgr.FindEMail(emailName))
            {
                Console.WriteLine("Email {0} is found!", emailName);
            }
            else
            {
                Console.WriteLine("Email {0} is not found!", emailName);
            }

            Console.ReadKey();
        }
    }
}
