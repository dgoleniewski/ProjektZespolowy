using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProjektZespolowy.Models
{
    public partial class ProjektZespolowyContext : DbContext
    {
        public ProjektZespolowyContext()
        {
        }

        public ProjektZespolowyContext(DbContextOptions<ProjektZespolowyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EntrepreneursWithProhibition> EntrepreneursWithProhibition { get; set; }
        public virtual DbSet<EntrepreneursWithProceedings> EntrepreneursWithProceedings { get; set; }
        public virtual DbSet<EntrepreneursDeleted> EntrepreneursDeleted { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=GOLENIEWSKI;Initial Catalog=ProjektZespolowy;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_CI_AS");

            modelBuilder.Entity<EntrepreneursWithProhibition>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wykaz_przedsiebiorcow_dzialajacych_bez_wpisu_do_rejestru_i_objetych_3-letnim_zakazem_wykonywania_dzialalnosci");

                entity.Property(e => e.DataDecyzji)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Data decyzji\"");

                entity.Property(e => e.DataDoreczenia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data doreczenia");

                entity.Property(e => e.DataObowiazywaniaZakazuDo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data obowiazywania zakazu do");

                entity.Property(e => e.DataObowiazywaniaZakazuOd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data obowiazywania zakazu od");

                entity.Property(e => e.FirmaLubNazwa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Firma lub nazwa");

                entity.Property(e => e.FormaPrawna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("\"Forma prawna\"");

                entity.Property(e => e.KodPocztowy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kod pocztowy");

                entity.Property(e => e.Lp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LP");

                entity.Property(e => e.Miejscowosc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.NrDomuLokalu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nr domu  lokalu");

                entity.Property(e => e.NumerKatalogowy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Numer katalogowy");

                entity.Property(e => e.StatusKsiegi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Status ksiegi");

                entity.Property(e => e.Ulica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ulica ");

                entity.Property(e => e.Wojewodztwo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntrepreneursWithProceedings>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wykaz_przedsiebiorcow_wobec_ktorych_wszczeto_postepowanie_w_sprawie_wykreslenia_z_rejestru");

                entity.Property(e => e.DataDoreczenia)
                    .HasColumnType("datetime")
                    .HasColumnName("Data doreczenia");

                entity.Property(e => e.DataZdarzenia)
                    .HasColumnType("datetime")
                    .HasColumnName("Data zdarzenia");

                entity.Property(e => e.FirmaLubNazwa)
                    .HasMaxLength(88)
                    .IsUnicode(false)
                    .HasColumnName("Firma lub nazwa");

                entity.Property(e => e.FormaPrawna)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("Forma prawna");

                entity.Property(e => e.KodPocztowy)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Kod pocztowy");

                entity.Property(e => e.Lp)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("LP");

                entity.Property(e => e.Miejscowosc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nip)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("NIP");

                entity.Property(e => e.NrDomuLokalu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nr domu  lokalu");

                entity.Property(e => e.NumerEwidencyjny)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("Numer ewidencyjny");

                entity.Property(e => e.NumerWpisuDoRejestru)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Numer wpisu do rejestru");

                entity.Property(e => e.StatusKsiegi)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("Status ksiegi");

                entity.Property(e => e.Ulica)
                    .HasMaxLength(26)
                    .IsUnicode(false)
                    .HasColumnName("Ulica ");

                entity.Property(e => e.Wojewodztwo)
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntrepreneursDeleted>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Wykaz_przedsiebiorcow_wykreslonych_z_rejestru_i_objetych_zakazem_wykonywania_dzialalnosci");

                entity.Property(e => e.DataDecyzji)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data decyzji");

                entity.Property(e => e.DataDoreczenia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data doreczenia");

                entity.Property(e => e.DataObowiazywaniaZakazuDo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data obowiazywania zakazu do");

                entity.Property(e => e.DataObowiazywaniaZakazuOd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data obowiazywania zakazu od");

                entity.Property(e => e.DataWpisuDoEwidencji)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Data wpisu do Ewidencji");

                entity.Property(e => e.FirmaLubNazwa)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Firma lub nazwa");

                entity.Property(e => e.FormaPrawna)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Forma prawna");

                entity.Property(e => e.KodPocztowy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Kod pocztowy");

                entity.Property(e => e.Lp)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LP");

                entity.Property(e => e.Miejscowosc)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nip)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NIP");

                entity.Property(e => e.NrDomuLokalu)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nr domu  lokalu");

                entity.Property(e => e.NrWpisuDoRejestru)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nr wpisu do rejestru");

                entity.Property(e => e.NumerEwidencyjny)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Numer ewidencyjny");

                entity.Property(e => e.RodzajZdarzenia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Rodzaj zdarzenia");

                entity.Property(e => e.StatusKsięgi)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Status księgi");

                entity.Property(e => e.Ulica)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ulica ");

                entity.Property(e => e.Wojewodztwo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
