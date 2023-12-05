using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Models
{
    internal class THUOC
    {
        public string ID_THUOC { get; set; }
        public string TENTHUOC { get; set; }
        public string CHIDINH { get; set; }
        public int GIATIEN { get; set; }

        public string Info
        {
            get
            {
                return $"{ID_THUOC} {TENTHUOC} {GIATIEN} {CHIDINH}";
            }
        }
    }
}
