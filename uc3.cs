class AddressBook
{
    private List<Contact> contacts = new List<Contact>();
    public void AddContact(Contact contact)
    {
        contacts.Add(contact);
    }
    public void DeleteContact(string firstName, string lastName)
    {
        Contact contactToRemove = contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);
        if (contactToRemove != null)
        {
            contacts.Remove(contactToRemove);
            Console.WriteLine("Contact deleted successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
    public void EditContact(string firstName, string lastName)
    {
        Contact contactToEdit = contacts.Find(c => c.FirstName == firstName && c.LastName == lastName);
        if (contactToEdit != null)
        {
            Console.WriteLine("Enter new details:");
            Console.Write("First Name: ");
            contactToEdit.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            contactToEdit.LastName = Console.ReadLine();
            Console.Write("Address: ");
            contactToEdit.Address = Console.ReadLine();
            Console.Write("City: ");
            contactToEdit.City = Console.ReadLine();
            Console.Write("State: ");
            contactToEdit.State = Console.ReadLine();
            Console.Write("Zip: ");
            contactToEdit.Zip = Console.ReadLine();
            Console.Write("Phone Number: ");
            contactToEdit.PhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            contactToEdit.Email = Console.ReadLine();
            Console.WriteLine("Contact edited successfully.");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
    public void DisplayContacts()
    {
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
}
