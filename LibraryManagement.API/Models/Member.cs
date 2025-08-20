namespace LibraryManagement.API.Models
{
    public class Member
    {
        public int Id { get; set; } // Member Id
        public string Name { get; set; } // Member Name
        public string Email { get; set; } // Member Email

        //  One-to-Many With Borrow
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
