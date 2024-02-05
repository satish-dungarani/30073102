using PasswordManagerSystem.Models;
using System.Collections.Generic;

namespace PasswordManagerSystem.Repositories
{
    public interface IPasswordApplicationRepository
    {
        PasswordApplication GetApplicationById(int applicationId);
        IEnumerable<PasswordApplication> GetAllApplications();
        void CreateApplication(PasswordApplication application);
        void UpdateApplication(PasswordApplication application);
        void DeleteApplication(int applicationId);
    }

}