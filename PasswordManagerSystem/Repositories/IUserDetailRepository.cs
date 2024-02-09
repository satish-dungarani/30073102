using PasswordManagerSystem.Data;
using System.Collections.Generic;
namespace PasswordManagerSystem.Repositories
{
    public interface IUserDetailRepository
{
    UserDetail GetUserDetailById(int userDetailId);
    IEnumerable<UserDetail> GetAllUserDetails();
    void CreateUserDetail(UserDetail userDetail);
    void UpdateUserDetail(UserDetail userDetail);
    void DeleteUserDetail(int userDetailId);
}
}
