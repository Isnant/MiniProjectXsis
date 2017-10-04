namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_krs
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string NIM { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Jadwal { get; set; }

        public virtual tbl_jadwal tbl_jadwal { get; set; }

        public virtual tbl_mahasiswa tbl_mahasiswa { get; set; }
    }
}
