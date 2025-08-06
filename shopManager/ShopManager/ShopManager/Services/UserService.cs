using System.Collections.Generic;
using ShopManager.Data.Models;
using ShopManager.Data.Repositories;

namespace ShopManager.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        public bool DeleteUser(int id)
        {
            return _userRepository.DeleteUser(id);
        }

        public bool BanUser(int userId)
        {
            return _userRepository.BanUser(userId);
        }

        public bool UnbanUser(int userId)
        {
            return _userRepository.UnbanUser(userId);
        }

        public bool ChangeUserRole(int userId, string newRole)
        {
            return _userRepository.ChangeRole(userId, newRole);
        }

        public decimal GetBalance(int userId)
        {
            return _userRepository.GetBalance(userId);
        }

        public bool AddBalance(int userId, decimal amount)
        {
            return _userRepository.AddBalance(userId, amount);
        }
    }
}