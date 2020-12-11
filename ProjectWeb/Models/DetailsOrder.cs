namespace ProjectWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetailsOrder")]
    public partial class DetailsOrder
    {
        [Key]
        public int ID_CTDonHang { get; set; }

        public int ID_SanPham { get; set; }

        public int ID_DonHang { get; set; }

        public int? SoLuongMua { get; set; }

        public int? GiaBan { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
