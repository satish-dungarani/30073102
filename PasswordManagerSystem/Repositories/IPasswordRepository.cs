using PasswordManagerSystem.Models;
using System.Collections.Generic;
namespace PasswordManagerSystem.Repositories
{
    public interface IPasswordRepository
    {
        Password GetPasswordById(int passwordId);
        IEnumerable<Password> GetAllPasswords();
        void CreatePassword(Password password);
        void UpdatePassword(Password password);
        void DeletePassword(int passwordId);
        IEnumerable<PasswordModel> GetAllPasswordsByUserId(int userId, string searchstr);
    }
}
