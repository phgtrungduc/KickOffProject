using PTDuc.KickOff.BL.Interfaces;
using PTDuc.KickOff.DL.Models;
using Microsoft.EntityFrameworkCore;

namespace PTDuc.KickOff.BL.BusinessLayer
{
    public class BLUser : BLBase<User>,IBLUser
    {
        public BLUser() {
            this.context = new KickOffContext();
            this.entity = this.context.Users;
        }

    }
}
