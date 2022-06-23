using System;
namespace DeliFood.Models
{
    public class HangHoaVM
    {
        public int MaHH { get; set; }

    }
    public class HangHoa : HangHoaVM
    {
        public string TenHangHoa { get; set; }
    }
}
