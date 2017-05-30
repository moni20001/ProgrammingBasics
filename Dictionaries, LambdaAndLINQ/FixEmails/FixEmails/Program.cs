using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        var command = Console.ReadLine();
        Dictionary<string, string> emails = new Dictionary<string, string>();
        while (!command.Equals("stop"))
        {
            string email = Console.ReadLine();
            if (email.EndsWith("us")&& email.EndsWith("uk"))
            {

            }
                else
            {
                emails[command]= email;
            }
            command = Console.ReadLine();
        }

        foreach (var email in emails)
        {
            Console.WriteLine("{0} -> {1}",email.Key,email.Value);
        }
    }
}
