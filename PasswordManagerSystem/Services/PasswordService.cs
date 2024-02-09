using PasswordManagerSystem.Data;
using PasswordManagerSystem.Helpers;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;
using System.Collections.Generic;

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
        
        public IEnumerable<PasswordModel> GetAllPasswordsByUserId(int userId, string searchstr)
        {
            return _passwordRepository.GetAllPasswordsByUserId(userId, searchstr);
        }

        public void CreatePassword(Password password)
        {
            password.PasswordValue = FormHelper.EncryptData(password.PasswordValue);
            _passwordRepository.CreatePassword(password);
        }

        public void UpdatePassword(Password password)
        {
            password.PasswordValue = FormHelper.EncryptData(password.PasswordValue);
            _passwordRepository.UpdatePassword(password);
        }

        public void DeletePassword(int passwordId)
        {
            _passwordRepository.DeletePassword(passwordId);
        }
    }
}
