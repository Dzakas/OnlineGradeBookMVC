using Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class DataContext : IdentityDbContext
    {
        public DbSet<_1ABiology> _1ABiology { get; set; }
        public DbSet<_1AChemistry> _1AChemistry { get; set; }
        public DbSet<_1AEnglish> _1AEnglish { get; set; }
        public DbSet<_1AGeography> _1AGeography { get; set; }
        public DbSet<_1AGerman> _1AGerman { get; set; }
        public DbSet<_1AHistory> _1AHistory { get; set; }
        public DbSet<_1AMath> _1AMath { get; set; }
        public DbSet<_1AStudent> _1AStudents { get; set; }
        public DbSet<ContactStudentInfo1A> ContactStudentInfo1A { get; set; }
        public DbSet<_1BBiology> _1BBiology { get; set; }
        public DbSet<_1BChemistry> _1BChemistry { get; set; }
        public DbSet<_1BEnglish> _1BEnglish { get; set; }
        public DbSet<_1BGeography> _1BGeography { get; set; }
        public DbSet<_1BGerman> _1BGerman { get; set; }
        public DbSet<_1BHistory> _1BHistory { get; set; }
        public DbSet<_1BMath> _1BMath { get; set; }
        public DbSet<_1BStudent> _1BStudents { get; set; }
        public DbSet<ContactStudentInfo1B> ContactStudentInfo1B { get; set; }
        public DbSet<_1CBiology> _1CBiology { get; set; }
        public DbSet<_1CChemistry> _1CChemistry { get; set; }
        public DbSet<_1CEnglish> _1CEnglish { get; set; }
        public DbSet<_1CGeography> _1CGeography { get; set; }
        public DbSet<_1CGerman> _1CGerman { get; set; }
        public DbSet<_1CHistory> _1CHistory { get; set; }
        public DbSet<_1CMath> _1CMath { get; set; }
        public DbSet<_1CStudent> _1CStudents { get; set; }
        public DbSet<ContactStudentInfo1C> ContactStudentInfo1C { get; set; }
        public DbSet<_2ABiology> _2ABiology { get; set; }
        public DbSet<_2AChemistry> _2AChemistry { get; set; }
        public DbSet<_2AEnglish> _2AEnglish { get; set; }
        public DbSet<_2AGeography> _2AGeography { get; set; }
        public DbSet<_2AGerman> _2AGerman { get; set; }
        public DbSet<_2AHistory> _2AHistory { get; set; }
        public DbSet<_2AMath> _2AMath { get; set; }
        public DbSet<_2AStudent> _2AStudents { get; set; }
        public DbSet<ContactStudentInfo2A> ContactStudentInfo2A { get; set; }
        public DbSet<_2BBiology> _2BBiology { get; set; }
        public DbSet<_2BChemistry> _2BChemistry { get; set; }
        public DbSet<_2BEnglish> _2BEnglish { get; set; }
        public DbSet<_2BGeography> _2BGeography { get; set; }
        public DbSet<_2BGerman> _2BGerman { get; set; }
        public DbSet<_2BHistory> _2BHistory { get; set; }
        public DbSet<_2BMath> _2BMath { get; set; }
        public DbSet<_2BStudent> _2BStudents { get; set; }
        public DbSet<ContactStudentInfo2B> ContactStudentInfo2B { get; set; }
        public DbSet<_2CBiology> _2CBiology { get; set; }
        public DbSet<_2CChemistry> _2CChemistry { get; set; }
        public DbSet<_2CEnglish> _2CEnglish { get; set; }
        public DbSet<_2CGeography> _2CGeography { get; set; }
        public DbSet<_2CGerman> _2CGerman { get; set; }
        public DbSet<_2CHistory> _2CHistory { get; set; }
        public DbSet<_2CMath> _2CMath { get; set; }
        public DbSet<_2CStudent> _2CStudents { get; set; }
        public DbSet<ContactStudentInfo2C> ContactStudentInfo2C { get; set; }
        public DbSet<_3ABiology> _3ABiology { get; set; }
        public DbSet<_3AChemistry> _3AChemistry { get; set; }
        public DbSet<_3AEnglish> _3AEnglish { get; set; }
        public DbSet<_3AGeography> _3AGeography { get; set; }
        public DbSet<_3AGerman> _3AGerman { get; set; }
        public DbSet<_3AHistory> _3AHistory { get; set; }
        public DbSet<_3AMath> _3AMath { get; set; }
        public DbSet<_3AStudent> _3AStudents { get; set; }
        public DbSet<ContactStudentInfo3A> ContactStudentInfo3A { get; set; }
        public DbSet<_3BBiology> _3BBiology { get; set; }
        public DbSet<_3BChemistry> _3BChemistry { get; set; }
        public DbSet<_3BEnglish> _3BEnglish { get; set; }
        public DbSet<_3BGeography> _3BGeography { get; set; }
        public DbSet<_3BGerman> _3BGerman { get; set; }
        public DbSet<_3BHistory> _3BHistory { get; set; }
        public DbSet<_3BMath> _3BMath { get; set; }
        public DbSet<_3BStudent> _3BStudents { get; set; }
        public DbSet<ContactStudentInfo3B> ContactStudentInfo3B { get; set; }
        public DbSet<_3CBiology> _3CBiology { get; set; }
        public DbSet<_3CChemistry> _3CChemistry { get; set; }
        public DbSet<_3CEnglish> _3CEnglish { get; set; }
        public DbSet<_3CGeography> _3CGeography { get; set; }
        public DbSet<_3CGerman> _3CGerman { get; set; }
        public DbSet<_3CHistory> _3CHistory { get; set; }
        public DbSet<_3CMath> _3CMath { get; set; }
        public DbSet<_3CStudent> _3CStudents { get; set; }
        public DbSet<ContactStudentInfo3C> ContactStudentInfo3C { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<TeacherAddress> TeacherAddress { get; set; }
        public DbSet<TeacherContactInfo> TeacherContactInfo { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<_1AStudent>().HasOne(a => a._1ABiology).WithOne(b => b._1AStudent).HasForeignKey<_1ABiology>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AChemistry).WithOne(b => b._1AStudent).HasForeignKey<_1AChemistry>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AEnglish).WithOne(b => b._1AStudent).HasForeignKey<_1AEnglish>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AGeography).WithOne(b => b._1AStudent).HasForeignKey<_1AGeography>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AGerman).WithOne(b => b._1AStudent).HasForeignKey<_1AGerman>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AHistory).WithOne(b => b._1AStudent).HasForeignKey<_1AHistory>(e => e.StudentRef);
            builder.Entity<_1AStudent>().HasOne(a => a._1AMath).WithOne(b => b._1AStudent).HasForeignKey<_1AMath>(e => e.StudentRef);

            builder.Entity<_1BStudent>().HasOne(a => a._1BBiology).WithOne(b => b._1BStudent).HasForeignKey<_1BBiology>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a._1BChemistry).WithOne(b => b._1BStudent).HasForeignKey<_1BChemistry>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a._1BEnglish).WithOne(b => b._1BStudent).HasForeignKey<_1BEnglish>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a._1BGeography).WithOne(b => b._1BStudent).HasForeignKey<_1BGeography>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a._1BGerman).WithOne(b => b._1BStudent).HasForeignKey<_1BGerman>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a._1BHistory).WithOne(b => b._1BStudent).HasForeignKey<_1BHistory>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a._1BMath).WithOne(b => b._1BStudent).HasForeignKey<_1BMath>(e => e.StudentRef);

            builder.Entity<_1CStudent>().HasOne(a => a._1CBiology).WithOne(b => b._1CStudent).HasForeignKey<_1CBiology>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a._1CChemistry).WithOne(b => b._1CStudent).HasForeignKey<_1CChemistry>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a._1CEnglish).WithOne(b => b._1CStudent).HasForeignKey<_1CEnglish>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a._1CGeography).WithOne(b => b._1CStudent).HasForeignKey<_1CGeography>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a._1CGerman).WithOne(b => b._1CStudent).HasForeignKey<_1CGerman>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a._1CHistory).WithOne(b => b._1CStudent).HasForeignKey<_1CHistory>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a._1CMath).WithOne(b => b._1CStudent).HasForeignKey<_1CMath>(e => e.StudentRef);

            builder.Entity<_2AStudent>().HasOne(a => a._2ABiology).WithOne(b => b._2AStudent).HasForeignKey<_2ABiology>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a._2AChemistry).WithOne(b => b._2AStudent).HasForeignKey<_2AChemistry>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a._2AEnglish).WithOne(b => b._2AStudent).HasForeignKey<_2AEnglish>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a._2AGeography).WithOne(b => b._2AStudent).HasForeignKey<_2AGeography>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a._2AGerman).WithOne(b => b._2AStudent).HasForeignKey<_2AGerman>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a._2AHistory).WithOne(b => b._2AStudent).HasForeignKey<_2AHistory>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a._2AMath).WithOne(b => b._2AStudent).HasForeignKey<_2AMath>(e => e.StudentRef);

            builder.Entity<_2BStudent>().HasOne(a => a._2BBiology).WithOne(b => b._2BStudent).HasForeignKey<_2BBiology>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a._2BChemistry).WithOne(b => b._2BStudent).HasForeignKey<_2BChemistry>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a._2BEnglish).WithOne(b => b._2BStudent).HasForeignKey<_2BEnglish>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a._2BGeography).WithOne(b => b._2BStudent).HasForeignKey<_2BGeography>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a._2BGerman).WithOne(b => b._2BStudent).HasForeignKey<_2BGerman>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a._2BHistory).WithOne(b => b._2BStudent).HasForeignKey<_2BHistory>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a._2BMath).WithOne(b => b._2BStudent).HasForeignKey<_2BMath>(e => e.StudentRef);

            builder.Entity<_2CStudent>().HasOne(a => a._2CBiology).WithOne(b => b._2CStudent).HasForeignKey<_2CBiology>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a._2CChemistry).WithOne(b => b._2CStudent).HasForeignKey<_2CChemistry>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a._2CEnglish).WithOne(b => b._2CStudent).HasForeignKey<_2CEnglish>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a._2CGeography).WithOne(b => b._2CStudent).HasForeignKey<_2CGeography>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a._2CGerman).WithOne(b => b._2CStudent).HasForeignKey<_2CGerman>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a._2CHistory).WithOne(b => b._2CStudent).HasForeignKey<_2CHistory>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a._2CMath).WithOne(b => b._2CStudent).HasForeignKey<_2CMath>(e => e.StudentRef);

            builder.Entity<_3AStudent>().HasOne(a => a._3ABiology).WithOne(b => b._3AStudent).HasForeignKey<_3ABiology>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a._3AChemistry).WithOne(b => b._3AStudent).HasForeignKey<_3AChemistry>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a._3AEnglish).WithOne(b => b._3AStudent).HasForeignKey<_3AEnglish>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a._3AGeography).WithOne(b => b._3AStudent).HasForeignKey<_3AGeography>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a._3AGerman).WithOne(b => b._3AStudent).HasForeignKey<_3AGerman>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a._3AHistory).WithOne(b => b._3AStudent).HasForeignKey<_3AHistory>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a._3AMath).WithOne(b => b._3AStudent).HasForeignKey<_3AMath>(e => e.StudentRef);

            builder.Entity<_3BStudent>().HasOne(a => a._3BBiology).WithOne(b => b._3BStudent).HasForeignKey<_3BBiology>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a._3BChemistry).WithOne(b => b._3BStudent).HasForeignKey<_3BChemistry>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a._3BEnglish).WithOne(b => b._3BStudent).HasForeignKey<_3BEnglish>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a._3BGeography).WithOne(b => b._3BStudent).HasForeignKey<_3BGeography>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a._3BGerman).WithOne(b => b._3BStudent).HasForeignKey<_3BGerman>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a._3BHistory).WithOne(b => b._3BStudent).HasForeignKey<_3BHistory>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a._3BMath).WithOne(b => b._3BStudent).HasForeignKey<_3BMath>(e => e.StudentRef);

            builder.Entity<_3CStudent>().HasOne(a => a._3CBiology).WithOne(b => b._3CStudent).HasForeignKey<_3CBiology>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a._3CChemistry).WithOne(b => b._3CStudent).HasForeignKey<_3CChemistry>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a._3CEnglish).WithOne(b => b._3CStudent).HasForeignKey<_3CEnglish>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a._3CGeography).WithOne(b => b._3CStudent).HasForeignKey<_3CGeography>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a._3CGerman).WithOne(b => b._3CStudent).HasForeignKey<_3CGerman>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a._3CHistory).WithOne(b => b._3CStudent).HasForeignKey<_3CHistory>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a._3CMath).WithOne(b => b._3CStudent).HasForeignKey<_3CMath>(e => e.StudentRef);

            builder.Entity<_1AStudent>().HasOne(a => a.ContactStudentInfo1A).WithOne(b => b._1AStudent).HasForeignKey<ContactStudentInfo1A>(e => e.StudentRef);
            builder.Entity<_1BStudent>().HasOne(a => a.ContactStudentInfo1B).WithOne(b => b._1BStudent).HasForeignKey<ContactStudentInfo1B>(e => e.StudentRef);
            builder.Entity<_1CStudent>().HasOne(a => a.ContactStudentInfo1C).WithOne(b => b._1CStudent).HasForeignKey<ContactStudentInfo1C>(e => e.StudentRef);
            builder.Entity<_2AStudent>().HasOne(a => a.ContactStudentInfo2A).WithOne(b => b._2AStudent).HasForeignKey<ContactStudentInfo2A>(e => e.StudentRef);
            builder.Entity<_2BStudent>().HasOne(a => a.ContactStudentInfo2B).WithOne(b => b._2BStudent).HasForeignKey<ContactStudentInfo2B>(e => e.StudentRef);
            builder.Entity<_2CStudent>().HasOne(a => a.ContactStudentInfo2C).WithOne(b => b._2CStudent).HasForeignKey<ContactStudentInfo2C>(e => e.StudentRef);
            builder.Entity<_3AStudent>().HasOne(a => a.ContactStudentInfo3A).WithOne(b => b._3AStudent).HasForeignKey<ContactStudentInfo3A>(e => e.StudentRef);
            builder.Entity<_3BStudent>().HasOne(a => a.ContactStudentInfo3B).WithOne(b => b._3BStudent).HasForeignKey<ContactStudentInfo3B>(e => e.StudentRef);
            builder.Entity<_3CStudent>().HasOne(a => a.ContactStudentInfo3C).WithOne(b => b._3CStudent).HasForeignKey<ContactStudentInfo3C>(e => e.StudentRef);


            builder.Entity<Teacher>().HasOne(a => a.TeacherAddress).WithOne(b => b.Teacher).HasForeignKey<TeacherAddress>(e => e.TeacherRef);
            builder.Entity<Teacher>().HasOne(a => a.TeacherContactInfo).WithOne(b => b.Teacher).HasForeignKey<TeacherContactInfo>(e => e.TeacherRef);
        }
    }
}
