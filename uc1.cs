using Syste;
namespace Name
{
class AddressBookMain
{
    static void Main()
    {
        AddressBook addressBook = new AddressBook();

        while (true)
        {
            Console.WriteLine("\nAddress Book Menu:");
            Console.WriteLine("1. Add Cantact");
            Console.WriteLine("2. Delete Cantact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Display Cantacts");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                        Contact newContact = new Contact();

                    while (true)
                        {
                         Console.Write("First Name: ");
                         string firstName = Console.ReadLine();
                         string Pattern = "[A-Z]{1}[a-z]";
                         if (Regex.IsMatch(firstName, Pattern))
                         {
                         newContact.FirstName = firstName;
                         break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input (*Fist letter Should be Captal*)");
                            }
                        }
                    while(true)
                    {
                        Console.Write("Last Name: ");
                        string lastName = Console.ReadLine();
                        string Pattern = "[A-Z]{1}[a-z]";
                        if (Regex.IsMatch(lastName, Pattern))
                        {
                            newContact.LastName = lastName;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (*Fist letter Should be Captal*)");
                        }
                    }
                    
                    while(true)
                    {
                        Console.Write("Address: ");
                        string address= Console.ReadLine();
                        string pattern = "[A-Z]{1}[a-z0-9]";
                        if (Regex.IsMatch(address, pattern)==true)
                        {
                            newContact.Address = address;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (*Fist letter Should be Captal*)");
                        }
                    }
                    while (true)
                    {
                        Console.Write("City: ");
                        string city = Console.ReadLine();
                        string pattern = "[A-Z]{1}[a-z]";
                        if (Regex.IsMatch(city, pattern))
                        {
                            newContact.City = city;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (*Fist letter Should be Captal*)");
                        }
                    }
                    while(true)
                    {
                        Console.Write("State:");
                        string state = Console.ReadLine();
                        string pattern = "[A-Z]{1}[a-z]";
                        if (Regex.IsMatch(state, pattern))
                        {
                            newContact.State = state;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (*Fist letter Should be Captal*)");
                        }
                    }
                    while (true)
                    {
                        Console.Write("Zip:");
                        string zip = Console.ReadLine();
                        string pattern = "[0-9]{6}";
                        if (Regex.IsMatch(zip, pattern))
                        {
                            newContact.Zip = zip;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (Zip Only Have 6 Digits)");
                        }
                    }
                    while (true)
                    {
                        Console.Write("Phone:");
                        string phone = Console.ReadLine();
                        string pattern = "[0-9]{10}";
                        if (Regex.IsMatch(phone, pattern))
                        {
                            newContact.PhoneNumber = phone;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (Phone Number Only Have 10 Digits)");
                        }
                    }
                    while (true)
                    {
                        Console.Write("Email:");
                        string email = Console.ReadLine();
                        string pattern = "^[a-zA-Z0-9._]+@gmail\\.com$";
                        if (Regex.IsMatch(email, pattern))
                        {
                            newContact.Email = email;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input Enter Correct mail Address");
                        }
                    }
                        addressBook.AddContact(newContact);
                    break;


                case 2:

                            Console.Write("Enter First Name of contact to delete: ");
                            string deleteFirstName = Console.ReadLine();
                            Console.Write("Enter Last Name of contact to delete: ");
                            string deleteLastName = Console.ReadLine();
                            addressBook.DeleteContact(deleteFirstName, deleteLastName);
                            break;

                        case 3:

                            Console.Write("Enter First Name of contact to edit: ");
                            string editFirstName = Console.ReadLine();
                            Console.Write("Enter Last Name of contact to edit: ");
                            string editLastName = Console.ReadLine();
                            addressBook.EditContact(editFirstName, editLastName);
                            break;

                        case 4:

                            addressBook.DisplayContacts();
                            break;

                        case 5:

                            Environment.Exit(0);
                            break;

                        default:

                            Console.WriteLine("Invalid choice. Please try again.");
                            break;

                            break;
                        }
                    }
            }
        }
    }
