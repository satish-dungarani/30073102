using System;

namespace PasswordManagerSystem.Data
{
    public class PasswordHistory
    {
        public int Id { get; set; }
        public int PasswordId { get; set; }
        public string OldPassword { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
