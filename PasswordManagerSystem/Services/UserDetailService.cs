using System.Collections.Generic;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;

namespace PasswordManagerSystem.Services
{
    public class UserDetailService
    {
        private readonly IUserDetailRepository _userDetailRepository;

        public UserDetailService(IUserDetailRepository userDetailRepository)
        {
            _userDetailRepository = userDetailRepository;
        }

        public UserDetail GetUserDetailById(int userDetailId)
        {
            return _userDetailRepository.GetUserDetailById(userDetailId);
        }

        public IEnumerable<UserDetail> GetAllUserDetails()
        {
            return _userDetailRepository.GetAllUserDetails();
        }

        public void CreateUserDetail(UserDetail userDetail)
        {
            // Additional business logic or validation can be added here
            _userDetailRepository.CreateUserDetail(userDetail);
        }

        public void UpdateUserDetail(UserDetail userDetail)
        {
            // Additional business logic or validation can be added here
            _userDetailRepository.UpdateUserDetail(userDetail);
        }

        public void DeleteUserDetail(int userDetailId)
        {
            // Additional business logic or validation can be added here
            _userDetailRepository.DeleteUserDetail(userDetailId);
        }
    }
}
