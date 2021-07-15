﻿// <auto-generated />
using AuditManagementPortal.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AuditManagementPortal.Migrations
{
    [DbContext(typeof(AuditManagementContext))]
    [Migration("20210504121520_initialMigrations")]
    partial class initialMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AuditManagementPortal.Models.AuditResponse", b =>
                {
                    b.Property<int>("AuditId")
                        .HasColumnType("int");

                    b.Property<string>("ProjectExecutionStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RemedialActionDuration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuditId");

                    b.ToTable("AuditResponses");
                });
#pragma warning restore 612, 618
        }
    }
}
