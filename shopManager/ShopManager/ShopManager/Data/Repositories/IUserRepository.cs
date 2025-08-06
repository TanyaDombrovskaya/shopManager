using System.Collections.Generic;
using ShopManager.Data.Models;

namespace ShopManager.Data.Repositories
{
    public interface IUserRepository
    {
        void AddUser(User user);
        User GetUserById(int id);
        User GetUserByUsername(string username);
        User GetUserByEmail(string email);
        IEnumerable<User> GetAllUsers();
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        bool BanUser(int userId);
        bool UnbanUser(int userId);
        bool ChangeRole(int userId, string newRole);
        decimal GetBalance(int userId);
        bool AddBalance(int userId, decimal amount);
    }
}