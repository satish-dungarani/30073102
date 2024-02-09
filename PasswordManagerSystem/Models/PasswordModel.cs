using System.ComponentModel;

namespace PasswordManagerSystem.Models
{
    public class PasswordModel
    {
        public int Id { get; set; }

        [DisplayName("User")]
        public string Username { get; set; }
        [DisplayName("Type")]
        public string ApplicationType { get; set; }
        [DisplayName("Application")]
        public string AppName { get; set; }
        [DisplayName("Username")]
        public string AppUsername { get; set; }
        [DisplayName("Password")]
        public string AppPassword { get; set; }
        [DisplayName("Is Active")]
        public string IsActive { get; set; }
        [DisplayName("Is Deleted")]
        public string IsDeleted { get; set; }
    }
}