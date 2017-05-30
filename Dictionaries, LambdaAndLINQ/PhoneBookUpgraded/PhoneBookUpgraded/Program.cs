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
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        while (!command.Equals("END"))
        {
            var arr = command.Split(' ');
            if (arr[0].Equals("A"))
            {
                string contact = arr[1];
                string number = arr[2];
                //add
                phonebook[contact] = number;

            }
            else if (arr[0].Equals("S"))
            {
                if (!phonebook.ContainsKey(arr[1]))
                {
                    Console.WriteLine("Contact {0} does not exist.", arr[1]);
                }
                else
                {
                    string contact = arr[1];
                    Console.WriteLine("{0} -> {1}", contact, phonebook[contact]);
                }
                //search
            }
            else if (arr[0].Equals("ListAll"))
            {
                var upgradedPhoneBook = phonebook.OrderBy(x => x.Key);
                foreach (var item in upgradedPhoneBook)
                {
                    Console.WriteLine("{0} -> {1}",item.Key,phonebook[item.Key]);
                }
            }
            command = Console.ReadLine();
        }
    }
}
