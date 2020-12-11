namespace ProjectWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            DetailsOrders = new HashSet<DetailsOrder>();
        }

        [Key]
        public int ID_SanPham { get; set; }

        public int? ID_DanhMuc { get; set; }

        [StringLength(50)]
        public string TenSanPham { get; set; }

        public string HinhAnh { get; set; }

        [StringLength(50)]
        public string MaSanPham { get; set; }

        public int GiaGoc { get; set; }

        [StringLength(50)]
        public string Sale { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public string Video { get; set; }

        public string HinhAnhGame { get; set; }

        public string HinhAnhGame1 { get; set; }

        public string HinhAnhGame2 { get; set; }

        public string MoTa { get; set; }

        public string MoTa1 { get; set; }

        public string MoTa2 { get; set; }

        public string Tags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailsOrder> DetailsOrders { get; set; }
    }
}
