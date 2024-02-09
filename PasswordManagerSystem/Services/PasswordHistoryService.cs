using PasswordManagerSystem.Data;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;
using System.Collections.Generic;

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
    }
}
