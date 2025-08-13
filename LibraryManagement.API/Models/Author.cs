using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.API.Models
{
    public class Author
    {
        public int Id { get; set; } // رقم المؤلف - Author ID
        public string? Name { get; set; } // اسم المؤلف - Author Name
        public string? Country { get; set; } // بلد المؤلف - Country

        // علاقة One-to-Many مع Book
        public ICollection<Book>? Books { get; set; }
    }
}
