using System;
using System.Collections.Generic;

namespace test.Data;

public partial class HoaDon
{
    public int MaHd { get; set; }

    public string MaKh { get; set; } = null!;

    public DateTime NgayLapHd { get; set; }

    public DateTime NgayNhanHang { get; set; }

    public int? MaNv { get; set; }
}
