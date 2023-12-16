using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQTQUANTRIVIEN.Models
{
    internal class THUOC
    {
        public string ID_THUOC { get; set; }
        public string TENTHUOC { get; set; }
        public string CHIDINH { get; set; }
        public DateTime NGAYHETHAN { get; set; }
        public string GIATIEN { get; set; }
        public int SOLUONG { get; set; }

        public string Info
        {
            get
            {
                return $"{ID_THUOC} {TENTHUOC} {GIATIEN} {CHIDINH} {NGAYHETHAN} {SOLUONG}";
            }
        }
    }
}
