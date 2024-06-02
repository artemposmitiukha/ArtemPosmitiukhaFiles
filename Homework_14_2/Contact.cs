namespace Homework_14_2
{
    public class Contact
    {
        internal string Name { get; set; }
        internal string Number { get; set; }

        public Contact(string name, string number)
        {
            Name = name;
            Number = number;
        }

    }
}