//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CNPMProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class DAILY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAILY()
        {
            this.BAOCAOCONGNOes = new HashSet<BAOCAOCONGNO>();
            this.BAOCAODOANHTHUs = new HashSet<BAOCAODOANHTHU>();
            this.DONHANGs = new HashSet<DONHANG>();
            this.NODAILies = new HashSet<NODAILY>();
            this.UUDAIs = new HashSet<UUDAI>();
        }
        //public DAILY(string maDaiLy, string maDinhMuc, string maHopDong, Nullable<DateTime> ngayLap,string cMND, string hoTenChuDaiLy, Nullable<DateTime> ngaySinh, string capDaiLy, string tenDaiLy, string noiDung)
        //{
        //    MaDaiLy = maDaiLy;
        //    MaDinhMuc = maDinhMuc;
        //    MaHopDong = maHopDong;
        //    NgayLap = ngayLap;
        //    CMND = cMND;
        //    HoTenChuDaiLy = hoTenChuDaiLy;
        //    NgaySinh = ngaySinh;
        //    CapDaiLy = capDaiLy;
        //    TenDaiLy = tenDaiLy;
        //    NoiDung = noiDung;
        //}
        private string maDaiLy;
        public string MaDaiLy
        {
            get { return maDaiLy; }
            set
            {
                if (maDaiLy!=value)
                {
                    maDaiLy = value;
                }
            } }

        private string maDinhMuc;
        public string MaDinhMuc
        {
            get { return maDinhMuc; }
            set
            {
                if (maDinhMuc!=value)
                {
                    maDinhMuc = value;
                }
            } }

        private string maHopDong;
        public string MaHopDong
        {
            get { return maHopDong; }
            set
            {
                if (maHopDong != value)
                {
                    maHopDong = value;
                }
            } }

        private Nullable<DateTime> ngayLap;
        public Nullable<System.DateTime> NgayLap
        {
            get { return ngayLap; }
            set
            {
                if (ngayLap!=value)
                {
                    ngayLap = value;
                }
            } }

        private string cMND;
        public string CMND
        {
            get { return cMND; }
            set
            {
                if (cMND != value)
                {
                    cMND = value;
                }
            } }

        private string hoTenChuDaiLy;
        public string HoTenChuDaiLy
        {
            get { return hoTenChuDaiLy; }
            set
            {
                if (hoTenChuDaiLy!=value)
                {
                    hoTenChuDaiLy = value;
                }
            } }

        private Nullable<DateTime> ngaySinh;
        public Nullable<DateTime> NgaySinh
        {
            get { return ngaySinh; }
            set
            {
                if (ngaySinh != value)
                {
                    ngaySinh = value;
                }
            }
        }

        private string capDaiLy;
        public string CapDaiLy
        {
            get { return capDaiLy; }
            set
            {
                if (capDaiLy!=value)
                {
                    capDaiLy = value;
                }
            } }

        private string tenDaiLy;
        public string TenDaiLy
        {
            get { return tenDaiLy; }
            set
            {
                if (tenDaiLy!=value)
                {
                    tenDaiLy = value;
                }
            } }

        private string noiDung;
        public string NoiDung
        {
            get { return noiDung; }
            set
            {
                if (noiDung!=value)
                {
                    noiDung = value;
                }
            } }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOCAOCONGNO> BAOCAOCONGNOes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BAOCAODOANHTHU> BAOCAODOANHTHUs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NODAILY> NODAILies { get; set; }
        public virtual DINHMUC DINHMUC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UUDAI> UUDAIs { get; set; }
    }
}
