using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lms_Db.Model
{
    public partial class lms_dbContext : DbContext
    {
        public lms_dbContext()
        {
        }

        public lms_dbContext(DbContextOptions<lms_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LmsBookDetails> LmsBookDetails { get; set; }
        public virtual DbSet<LmsBookIssue> LmsBookIssue { get; set; }
        public virtual DbSet<LmsFineDetails> LmsFineDetails { get; set; }
        public virtual DbSet<LmsMembers> LmsMembers { get; set; }
        public virtual DbSet<LmsSuppliersDetails> LmsSuppliersDetails { get; set; }
        public virtual DbSet<VwBookDetails> VwBookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-T663RI27;Database=lms_db; integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LmsBookDetails>(entity =>
            {
                entity.HasKey(e => e.BookCode)
                    .HasName("LMS_cts4");

                entity.ToTable("LMS_BOOK_DETAILS");

                entity.Property(e => e.BookCode)
                    .HasColumnName("BOOK_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasColumnName("AUTHOR")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BookEdition).HasColumnName("BOOK_EDITION");

                entity.Property(e => e.BookTitle)
                    .IsRequired()
                    .HasColumnName("BOOK_TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DateArrival)
                    .HasColumnName("DATE_ARRIVAL")
                    .HasColumnType("date");

                entity.Property(e => e.Price)
                    .HasColumnName("PRICE")
                    .HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Publication)
                    .HasColumnName("PUBLICATION")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PublishDate)
                    .HasColumnName("PUBLISH_DATE")
                    .HasColumnType("date");

                entity.Property(e => e.RackNum)
                    .HasColumnName("RACK_NUM")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LmsBookIssue>(entity =>
            {
                entity.HasKey(e => e.BookIssueNo)
                    .HasName("LMS_cts5");

                entity.ToTable("LMS_BOOK_ISSUE");

                entity.Property(e => e.BookIssueNo)
                    .HasColumnName("BOOK_ISSUE_NO")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookCode)
                    .IsRequired()
                    .HasColumnName("BOOK_CODE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateIssue)
                    .HasColumnName("DATE_ISSUE")
                    .HasColumnType("date");

                entity.Property(e => e.DateReturn)
                    .HasColumnName("DATE_RETURN")
                    .HasColumnType("date");

                entity.Property(e => e.DateReturned)
                    .HasColumnName("DATE_RETURNED")
                    .HasColumnType("date");

                entity.Property(e => e.FineRange)
                    .HasColumnName("FINE_RANGE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MemberId)
                    .IsRequired()
                    .HasColumnName("MEMBER_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LmsFineDetails>(entity =>
            {
                entity.HasKey(e => e.FineRange)
                    .HasName("LMS_cts3");

                entity.ToTable("LMS_FINE_DETAILS");

                entity.Property(e => e.FineRange)
                    .HasColumnName("FINE_RANGE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("FINE_AMOUNT")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<LmsMembers>(entity =>
            {
                entity.HasKey(e => e.MemberId)
                    .HasName("LMS_cts1");

                entity.ToTable("LMS_MEMBERS");

                entity.Property(e => e.MemberId)
                    .HasColumnName("MEMBER_ID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("CITY")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateExpire)
                    .HasColumnName("DATE_EXPIRE")
                    .HasColumnType("date");

                entity.Property(e => e.DateRegister)
                    .HasColumnName("DATE_REGISTER")
                    .HasColumnType("date");

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasColumnName("MEMBER_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MembershipStatus)
                    .IsRequired()
                    .HasColumnName("MEMBERSHIP_STATUS")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LmsSuppliersDetails>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("LMS_cts2");

                entity.ToTable("LMS_SUPPLIERS_DETAILS");

                entity.Property(e => e.SupplierId)
                    .HasColumnName("SUPPLIER_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("ADDRESS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact).HasColumnName("CONTACT");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwBookDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Book_details");

                entity.Property(e => e.BookTitle)
                    .IsRequired()
                    .HasColumnName("BOOK_TITLE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MemberName)
                    .IsRequired()
                    .HasColumnName("MEMBER_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasColumnName("SUPPLIER_NAME")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
