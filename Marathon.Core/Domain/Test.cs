using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marathon.Core.Domain
{
    public class Test:BaseClass
    {
        [Key]
        public int Id { get; set; }
        public DateTime ConductedDate { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<TestType> TestTypes { get; set; }
    }
}
