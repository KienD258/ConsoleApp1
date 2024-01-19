using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buoi6
{
    public class CungThu
    {
        //prop
        public int DiemTanCong { get; set; }
        public int DiemPhongThu { get; set; }
        public int HP { get; set; }
        public int TocDo { get; set; }

        //ctor
        public CungThu()
        {
            DiemTanCong = 100;
        }
        public CungThu(int diemTanCong, int diemPhongThu, int hP, int tocDo)
        {
            this.DiemTanCong = diemTanCong;
            this.DiemPhongThu = diemPhongThu;
            this.HP = hP;
            this.TocDo = tocDo;
        }
        public void KyNang1()
        {
            this.DiemTanCong *= 2 ;
        }
    }
}
