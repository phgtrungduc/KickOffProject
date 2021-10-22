using Microsoft.AspNetCore.Mvc;
using PTDuc.KickOff.BL.BusinessLayer;
using PTDuc.KickOff.BL.Interfaces;
using PTDuc.KickOff.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTDuc.KickOff.PL.Controllers
{
    public class UserController
        : BaseEntityController<User>
    {
        IBLUser BLUser;
        public UserController(IBLUser BLUser) : base(BLUser)
        {
            this.BLUser = BLUser;
        }
    }
}
