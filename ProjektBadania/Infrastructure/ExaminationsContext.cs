using Microsoft.EntityFrameworkCore;
using ProjektBadania.Domain.Entities;

namespace ProjektBadania.Infrastructure
{
    public class ExaminationsContext(DbContextOptions<ExaminationsContext> options)
        : DbContext(options)
    {
        public DbSet<Examination> Examinations { get; set; }
        public DbSet<ExaminationType> ExaminationTypes { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Examination>(builder =>
            {
                builder.HasKey(x => x.Id);

                builder.HasOne(e => e.Patient)
                    .WithMany(p => p.Examinations)
                    .HasForeignKey(x => x.PatientId);

                builder.HasOne(x => x.ExaminationType)
                    .WithMany(a => a.Examinations)
                    .HasForeignKey(x => x.ExaminationTypeId);
            });

            modelBuilder.Entity<Patient>(builder =>
            {
                builder.HasKey(x => x.Id);

                builder.Property(x => x.Name)
                    .IsRequired();

                builder.Property(x => x.Pesel)
                    .IsRequired()
                    .HasMaxLength(11);
            });

            SeedData(modelBuilder);
        }

    private void SeedData(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<ExaminationType>(builder =>
        {
            builder.HasData(
                new ExaminationType { Id = 1, Name = "Pobieranie krwi" },
                new ExaminationType { Id = 2, Name = "Badania kontrolne" }
                );
        });

        modelBuilder.Entity<Patient>(builder =>
        {
            builder.HasData(
                new Patient
                {
                    Id = 1,
                    Name = "Jan Kowalski",
                    DateOfBirth = new DateOnly(1980, 5, 12),
                    Pesel = "80051212345",
                    Country = "Polska",
                    City = "Warszawa",
                    PostalCode = "00-001",
                    Street = "Marszałkowska",
                    HouseNumber = "10"
                },
                new Patient
                {
                    Id = 2,
                    Name = "Anna Nowak",
                    DateOfBirth = new DateOnly(1990, 7, 25),
                    Pesel = "90072567890",
                    Country = "Polska",
                    City = "Kraków",
                    PostalCode = "30-001",
                    Street = "Floriańska",
                    HouseNumber = "5"
                },
                new Patient
                {
                    Id = 3,
                    Name = "Piotr Wiśniewski",
                    DateOfBirth = new DateOnly(1975, 3, 14),
                    Pesel = "75031423456",
                    Country = "Polska",
                    City = "Gdańsk",
                    PostalCode = "80-001",
                    Street = "Długa",
                    HouseNumber = "20"
                },
                new Patient
                {
                    Id = 4,
                    Name = "Katarzyna Zielińska",
                    DateOfBirth = new DateOnly(1985, 11, 22),
                    Pesel = "85112234567",
                    Country = "Polska",
                    City = "Wrocław",
                    PostalCode = "50-001",
                    Street = "Świdnicka",
                    HouseNumber = "15"
                },
                new Patient
                {
                    Id = 5,
                    Name = "Marek Lewandowski",
                    DateOfBirth = new DateOnly(1995, 8, 30),
                    Pesel = "95083045678",
                    Country = "Polska",
                    City = "Poznań",
                    PostalCode = "60-001",
                    Street = "Święty Marcin",
                    HouseNumber = "3"
                }
            );
        });

        modelBuilder.Entity<Examination>(builder =>
        {

            builder.HasData(
                new Examination
                {
                    Id = 1,
                    Name = "Badanie Krwi",
                    Description = "Podstawowe badanie krwi.",
                    DateOfExamination = new DateTime(2023, 1, 15),
                    PatientId = 1,
                    ExaminationTypeId = 1
                },
                new Examination
                {
                    Id = 2,
                    Name = "USG Jamy Brzusznej",
                    Description = "Ultrasonografia jamy brzusznej.",
                    DateOfExamination = new DateTime(2023, 2, 20),
                    PatientId = 2,
                    ExaminationTypeId = 1
                },
                new Examination
                {
                    Id = 3,
                    Name = "RTG Klp",
                    Description = "Rentgen klatki piersiowej.",
                    DateOfExamination = new DateTime(2023, 3, 5),
                    PatientId = 3,
                    ExaminationTypeId = 1
                },
                new Examination
                {
                    Id = 4,
                    Name = "EKG",
                    Description = "Elektrokardiogram.",
                    DateOfExamination = new DateTime(2023, 4, 10),
                    PatientId = 4,
                    ExaminationTypeId = 2
                },
                new Examination
                {
                    Id = 5,
                    Name = "MRI Głowy",
                    Description = "Rezonans magnetyczny głowy.",
                    DateOfExamination = new DateTime(2023, 5, 25),
                    PatientId = 5,
                    ExaminationTypeId = 2
                }
            );
        });
    }
}
}
        

