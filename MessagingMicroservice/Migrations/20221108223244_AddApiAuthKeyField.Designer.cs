﻿// <auto-generated />
using MessagingMicroservice.Database.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MessagingMicroservice.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20221108223244_AddApiAuthKeyField")]
    partial class AddApiAuthKeyField
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BreganMicroservice.Database.Models.Config", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RowId"));

                    b.Property<string>("ApiAuthKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("EmailApiKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("HFConnectionString")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProjectMonitorKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SendGridApiKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TelegramBotApiKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RowId");

                    b.ToTable("Config");

                    b.HasData(
                        new
                        {
                            RowId = 1,
                            ApiAuthKey = "",
                            EmailApiKey = "",
                            HFConnectionString = "",
                            ProjectMonitorKey = "",
                            SendGridApiKey = "",
                            TelegramBotApiKey = ""
                        });
                });

            modelBuilder.Entity("BreganMicroservice.Database.Models.EmailSendRequests", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RowId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("EmailProcessingStatus")
                        .HasColumnType("integer");

                    b.Property<int>("FailedProcessingAttempts")
                        .HasColumnType("integer");

                    b.Property<string>("FromEmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FromEmailAddressName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TemplateId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ToEmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ToEmailAddressName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("RowId");

                    b.ToTable("EmailSendRequest");
                });

            modelBuilder.Entity("BreganMicroservice.Database.Models.TextSendRequests", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RowId"));

                    b.Property<int>("ChatId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FailedProcessingAttempts")
                        .HasColumnType("integer");

                    b.Property<int>("MessageProcessingStatus")
                        .HasColumnType("integer");

                    b.HasKey("RowId");

                    b.ToTable("TextSendRequests");
                });
#pragma warning restore 612, 618
        }
    }
}