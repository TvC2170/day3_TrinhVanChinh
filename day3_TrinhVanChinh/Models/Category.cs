using System.ComponentModel.DataAnnotations;

namespace day3_TrinhVanChinh.Models
{
    public class Category
    {

        [Required(ErrorMessage = "Id is required")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 2 ,ErrorMessage = "Name cannot exceed 100 characters or lower than 2 characters")]
        public string? Name { get; set; } 
    }
}
