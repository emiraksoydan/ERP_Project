using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class UserRole
    {
        public Guid UserRoleID { get; set; }
        public Guid RoleID { get; set; }
        public Role Role { get; set; }
        public User User { get; set; }

        public Guid UserID { get; set; }

    }
}
