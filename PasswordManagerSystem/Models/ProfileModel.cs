using PasswordManagerSystem.Data;

namespace PasswordManagerSystem.Models
{
    public class ProfileModel
    {
        public User user { get; set; }
        public UserDetail userDetail { get; set; }
        public string profilePic { get; set; }
        public ProfileModel()
        {
            user = new User();
            userDetail = new UserDetail();
        }
    }
}
