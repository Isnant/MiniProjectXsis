namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_mata_kuliah
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_mata_kuliah()
        {
            tbl_jadwal = new HashSet<tbl_jadwal>();
            tbl_kehadiran = new HashSet<tbl_kehadiran>();
            tbl_nilai = new HashSet<tbl_nilai>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Matkul { get; set; }

        [Required]
        [StringLength(30)]
        public string Nama_Matkul { get; set; }

        public int SKS { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Dosen { get; set; }

        [Required]
        [StringLength(10)]
        public string Semester { get; set; }

        public int Jumlah_Pertemuan { get; set; }

        public virtual tbl_dosen tbl_dosen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_jadwal> tbl_jadwal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kehadiran> tbl_kehadiran { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_nilai> tbl_nilai { get; set; }
    }
}
