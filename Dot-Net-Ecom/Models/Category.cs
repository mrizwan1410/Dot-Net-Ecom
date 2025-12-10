using System.ComponentModel.DataAnnotations;

namespace Dot_Net_Ecom.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
