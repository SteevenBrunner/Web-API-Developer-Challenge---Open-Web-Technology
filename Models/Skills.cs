using System.ComponentModel.DataAnnotations;

namespace Web_API_Developer_Challenge___Open_Web_Technology.Models
{
    public class Skills
    {
        public enum Levels
        {
            Beginner,
            Intermediate,
            Advanced,
            Expert
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Level is required")]
        public Levels Level { get; set; }

    }
}