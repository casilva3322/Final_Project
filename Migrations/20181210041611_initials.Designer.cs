﻿// <auto-generated />
using Final_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Final_Project.Migrations
{
    [DbContext(typeof(BffTekWebContext))]
    [Migration("20181210041611_initials")]
    partial class initials
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Final_Project.Models.Particpant", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("FName");

                    b.Property<string>("LName");

                    b.Property<string>("PhoneNumb");

                    b.HasKey("ID");

                    b.ToTable("Particpant");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Particpant");
                });

            modelBuilder.Entity("Final_Project.Models.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProjDescript");

                    b.Property<string>("ProjName");

                    b.HasKey("ID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("Final_Project.Models.ProjInfo", b =>
                {
                    b.Property<int>("ProjID");

                    b.Property<string>("ParticipantID");

                    b.HasKey("ProjID", "ParticipantID");

                    b.HasIndex("ParticipantID");

                    b.ToTable("ProjInfo");
                });

            modelBuilder.Entity("Final_Project.Models.Client", b =>
                {
                    b.HasBaseType("Final_Project.Models.Particpant");

                    b.Property<string>("CoName");

                    b.ToTable("Client");

                    b.HasDiscriminator().HasValue("Client");
                });

            modelBuilder.Entity("Final_Project.Models.Member", b =>
                {
                    b.HasBaseType("Final_Project.Models.Particpant");

                    b.Property<string>("Mjr");

                    b.ToTable("Member");

                    b.HasDiscriminator().HasValue("Member");
                });

            modelBuilder.Entity("Final_Project.Models.ProjInfo", b =>
                {
                    b.HasOne("Final_Project.Models.Particpant", "Participant")
                        .WithMany("Projects")
                        .HasForeignKey("ParticipantID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Final_Project.Models.Project", "Project")
                        .WithMany("Partcipants")
                        .HasForeignKey("ProjID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
