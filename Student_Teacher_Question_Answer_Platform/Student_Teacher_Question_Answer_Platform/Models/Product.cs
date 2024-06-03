using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Student_Teacher_Question_Answer_Platform.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }

        public int Qty { get; set; }

    }
}
