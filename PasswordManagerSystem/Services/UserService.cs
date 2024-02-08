using System.Collections.Generic;
using System.Linq;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;

namespace PasswordManagerSystem.Services
{
    public class UserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserDetailRepository _userDetailRepository;

        public UserService(IUserRepository userRepository, IUserDetailRepository userDetailRepository)
        {
            _userRepository = userRepository;
            _userDetailRepository = userDetailRepository;
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
            // Additional business logic or valida_userRepositorytion can be added here
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
        public ProfileModel GetUserByUsernameAndPassword(string username, string password)
        {
            var user = _userRepository.GetUserByUsernameAndPassword(username, password);
            if (user == null) 
                return null;

            return new ProfileModel
            {
                user = user,
                userDetail = _userDetailRepository.GetAllUserDetails().FirstOrDefault(x => x.UserId == user.Id)
            };
        }
    }
}
