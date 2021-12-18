using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Proxies;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace cellular
{
    [Index(nameof(Series), nameof(Num), IsUnique = true)]
    public class Passport
=======
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace cellular
{
    public partial class Passport
>>>>>>> acb11c1 (ef6 and net472)
    {
        [Key]
        public int Id { get; set; }

<<<<<<< HEAD
        [Column(TypeName = "VARCHAR(4)"), Required]
        public string Series { get; set; }
        
        [Column(TypeName = "VARCHAR(6)"), Required]
=======
        [Column(TypeName = "VARCHAR"), MaxLength(4), MinLength(4), Required, Index("IX_Pasports_SeriesAndNum", IsUnique = true)]
        public string Series { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(6), MinLength(6), Required, Index("IX_Pasports_SeriesAndNum", IsUnique = true)]
>>>>>>> acb11c1 (ef6 and net472)
        public string Num { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime DateOfIssue { get; set; }
        
<<<<<<< HEAD
        [Column(TypeName = "VARCHAR(63)"), Required]
        public string IssuingAuthority { get; set; }
        
        [Column(TypeName = "VARCHAR(63)"), Required]
        public string Surname { get; set; }
        
        [Column(TypeName = "VARCHAR(63)"), Required]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(63)")]
=======
        [Column(TypeName = "VARCHAR"), MaxLength(63), Required]
        public string IssuingAuthority { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(11), Required]
        public string Surname { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(63), Required]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(11)]
>>>>>>> acb11c1 (ef6 and net472)
        public string Patronymic { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime DateOfBirth { get; set; }
        
<<<<<<< HEAD
        [Column(TypeName = "VARCHAR(255)"), Required]
        public string Address { get; set; }

        public virtual Client Client { get; set; }

=======
        [Column(TypeName = "VARCHAR"), MaxLength(255), Required]
        public string Address { get; set; }

>>>>>>> acb11c1 (ef6 and net472)
        public override string ToString()
        {
            return $"{Series} {Num}";
        }
<<<<<<< HEAD
    }

    public class Client
=======

        public void Update(Passport passport)
        {
            this.Series = passport.Series;
            this.Num = passport.Num;
            this.DateOfIssue = passport.DateOfIssue;
            this.IssuingAuthority = passport.IssuingAuthority;
            this.Surname = passport.Surname;
            this.Name = passport.Name;
            this.Patronymic = passport.Patronymic;
            this.DateOfBirth = passport.DateOfBirth;
            this.Address = passport.Address;
        }
    }

    public partial class Client
>>>>>>> acb11c1 (ef6 and net472)
    {
        [Key]
        public int Id { get; set; }
        
<<<<<<< HEAD
        [Required]
        public int PassportId { get; set; }
        [ForeignKey("PassportId")]
=======
        public int PassportId { get; set; }
        //[ForeignKey("PassportId")]
>>>>>>> acb11c1 (ef6 and net472)
        public virtual Passport Passport { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public override string ToString()
        {
            UserManager userManager = new UserManager(this.Id);
            return userManager.GetFullName();
        }
    }

<<<<<<< HEAD
    [Index(nameof(Num), IsUnique = true)]
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int ClientId { get; set; }
        [ForeignKey("ClientId")]
        public virtual Client Client { get; set; }
        
        [Column(TypeName = "VARCHAR(11)"), Required]
=======
    public partial class PhoneNumber
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(11), MinLength(11), Required, Index("IX_PhoneNumbers_Num", IsUnique = true)]
>>>>>>> acb11c1 (ef6 and net472)
        public string Num { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return Utils.ValidatePhone(Num);
        }
    }

<<<<<<< HEAD
    public class Call
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int OutgoingPhoneNumberId { get; set; }
        [ForeignKey("OutgoingPhoneNumberId")]
        public virtual PhoneNumber OutgoingPhoneNumber { get; set; }
        
        [Required]
        public int IncomingPhoneNumberId { get; set; }
        [ForeignKey("IncomingPhoneNumberId")]
=======
    public partial class Call
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("OutgoingPhoneNumber")]
        public int OutgoingPhoneNumberId { get; set; }
        public virtual PhoneNumber OutgoingPhoneNumber { get; set; }

        [ForeignKey("IncomingPhoneNumber")]
        public int IncomingPhoneNumberId { get; set; }
>>>>>>> acb11c1 (ef6 and net472)
        public virtual PhoneNumber IncomingPhoneNumber { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }
        
        [Required]
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return $"{OutgoingPhoneNumber} --> {IncomingPhoneNumber}";
        }
    }

<<<<<<< HEAD
    public class ApplicationContext : DbContext
    {
        public DbSet<Passport> Passports { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public DbSet<Call> Calls { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();  // true, если все создали, false - если что-то не создали (уже есть)
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning))
                .UseMySql("server=127.0.0.1;user=root;password=root;database=cellular;port=3306;", 
                          new MySqlServerVersion(new Version(8, 0, 27))
            );
=======
    //[DbConfigurationType(typeof(MySqlEFConfiguration))
    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<Call> Calls { get; set; }

        public ApplicationContext()
            : base("DbConnection")
        {
            bool create = this.Database.CreateIfNotExists();

            // Почему-то EF не создает уникальные индексы по аннотациям. Прописываем их самостоятельно
            // Создавать индексы нужно только в том случае, если была создана БД, иначе получим ошибку дубликатов
            if (create)
            {
                this.Database.ExecuteSqlCommand(
@"
CREATE UNIQUE INDEX `IX_Clients_PassportId` ON `Clients` (`PassportId`);

CREATE UNIQUE INDEX `IX_Passport_SeriesAndNum` ON `Passports` (`Series`, `Num`);

CREATE UNIQUE INDEX `IX_PhoneNumber_Num` ON `PhoneNumbers` (`Num`);
");
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Client>()
            //    .HasRequired(x => x.Passport)
            //    .WithOptional();
>>>>>>> acb11c1 (ef6 and net472)
        }

        public void Load()
        {
            Passports.Load();
            Clients.Load();
            PhoneNumbers.Load();
            Calls.Load();
        }
<<<<<<< HEAD
=======

        public Client GetClientByPassport(Passport passport)
        {
            return this.Clients.Where(x => x.PassportId == passport.Id).FirstOrDefault();
        }
>>>>>>> acb11c1 (ef6 and net472)
    }
}
