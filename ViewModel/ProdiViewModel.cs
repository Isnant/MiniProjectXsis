using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class ProdiViewModel
    {
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

        public string Nama_Fakultas { get; set; }
    }
}
