using System;

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
