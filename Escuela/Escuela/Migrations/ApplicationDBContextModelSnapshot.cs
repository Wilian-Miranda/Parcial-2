// <auto-generated />
using System;
using Escuela.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Escuela.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Escuela.Dominio.Tbl_Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("credits")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("courseId");

                    b.ToTable("Tbl_Course");
                });

            modelBuilder.Entity("Escuela.Dominio.Tbl_Enrollment", b =>
                {
                    b.Property<int>("enrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<int?>("grade")
                        .HasColumnType("int");

                    b.Property<int>("studentId")
                        .HasColumnType("int");

                    b.HasKey("enrollmentId");

                    b.HasIndex("courseId");

                    b.HasIndex("studentId");

                    b.ToTable("Tbl_Enrollment");
                });

            modelBuilder.Entity("Escuela.Dominio.Tbl_Student", b =>
                {
                    b.Property<int>("studendId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("enrollmentsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstMidName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studendId");

                    b.ToTable("Tbl_Student");
                });

            modelBuilder.Entity("Escuela.Dominio.Tbl_Enrollment", b =>
                {
                    b.HasOne("Escuela.Dominio.Tbl_Course", "Course")
                        .WithMany("Course")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Escuela.Dominio.Tbl_Student", "Student")
                        .WithMany("Student")
                        .HasForeignKey("studentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Escuela.Dominio.Tbl_Course", b =>
                {
                    b.Navigation("Course");
                });

            modelBuilder.Entity("Escuela.Dominio.Tbl_Student", b =>
                {
                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
