namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_admin
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_admin()
        {
            tbl_user = new HashSet<tbl_user>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Admin { get; set; }

        [Required]
        [StringLength(30)]
        public string Nama_Admin { get; set; }

        [Required]
        [StringLength(200)]
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
        public string Agama { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user> tbl_user { get; set; }
    }
}
