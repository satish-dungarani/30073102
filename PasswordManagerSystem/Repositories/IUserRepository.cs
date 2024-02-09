using PasswordManagerSystem.Data;
using PasswordManagerSystem.Models;
using System.Collections.Generic;
namespace PasswordManagerSystem.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int userId);
        IEnumerable<UserModel> GetAllUsers(string searchstr);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int userId);
        User GetUserByUsernameAndPassword(string username, string password);
    }
}
