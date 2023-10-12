namespace FourT.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHoaDon { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaMonAn { get; set; }

        public double SoLuong { get; set; }

        public double DonGia { get; set; }

        public double GiamGia { get; set; }

        public double ThanhTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual MonAn MonAn { get; set; }
    }
}
