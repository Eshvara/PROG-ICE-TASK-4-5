using System.ComponentModel.DataAnnotations;

namespace Book_Haven.Models
{
    public class Category
    {

        //VARIABLES

        [Key]

        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }

    }
}
