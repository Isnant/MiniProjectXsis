using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace MiniProject.Repo
{
    public class MahasiswaRepo
    {
        public static string Message = string.Empty;
        //public static List<MahasiswaViewModel> All()
        //{
        //    return All("");
        //}
        public static List<MahasiswaViewModel> All()
        {
            List<MahasiswaViewModel> result = new List<MahasiswaViewModel>();
            using (var db = new DataModelContext())
            {
                result = (from M in db.tbl_mahasiswa
                          join P in db.tbl_prodi
                          on M.Kode_Prodi equals P.Kode_Prodi
                          where M.Kode_Prodi == (M.Kode_Prodi.Length > 0 ? M.Kode_Prodi : M.Kode_Prodi)
                          select new MahasiswaViewModel
                          {
                              ID = M.ID,
                              NIM = M.NIM,
                              Nama_Mahasiswa = M.Nama_Mahasiswa,
                              Alamat = M.Alamat,
                              Kode_Prodi = M.Kode_Prodi,
                              Email_Mahasiswa = M.Email_Mahasiswa,
                              No_Hp = M.No_Hp,
                              Jenis_Kelamin = M.Jenis_Kelamin,
                              AGAMA = M.AGAMA,
                              Nama_Prodi = P.Nama_Prodi
                          }).ToList();
            }
            return result;
        }

        public static MahasiswaViewModel GetById(int id)
        {
            MahasiswaViewModel result = new MahasiswaViewModel();
            using (var db = new DataModelContext())
            {
                result = (from M in db.tbl_mahasiswa
                          join P in db.tbl_prodi
                          on M.Kode_Prodi equals P.Kode_Prodi
                          where M.ID == id
                          select new MahasiswaViewModel
                          {
                              ID = M.ID,
                              NIM = M.NIM,
                              Nama_Mahasiswa = M.Nama_Mahasiswa,
                              Alamat = M.Alamat,
                              Kode_Prodi = M.Kode_Prodi,
                              Email_Mahasiswa = M.Email_Mahasiswa,
                              No_Hp = M.No_Hp,
                              Jenis_Kelamin = M.Jenis_Kelamin,
                              AGAMA = M.AGAMA,
                              Nama_Prodi = P.Nama_Prodi

                          }).FirstOrDefault();

            }
            return result;
        }
        public static bool Update(MahasiswaViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new DataModelContext())
                {
                    if ((model.ID == null ? 0 : model.ID) == 0)
                    {
                        tbl_mahasiswa M = new tbl_mahasiswa();
                        M.NIM = model.NIM;
                        M.Nama_Mahasiswa = model.Nama_Mahasiswa;
                        M.Alamat = model.Alamat;
                        M.Kode_Prodi = model.Kode_Prodi;
                        M.Email_Mahasiswa = model.Email_Mahasiswa;
                        M.No_Hp = model.No_Hp;
                        M.Jenis_Kelamin = model.Jenis_Kelamin.Trim();
                        M.AGAMA = model.AGAMA;
                        db.tbl_mahasiswa.Add(M);
                        db.SaveChanges();


                    }
                    else
                    {
                        tbl_mahasiswa M = db.tbl_mahasiswa.Where(o => o.ID == model.ID).FirstOrDefault();
                        if (M != null)
                        {
                            M.NIM = model.NIM;
                            M.Nama_Mahasiswa = model.Nama_Mahasiswa;
                            M.Alamat = model.Alamat;
                            M.Kode_Prodi = model.Kode_Prodi;
                            M.Email_Mahasiswa = model.Email_Mahasiswa;
                            M.No_Hp = model.No_Hp;
                            M.Jenis_Kelamin = model.Jenis_Kelamin.Trim();
                            M.AGAMA = model.AGAMA;
                            db.SaveChanges();
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;

            }
            return result;
        }
        public static bool Delete(int id)
        {
            bool result = true;
            try
            {
                using (var db = new DataModelContext())
                {
                    tbl_mahasiswa M = db.tbl_mahasiswa.Where(o => o.ID == id).FirstOrDefault();
                    db.tbl_mahasiswa.Remove(M);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Message = ex.Message;
                result = false;

            }
            return result;
        }
        //untuk list prodi
        public static List<ProdiViewModel> Alls()
        {
            List<ProdiViewModel> result = new List<ProdiViewModel>();
            using (var db = new DataModelContext())
            {
                result = (from P in db.tbl_prodi
                          join F in db.tbl_fakultas
                          on P.Kode_Fakultas equals F.Kode_Fakultas
                          where P.Kode_Fakultas == (P.Kode_Fakultas.Length > 0 ? P.Kode_Fakultas : P.Kode_Fakultas)
                          select new ProdiViewModel
                          {
                              ID = P.ID,
                              Kode_Prodi = P.Kode_Prodi,
                              Nama_Prodi = P.Nama_Prodi,
                              Kode_Fakultas = P.Kode_Fakultas,
                              Nama_Fakultas = "(" + P.Kode_Fakultas + ")" + F.Nama
                          }).ToList();
            }
            return result;
        }
    }
}
