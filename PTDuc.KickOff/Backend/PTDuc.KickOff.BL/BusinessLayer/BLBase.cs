using PTDuc.KickOff.BL.Interfaces;
using PTDuc.KickOff.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDuc.KickOff.BL.BusinessLayer
{
    public class BLBase<TEntity> : IBLBase<TEntity>
    {
        public ServiceResult Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetAll()
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetByID(string Id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ServiceResult Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
