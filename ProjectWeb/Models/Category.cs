namespace ProjectWeb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Category
    {
        [Key]
        public int ID_DanhMuc { get; set; }

        [StringLength(50)]
        public string TenDanhMuc { get; set; }
    }
}
