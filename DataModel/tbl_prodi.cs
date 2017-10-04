namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_prodi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_prodi()
        {
            tbl_dosen = new HashSet<tbl_dosen>();
            tbl_mahasiswa = new HashSet<tbl_mahasiswa>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Prodi { get; set; }

        [Required]
        [StringLength(50)]
        public string Nama_Prodi { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Fakultas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_dosen> tbl_dosen { get; set; }

        public virtual tbl_fakultas tbl_fakultas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_mahasiswa> tbl_mahasiswa { get; set; }
    }
}
