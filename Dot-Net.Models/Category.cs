using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Dot_Net.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }

        [Range(1,100,ErrorMessage ="Display Order must be in range of 1 and 100")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
    }
}
