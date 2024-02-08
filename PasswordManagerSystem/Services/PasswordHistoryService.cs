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

        public IEnumerable<HistoryModel> GetPasswordHistoriesByUserId(int userId, string searchstr)
        {
            return _passwordHistoryRepository.GetPasswordHistoriesByUserId(userId, searchstr);
        }

        public void CreatePasswordHistory(PasswordHistory passwordHistory)
        {
            _passwordHistoryRepository.CreatePasswordHistory(passwordHistory);
        }
    }
}
