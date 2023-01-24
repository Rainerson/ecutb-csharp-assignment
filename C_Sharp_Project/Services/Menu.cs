using Newtonsoft.Json;

namespace C_Sharp_Project.Services
{
    internal class Menu
    {

        private List<IPerson> persons = new List<IPerson>();
        private FileService file = new FileService();

        public string FilePath { get; set; } = null!;
        public void WecomeMenu()
        {
            Console.WriteLine("Välkommen till Adressboken");
            Console.WriteLine("1. Skapa en kontakt");
            Console.WriteLine("2. Visa alla kontakter");
            Console.WriteLine("3. Visa en specifik kontakt");
            Console.WriteLine("4. Ta bort en kontakt");
            Console.WriteLine("Välj ett av alternativen ovan");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateContact(); break;
                case "2": ShowAllContacts(); break;
                case "3": ShowOneContact(); break;
                case "4": RemoveContact(); break;
            }
        }

        private void CreateContact()
        {
            Console.Clear();
            Console.WriteLine("Skapa en ny kontakt");

            IPerson person = new Person();
            Console.Write("Ange Förnamn:");
            person.FirstName = Console.ReadLine() ?? null!;
            Console.Write("Ange Efternamn:");
            person.LastName = Console.ReadLine() ?? null!;
            Console.Write("Ange E-post:");
            person.Email = Console.ReadLine() ?? null!;
            Console.Write("Ange Telefonnummer:");
            person.PhoneNumber = Console.ReadLine() ?? null!;
            Console.Write("Ange Adress");
            person.Adress = Console.ReadLine() ?? null!;

            persons.Add(person);
            file.SaveToFile(FilePath, JsonConvert.SerializeObject(new { persons }));
        }

        private void ShowAllContacts()
        {
        }

        private void ShowOneContact()
        {
        }

        private void RemoveContact()
        {
        }

    }



}
