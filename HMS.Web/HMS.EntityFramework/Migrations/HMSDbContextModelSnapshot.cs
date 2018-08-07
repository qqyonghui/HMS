﻿// <auto-generated />
using System;
using HMS.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HMS.EntityFramework.Migrations
{
    [DbContext(typeof(HMSDbContext))]
    partial class HMSDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HMS.EntityFramework.Permissions", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreateBy");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Discriminator")
                        .HasMaxLength(100);

                    b.Property<bool>("IsDelete");

                    b.Property<Guid>("LastModify");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("TenantId");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("HMS.EntityFramework.SysCatagory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreateBy");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<Guid>("LastModify");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<string>("Name")
                        .HasMaxLength(100);

                    b.Property<Guid>("ParentId");

                    b.Property<Guid>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("SysCatagories");
                });

            modelBuilder.Entity("HMS.EntityFramework.SysRoles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreateBy");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<Guid>("LastModify");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<Guid>("TenantId");

                    b.HasKey("Id");

                    b.ToTable("SysRoles");
                });

            modelBuilder.Entity("HMS.EntityFramework.SysUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreateBy");

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Gender");

                    b.Property<bool>("IsDelete");

                    b.Property<Guid>("LastModify");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<string>("LoginName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber");

                    b.Property<Guid>("RoleId");

                    b.Property<Guid>("TenantId");

                    b.Property<string>("UserName")
                        .HasMaxLength(100);

                    b.Property<DateTime>("lastLoginTime");

                    b.HasKey("Id");

                    b.ToTable("SysUser");
                });

            modelBuilder.Entity("HMS.EntityFramework.Tenants", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CreateBy");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsDelete");

                    b.Property<Guid>("LastModify");

                    b.Property<DateTime>("LastModifyTime");

                    b.Property<string>("LoginName")
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tenants");
                });
#pragma warning restore 612, 618
        }
    }
}
