namespace Homework_14_2
{

    public class ContactManager
    {
        public Dictionary<string, string> contactList = new Dictionary<string, string>();
        public void AddContact(Contact contact)
        {
            if (string.IsNullOrEmpty(contact.Name) || string.IsNullOrEmpty(contact.Number))
                Console.WriteLine("Invalid contact info!");
            else
            {
                contactList.Add(contact.Name, contact.Number);
                Console.WriteLine($"Name: {contact.Name} | Number: {contact.Number}");
            }
        }
        public void RemoveContact(string name)
        {
            if (contactList.ContainsKey(name))
                contactList.Remove(name);
            else
                Console.WriteLine("There's no such contact!");
        }
        public string GetContact(string contactId)
        {
            if (contactList.ContainsKey(contactId))
                return contactList[contactId];
            else
                return "There's no such contact!";

        }
        public void ChangeContact(string contactId, string newContact)
        {
            if (contactList.ContainsKey(contactId))
                contactList[contactId] = newContact;
            else
                Console.WriteLine("There's no such contact!");
        }
        public void ShowContacts()
        {
            foreach (var contact in contactList)
            {
                Console.WriteLine($"Name: {contact.Key} | Number: {contact.Value}");
            }
        }
    }
}