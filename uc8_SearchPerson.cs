using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_23__AddressBookSystemUC7_UC10
{
    internal class uc8_SearchPerson
    {
        List<Contact> AddressList = new List<Contact>();
        Dictionary<string, List<Contact>> MultipleAddressbook = new Dictionary<string, List<Contact>>();

        public void Search_person_city_state()
        {

            Console.WriteLine("Enter your Choice for Searching a Person in");
            Console.WriteLine("\n1.City \n2.State");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter City Name:");
                    String City = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.city == City))
                    {
                        Console.WriteLine(data.firstname + " " + data.lastname + " is from " + data.city);
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter State Name:");
                    String State = Console.ReadLine();

                    foreach (Contact data in this.AddressList.FindAll(e => e.state == State))
                    {
                        Console.WriteLine(data.firstname + " " + data.lastname + " is from " + data.state);
                    }
                    break;

            }


        }
    }
}
