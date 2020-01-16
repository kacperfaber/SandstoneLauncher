﻿// <auto-generated />
using System;
using KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KacpiiToZiomal.SandstoneLauncher.Web.Rest.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20200116113551_UnauthorizedMigration2")]
    partial class UnauthorizedMigration2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models.Developer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("CredentialsId")
                        .HasColumnName("credentials_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("developers");
                });

            modelBuilder.Entity("KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models.DeveloperCredentials", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .HasColumnName("client_id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientSecret")
                        .HasColumnName("client_secret")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeveloperId")
                        .HasColumnName("developer_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("developer_credentials");
                });

            modelBuilder.Entity("KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models.DeveloperToken", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Archived")
                        .HasColumnName("archived")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Authorized")
                        .HasColumnName("authorized")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("AuthorizedAt")
                        .HasColumnName("authorized_at")
                        .HasColumnType("TEXT");

                    b.Property<string>("DeveloperId")
                        .HasColumnName("developer_id")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ExpiredAt")
                        .HasColumnName("expired_at")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("GeneratedAt")
                        .HasColumnName("generated_at")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnName("last_updated_at")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Unauthorized")
                        .HasColumnName("unauthorized")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("UnauthorizedAt")
                        .HasColumnName("unauthorized_at")
                        .HasColumnType("TEXT");

                    b.Property<int>("UpdatedTimes")
                        .HasColumnName("updated_times")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("developer_tokens");
                });

            modelBuilder.Entity("KacpiiToZiomal.SandstoneLauncher.Web.Rest.Commons.Models.UserCredentials", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnName("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnName("password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("user_credentials");
                });
#pragma warning restore 612, 618
        }
    }
}
