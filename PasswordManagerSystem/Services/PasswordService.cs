using System.Collections.Generic;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;

namespace PasswordManagerSystem.Services
{
    public class PasswordService
    {
        private readonly IPasswordRepository _passwordRepository;

        public PasswordService(IPasswordRepository passwordRepository)
        {
            _passwordRepository = passwordRepository;
        }

        public Password GetPasswordById(int passwordId)
        {
            return _passwordRepository.GetPasswordById(passwordId);
        }

        public IEnumerable<Password> GetAllPasswords()
        {
            return _passwordRepository.GetAllPasswords();
        }
        
        public IEnumerable<PasswordModel> GetAllPasswordsByUserId(int userId, string searchstr)
        {
            return _passwordRepository.GetAllPasswordsByUserId(userId, searchstr);
        }

        public void CreatePassword(Password password)
        {
            _passwordRepository.CreatePassword(password);
        }

        public void UpdatePassword(Password password)
        {
            _passwordRepository.UpdatePassword(password);
        }

        public void DeletePassword(int passwordId)
        {
            _passwordRepository.DeletePassword(passwordId);
        }
    }
}
