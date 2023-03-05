using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }

    public class ProductCreateVM
    {
        [Required(ErrorMessage = "Product Title is Required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Product Description is Required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Product Price is Required")]
        [Range(0,int.MaxValue)]
        public decimal Price { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
    }
}
