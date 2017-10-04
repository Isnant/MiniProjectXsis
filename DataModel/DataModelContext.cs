namespace DataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataModelContext : DbContext
    {
        public DataModelContext()
            : base("name=DataModelContext")
        {
        }

        public virtual DbSet<tbl_admin> tbl_admin { get; set; }
        public virtual DbSet<tbl_Detail_Tagihan> tbl_Detail_Tagihan { get; set; }
        public virtual DbSet<tbl_dosen> tbl_dosen { get; set; }
        public virtual DbSet<tbl_fakultas> tbl_fakultas { get; set; }
        public virtual DbSet<tbl_jadwal> tbl_jadwal { get; set; }
        public virtual DbSet<tbl_kehadiran> tbl_kehadiran { get; set; }
        public virtual DbSet<tbl_krs> tbl_krs { get; set; }
        public virtual DbSet<tbl_mahasiswa> tbl_mahasiswa { get; set; }
        public virtual DbSet<tbl_mata_kuliah> tbl_mata_kuliah { get; set; }
        public virtual DbSet<tbl_nilai> tbl_nilai { get; set; }
        public virtual DbSet<tbl_Periode> tbl_Periode { get; set; }
        public virtual DbSet<tbl_prodi> tbl_prodi { get; set; }
        public virtual DbSet<tbl_Ruang_Kelas> tbl_Ruang_Kelas { get; set; }
        public virtual DbSet<tbl_tagihan> tbl_tagihan { get; set; }
        public virtual DbSet<tbl_Tagihan_Mahasiswa> tbl_Tagihan_Mahasiswa { get; set; }
        public virtual DbSet<tbl_ujian> tbl_ujian { get; set; }
        public virtual DbSet<tbl_user> tbl_user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.Kode_Admin)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.Nama_Admin)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.No_Hp)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.Jenis_Kelamin)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .Property(e => e.Agama)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_admin>()
                .HasMany(e => e.tbl_user)
                .WithRequired(e => e.tbl_admin)
                .HasForeignKey(e => e.User_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Detail_Tagihan>()
                .Property(e => e.NIM)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Detail_Tagihan>()
                .Property(e => e.Kode_Tagihan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Detail_Tagihan>()
                .Property(e => e.Kode_Detail_Tagihan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Detail_Tagihan>()
                .HasMany(e => e.tbl_Tagihan_Mahasiswa)
                .WithRequired(e => e.tbl_Detail_Tagihan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.Kode_Dosen)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.Nama_Dosen)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.No_Hp)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.Jenis_Kelamin)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.AGAMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .Property(e => e.Kode_Prodi)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_dosen>()
                .HasMany(e => e.tbl_mata_kuliah)
                .WithRequired(e => e.tbl_dosen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_dosen>()
                .HasMany(e => e.tbl_user)
                .WithRequired(e => e.tbl_dosen)
                .HasForeignKey(e => e.User_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_fakultas>()
                .Property(e => e.Kode_Fakultas)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_fakultas>()
                .Property(e => e.Nama)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_fakultas>()
                .HasMany(e => e.tbl_prodi)
                .WithRequired(e => e.tbl_fakultas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_jadwal>()
                .Property(e => e.Kode_Jadwal)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_jadwal>()
                .Property(e => e.Kode_Matkul)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_jadwal>()
                .Property(e => e.Kode_Ruangan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_jadwal>()
                .Property(e => e.Code_Periode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_jadwal>()
                .HasMany(e => e.tbl_krs)
                .WithRequired(e => e.tbl_jadwal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_jadwal>()
                .HasMany(e => e.tbl_ujian)
                .WithRequired(e => e.tbl_jadwal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_kehadiran>()
                .Property(e => e.NIM)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_kehadiran>()
                .Property(e => e.IsHadir)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_kehadiran>()
                .Property(e => e.Kode_matkul)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_krs>()
                .Property(e => e.NIM)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_krs>()
                .Property(e => e.Kode_Jadwal)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.NIM)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.Nama_Mahasiswa)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.Alamat)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.Kode_Prodi)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.Email_Mahasiswa)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.No_Hp)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.Jenis_Kelamin)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .Property(e => e.AGAMA)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .HasMany(e => e.tbl_Detail_Tagihan)
                .WithRequired(e => e.tbl_mahasiswa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .HasMany(e => e.tbl_kehadiran)
                .WithRequired(e => e.tbl_mahasiswa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .HasMany(e => e.tbl_krs)
                .WithRequired(e => e.tbl_mahasiswa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .HasMany(e => e.tbl_nilai)
                .WithRequired(e => e.tbl_mahasiswa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mahasiswa>()
                .HasMany(e => e.tbl_user)
                .WithRequired(e => e.tbl_mahasiswa)
                .HasForeignKey(e => e.User_Name)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .Property(e => e.Kode_Matkul)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .Property(e => e.Nama_Matkul)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .Property(e => e.Kode_Dosen)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .Property(e => e.Semester)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .HasMany(e => e.tbl_jadwal)
                .WithRequired(e => e.tbl_mata_kuliah)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .HasMany(e => e.tbl_kehadiran)
                .WithRequired(e => e.tbl_mata_kuliah)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_mata_kuliah>()
                .HasMany(e => e.tbl_nilai)
                .WithRequired(e => e.tbl_mata_kuliah)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_nilai>()
                .Property(e => e.NIM)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_nilai>()
                .Property(e => e.Kode_Matkul)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_nilai>()
                .Property(e => e.Nilai_UTS)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_nilai>()
                .Property(e => e.Nilai_Quis)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_nilai>()
                .Property(e => e.Nilai_UAS)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_nilai>()
                .Property(e => e.Nilai_Akhir)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_Periode>()
                .Property(e => e.Kode_Periode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Periode>()
                .Property(e => e.Periode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Periode>()
                .Property(e => e.Tahun)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Periode>()
                .HasMany(e => e.tbl_jadwal)
                .WithRequired(e => e.tbl_Periode)
                .HasForeignKey(e => e.Code_Periode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Periode>()
                .HasMany(e => e.tbl_ujian)
                .WithRequired(e => e.tbl_Periode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_prodi>()
                .Property(e => e.Kode_Prodi)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_prodi>()
                .Property(e => e.Nama_Prodi)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_prodi>()
                .Property(e => e.Kode_Fakultas)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_prodi>()
                .HasMany(e => e.tbl_dosen)
                .WithRequired(e => e.tbl_prodi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_prodi>()
                .HasMany(e => e.tbl_mahasiswa)
                .WithRequired(e => e.tbl_prodi)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Ruang_Kelas>()
                .Property(e => e.Kode_Ruangan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_Ruang_Kelas>()
                .HasMany(e => e.tbl_jadwal)
                .WithRequired(e => e.tbl_Ruang_Kelas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_tagihan>()
                .Property(e => e.Kode_Tagihan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_tagihan>()
                .HasMany(e => e.tbl_Detail_Tagihan)
                .WithRequired(e => e.tbl_tagihan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_Tagihan_Mahasiswa>()
                .Property(e => e.Kode_Detail_Tagihan)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ujian>()
                .Property(e => e.NIM)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ujian>()
                .Property(e => e.Kode_Jadwal)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_ujian>()
                .Property(e => e.Presentasi_Kehadiran)
                .HasPrecision(8, 2);

            modelBuilder.Entity<tbl_ujian>()
                .Property(e => e.Kode_Periode)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.User_Name)
                .IsUnicode(false);

            modelBuilder.Entity<tbl_user>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
