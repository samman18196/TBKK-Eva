﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tbkkData.Models;

namespace tbkkData.Migrations
{
    [DbContext(typeof(tbkkDataContext))]
    partial class tbkkDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("tbkkData.Models.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CompanyName");

                    b.Property<string>("Image");

                    b.Property<string>("Status");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("tbkkData.Models.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DepartmentName");

                    b.Property<string>("Image");

                    b.Property<string>("Status");

                    b.HasKey("DepartmentID");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("tbkkData.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("Age");

                    b.Property<DateTime>("Birthday");

                    b.Property<int?>("CompanyID1");

                    b.Property<DateTime>("Date_of_employment");

                    b.Property<int?>("DepartmentID1");

                    b.Property<string>("Email");

                    b.Property<int?>("EmployeeTypeID1");

                    b.Property<int>("Employee_CompanyID");

                    b.Property<int>("Employee_DepartmentID");

                    b.Property<int>("Employee_EmployeeTypeID");

                    b.Property<int>("Employee_PositionID");

                    b.Property<string>("FirstName");

                    b.Property<string>("Gender");

                    b.Property<string>("Image");

                    b.Property<string>("LastName");

                    b.Property<int?>("PositionID1");

                    b.Property<double>("Salary");

                    b.Property<string>("Status");

                    b.Property<string>("Telephone");

                    b.HasKey("EmployeeID");

                    b.HasIndex("CompanyID1");

                    b.HasIndex("DepartmentID1");

                    b.HasIndex("EmployeeTypeID1");

                    b.HasIndex("PositionID1");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("tbkkData.Models.EmployeeType", b =>
                {
                    b.Property<int>("EmployeeTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeTypeName");

                    b.HasKey("EmployeeTypeID");

                    b.ToTable("EmployeeType");
                });

            modelBuilder.Entity("tbkkData.Models.Evaluation", b =>
                {
                    b.Property<int>("EvaluationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("EvaDate");

                    b.Property<string>("EvaDetail");

                    b.Property<int>("EvaStatus");

                    b.Property<int>("EvaSumPoint");

                    b.Property<int>("Eva_GradeHistoryID");

                    b.Property<int>("EvaluatorID");

                    b.Property<string>("Evatype");

                    b.Property<int?>("GradeHistoryID1");

                    b.HasKey("EvaluationID");

                    b.HasIndex("GradeHistoryID1");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("tbkkData.Models.GradeHistory", b =>
                {
                    b.Property<int>("GradeHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count");

                    b.Property<int>("GrahAllPoint");

                    b.Property<int>("GrahBonusUp");

                    b.Property<int>("GrahRound1");

                    b.Property<int>("GrahRound2");

                    b.Property<int>("GrahRound3");

                    b.Property<int>("GrahSalaryUp");

                    b.Property<string>("GrahYear");

                    b.HasKey("GradeHistoryID");

                    b.ToTable("GradeHistory");
                });

            modelBuilder.Entity("tbkkData.Models.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Login_EmployeeID");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("LoginID");

                    b.HasIndex("Login_EmployeeID");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("tbkkData.Models.Position", b =>
                {
                    b.Property<int>("PositionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PositionName");

                    b.HasKey("PositionID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("tbkkData.Models.Employee", b =>
                {
                    b.HasOne("tbkkData.Models.Company", "CompanyID")
                        .WithMany()
                        .HasForeignKey("CompanyID1");

                    b.HasOne("tbkkData.Models.Department", "DepartmentID")
                        .WithMany()
                        .HasForeignKey("DepartmentID1");

                    b.HasOne("tbkkData.Models.EmployeeType", "EmployeeTypeID")
                        .WithMany()
                        .HasForeignKey("EmployeeTypeID1");

                    b.HasOne("tbkkData.Models.Position", "PositionID")
                        .WithMany()
                        .HasForeignKey("PositionID1");
                });

            modelBuilder.Entity("tbkkData.Models.Evaluation", b =>
                {
                    b.HasOne("tbkkData.Models.GradeHistory", "GradeHistoryID")
                        .WithMany()
                        .HasForeignKey("GradeHistoryID1");
                });

            modelBuilder.Entity("tbkkData.Models.Login", b =>
                {
                    b.HasOne("tbkkData.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Login_EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
