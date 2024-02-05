using PasswordManagerSystem.Models;
using System.Collections.Generic;
namespace PasswordManagerSystem.Repositories
{
    public interface IPasswordHistoryRepository
{
    IEnumerable<PasswordHistory> GetPasswordHistories(int passwordId);
    void CreatePasswordHistory(PasswordHistory passwordHistory);
    // Add other methods if needed
}
}
