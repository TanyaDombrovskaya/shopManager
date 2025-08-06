using ShopManager.Data.Models;
using ShopManager.Data.Repositories;
using ShopManager.Utilities;
using System;

namespace ShopManager.Services
{
    public class AuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Login(string username, string password)
        {
            try
            {
                Console.WriteLine($"Attempting login for user: {username}");

                var user = _userRepository.GetUserByUsername(username);
                Console.WriteLine($"User retrieved from DB: {(user != null ? "Exists" : "NULL")}");

                if (user == null)
                {
                    Console.WriteLine("Login failed: User not found");
                    return null;
                }

                Console.WriteLine($"User details - Role: {user.Role}, IsBanned: {user.IsBanned}");

                if (user.IsBanned)
                {
                    Console.WriteLine("Login failed: User is banned");
                    throw new Exception("Ваш аккаунт заблокирован. Обратитесь к администратору.");
                }

                bool passwordValid = PasswordHasher.VerifyPassword(password, user.PasswordHash);
                Console.WriteLine($"Password verification: {passwordValid}");

                if (!passwordValid)
                {
                    Console.WriteLine("Login failed: Invalid password");
                    return null;
                }

                Console.WriteLine($"Login successful for user: {username}");
                return user;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"CRITICAL LOGIN ERROR: {ex.ToString()}");
                throw new Exception("Произошла ошибка при входе в систему", ex);
            }
        }

        public User Register(string username, string password, string email)
        {
            if (_userRepository.GetUserByUsername(username) != null)
            {
                throw new Exception("Пользователь с таким именем уже существует");
            }

            if (_userRepository.GetUserByEmail(email) != null)
            {
                throw new Exception("Пользователь с таким email уже существует");
            }

            var newUser = new User
            {
                Username = username,
                PasswordHash = PasswordHasher.HashPassword(password),
                Email = email,
                Role = "User",
                IsBanned = false
            };

            _userRepository.AddUser(newUser);
            return newUser;
        }

        public User GetUserByUsername(string username)
        {
            return _userRepository.GetUserByUsername(username);
        }

        public bool UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }
    }
}