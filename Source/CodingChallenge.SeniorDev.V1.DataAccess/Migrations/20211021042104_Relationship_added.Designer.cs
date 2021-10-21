﻿// <auto-generated />
using System;
using CodingChallenge.SeniorDev.V1.DataAccess.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodingChallenge.SeniorDev.V1.DataAccess.Migrations
{
    [DbContext(typeof(CodingChallengeDataContext))]
    [Migration("20211021042104_Relationship_added")]
    partial class Relationship_added
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Course", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MaximumStudentLimit")
                        .HasColumnType("int");

                    b.Property<string>("Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("TeacherID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TeacherID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Student", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Birthdate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NICNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.StudentCourses", b =>
                {
                    b.Property<Guid>("StudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourseID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentID", "CourseID");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Teacher", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Birthdate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("CourseStudentCourses", b =>
                {
                    b.Property<Guid>("CoursesID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentCoursesStudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentCoursesCourseID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CoursesID", "StudentCoursesStudentID", "StudentCoursesCourseID");

                    b.HasIndex("StudentCoursesStudentID", "StudentCoursesCourseID");

                    b.ToTable("CourseStudentCourses");
                });

            modelBuilder.Entity("StudentStudentCourses", b =>
                {
                    b.Property<Guid>("StudentsID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentCoursesStudentID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("StudentCoursesCourseID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentsID", "StudentCoursesStudentID", "StudentCoursesCourseID");

                    b.HasIndex("StudentCoursesStudentID", "StudentCoursesCourseID");

                    b.ToTable("StudentStudentCourses");
                });

            modelBuilder.Entity("CodingChallenge.SeniorDev.V1.Common.Entity.Course", b =>
                {
                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("CourseStudentCourses", b =>
                {
                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.StudentCourses", null)
                        .WithMany()
                        .HasForeignKey("StudentCoursesStudentID", "StudentCoursesCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentStudentCourses", b =>
                {
                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.Student", null)
                        .WithMany()
                        .HasForeignKey("StudentsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodingChallenge.SeniorDev.V1.Common.Entity.StudentCourses", null)
                        .WithMany()
                        .HasForeignKey("StudentCoursesStudentID", "StudentCoursesCourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
