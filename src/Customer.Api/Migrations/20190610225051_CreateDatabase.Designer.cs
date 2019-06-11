﻿// <auto-generated />
using System;
using Customer.Api.Models.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Customer.Api.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20190610225051_CreateDatabase")]
    partial class CreateDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Customer.Api.Models.Sqlite.CustomerRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Customer.Api.Models.Sqlite.PhoneRecord", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AreaCode");

                    b.Property<long?>("CustomerRecordId");

                    b.Property<int>("Number");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("CustomerRecordId");

                    b.ToTable("PhoneRecord");
                });

            modelBuilder.Entity("Customer.Api.Models.Sqlite.PhoneRecord", b =>
                {
                    b.HasOne("Customer.Api.Models.Sqlite.CustomerRecord")
                        .WithMany("Phones")
                        .HasForeignKey("CustomerRecordId");
                });
#pragma warning restore 612, 618
        }
    }
}