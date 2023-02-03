
namespace C_Sharp_Project.Tests
{
    [TestClass]
    public class Add_Contact_Test
    {
        [TestMethod]
        public void Add_Contact_To_List()
        {

            //arrange
            Person person = new Person();
            List<Person> persons = new List<Person>();

            //act
            persons.Add(person);

            //assert
            Assert.AreEqual(1, persons.Count);
        }
    }
}