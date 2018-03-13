using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppReflection
{
    [Table("Persona")]
    public class Person
    {
        public int Id { get; set; }
        public string LastName { get; set; }


        public string FullName(string name, string lastName)
        {
            return "";
        }
    }
}
