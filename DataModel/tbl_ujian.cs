namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ujian
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string NIM { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Jadwal { get; set; }

        public DateTime Hari { get; set; }

        public DateTime Jam { get; set; }

        public decimal Presentasi_Kehadiran { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Periode { get; set; }

        public virtual tbl_jadwal tbl_jadwal { get; set; }

        public virtual tbl_Periode tbl_Periode { get; set; }
    }
}
