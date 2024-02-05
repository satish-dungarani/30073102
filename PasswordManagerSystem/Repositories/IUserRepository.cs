using PasswordManagerSystem.Models;
using System.Collections.Generic;
namespace PasswordManagerSystem.Repositories
{
    public interface IUserRepository
{
    User GetUserById(int userId);
    IEnumerable<User> GetAllUsers();
    void CreateUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int userId);
}
}
