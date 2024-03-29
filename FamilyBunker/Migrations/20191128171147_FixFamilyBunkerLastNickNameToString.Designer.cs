﻿// <auto-generated />
using System;
using FamilyBunker;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FamilyBunker.Migrations
{
    [DbContext(typeof(FamilyBunkerContext))]
    [Migration("20191128171147_FixFamilyBunkerLastNickNameToString")]
    partial class FixFamilyBunkerLastNickNameToString
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FamilyBunker.Entities.Calendar", b =>
                {
                    b.Property<int>("calendarId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date");

                    b.Property<DateTime>("endTime");

                    b.Property<string>("eventName")
                        .HasMaxLength(100);

                    b.Property<int>("memberId");

                    b.Property<DateTime>("startTime");

                    b.HasKey("calendarId");

                    b.HasIndex("memberId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("FamilyBunker.Entities.groceryList", b =>
                {
                    b.Property<int>("groceryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("itemName")
                        .HasMaxLength(200);

                    b.Property<int>("memberId");

                    b.Property<int>("quantity");

                    b.HasKey("groceryId");

                    b.HasIndex("memberId");

                    b.ToTable("groceryLists");
                });

            modelBuilder.Entity("FamilyBunker.Entities.Member", b =>
                {
                    b.Property<int>("memberId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("firstName")
                        .HasMaxLength(50);

                    b.Property<string>("lastName")
                        .HasMaxLength(50);

                    b.Property<string>("nickName")
                        .HasMaxLength(50);

                    b.HasKey("memberId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("FamilyBunker.Entities.Calendar", b =>
                {
                    b.HasOne("FamilyBunker.Entities.Member")
                        .WithMany("Calendars")
                        .HasForeignKey("memberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FamilyBunker.Entities.groceryList", b =>
                {
                    b.HasOne("FamilyBunker.Entities.Member")
                        .WithMany("groceryLists")
                        .HasForeignKey("memberId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
