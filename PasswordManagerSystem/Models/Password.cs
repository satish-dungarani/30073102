using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerSystem.Models
{
    public class Password
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ApplicationType { get; set; }
        public string ApplicationName { get; set; }
        public string Username { get; set; }
        public string PasswordValue { get; set; }
        public bool RemindMe { get; set; } = false;
        public int? ReminderDays { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; } = true;
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
