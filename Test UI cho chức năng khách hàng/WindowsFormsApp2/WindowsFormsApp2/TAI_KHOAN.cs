using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class TAI_KHOAN
    {
        public string ID_TAIKHOAN { get; set; }
        public String HOTEN { get; set; }
        public String SDT { get; set; }
        public DateTime NGAYSINH { get; set; }
        public String EMAIL { get; set;}
        public String MATKHAU { get; set; }
        public String LOAITK { get; set; }

        public string Info
        {
            get { return $"{ID_TAIKHOAN}\t{SDT}\t{MATKHAU}\t{LOAITK}"; }
        }
    }
}
