using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
    public partial class DangKyThongTin
    {
        public int Id { get; set; }

        public int? IdMaxCQT { get; set; }

        public int? IdCQT { get; set; }

        public int? IdMaNgach { get; set; }

        public string MaDuThi { get; set; }

        public string Ho { get; set; }

        public string Ten { get; set; }

        public string HoTen { get; set; }

        public bool? GioiTinh { get; set; }

        public string NgaySinh { get; set; }

        public string ThangSinh { get; set; }

        public string NgayThangNamSinhStrig { get; set; }

        public string NamSinh { get; set; }

        public DateTime? NgayThangNamSinh { get; set; }

        public string DanToc { get; set; }

        public string TonGiao { get; set; }

        public string CMND { get; set; }

        public DateTime? NgayCapCMND { get; set; }

        public string NoiCapCMND { get; set; }

        public string DienThoai { get; set; }

        public string Email { get; set; }

        public string QueQuan { get; set; }

        public string HoKhauThuongTru { get; set; }

        public string ChoOHienNay { get; set; }

        public string SucKhoe { get; set; }

        public string ChieuCao { get; set; }

        public string CanNang { get; set; }

        public string HoTenLienHe { get; set; }

        public string DienThoaiLienHe { get; set; }

        public string DiaChiLienHe { get; set; }

        public string TenCSDT1 { get; set; }

        public int? IdHocVan1 { get; set; }

        public string TenNganh1 { get; set; }

        public string TenChuyenNganh1 { get; set; }

        public int? IdLoaiHinh1 { get; set; }

        public int? IdKQHT1 { get; set; }

        public string SoHieuVanBang1 { get; set; }

        public DateTime? NgayCapVanBang1 { get; set; }

        public string TenCSDT2 { get; set; }

        public int? IdHocVan2 { get; set; }

        public string TenNganh2 { get; set; }

        public string TenChuyenNganh2 { get; set; }

        public int? IdLoaiHinh2 { get; set; }

        public int? IdKQHT2 { get; set; }

        public string SoHieuVanBang2 { get; set; }

        public DateTime? NgayCapVanBang2 { get; set; }

        public bool? MienNgoaiNgu { get; set; }

        public int? IdMienNN { get; set; }

        public int? IdNgoaiNgu { get; set; }

        public int? IdTrinhDoNN { get; set; }

        public string TenCSDTNN { get; set; }

        public string SoHieuVanBangNN { get; set; }

        public DateTime? NgayCapNN { get; set; }

        public string TenNganhNN { get; set; }

        public int? DiemSoNN { get; set; }

        public string NoiDungKhacNN { get; set; }

        public string ChungChiNgoaiNgu { get; set; }

        public int? IdTinHoc { get; set; }

        public int? IdTrinhDoTinHoc { get; set; }

        public string TenCSDTTinHoc { get; set; }

        public string SoHieuVanBangTinHoc { get; set; }

        public DateTime? NgayCapVanBangTinHoc { get; set; }

        public string TenNganhTinHoc { get; set; }

        public string NoiDungKhacTinHoc { get; set; }

        public string ChungChiTinHoc { get; set; }

        public bool? CheckUuTien { get; set; }

        public int? IdUuTien { get; set; }

        public int? DuyetHoSo { get; set; }

        public string LyDoKhongDuyet { get; set; }

        public string IdCBQL { get; set; }

        public DateTime? NgayDangKy { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        public DateTime? NgayDuyetHoSo { get; set; }

        public bool? VoHieu { get; set; }
        public string ViTriDuTuyen { get; set; }
        public string DonViDuTuyen { get; set; }
        public string NgayCapCMNDString { get; set; }
        public string BanThanHienNay { get; set; }
        public string TrinhDoVanHoa { get; set; }
        public string TrinhDoChuyenMon { get; set; }
        public string LoaiHinhDaoTao { get; set; }
        public string NgayDangKyString { get; set; }
    }
}
