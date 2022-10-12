﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using workshop.Model;

#nullable disable

namespace workshop.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("workshop.Model.Entities.UserEntity", b =>
                {
                    b.Property<int>("UserEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserEntityId"), 1L, 1);

                    b.Property<string>("Access_token")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminApproved")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminApprovedIP")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminDeactivate")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminDeactivateIP")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminNotApproved")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminNotApprovedIP")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminReactivate")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("AdminReactivateIP")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ApprovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CommetNotApproved")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("ConfirmEmailTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConfirmKYCTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConfirmPersonalIDTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConfirmTelTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeactivateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("EmailOTP")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("EmailOTPRef")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Expires_in")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("FullName")
                        .HasColumnType("varchar(250)");

                    b.Property<bool>("IsConfirmEmail")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConfirmKYC")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConfirmPersonalID")
                        .HasColumnType("bit");

                    b.Property<bool>("IsConfirmTel")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeactivate")
                        .HasColumnType("bit");

                    b.Property<bool>("IsReactivate")
                        .HasColumnType("bit");

                    b.Property<string>("LineId")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("NotApprovedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Organization_Code")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Organization_Name_TH")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PersonalID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReactivateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Refresh_token")
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("SMSExpire")
                        .HasColumnType("datetime2");

                    b.Property<string>("SMSOTP")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("SMSOTPRef")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Tel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserCode")
                        .HasColumnType("varchar(50)");

                    b.Property<int>("UserStage")
                        .HasColumnType("int");

                    b.Property<int>("UserType")
                        .HasColumnType("int");

                    b.Property<string>("dbPathFace")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("dbPathKYC")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("dbPathPersonalID")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("faceData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fileNameFace")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fileNameKYC")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fileNamePersonalID")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fullPathFace")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fullPathKYC")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("fullPathPersonalID")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("testcol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserEntityId");

                    b.ToTable("UserEntitys");
                });
#pragma warning restore 612, 618
        }
    }
}
