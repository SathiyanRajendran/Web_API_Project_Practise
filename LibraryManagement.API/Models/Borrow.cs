using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.API.Models
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; } // رقم عملية الاستعارة - Borrow ID

        // علاقة مع Book
        [Required]
        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book? Book { get; set; } // nullable

        // علاقة مع Member
        [Required]
        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
        public Member? Member { get; set; } // nullable

        [Required]
        public DateTime BorrowDate { get; set; } // تاريخ الاستعارة

        public DateTime? ReturnDate { get; set; } // تاريخ الإرجاع (nullable)
    }
}
