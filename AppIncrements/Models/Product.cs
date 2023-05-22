using AppIncrements.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace AppIncrements.Models
{
    public class Product : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Item")]
        [Required(ErrorMessage = "The Item Name is Required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The Item name must be between 3 to 20 chars")]
        public string Item { get; set; }
        [Display(Name = "Photo")]
        [Required(ErrorMessage = "The Item Photo is Required")]
        public string Logo { get; set; }
        [Display(Name = "Category")]
        [Required(ErrorMessage = "The Item Category is Required")]
        public string Category { get; set; }
        [Display(Name = "Specification")]
        [Required(ErrorMessage = "The Item Specification is Required")]
        public string Specification { get; set; }
        [Required(ErrorMessage = "The Item Price is Required")]
        public double Price { get; set; }




    }
}
