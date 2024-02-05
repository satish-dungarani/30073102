using System.Collections.Generic;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;

namespace PasswordManagerSystem.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUserById(int userId)
        {
            return _userRepository.GetUserById(userId);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public void CreateUser(User user)
        {
            // Additional business logic or validation can be added here
            _userRepository.CreateUser(user);
        }

        public void UpdateUser(User user)
        {
            // Additional business logic or validation can be added here
            _userRepository.UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            // Additional business logic or validation can be added here
            _userRepository.DeleteUser(userId);
        }
    }
}
