using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace cellular
{
    public partial class Passport
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR"), MaxLength(4), MinLength(4), Required, Index("IX_Pasports_SeriesAndNum", IsUnique = true)]
        public string Series { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(6), MinLength(6), Required, Index("IX_Pasports_SeriesAndNum", IsUnique = true)]
        public string Num { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime DateOfIssue { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(63), Required]
        public string IssuingAuthority { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(11), Required]
        public string Surname { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(63), Required]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(11)]
        public string Patronymic { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime DateOfBirth { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(255), Required]
        public string Address { get; set; }

        public override string ToString()
        {
            return $"{Series} {Num}";
        }

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
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Passport")]
        public int PassportId { get; set; }
        public virtual Passport Passport { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public override string ToString()
        {
            UserManager userManager = new UserManager(this.Id);
            return userManager.GetFullName();
        }
    }

    public partial class Tariff
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR"), MaxLength(63), Required, Index("IX_Tariffs_Name", IsUnique = true)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public partial class PhoneNumber
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        
        [Column(TypeName = "VARCHAR"), MaxLength(11), MinLength(11), Required, Index("IX_PhoneNumbers_Num", IsUnique = true)]
        public string Num { get; set; }

        [ForeignKey("Tariff")]
        public int TariffId { get; set; }
        public virtual Tariff Tariff { get; set; }

        [Column(TypeName = "DATE"), Required]
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return Utils.ValidatePhone(Num);
        }
    }

    public partial class Call
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("OutgoingPhoneNumber")]
        public int OutgoingPhoneNumberId { get; set; }
        public virtual PhoneNumber OutgoingPhoneNumber { get; set; }

        [ForeignKey("IncomingPhoneNumber")]
        public int IncomingPhoneNumberId { get; set; }
        public virtual PhoneNumber IncomingPhoneNumber { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }
        
        [Required]
        public DateTime EndTime { get; set; }

        public override string ToString()
        {
            return $"{OutgoingPhoneNumber} --> {IncomingPhoneNumber}";
        }

        public TimeSpan GetDuration()
        {
            return this.EndTime.Subtract(this.StartTime);
        }

        public int GetDurationAsMinutes()
        {
            return this.GetDuration().Minutes;
        }
    }

    public class ApplicationContext : DbContext
    {
        public virtual DbSet<Passport> Passports { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Tariff> Tariffs { get; set; }
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

CREATE UNIQUE INDEX `IX_Tariffs_Name` ON `Tariffs` (`Name`);

CREATE UNIQUE INDEX `IX_PhoneNumber_Num` ON `PhoneNumbers` (`Num`);
");
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Client>()
            //    .HasRequired(x => x.Passport)
            //    .WithOptional();
        }

        public void Load()
        {
            Passports.Load();
            Clients.Load();
            PhoneNumbers.Load();
            Calls.Load();
        }

        public Client GetClientByPassport(Passport passport)
        {
            return this.Clients.Where(x => x.PassportId == passport.Id).FirstOrDefault();
        }
    }
}
