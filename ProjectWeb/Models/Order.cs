namespace ProjectWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            DetailsOrders = new HashSet<DetailsOrder>();
        }

        [Key]
        public int ID_DonHang { get; set; }

        public int? ID_Account { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Ngay { get; set; }

        public int? TongTien { get; set; }

        public int? TrangThai { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailsOrder> DetailsOrders { get; set; }
    }
}
