using System.ComponentModel.DataAnnotations;

namespace ChefsNDishes.Models
{
    public class Dish
    {

        [Required(ErrorMessage = "is required")]
        [MinLength(3, ErrorMessage = "must be at least 3 characters")]
        [Display(Name = "Dish Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(100,1500, ErrorMessage ="Realistic calorie range: 100-1500.")]
        [Display(Name = "# of Calories")]
        public int Calories { get; set; }
        [Required(ErrorMessage = "is required")]
        [Range(10,45, ErrorMessage ="please limit field: 10-45 characters")]
        [Display(Name = "Description of Dish")]
        public string Description { get; set; }

        [Required(ErrorMessage = "is required")]
        [Range(1,5, ErrorMessage ="Range: 1-5, least to most tasty")]
        [Display(Name = "Description of Dish")]
        public int Tastiness { get; set; }
        
        public Chef ChefId { get; set; }
    }
}