using System.Collections.Generic;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;

namespace PasswordManagerSystem.Services
{
    public class PasswordHistoryService
    {
        private readonly IPasswordHistoryRepository _passwordHistoryRepository;

        public PasswordHistoryService(IPasswordHistoryRepository passwordHistoryRepository)
        {
            _passwordHistoryRepository = passwordHistoryRepository;
        }

        public IEnumerable<PasswordHistory> GetPasswordHistories(int passwordId)
        {
            return _passwordHistoryRepository.GetPasswordHistories(passwordId);
        }

        public void CreatePasswordHistory(PasswordHistory passwordHistory)
        {
            // Additional business logic or validation can be added here
            _passwordHistoryRepository.CreatePasswordHistory(passwordHistory);
        }
    }
}
