using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppReflection
{
    [Table("Alumno")]
    public class Alumno
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
