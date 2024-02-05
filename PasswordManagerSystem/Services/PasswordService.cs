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

        public void CreatePassword(Password password)
        {
            // Additional business logic or validation can be added here
            _passwordRepository.CreatePassword(password);
        }

        public void UpdatePassword(Password password)
        {
            // Additional business logic or validation can be added here
            _passwordRepository.UpdatePassword(password);
        }

        public void DeletePassword(int passwordId)
        {
            // Additional business logic or validation can be added here
            _passwordRepository.DeletePassword(passwordId);
        }
    }
}
