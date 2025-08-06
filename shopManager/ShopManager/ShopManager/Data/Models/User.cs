namespace ShopManager.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public bool IsBanned { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal Balance { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Manager,
        User
    }
}