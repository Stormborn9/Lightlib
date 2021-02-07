﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace LightLib.Data.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("LightLib.Data.Models.Assets.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int?>("AvailabilityStatusId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Cost")
                        .HasColumnType("numeric");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int?>("LocationId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AvailabilityStatusId");

                    b.HasIndex("LocationId");

                    b.ToTable("assets");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.AudioBook", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ASIN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeweyIndex")
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("LengthMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("audio_books");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.AudioCd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("DeweyIndex")
                        .HasColumnType("text");

                    b.Property<string>("Genre")
                        .HasColumnType("text");

                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("audio_cds");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DeweyIndex")
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("PublicationYear")
                        .HasColumnType("integer");

                    b.Property<string>("Publisher")
                        .HasColumnType("text");

                    b.Property<string>("Summary")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("books");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.DVD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("AlternativeTitle")
                        .HasColumnType("text");

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Edition")
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<int>("LengthMinutes")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UPC")
                        .HasColumnType("text");

                    b.Property<int>("Year")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("dvds");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Periodical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DateOfPublication")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ISSN")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<string>("Publisher")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UniformTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.ToTable("periodicals");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Tags.AssetTag", b =>
                {
                    b.Property<Guid>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<int>("TagId")
                        .HasColumnType("integer");

                    b.HasKey("AssetId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("asset_tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Tags.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("LightLib.Data.Models.AvailabilityStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("availability_statuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The item is lost.",
                            Name = "LOST"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The item is in good condition.",
                            Name = "GOOD_CONDITION"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The item is in unknown whereabouts and condition.",
                            Name = "UNKNOWN_CONDITION"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The item has been destroyed.",
                            Name = "DESTROYED"
                        });
                });

            modelBuilder.Entity("LightLib.Data.Models.BranchHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("BranchId")
                        .HasColumnType("integer");

                    b.Property<int>("CloseTime")
                        .HasColumnType("integer");

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("integer");

                    b.Property<int>("OpenTime")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("branch_hours");
                });

            modelBuilder.Entity("LightLib.Data.Models.Checkout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid?>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Since")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Until")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("checkouts");
                });

            modelBuilder.Entity("LightLib.Data.Models.CheckoutHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid?>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CheckedIn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CheckedOut")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("checkout_histories");
                });

            modelBuilder.Entity("LightLib.Data.Models.Hold", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<Guid?>("AssetId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("HoldPlaced")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("holds");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryBranch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OpenDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("library_branches");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<decimal>("CurrentFees")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("Issued")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("library_cards");
                });

            modelBuilder.Entity("LightLib.Data.Models.Patron", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("HomeLibraryBranchId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("LibraryCardId")
                        .HasColumnType("integer");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("HomeLibraryBranchId");

                    b.HasIndex("LibraryCardId");

                    b.ToTable("patrons");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Asset", b =>
                {
                    b.HasOne("LightLib.Data.Models.AvailabilityStatus", "AvailabilityStatus")
                        .WithMany()
                        .HasForeignKey("AvailabilityStatusId");

                    b.HasOne("LightLib.Data.Models.LibraryBranch", "Location")
                        .WithMany("LibraryAssets")
                        .HasForeignKey("LocationId");

                    b.Navigation("AvailabilityStatus");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.AudioBook", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.AudioCd", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Book", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.DVD", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Periodical", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Tags.AssetTag", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany("AssetTags")
                        .HasForeignKey("AssetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LightLib.Data.Models.Assets.Tags.Tag", "Tag")
                        .WithMany("AssetTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Asset");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("LightLib.Data.Models.BranchHours", b =>
                {
                    b.HasOne("LightLib.Data.Models.LibraryBranch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("LightLib.Data.Models.Checkout", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany("Checkouts")
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("Asset");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.CheckoutHistory", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("Asset");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.Hold", b =>
                {
                    b.HasOne("LightLib.Data.Models.Assets.Asset", "Asset")
                        .WithMany()
                        .HasForeignKey("AssetId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("Asset");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.Patron", b =>
                {
                    b.HasOne("LightLib.Data.Models.LibraryBranch", "HomeLibraryBranch")
                        .WithMany("Patrons")
                        .HasForeignKey("HomeLibraryBranchId");

                    b.HasOne("LightLib.Data.Models.LibraryCard", "LibraryCard")
                        .WithMany()
                        .HasForeignKey("LibraryCardId");

                    b.Navigation("HomeLibraryBranch");

                    b.Navigation("LibraryCard");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Asset", b =>
                {
                    b.Navigation("AssetTags");
                });

            modelBuilder.Entity("LightLib.Data.Models.Assets.Tags.Tag", b =>
                {
                    b.Navigation("AssetTags");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryBranch", b =>
                {
                    b.Navigation("LibraryAssets");

                    b.Navigation("Patrons");
                });

            modelBuilder.Entity("LightLib.Data.Models.LibraryCard", b =>
                {
                    b.Navigation("Checkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
