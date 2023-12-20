﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TrailApp.Model;

#nullable disable

namespace TrailApp.Migrations
{
    [DbContext(typeof(UserDbContext))]
    [Migration("20231220160827_forthDb")]
    partial class forthDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProfileService.Model.Activity", b =>
                {
                    b.Property<string>("activityID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("activityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("activityTimePreference")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("units")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("activityID");

                    b.ToTable("Activity", "CW2");
                });

            modelBuilder.Entity("ProfileService.Model.Profile", b =>
                {
                    b.Property<string>("profileID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("creationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("profileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("profileID");

                    b.ToTable("Profile", "CW2");
                });

            modelBuilder.Entity("ProfileService.Model.Trail", b =>
                {
                    b.Property<string>("trailID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("creationDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("trailID");

                    b.ToTable("Trail", "CW2");
                });

            modelBuilder.Entity("TrailApp.Model.User", b =>
                {
                    b.Property<string>("userID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("archivedAccess")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userID");

                    b.ToTable("Users", "CW2");
                });
#pragma warning restore 612, 618
        }
    }
}
