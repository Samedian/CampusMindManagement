﻿// <auto-generated />
using CampusMindManagementDAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CampusMindManagementDAL.Migrations
{
    [DbContext(typeof(CampusMindDbContext))]
    partial class CampusMindDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("CampusMindManagementDAL.Model.Access", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleAssign")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserName");

                    b.ToTable("Accesses");
                });

            modelBuilder.Entity("CampusMindManagementDAL.Model.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CandidateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeadId")
                        .HasColumnType("int");

                    b.HasKey("CandidateId");

                    b.HasIndex("LeadId");

                    b.ToTable("Candidate");
                });

            modelBuilder.Entity("CampusMindManagementDAL.Model.Lead", b =>
                {
                    b.Property<int>("LeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LeadName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("int");

                    b.HasKey("LeadId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("Lead");
                });

            modelBuilder.Entity("CampusMindManagementDAL.Model.Technology", b =>
                {
                    b.Property<int>("TechonolgyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TechnologyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TechonolgyId");

                    b.ToTable("Technology");
                });

            modelBuilder.Entity("CampusMindManagementDAL.Model.Candidate", b =>
                {
                    b.HasOne("CampusMindManagementDAL.Model.Lead", "Lead")
                        .WithMany()
                        .HasForeignKey("LeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lead");
                });

            modelBuilder.Entity("CampusMindManagementDAL.Model.Lead", b =>
                {
                    b.HasOne("CampusMindManagementDAL.Model.Technology", "Technology")
                        .WithMany()
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Technology");
                });
#pragma warning restore 612, 618
        }
    }
}
