using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace MiniProject.Repo
{
    public class MataKuliahRepo
    {
        public static string Message = string.Empty;
        //public static List<MahasiswaViewModel> All()
        //{
        //    return All("");
        //}
        public static List<MataKuliahViewModel> All()
        {
            List<MataKuliahViewModel> result = new List<MataKuliahViewModel>();
            using (var db = new DataModelContext())
            {
                result = (from MK in db.tbl_mata_kuliah
                          join D in db.tbl_dosen
                          on MK.Kode_Dosen equals D.Kode_Dosen
                          where MK.Kode_Dosen == (MK.Kode_Dosen.Length > 0 ? MK.Kode_Dosen : MK.Kode_Dosen)
                          select new MataKuliahViewModel
                          {
                              ID = MK.ID,
                              Kode_Matkul = MK.Kode_Matkul,
                              Nama_Matkul = MK.Nama_Matkul,
                              SKS = MK.SKS,
                              Kode_Dosen = MK.Kode_Dosen,
                              Semester = MK.Semester,
                              Jumlah_Pertemuan = MK.Jumlah_Pertemuan,
                              Nama_Dosen = D.Nama_Dosen
                          }).ToList();
            }
            return result;
        }

        public static MataKuliahViewModel GetById(int id)
        {
            MataKuliahViewModel result = new MataKuliahViewModel();
            using (var db = new DataModelContext())
            {
                result = (from MK in db.tbl_mata_kuliah
                          join D in db.tbl_dosen
                          on MK.Kode_Dosen equals D.Kode_Dosen
                          where MK.ID == id
                          select new MataKuliahViewModel
                          {
                              ID = MK.ID,
                              Kode_Matkul = MK.Kode_Matkul,
                              Nama_Matkul = MK.Nama_Matkul,
                              SKS = MK.SKS,
                              Kode_Dosen = MK.Kode_Dosen,
                              Semester = MK.Semester,
                              Jumlah_Pertemuan = MK.Jumlah_Pertemuan,
                              Nama_Dosen = D.Nama_Dosen
                          }).FirstOrDefault();

            }
            return result;
        }
        public static bool Update(MataKuliahViewModel model)
        {
            bool result = true;
            try
            {
                using (var db = new DataModelContext())
                {
                    if ((model.ID == null ? 0 : model.ID) == 0)
                    {
                        tbl_mata_kuliah MK = new tbl_mata_kuliah ();
                        MK.Kode_Matkul = model.Kode_Matkul;
                        MK.Nama_Matkul = model.Nama_Matkul;
                        MK.SKS = model.SKS;
                        MK.Kode_Dosen = model.Kode_Dosen;
                        MK.Semester = model.Semester;
                        MK.Jumlah_Pertemuan = model.Jumlah_Pertemuan;
                        db.tbl_mata_kuliah.Add(MK);
                        db.SaveChanges();
                    }
                    else
                    {
                        tbl_mata_kuliah MK = db.tbl_mata_kuliah.Where(o => o.ID == model.ID).FirstOrDefault();
                        if (MK != null)
                        {
                            MK.Kode_Matkul = model.Kode_Matkul;
                            MK.Nama_Matkul = model.Nama_Matkul;
                            MK.SKS = model.SKS;
                            MK.Kode_Dosen = model.Kode_Dosen;
                            MK.Semester = model.Semester;
                            MK.Jumlah_Pertemuan = model.Jumlah_Pertemuan;
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
                    tbl_mata_kuliah MK = db.tbl_mata_kuliah.Where(o => o.ID == id).FirstOrDefault();
                    db.tbl_mata_kuliah.Remove(MK);
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
    }
}
