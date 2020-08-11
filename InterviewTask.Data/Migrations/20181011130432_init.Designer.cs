﻿// <auto-generated />
using System;
using InterviewTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InterviewTask.Data.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20181011130432_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InterviewTask.Data.Entities.Avatar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Bytes")
                        .IsRequired();

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime>("UpdatedDate");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("Avatars");
                });

            modelBuilder.Entity("InterviewTask.Data.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(4)
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new { Id = 1, Code = "DJI", Name = "Djibouti" },
                        new { Id = 2, Code = "ZAF", Name = "South Africa" },
                        new { Id = 3, Code = "ETH", Name = "Ethiopia" },
                        new { Id = 4, Code = "ARE", Name = "United Arab Emirates" },
                        new { Id = 5, Code = "BHR", Name = "Bahrain" },
                        new { Id = 6, Code = "DZA", Name = "Algeria" },
                        new { Id = 7, Code = "EGY", Name = "Egypt" },
                        new { Id = 8, Code = "IRQ", Name = "Iraq" },
                        new { Id = 9, Code = "JOR", Name = "Jordan" },
                        new { Id = 10, Code = "KWT", Name = "Kuwait" },
                        new { Id = 11, Code = "LBN", Name = "Lebanon" },
                        new { Id = 12, Code = "LBY", Name = "Libya" },
                        new { Id = 13, Code = "MAR", Name = "Morocco" },
                        new { Id = 14, Code = "OMN", Name = "Oman" },
                        new { Id = 15, Code = "QAT", Name = "Qatar" },
                        new { Id = 16, Code = "SAU", Name = "Saudi Arabia" },
                        new { Id = 17, Code = "SYR", Name = "Syria" },
                        new { Id = 18, Code = "TUN", Name = "Tunisia" },
                        new { Id = 19, Code = "YEM", Name = "Yemen" },
                        new { Id = 20, Code = "CHL", Name = "Chile" },
                        new { Id = 21, Code = "IND", Name = "India" },
                        new { Id = 22, Code = "AZE", Name = "Azerbaijan" },
                        new { Id = 23, Code = "RUS", Name = "Russia" },
                        new { Id = 24, Code = "BLR", Name = "Belarus" },
                        new { Id = 25, Code = "BGR", Name = "Bulgaria" },
                        new { Id = 26, Code = "NGA", Name = "Nigeria" },
                        new { Id = 27, Code = "BGD", Name = "Bangladesh" },
                        new { Id = 28, Code = "CHN", Name = "China" },
                        new { Id = 29, Code = "FRA", Name = "France" },
                        new { Id = 30, Code = "BIH", Name = "Bosnia and Herzegovina" },
                        new { Id = 31, Code = "ESP", Name = "Spain" },
                        new { Id = 32, Code = "USA", Name = "United States" },
                        new { Id = 33, Code = "CZE", Name = "Czechia" },
                        new { Id = 34, Code = "GBR", Name = "United Kingdom" },
                        new { Id = 35, Code = "DNK", Name = "Denmark" },
                        new { Id = 36, Code = "AUT", Name = "Austria" },
                        new { Id = 37, Code = "CHE", Name = "Switzerland" },
                        new { Id = 38, Code = "DEU", Name = "Germany" },
                        new { Id = 39, Code = "LIE", Name = "Liechtenstein" },
                        new { Id = 40, Code = "LUX", Name = "Luxembourg" },
                        new { Id = 41, Code = "MDV", Name = "Maldives" },
                        new { Id = 42, Code = "BTN", Name = "Bhutan" },
                        new { Id = 43, Code = "GRC", Name = "Greece" },
                        new { Id = 44, Code = "029", Name = "Caribbean" },
                        new { Id = 45, Code = "AUS", Name = "Australia" },
                        new { Id = 46, Code = "BLZ", Name = "Belize" },
                        new { Id = 47, Code = "CAN", Name = "Canada" },
                        new { Id = 48, Code = "HKG", Name = "Hong Kong SAR" },
                        new { Id = 49, Code = "IDN", Name = "Indonesia" },
                        new { Id = 50, Code = "IRL", Name = "Ireland" },
                        new { Id = 51, Code = "JAM", Name = "Jamaica" },
                        new { Id = 52, Code = "MYS", Name = "Malaysia" },
                        new { Id = 53, Code = "NZL", Name = "New Zealand" },
                        new { Id = 54, Code = "PHL", Name = "Philippines" },
                        new { Id = 55, Code = "SGP", Name = "Singapore" },
                        new { Id = 56, Code = "TTO", Name = "Trinidad and Tobago" },
                        new { Id = 57, Code = "ZWE", Name = "Zimbabwe" },
                        new { Id = 58, Code = "419", Name = "Latin America" },
                        new { Id = 59, Code = "ARG", Name = "Argentina" },
                        new { Id = 60, Code = "BOL", Name = "Bolivia" },
                        new { Id = 61, Code = "COL", Name = "Colombia" },
                        new { Id = 62, Code = "CRI", Name = "Costa Rica" },
                        new { Id = 63, Code = "CUB", Name = "Cuba" },
                        new { Id = 64, Code = "DOM", Name = "Dominican Republic" },
                        new { Id = 65, Code = "ECU", Name = "Ecuador" },
                        new { Id = 66, Code = "GTM", Name = "Guatemala" },
                        new { Id = 67, Code = "HND", Name = "Honduras" },
                        new { Id = 68, Code = "MEX", Name = "Mexico" },
                        new { Id = 69, Code = "NIC", Name = "Nicaragua" },
                        new { Id = 70, Code = "PAN", Name = "Panama" },
                        new { Id = 71, Code = "PER", Name = "Peru" },
                        new { Id = 72, Code = "PRI", Name = "Puerto Rico" },
                        new { Id = 73, Code = "PRY", Name = "Paraguay" },
                        new { Id = 74, Code = "SLV", Name = "El Salvador" },
                        new { Id = 75, Code = "URY", Name = "Uruguay" },
                        new { Id = 76, Code = "VEN", Name = "Venezuela" },
                        new { Id = 77, Code = "EST", Name = "Estonia" },
                        new { Id = 78, Code = "IRN", Name = "Iran" },
                        new { Id = 79, Code = "SEN", Name = "Senegal" },
                        new { Id = 80, Code = "FIN", Name = "Finland" },
                        new { Id = 81, Code = "FRO", Name = "Faroe Islands" },
                        new { Id = 82, Code = "BEL", Name = "Belgium" },
                        new { Id = 83, Code = "COD", Name = "Congo (DRC)" },
                        new { Id = 84, Code = "CIV", Name = "Côte d’Ivoire" },
                        new { Id = 85, Code = "CMR", Name = "Cameroon" },
                        new { Id = 86, Code = "HTI", Name = "Haiti" },
                        new { Id = 87, Code = "MCO", Name = "Monaco" },
                        new { Id = 88, Code = "MLI", Name = "Mali" },
                        new { Id = 89, Code = "REU", Name = "Réunion" },
                        new { Id = 90, Code = "NLD", Name = "Netherlands" },
                        new { Id = 91, Code = "ISR", Name = "Israel" },
                        new { Id = 92, Code = "HRV", Name = "Croatia" },
                        new { Id = 93, Code = "HUN", Name = "Hungary" },
                        new { Id = 94, Code = "ARM", Name = "Armenia" },
                        new { Id = 95, Code = "ISL", Name = "Iceland" },
                        new { Id = 96, Code = "ITA", Name = "Italy" },
                        new { Id = 97, Code = "JPN", Name = "Japan" },
                        new { Id = 98, Code = "GEO", Name = "Georgia" },
                        new { Id = 99, Code = "KAZ", Name = "Kazakhstan" },
                        new { Id = 100, Code = "GRL", Name = "Greenland" },
                        new { Id = 101, Code = "KHM", Name = "Cambodia" },
                        new { Id = 102, Code = "KOR", Name = "Korea" },
                        new { Id = 103, Code = "KGZ", Name = "Kyrgyzstan" },
                        new { Id = 104, Code = "001", Name = "World" },
                        new { Id = 105, Code = "LAO", Name = "Laos" },
                        new { Id = 106, Code = "LTU", Name = "Lithuania" },
                        new { Id = 107, Code = "LVA", Name = "Latvia" },
                        new { Id = 108, Code = "MKD", Name = "Macedonia, FYRO" },
                        new { Id = 109, Code = "MNG", Name = "Mongolia" },
                        new { Id = 110, Code = "BRN", Name = "Brunei" },
                        new { Id = 111, Code = "MLT", Name = "Malta" },
                        new { Id = 112, Code = "MMR", Name = "Myanmar" },
                        new { Id = 113, Code = "NOR", Name = "Norway" },
                        new { Id = 114, Code = "NPL", Name = "Nepal" },
                        new { Id = 115, Code = "PAK", Name = "Pakistan" },
                        new { Id = 116, Code = "POL", Name = "Poland" },
                        new { Id = 117, Code = "AFG", Name = "Afghanistan" },
                        new { Id = 118, Code = "BRA", Name = "Brazil" },
                        new { Id = 119, Code = "PRT", Name = "Portugal" },
                        new { Id = 120, Code = "MDA", Name = "Moldova" },
                        new { Id = 121, Code = "ROU", Name = "Romania" },
                        new { Id = 122, Code = "RWA", Name = "Rwanda" },
                        new { Id = 123, Code = "SWE", Name = "Sweden" },
                        new { Id = 124, Code = "LKA", Name = "Sri Lanka" },
                        new { Id = 125, Code = "SVK", Name = "Slovakia" },
                        new { Id = 126, Code = "SVN", Name = "Slovenia" },
                        new { Id = 127, Code = "SOM", Name = "Somalia" },
                        new { Id = 128, Code = "ALB", Name = "Albania" },
                        new { Id = 129, Code = "MNE", Name = "Montenegro" },
                        new { Id = 130, Code = "SRB", Name = "Serbia" },
                        new { Id = 131, Code = "KEN", Name = "Kenya" },
                        new { Id = 132, Code = "TJK", Name = "Tajikistan" },
                        new { Id = 133, Code = "THA", Name = "Thailand" },
                        new { Id = 134, Code = "ERI", Name = "Eritrea" },
                        new { Id = 135, Code = "TKM", Name = "Turkmenistan" },
                        new { Id = 136, Code = "BWA", Name = "Botswana" },
                        new { Id = 137, Code = "TUR", Name = "Turkey" },
                        new { Id = 138, Code = "UKR", Name = "Ukraine" },
                        new { Id = 139, Code = "UZB", Name = "Uzbekistan" },
                        new { Id = 140, Code = "VNM", Name = "Vietnam" },
                        new { Id = 141, Code = "MAC", Name = "Macao SAR" },
                        new { Id = 142, Code = "TWN", Name = "Taiwan" }
                    );
                });

            modelBuilder.Entity("InterviewTask.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("Age");

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FirstName")
                        .HasMaxLength(64)
                        .IsUnicode(true);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .HasMaxLength(64)
                        .IsUnicode(true);

                    b.Property<DateTime>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("InterviewTask.Data.Entities.Avatar", b =>
                {
                    b.HasOne("InterviewTask.Data.Entities.User", "User")
                        .WithOne("Avatar")
                        .HasForeignKey("InterviewTask.Data.Entities.Avatar", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InterviewTask.Data.Entities.User", b =>
                {
                    b.HasOne("InterviewTask.Data.Entities.Country", "UserCountry")
                        .WithMany("Users")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
