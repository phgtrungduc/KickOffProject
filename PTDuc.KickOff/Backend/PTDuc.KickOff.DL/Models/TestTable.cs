using System;
using System.Collections.Generic;

#nullable disable

namespace PTDuc.KickOff.DL.Models
{
    public partial class TestTable:BaseEntity
    {
        public Guid TestId { get; set; }
        public int? TestInt { get; set; }
        public string TestString { get; set; }
    }
}
