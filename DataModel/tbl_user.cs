namespace DataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_user
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string User_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public virtual tbl_admin tbl_admin { get; set; }

        public virtual tbl_dosen tbl_dosen { get; set; }

        public virtual tbl_mahasiswa tbl_mahasiswa { get; set; }
    }
}
