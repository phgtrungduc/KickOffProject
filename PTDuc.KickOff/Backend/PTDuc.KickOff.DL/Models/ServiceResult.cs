using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTDuc.KickOff.DL.Models
{
    public class ServiceResult
    {
        /// <summary>
        /// Dữ liệu trả về (Vd thông tin khách hàng đã thêm)
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// Câu thông báo gửi về (Vd: Mã khách hàng bị trùng)
        /// </summary>
        public string Messenger { get; set; }
    }
}
