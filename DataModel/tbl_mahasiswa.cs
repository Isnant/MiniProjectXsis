namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_mahasiswa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_mahasiswa()
        {
            tbl_Detail_Tagihan = new HashSet<tbl_Detail_Tagihan>();
            tbl_kehadiran = new HashSet<tbl_kehadiran>();
            tbl_krs = new HashSet<tbl_krs>();
            tbl_nilai = new HashSet<tbl_nilai>();
            tbl_user = new HashSet<tbl_user>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string NIM { get; set; }

        [Required]
        [StringLength(30)]
        public string Nama_Mahasiswa { get; set; }

        [Required]
        [StringLength(200)]
        public string Alamat { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Prodi { get; set; }

        [StringLength(50)]
        public string Email_Mahasiswa { get; set; }

        [Required]
        [StringLength(12)]
        public string No_Hp { get; set; }

        [Required]
        [StringLength(1)]
        public string Jenis_Kelamin { get; set; }

        [Required]
        [StringLength(10)]
        public string AGAMA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Detail_Tagihan> tbl_Detail_Tagihan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_kehadiran> tbl_kehadiran { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_krs> tbl_krs { get; set; }

        public virtual tbl_prodi tbl_prodi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_nilai> tbl_nilai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user> tbl_user { get; set; }
    }
}
