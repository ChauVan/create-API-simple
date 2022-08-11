using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebAPIapp.Models
{
    public class HangHoaTGDD
    {
        public string tenHH { get; set; }
        public double DonGia { get; set; }
    }
    public class HangHoa : HangHoaTGDD
    {
        public Guid maHH { get; set; }
      
    }

}
