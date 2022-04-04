using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_23__AddressBookSystemUC7_UC10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            UC7_Noduplicate uniquename = new UC7_Noduplicate();
            Contact newcontact = new Contact();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Number to Execute the Address book Program \n1. Create contacts \n2. Add contact \n3. Edit contact \n4. Delete contact \n5. Add contact \n6. Add multiple Address Book with unique name \n7. Check For Duplicate \n8. Search person by city or state \n9. View person by city or state \n10. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 6:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        UC7_Noduplicate addContact = new UC7_Noduplicate();
                        addContact.AddUniqueContact("Rishabh");
                        break;
                    case 7:
                        Console.WriteLine("Enter the Unique Contact to be added: ");
                        UC7_Noduplicate noDuplicate = new UC7_Noduplicate();
                        noDuplicate.DisplayUniqueContacts();
                        break;

                    case 8:
                        uc8_SearchPerson searchPerson = new uc8_SearchPerson();
                        searchPerson.Search_person_city_state();
                        break;
                    case 9:
                        UC9_view_person_city_state viewPerson = new UC9_view_person_city_state();
                        viewPerson.view_person_city_state();
                        break;
                    case 10:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
}
    

