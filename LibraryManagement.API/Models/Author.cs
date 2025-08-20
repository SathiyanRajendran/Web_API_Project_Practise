using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models
{
    public class Author
    {
        public int Id { get; set; } //  Author ID
        public string? Name { get; set; } //  Author Name
        public string? Country { get; set; } //  Country

        //  One-to-Many With Book
        public ICollection<Book>? Books { get; set; }
    }
}
