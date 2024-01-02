using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BookLibrary_Razor.Model
{
    public class BookCategory
    {

        public required int Id { get; set; }
        [DisplayName("Category Name")]
        [Required]
        [MaxLength(30)]
        public required String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(0, 100)]
        public required int DisplayOrder { get; set; }
    }
}
