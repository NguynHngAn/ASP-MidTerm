﻿using System;
using System.Collections.Generic;

namespace PraticeDbFirst2.Data;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;

    public string TenCty { get; set; } = null!;

    public string? DiaChi { get; set; }

    public string? DienThoai { get; set; }

    public int ThanhPho { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

    public virtual ThanhPho ThanhPhoNavigation { get; set; } = null!;
}
