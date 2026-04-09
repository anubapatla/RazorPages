using System.ComponentModel.DataAnnotations;

namespace Razorpages.Models
{
    public class Books
    {
        public int Id { get; set; }
        [Required]
        [DisplayColumn("Book Title")]
        public string BookTitle { get; set; }

        [DisplayColumn("BookDescription")]
        public string BookDescription { get; set; }
        [Required]
        public string Author { get; set; }
    }
}
