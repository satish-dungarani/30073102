using System.ComponentModel;

namespace PasswordManagerSystem.Models
{
    public class HistoryModel
    {
        public int Id { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("App Type")]
        public string AppType { get; set; }
        [DisplayName("App Name")]
        public string AppName { get; set; }
        [DisplayName("App Username")]
        public string AppUsername { get; set; }
        [DisplayName("Previous Password")]
        public string PrePassword { get; set; }
        [DisplayName("Recent Password")]
        public string RecPassword { get; set; }
        [DisplayName("Updated Date")]
        public string UpdatedDate { get; set; }
    }
}
