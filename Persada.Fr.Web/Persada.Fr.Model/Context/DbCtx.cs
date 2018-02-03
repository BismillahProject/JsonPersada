using Persada.Fr.Model.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persada.Fr.Model.Context
{
    public class DbCtx : DbContext
    {
        public DbCtx() : base("name=DbConextion") { }

        public DbSet<MUSER> muser { get; set; }
        public DbSet<RegisterUser> RegisterUser { get; set; }
        public DbSet<ClientKey> ClientKeys { get; set; }
        public DbSet<TokensManager> TokensManager { get; set; }

        public virtual DbSet<TOURIS_TM_CATEGORY> TOURIS_TM_CATEGORY { get; set; }
        public virtual DbSet<TOURIS_TM_CITY> TOURIS_TM_CITY { get; set; }
        public virtual DbSet<TOURIS_TM_COUNTRY> TOURIS_TM_COUNTRY { get; set; }
        public virtual DbSet<TOURIS_TM_CULINARY> TOURIS_TM_CULINARY { get; set; }
        public virtual DbSet<TOURIS_TM_CULINARY_PHOTO> TOURIS_TM_CULINARY_PHOTO { get; set; }
        public virtual DbSet<TOURIS_TM_DISTRICTS> TOURIS_TM_DISTRICTS { get; set; }
        public virtual DbSet<TOURIS_TM_EVENT> TOURIS_TM_EVENT { get; set; }
        public virtual DbSet<TOURIS_TM_EVENT_PHOTO> TOURIS_TM_EVENT_PHOTO { get; set; }
        public virtual DbSet<TOURIS_TM_MENU> TOURIS_TM_MENU { get; set; }
        public virtual DbSet<TOURIS_TM_PARAMETER> TOURIS_TM_PARAMETER { get; set; }
        public virtual DbSet<TOURIS_TM_PROVINCE> TOURIS_TM_PROVINCE { get; set; }
        public virtual DbSet<TOURIS_TM_ROLE> TOURIS_TM_ROLE { get; set; }
        public virtual DbSet<TOURIS_TM_ROLE_MENU> TOURIS_TM_ROLE_MENU { get; set; }
        public virtual DbSet<TOURIS_TM_TESTIMONIAL> TOURIS_TM_TESTIMONIAL { get; set; }
        public virtual DbSet<TOURIS_TM_TOUR> TOURIS_TM_TOUR { get; set; }
        public virtual DbSet<TOURIS_TM_TOUR_PHOTO> TOURIS_TM_TOUR_PHOTO { get; set; }
        public virtual DbSet<TOURIS_TM_USER> TOURIS_TM_USER { get; set; }
        public virtual DbSet<TOURIS_TM_USER_DT> TOURIS_TM_USER_DT { get; set; }
        public virtual DbSet<TOURIS_TM_USER_PROFILE> TOURIS_TM_USER_PROFILE { get; set; }
        public virtual DbSet<TOURIS_TM_USER_PROFILE_SOSMED> TOURIS_TM_USER_PROFILE_SOSMED { get; set; }
        public virtual DbSet<TOURIS_TM_VILLAGE> TOURIS_TM_VILLAGE { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .Property(e => e.CATEGORY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .Property(e => e.CATEGORY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .Property(e => e.CATEGORY_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .HasMany(e => e.TOURIS_TM_CULINARY)
        //        .WithRequired(e => e.TOURIS_TM_CATEGORY)
        //        .HasForeignKey(e => e.CATEGORY_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .HasMany(e => e.TOURIS_TM_EVENT)
        //        .WithRequired(e => e.TOURIS_TM_CATEGORY)
        //        .HasForeignKey(e => e.CATEGORY_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_CATEGORY>()
        //        .HasMany(e => e.TOURIS_TM_TOUR)
        //        .WithRequired(e => e.TOURIS_TM_CATEGORY)
        //        .HasForeignKey(e => e.CATEGORY_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_CITY>()
        //        .Property(e => e.CITY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CITY>()
        //        .Property(e => e.CITY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CITY>()
        //        .Property(e => e.CITY_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CITY>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CITY>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CITY>()
        //        .HasMany(e => e.TOURIS_TM_DISTRICTS)
        //        .WithRequired(e => e.TOURIS_TM_CITY)
        //        .HasForeignKey(e => e.CITY_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_COUNTRY>()
        //        .Property(e => e.COUNTRY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_COUNTRY>()
        //        .Property(e => e.COUNTRY_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_COUNTRY>()
        //        .Property(e => e.COUNTRY_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_COUNTRY>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_COUNTRY>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY>()
        //        .Property(e => e.CULINARY_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY>()
        //        .Property(e => e.CULINARY_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY>()
        //        .HasMany(e => e.TOURIS_TM_CULINARY_PHOTO)
        //        .WithRequired(e => e.TOURIS_TM_CULINARY)
        //        .HasForeignKey(e => e.CULINARY_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY_PHOTO>()
        //        .Property(e => e.PHOTO_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY_PHOTO>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_CULINARY_PHOTO>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_DISTRICTS>()
        //        .Property(e => e.DISTRICTS_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_DISTRICTS>()
        //        .Property(e => e.DISTRICTS_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_DISTRICTS>()
        //        .Property(e => e.DISTRICTS_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_DISTRICTS>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_DISTRICTS>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_DISTRICTS>()
        //        .HasMany(e => e.TOURIS_TM_VILLAGE)
        //        .WithRequired(e => e.TOURIS_TM_DISTRICTS)
        //        .HasForeignKey(e => e.DISTRICTS_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT>()
        //        .Property(e => e.EVENT_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT>()
        //        .Property(e => e.EVENT_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT>()
        //        .HasMany(e => e.TOURIS_TM_EVENT_PHOTO)
        //        .WithRequired(e => e.TOURIS_TM_EVENT)
        //        .HasForeignKey(e => e.EVENT_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT_PHOTO>()
        //        .Property(e => e.PHOTO_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT_PHOTO>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_EVENT_PHOTO>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_MENU>()
        //        .Property(e => e.MENU_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_MENU>()
        //        .Property(e => e.MENU_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_MENU>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_MENU>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_MENU>()
        //        .HasMany(e => e.TOURIS_TM_ROLE_MENU)
        //        .WithRequired(e => e.TOURIS_TM_MENU)
        //        .HasForeignKey(e => e.MENU_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_PARAMETER>()
        //        .Property(e => e.PARAMETER_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PARAMETER>()
        //        .Property(e => e.PARAMETER_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PARAMETER>()
        //        .Property(e => e.PARAMETER_VALUE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PARAMETER>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PARAMETER>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .Property(e => e.COUNTRY_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .Property(e => e.PROVINCE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .Property(e => e.PROVINCE_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .Property(e => e.PROVINCE_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_PROVINCE>()
        //        .HasMany(e => e.TOURIS_TM_CITY)
        //        .WithRequired(e => e.TOURIS_TM_PROVINCE)
        //        .HasForeignKey(e => e.PROVINCE_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE>()
        //        .Property(e => e.ROLE_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE>()
        //        .Property(e => e.ROLE_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE>()
        //        .HasMany(e => e.TOURIS_TM_ROLE_MENU)
        //        .WithRequired(e => e.TOURIS_TM_ROLE)
        //        .HasForeignKey(e => e.ROLE_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE>()
        //        .HasMany(e => e.TOURIS_TM_USER_DT)
        //        .WithRequired(e => e.TOURIS_TM_ROLE)
        //        .HasForeignKey(e => e.ROLE_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE_MENU>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_ROLE_MENU>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TESTIMONIAL>()
        //        .Property(e => e.TESTIMONI_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TESTIMONIAL>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TESTIMONIAL>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR>()
        //        .Property(e => e.TOUR_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR>()
        //        .Property(e => e.TOUR_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR>()
        //        .HasMany(e => e.TOURIS_TM_TOUR_PHOTO)
        //        .WithRequired(e => e.TOURIS_TM_TOUR)
        //        .HasForeignKey(e => e.TOUR_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR_PHOTO>()
        //        .Property(e => e.PHOTO_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR_PHOTO>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_TOUR_PHOTO>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .Property(e => e.USER_ID)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .Property(e => e.USER_MAIL)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .Property(e => e.USER_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .Property(e => e.PASSWORD)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER>()
        //        .HasMany(e => e.TOURIS_TM_USER_PROFILE)
        //        .WithRequired(e => e.TOURIS_TM_USER)
        //        .HasForeignKey(e => e.USER_ID_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_DT>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_DT>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_DT>()
        //        .HasMany(e => e.TOURIS_TM_USER)
        //        .WithRequired(e => e.TOURIS_TM_USER_DT)
        //        .HasForeignKey(e => e.USER_DT_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.GENDER)
        //        .IsFixedLength()
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.ADDRESS)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.JOB)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.COMPANY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.HOBBY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE>()
        //        .HasMany(e => e.TOURIS_TM_USER_PROFILE_SOSMED)
        //        .WithRequired(e => e.TOURIS_TM_USER_PROFILE)
        //        .HasForeignKey(e => e.USER_PROFILE_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE_SOSMED>()
        //        .Property(e => e.SOSMED_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE_SOSMED>()
        //        .Property(e => e.SOSMED_PATH)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE_SOSMED>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_USER_PROFILE_SOSMED>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .Property(e => e.CHILDHOOD_NAME)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .Property(e => e.CHILDHOOD_CODE)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .Property(e => e.CHILDHOOD_DESCRIPTION)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .Property(e => e.CREATED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .Property(e => e.LAST_MODIFIED_BY)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .HasMany(e => e.TOURIS_TM_CULINARY)
        //        .WithRequired(e => e.TOURIS_TM_VILLAGE)
        //        .HasForeignKey(e => e.VILLAGE_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .HasMany(e => e.TOURIS_TM_EVENT)
        //        .WithRequired(e => e.TOURIS_TM_VILLAGE)
        //        .HasForeignKey(e => e.VILLAGE_ID)
        //        .WillCascadeOnDelete(false);

        //    modelBuilder.Entity<TOURIS_TM_VILLAGE>()
        //        .HasMany(e => e.TOURIS_TM_TOUR)
        //        .WithRequired(e => e.TOURIS_TM_VILLAGE)
        //        .HasForeignKey(e => e.VILLAGE_ID)
        //        .WillCascadeOnDelete(false);
        //}
    }
}
