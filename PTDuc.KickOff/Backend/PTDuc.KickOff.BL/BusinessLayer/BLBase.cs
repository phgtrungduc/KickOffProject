using PTDuc.KickOff.BL.Interfaces;
using PTDuc.KickOff.DL.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace PTDuc.KickOff.BL.BusinessLayer
{
    public class BLBase<TEntity> : IBLBase<TEntity>
    {
        protected KickOffContext context;
        protected DbSet<BaseEntity> entity;
        public ServiceResult Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public ServiceResult GetAll()
        {
            var res = new ServiceResult();
            res.Data = entity;
            return res;
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
