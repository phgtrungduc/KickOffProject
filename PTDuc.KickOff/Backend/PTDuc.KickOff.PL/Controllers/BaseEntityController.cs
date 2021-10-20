using Microsoft.AspNetCore.Mvc;
using PTDuc.KickOff.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTDuc.KickOff.PL.Controllers
{
    public class BaseEntityController<TEntity> : Controller
    {
        IBLBase<TEntity> _BLBase;
        public BaseEntityController(IBLBase<TEntity> BLBase)
        {
            _BLBase = BLBase;
        }

        // GET: api/<CustomersController>
        /// <summary>
        /// Lấy toàn bộ danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        /// createdBy:PTDuc(23/12/2020)
        /// đây là ở thằng cha nhá
        [HttpGet]
        public virtual IActionResult Get()
        {
            var res = _BLBase.GetAll();
            return Ok(res);
        }

        // GET api/<CustomersController>/5
        /// <summary>
        /// Tìm kiếm nhân viên theo ID
        /// </summary>
        /// <param name="id">Mã khách hàng</param>
        /// <param name="name"></param>
        /// <returns></returns>
        /// CreatedBy: PTDuc(4/12/2020)
        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            var res = _BLBase.GetByID(id);
            return Ok(res);
        }

        // POST api/<CustomersController>
        /// <summary>
        /// Thêm mới 1 đối tượng
        /// </summary>
        /// <param name="entity">Đối tượng truyền lên từ client</param>
        /// <returns></returns>
        /// CreatedBy: PTDuc(4/12/2020)
        [HttpPost]
        public IActionResult Post([FromBody] TEntity entity)
        {

            var res = _BLBase.Insert(entity);
            return Ok(res);

        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] TEntity entity)
        {
            var res = _BLBase.Update(entity);
            return Ok(res);
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] TEntity entity)
        {
            var res = _BLBase.Delete(entity);
            return Ok(res);
        }
    }
}
