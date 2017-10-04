namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Detail_Tagihan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Detail_Tagihan()
        {
            tbl_Tagihan_Mahasiswa = new HashSet<tbl_Tagihan_Mahasiswa>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string NIM { get; set; }

        [Required]
        [StringLength(10)]
        public string Kode_Tagihan { get; set; }

        public decimal Basic_Value { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Detail_Tagihan { get; set; }

        public virtual tbl_mahasiswa tbl_mahasiswa { get; set; }

        public virtual tbl_tagihan tbl_tagihan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Tagihan_Mahasiswa> tbl_Tagihan_Mahasiswa { get; set; }
    }
}
