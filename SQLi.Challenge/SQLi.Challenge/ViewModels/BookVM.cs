using System.ComponentModel.DataAnnotations;

namespace SQLi.Challenge.ViewModels
{
    public class BookVM
    {
        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(50, ErrorMessage = "The Title must be less than 50 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The ISBN field is required.")]
        [StringLength(19, MinimumLength = 5, ErrorMessage = "The ISBN must be between 5 and 19 characters.")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "The Author field is required.")]
        [StringLength(80, ErrorMessage = "The Author name must be less than 80 characters.")]
        public string Author { get; set; }  

        [Required(ErrorMessage = "The Price field is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "The Price must be greater than zero.")]
        public double Price { get; set; }

        [Required(ErrorMessage = "The Quantity field is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "The Quantity cannot be negative.")]
        public int Quantity { get; set; }
        public int PublishYear { get; set; }
    }
}
