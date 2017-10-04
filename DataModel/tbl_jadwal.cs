namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_jadwal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_jadwal()
        {
            tbl_krs = new HashSet<tbl_krs>();
            tbl_ujian = new HashSet<tbl_ujian>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Jadwal { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Matkul { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Ruangan { get; set; }

        public DateTime Hari { get; set; }

        public DateTime Jam { get; set; }

        [Required]
        [StringLength(10)]
        public string Code_Periode { get; set; }

        public virtual tbl_mata_kuliah tbl_mata_kuliah { get; set; }

        public virtual tbl_Periode tbl_Periode { get; set; }

        public virtual tbl_Ruang_Kelas tbl_Ruang_Kelas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_krs> tbl_krs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ujian> tbl_ujian { get; set; }
    }
}
