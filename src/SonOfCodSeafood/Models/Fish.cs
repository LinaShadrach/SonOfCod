using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SonOfCodSeafood.Models
{
    [Table("Fish")]
    public class Fish
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
