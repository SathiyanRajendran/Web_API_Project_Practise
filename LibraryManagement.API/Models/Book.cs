namespace LibraryManagement.API.Models
{
    public class Book
    {
        public int Id { get; set; } // رقم الكتاب - Book ID
        public string Title { get; set; } // عنوان الكتاب - Title
        public DateTime PublishedDate { get; set; } // تاريخ النشر - Published Date
        public bool IsAvailable { get; set; } // متاح للاستعارة - Availability

        // مفتاح أجنبي - Foreign Key
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        // علاقة One-to-Many مع Borrow
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
