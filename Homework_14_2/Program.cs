
namespace Homework_14_2
{

    class Program
    {
        static void DisplayMenu()
        {
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Remove contact");
            Console.WriteLine("3. Get contact");
            Console.WriteLine("4. Change contact");
            Console.WriteLine("5. Show contacts");
            Console.WriteLine("6. Exit");
        }
        static void Main(string[] args)
        {
            ContactManager manager = new ContactManager();
            while (true)
            {
                DisplayMenu();

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Enter contact name: ");
                        string name_1 = Console.ReadLine() ?? "Invalid name";
                        Console.Write("Enter contact number: ");
                        string number_1 = Console.ReadLine() ?? "Invalid number";
                        var contact_1 = new Contact(name_1, number_1);
                        manager.AddContact(contact_1);
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter contact name: ");
                        string name_2 = Console.ReadLine();
                        manager.RemoveContact(name_2);
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("Enter contact name: ");
                        string name_3 = Console.ReadLine();
                        Console.WriteLine(manager.GetContact(name_3));
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter contact name: ");
                        string name_4 = Console.ReadLine();
                        Console.Write("Enter new contact number: ");
                        string number_4 = Console.ReadLine();
                        manager.ChangeContact(name_4, number_4);
                        break;
                    case 5:
                        Console.Clear();
                        manager.ShowContacts();
                        break;
                    case 6:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("There's no such options");
                        break;


                }
            }
        }
    }
}