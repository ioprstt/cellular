using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Proxies;

namespace cellular
{
    [Index(nameof(Series), nameof(Num), IsUnique = true)]
    public class Passport
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "VARCHAR(4)"), Required]
        public string Series { get; set; }
        
        [Column(TypeName = "VARCHAR(6)"), Required]
        public string Num { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime DateOfIssue { get; set; }
        
        [Column(TypeName = "VARCHAR(63)"), Required]
        public string IssuingAuthority { get; set; }
        
        [Column(TypeName = "VARCHAR(63)"), Required]
        public string Surname { get; set; }
        
        [Column(TypeName = "VARCHAR(63)"), Required]
        public string Name { get; set; }
        
        [Column(TypeName = "VARCHAR(63)")]
        public string Patronymic { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime DateOfBirth { get; set; }
        
        [Column(TypeName = "VARCHAR(255)"), Required]
        public string Address { get; set; }

        public virtual Client Client { get; set; }

        public override string ToString()
        {
            return $"{Series} {Num}";
        }
    }

    public class Client
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int PassportId { get; set; }
        [ForeignKey("PassportId")]
        public virtual Passport Passport { get; set; }

        public virtual ICollection<PhoneNumber> PhoneNumbers { get; set; }

        public override string ToString()
        {
            UserManager userManager = new UserManager(this);
            return userManager.GetFullName();
        }
    }

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
        public string Num { get; set; }
        
        [Column(TypeName = "DATE"), Required]
        public DateTime RegistrationDate { get; set; }

        public override string ToString()
        {
            return Utils.ValidatePhone(Num);
        }
    }

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
                .UseMySql(
                "server=127.0.0.1;user=root;password=root;database=cellular;port=3306;",
                new MySqlServerVersion(new Version(8, 0, 27))
            );
        }

        public void Load()
        {
            Passports.Load();
            Clients.Load();
            PhoneNumbers.Load();
            Calls.Load();
        }

        public void LoadPassports() { Passports.Load(); }
        public void LoadClients() { Clients.Load(); }
        public void LoadPhoneNumbers() { PhoneNumbers.Load(); }
        public void LoadCalls() { Calls.Load(); }
    }
}
