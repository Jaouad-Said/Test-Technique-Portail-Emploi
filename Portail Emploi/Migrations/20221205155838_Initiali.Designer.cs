// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portail_Emploi.Data;

#nullable disable

namespace PortailEmploi.Migrations
{
    [DbContext(typeof(DbContextCandidatures))]
    [Migration("20221205155838_Initiali")]
    partial class Initiali
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Portail_Emploi.Models.Candidat", b =>
                {
                    b.Property<int>("ID_Candidat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Candidat"));

                    b.Property<string>("D_Employeur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("N_Etude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("N_Experience")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Candidat");

                    b.ToTable("Candidats");
                });

            modelBuilder.Entity("Portail_Emploi.Models.Resume", b =>
                {
                    b.Property<int>("ID_Resume")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Resume"));

                    b.Property<string>("CVurl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_Candidat")
                        .HasColumnType("int");

                    b.HasKey("ID_Resume");

                    b.HasIndex("ID_Candidat");

                    b.ToTable("Resumes");
                });

            modelBuilder.Entity("Portail_Emploi.Models.Resume", b =>
                {
                    b.HasOne("Portail_Emploi.Models.Candidat", "Candidats")
                        .WithMany()
                        .HasForeignKey("ID_Candidat")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidats");
                });
#pragma warning restore 612, 618
        }
    }
}
