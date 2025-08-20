using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.API.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; } //  Borrow ID

        // Relation With Book
        [Required]
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book? Book { get; set; } 

        // Relation With Member
        [Required]
        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
        public Member? Member { get; set; } 

        [Required]
        public DateTime BorrowDate { get; set; } 

        public DateTime? ReturnDate { get; set; } 
    }
}
