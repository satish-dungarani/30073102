using PasswordManagerSystem.Data;
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

    }
}
