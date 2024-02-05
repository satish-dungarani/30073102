using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManagerSystem.Models
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
