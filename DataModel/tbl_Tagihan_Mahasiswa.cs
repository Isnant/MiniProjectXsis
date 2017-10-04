namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Tagihan_Mahasiswa
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Detail_Tagihan { get; set; }

        public decimal Final_Value { get; set; }

        public virtual tbl_Detail_Tagihan tbl_Detail_Tagihan { get; set; }
    }
}
