using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class LOAI_DV
    {
        public string ID_LOAIDV { get; set; }
        public string TENDV { get; set; }
        public int GIATIEN { get; set; }
        public string Info { 
            get { return $"{TENDV} giá {GIATIEN}$"; }
        }
    }
}
