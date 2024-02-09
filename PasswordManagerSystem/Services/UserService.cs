using PasswordManagerSystem.Data;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;
using System.Collections.Generic;
using System.Linq;

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

        public void CreateUser(User user)
        {
            _userRepository.CreateUser(user);
        }

        public void DeleteUser(int userId)
        {
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

        public List<UserModel> GetAllUserDetails(string searchstr)
        {
            return _userRepository.GetAllUsers(searchstr).ToList();
        }
    }
}
