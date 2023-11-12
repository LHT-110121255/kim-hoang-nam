namespace TVU.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("covanhoctap")]
    public partial class covanhoctap
    {
        [StringLength(9)]
        public string namHoc { get; set; }

        [StringLength(20)]
        public string maLop { get; set; }

        [StringLength(250)]
        public string nganh { get; set; }

        [Key]
        [StringLength(100)]
        public string tenCVHT { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(20)]
        public string dienThoai { get; set; }

        [StringLength(100)]
        public string quyetDinh { get; set; }

        [StringLength(200)]
        public string ghiChu { get; set; }

        [StringLength(300)]
        public string noiDungDieuChinh { get; set; }
    }
}
