using System.ComponentModel.DataAnnotations;

namespace BookMart.Models
{
    public class AuthorViewModel
    {
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; } = string.Empty;

        [Display(Name = "Genre")]
        public string Genre { get; set; } = string.Empty;
    }
}