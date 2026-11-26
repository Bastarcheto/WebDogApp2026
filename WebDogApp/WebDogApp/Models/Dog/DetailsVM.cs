using System.ComponentModel.DataAnnotations;

namespace WebDogApp.Models.Dog
{
    public class DetailsVM
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Dog Name")]
        public string Name { get; set; } = null!;
        [Range(0, 30, ErrorMessage = "Age must be between 0 and 30")]
        [Display(Name = "Age")]
        public int Age { get; set; }
        [Display(Name = "Breed")]
        public string BreedName { get; set; } = null!;
        [Display(Name = "Dog Picture")]
        public string? Picture { get; set; } = null!;
    }
}
