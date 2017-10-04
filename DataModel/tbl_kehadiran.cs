namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_kehadiran
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string NIM { get; set; }

        [Required]
        [StringLength(10)]
        public string IsHadir { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_matkul { get; set; }

        public DateTime Hari { get; set; }

        public virtual tbl_mahasiswa tbl_mahasiswa { get; set; }

        public virtual tbl_mata_kuliah tbl_mata_kuliah { get; set; }
    }
}
