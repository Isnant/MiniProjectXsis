using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MahasiswaViewModel
    {
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string NIM { get; set; }

        [Required]
        [StringLength(30), DisplayName("Nama Mahasiswa")]
        public string Nama_Mahasiswa { get; set; }

        [Required]
        [StringLength(200)]
        public string Alamat { get; set; }

        [Required]
        [StringLength(10), DisplayName("Program Studi")]
        public string Kode_Prodi { get; set; }
        [DisplayName("Program Studi")]
        public string Nama_Prodi { get; set; }

        [StringLength(50), DisplayName("E-mail")]
        public string Email_Mahasiswa { get; set; }

        [Required]
        [StringLength(12), DisplayName("No HP")]
        public string No_Hp { get; set; }

        [Required]
        [StringLength(1), DisplayName("Jenis Kelamim")]
        public string Jenis_Kelamin { get; set; }
        public string JenisKelamin
        {
            get
            {
                if (Jenis_Kelamin == "M")
                    return "Male";
                else 
                    return "Female";
            }
        }

        [Required]
        [StringLength(10)]
        public string AGAMA { get; set; }
    }
}
