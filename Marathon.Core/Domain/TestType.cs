using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Marathon.Core.Domain
{
   public class TestType:BaseClass
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
