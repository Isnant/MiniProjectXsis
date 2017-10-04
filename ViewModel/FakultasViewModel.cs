using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class FakultasViewModel
    {
        public int ID { get; set; }

        [Key]
        [StringLength(10)]
        public string Kode_Fakultas { get; set; }

        [Required]
        [StringLength(100)]
        public string Nama { get; set; }
    }
}
