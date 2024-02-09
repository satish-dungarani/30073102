using PasswordManagerSystem.Data;
using PasswordManagerSystem.Models;
using System.Collections.Generic;
namespace PasswordManagerSystem.Repositories
{
    public interface IPasswordHistoryRepository
    {
        IEnumerable<HistoryModel> GetPasswordHistoriesByUserId(int userId, string searchstr);
        void CreatePasswordHistory(PasswordHistory passwordHistory);
    }
}
