using System.Collections.Generic;
using PasswordManagerSystem.Models;
using PasswordManagerSystem.Repositories;

namespace PasswordManagerSystem.Services
{
    public class PasswordApplicationService
    {
        private readonly IPasswordApplicationRepository _passwordApplicationRepository;

        public PasswordApplicationService(IPasswordApplicationRepository passwordApplicationRepository)
        {
            _passwordApplicationRepository = passwordApplicationRepository;
        }

        public PasswordApplication GetApplicationById(int applicationId)
        {
            return _passwordApplicationRepository.GetApplicationById(applicationId);
        }

        public IEnumerable<PasswordApplication> GetAllApplications()
        {
            return _passwordApplicationRepository.GetAllApplications();
        }

        public void CreateApplication(PasswordApplication application)
        {
            // Additional business logic or validation can be added here
            _passwordApplicationRepository.CreateApplication(application);
        }

        public void UpdateApplication(PasswordApplication application)
        {
            // Additional business logic or validation can be added here
            _passwordApplicationRepository.UpdateApplication(application);
        }

        public void DeleteApplication(int applicationId)
        {
            // Additional business logic or validation can be added here
            _passwordApplicationRepository.DeleteApplication(applicationId);
        }
    }
}
