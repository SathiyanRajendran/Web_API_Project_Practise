namespace LibraryManagement.API.Models
{
    public class Book
    {
        public int Id { get; set; } //  Book ID
        public string Title { get; set; } //  Title
        public DateTime PublishedDate { get; set; } //  Published Date
        public bool IsAvailable { get; set; } //  Availability

        //  Foreign Key
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        //  One-to-Many With Borrow
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
