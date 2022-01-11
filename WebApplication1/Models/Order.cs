using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Order
    {

        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Order Name")]
        [StringLength(20), MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Product Description of minimum 5 characters")]
        [StringLength(100), MinLength(5)]
        public string Description { get; set; }
        [Required]
        public int Prrice { get; set; }
        [Required]
        public int Order_Quantity { get; set; }


      

    }
}
