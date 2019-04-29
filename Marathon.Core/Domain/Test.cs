using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marathon.Core.Domain
{
   public class Test:BaseClass
    {
        [Key]
        public int Id { get; set; }
        public DateTime ConductedDate { get; set; }

        //public int TestTypeId { get; set; }
        //public int UserId { get; set; }
    }
}
