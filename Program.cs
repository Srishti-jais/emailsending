using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2emailsender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email, sub, msg;
            Console.Write("enter the email");
            email = Console.ReadLine();
            Console.Write("enter the subject");
            sub = Console.ReadLine();
            Console.WriteLine("enter the msg");
            msg = Console.ReadLine();
            mailer mr= new mailer();
            bool res=mr.SendMyEmail(email, sub, msg);
            if (res == true)
            {
                Console.WriteLine("email sended successfully");
            }
            else
            {
                Console.WriteLine("email doesnot send successfully"); 
            }
        }
    }
}
