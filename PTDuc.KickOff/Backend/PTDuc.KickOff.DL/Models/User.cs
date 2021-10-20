using System;
using System.Collections.Generic;

#nullable disable

namespace PTDuc.KickOff.DL.Models
{
    public partial class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
    }
}
