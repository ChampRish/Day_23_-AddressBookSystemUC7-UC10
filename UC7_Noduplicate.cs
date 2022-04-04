using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_23__AddressBookSystemUC7_UC10
{
    public class UC7_Noduplicate
    {
        List<Contact> AddressList = new List<Contact>();
        Dictionary<string, List<Contact>> MultipleAddressbook = new Dictionary<string, List<Contact>>();
        public void AddContact(Contact newcontact)
        {
            AddressList.Add(newcontact);
            MultipleAddressbook.Add(newcontact.firstname, AddressList);
        }



        public void AddUniqueContact(string uniquename)
        {
            foreach (var contact in AddressList)
            {
                if (contact.firstname.Equals(uniquename))
                {
                    Contact multiplecontact = new Contact();

                    Console.WriteLine("Contact already exist , Enter unique name");
                    multiplecontact.firstname = Console.ReadLine();
                    multiplecontact.lastname = Console.ReadLine();
                    multiplecontact.address = Console.ReadLine();
                    multiplecontact.city = Console.ReadLine();
                    multiplecontact.state = Console.ReadLine();
                    multiplecontact.zip = Console.ReadLine();
                    multiplecontact.phonenumber = Console.ReadLine();
                    multiplecontact.emailid = Console.ReadLine();
                    AddContact(multiplecontact);
                }
            }
        }
        public void DisplayUniqueContacts()
        {
            Console.WriteLine("Enter firstname to display that contact details");
            string name = Console.ReadLine().ToLower();
            foreach (var contacts in MultipleAddressbook)
            {
                if (contacts.Key == name)
                {
                    foreach (var data in contacts.Value)
                    {
                        Console.WriteLine("The Contact details of " + data.firstname + "are : \n" + data.firstname + " " + data.lastname + " " + data.address + " " + data.city + " " + data.state + " " + data.zip + " " + data.phonenumber + " " + data.emailid);
                    }
                }

            }
        }

    }
}



