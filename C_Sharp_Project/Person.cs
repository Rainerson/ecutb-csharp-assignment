

namespace C_Sharp_Project
{
    internal interface IPerson
    {
        Guid Id { get; set; }
        string FirstName { get; set; }

        string LastName { get; set; } 

        string Email { get; set; } 

        string PhoneNumber { get; set; } 

        string Adress { get; set; }

    }
    public class Person : IPerson
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string Adress { get; set; } = null!;
    }
}
