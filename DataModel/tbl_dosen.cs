namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_dosen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_dosen()
        {
            tbl_mata_kuliah = new HashSet<tbl_mata_kuliah>();
            tbl_user = new HashSet<tbl_user>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Dosen { get; set; }

        [Required]
        [StringLength(30)]
        public string Nama_Dosen { get; set; }

        [Required]
        [StringLength(100)]
        public string Alamat { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(12)]
        public string No_Hp { get; set; }

        [Required]
        [StringLength(1)]
        public string Jenis_Kelamin { get; set; }

        [Required]
        [StringLength(10)]
        public string AGAMA { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Prodi { get; set; }

        public virtual tbl_prodi tbl_prodi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_mata_kuliah> tbl_mata_kuliah { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user> tbl_user { get; set; }
    }
}
