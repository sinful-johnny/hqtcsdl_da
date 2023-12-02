using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class BENH_AN
    {
        public string ID_KH { get; set; }
        public string ID_NS { get; set; }
        public DateTime NGAYKHAM { get; set; }
        public string ID_BA { get; set; }

        public string Info
        {
            get { return $"{ID_KH}\t{ID_NS}\t{NGAYKHAM}\t{ID_BA}"; }
        }
    }
}
