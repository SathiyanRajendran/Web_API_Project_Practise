namespace LibraryManagement.API.Models
{
    public class Member
    {
        public int Id { get; set; } // رقم العضو
        public string Name { get; set; } // اسم العضو
        public string Email { get; set; } // إيميل العضو

        // علاقة One-to-Many مع الاستعارات
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
