using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MataKuliahViewModel
    {
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

        public string Nama_Dosen { get; set; }

        [Required]
        [StringLength(10)]
        public string Semester { get; set; }

        public int Jumlah_Pertemuan { get; set; }
    }
}
