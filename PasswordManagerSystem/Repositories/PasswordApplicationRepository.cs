using PasswordManagerSystem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace PasswordManagerSystem.Repositories
{
    public class PasswordApplicationRepository : IPasswordApplicationRepository
    {
        private readonly PasswordManagerContext _dbContext;

        public PasswordApplicationRepository(PasswordManagerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PasswordApplication GetApplicationById(int applicationId)
        {
            return _dbContext.PasswordApplications.Find(applicationId);
        }

        public IEnumerable<PasswordApplication> GetAllApplications()
        {
            return _dbContext.PasswordApplications.ToList();
        }

        public void CreateApplication(PasswordApplication application)
        {
            _dbContext.PasswordApplications.Add(application);
            _dbContext.SaveChanges();
        }

        public void UpdateApplication(PasswordApplication application)
        {
            _dbContext.Entry(application).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteApplication(int applicationId)
        {
            var application = _dbContext.PasswordApplications.Find(applicationId);
            if (application != null)
            {
                _dbContext.PasswordApplications.Remove(application);
                _dbContext.SaveChanges();
            }
        }
    }
}