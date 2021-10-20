using PTDuc.KickOff.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDuc.KickOff.BL.Interfaces
{
    public interface IBLBase<TEntity>
    {
        ServiceResult GetAll();
        ServiceResult GetByID(string Id);
        ServiceResult Delete(TEntity entity);
        ServiceResult Update(TEntity entity);
        ServiceResult Insert(TEntity entity);
    }
}
