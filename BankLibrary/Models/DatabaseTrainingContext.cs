using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BankLibrary.Models
{
    public partial class DatabaseTrainingContext : DbContext
    {
        public DatabaseTrainingContext()
        {
        }

        public DatabaseTrainingContext(DbContextOptions<DatabaseTrainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Ajay> Ajays { get; set; }
        public virtual DbSet<Darshan> Darshans { get; set; }
        public virtual DbSet<HarishSbaccount> HarishSbaccounts { get; set; }
        public virtual DbSet<JivikaTable> JivikaTables { get; set; }
        public virtual DbSet<LekhanaSbacc> LekhanaSbaccs { get; set; }
        public virtual DbSet<Manisha> Manishas { get; set; }
        public virtual DbSet<ManishaSbaccount> ManishaSbaccounts { get; set; }
        public virtual DbSet<ManishaSbtransaction> ManishaSbtransactions { get; set; }
        public virtual DbSet<SarwatSbaccount> SarwatSbaccounts { get; set; }
        public virtual DbSet<SarwatSbtransaction> SarwatSbtransactions { get; set; }
        public virtual DbSet<SbAccountAkshay> SbAccountAkshays { get; set; }
        public virtual DbSet<SbaccountAmresh> SbaccountAmreshes { get; set; }
        public virtual DbSet<Shaifali> Shaifalis { get; set; }
        public virtual DbSet<Shivam> Shivams { get; set; }
        public virtual DbSet<Table1> Table1s { get; set; }
        public virtual DbSet<Table2> Table2s { get; set; }
        public virtual DbSet<Table3> Table3s { get; set; }
        public virtual DbSet<Table4> Table4s { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=172.22.10.31;Database=DatabaseTraining;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Ajay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Ajay");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Darshan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Darshan");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HarishSbaccount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("harish_SBAccount");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(10)
                    .HasColumnName("employee_name")
                    .IsFixedLength(true);

                entity.Property(e => e.EmployeeNumber).HasColumnName("employee_number");
            });

            modelBuilder.Entity<JivikaTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Jivika_Table");

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .HasColumnName("age")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LekhanaSbacc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Lekhana_sbacc");

                entity.Property(e => e.AccNumber).HasColumnName("acc_number");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("address");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Manisha>(entity =>
            {
                entity.HasKey(e => e.Eid);

                entity.ToTable("Manisha");

                entity.Property(e => e.Eid).ValueGeneratedNever();

                entity.Property(e => e.Ename).HasMaxLength(50);
            });

            modelBuilder.Entity<ManishaSbaccount>(entity =>
            {
                entity.HasKey(e => e.Accno);

                entity.ToTable("Manisha_SBAccount");

                entity.Property(e => e.Accno).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bal).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ManishaSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("Manisha_SBTransaction");

                entity.Property(e => e.TransId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransID");

                entity.Property(e => e.Amt).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransDate).HasColumnType("date");

                entity.Property(e => e.TransType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SarwatSbaccount>(entity =>
            {
                entity.HasKey(e => e.AccountNumber);

                entity.ToTable("Sarwat_SBAccount");

                entity.Property(e => e.AccountNumber).ValueGeneratedNever();

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalance).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SarwatSbtransaction>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Sarwat_SBTransaction");

                entity.Property(e => e.TransactionId)
                    .ValueGeneratedNever()
                    .HasColumnName("TransactionID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TransactionDate).HasColumnType("date");

                entity.Property(e => e.TransactionType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SbAccountAkshay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sb_account_akshay");

                entity.Property(e => e.CustomerName)
                    .IsUnicode(false)
                    .HasColumnName("customer_name");
            });

            modelBuilder.Entity<SbaccountAmresh>(entity =>
            {
                entity.HasKey(e => e.AccNo);

                entity.ToTable("SBAccount_Amresh");

                entity.Property(e => e.AccNo).ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shaifali>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Shaifali");

                entity.Property(e => e.Shaifali1)
                    .HasMaxLength(10)
                    .HasColumnName("Shaifali")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Shivam>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("shivam");

                entity.Property(e => e.Empname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_1");

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_2");

                entity.Property(e => e.Age)
                    .HasMaxLength(10)
                    .HasColumnName("age")
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table3>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_3");

                entity.Property(e => e.Xyz)
                    .HasMaxLength(10)
                    .HasColumnName("xyz")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Table4>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Table_4");

                entity.Property(e => e.Ravi)
                    .HasMaxLength(10)
                    .HasColumnName("ravi")
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
