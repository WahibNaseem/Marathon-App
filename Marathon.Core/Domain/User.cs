using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marathon.Core.Domain
{
   public class User:BaseClass
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public int TestId { get; set; }
        public Test Test { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
