using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewTask.Data.Migrations
{
    public partial class removingcountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 4, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Code", "Name" },
                values: new object[,]
                {
                    { 1, "DJI", "Djibouti" },
                    { 104, "001", "World" },
                    { 103, "KGZ", "Kyrgyzstan" },
                    { 102, "KOR", "Korea" },
                    { 101, "KHM", "Cambodia" },
                    { 100, "GRL", "Greenland" },
                    { 99, "KAZ", "Kazakhstan" },
                    { 98, "GEO", "Georgia" },
                    { 97, "JPN", "Japan" },
                    { 96, "ITA", "Italy" },
                    { 95, "ISL", "Iceland" },
                    { 94, "ARM", "Armenia" },
                    { 93, "HUN", "Hungary" },
                    { 92, "HRV", "Croatia" },
                    { 91, "ISR", "Israel" },
                    { 90, "NLD", "Netherlands" },
                    { 89, "REU", "Réunion" },
                    { 88, "MLI", "Mali" },
                    { 74, "SLV", "El Salvador" },
                    { 75, "URY", "Uruguay" },
                    { 76, "VEN", "Venezuela" },
                    { 77, "EST", "Estonia" },
                    { 78, "IRN", "Iran" },
                    { 79, "SEN", "Senegal" },
                    { 105, "LAO", "Laos" },
                    { 80, "FIN", "Finland" },
                    { 82, "BEL", "Belgium" },
                    { 83, "COD", "Congo (DRC)" },
                    { 84, "CIV", "Côte d’Ivoire" },
                    { 85, "CMR", "Cameroon" },
                    { 86, "HTI", "Haiti" },
                    { 87, "MCO", "Monaco" },
                    { 81, "FRO", "Faroe Islands" },
                    { 106, "LTU", "Lithuania" },
                    { 107, "LVA", "Latvia" },
                    { 108, "MKD", "Macedonia, FYRO" },
                    { 127, "SOM", "Somalia" },
                    { 128, "ALB", "Albania" },
                    { 129, "MNE", "Montenegro" },
                    { 130, "SRB", "Serbia" },
                    { 131, "KEN", "Kenya" },
                    { 132, "TJK", "Tajikistan" },
                    { 126, "SVN", "Slovenia" },
                    { 133, "THA", "Thailand" },
                    { 135, "TKM", "Turkmenistan" },
                    { 136, "BWA", "Botswana" },
                    { 137, "TUR", "Turkey" },
                    { 138, "UKR", "Ukraine" },
                    { 139, "UZB", "Uzbekistan" },
                    { 140, "VNM", "Vietnam" },
                    { 134, "ERI", "Eritrea" },
                    { 73, "PRY", "Paraguay" },
                    { 125, "SVK", "Slovakia" },
                    { 123, "SWE", "Sweden" },
                    { 109, "MNG", "Mongolia" },
                    { 110, "BRN", "Brunei" },
                    { 111, "MLT", "Malta" },
                    { 112, "MMR", "Myanmar" },
                    { 113, "NOR", "Norway" },
                    { 114, "NPL", "Nepal" },
                    { 124, "LKA", "Sri Lanka" },
                    { 115, "PAK", "Pakistan" },
                    { 117, "AFG", "Afghanistan" },
                    { 118, "BRA", "Brazil" },
                    { 119, "PRT", "Portugal" },
                    { 120, "MDA", "Moldova" },
                    { 121, "ROU", "Romania" },
                    { 122, "RWA", "Rwanda" },
                    { 116, "POL", "Poland" },
                    { 72, "PRI", "Puerto Rico" },
                    { 71, "PER", "Peru" },
                    { 70, "PAN", "Panama" },
                    { 20, "CHL", "Chile" },
                    { 21, "IND", "India" },
                    { 22, "AZE", "Azerbaijan" },
                    { 23, "RUS", "Russia" },
                    { 24, "BLR", "Belarus" },
                    { 25, "BGR", "Bulgaria" },
                    { 19, "YEM", "Yemen" },
                    { 26, "NGA", "Nigeria" },
                    { 28, "CHN", "China" },
                    { 29, "FRA", "France" },
                    { 30, "BIH", "Bosnia and Herzegovina" },
                    { 31, "ESP", "Spain" },
                    { 32, "USA", "United States" },
                    { 33, "CZE", "Czechia" },
                    { 27, "BGD", "Bangladesh" },
                    { 34, "GBR", "United Kingdom" },
                    { 18, "TUN", "Tunisia" },
                    { 16, "SAU", "Saudi Arabia" },
                    { 2, "ZAF", "South Africa" },
                    { 3, "ETH", "Ethiopia" },
                    { 4, "ARE", "United Arab Emirates" },
                    { 5, "BHR", "Bahrain" },
                    { 6, "DZA", "Algeria" },
                    { 7, "EGY", "Egypt" },
                    { 17, "SYR", "Syria" },
                    { 8, "IRQ", "Iraq" },
                    { 10, "KWT", "Kuwait" },
                    { 11, "LBN", "Lebanon" },
                    { 12, "LBY", "Libya" },
                    { 13, "MAR", "Morocco" },
                    { 14, "OMN", "Oman" },
                    { 15, "QAT", "Qatar" },
                    { 9, "JOR", "Jordan" },
                    { 141, "MAC", "Macao SAR" },
                    { 35, "DNK", "Denmark" },
                    { 37, "CHE", "Switzerland" },
                    { 56, "TTO", "Trinidad and Tobago" },
                    { 57, "ZWE", "Zimbabwe" },
                    { 58, "419", "Latin America" },
                    { 59, "ARG", "Argentina" },
                    { 60, "BOL", "Bolivia" },
                    { 61, "COL", "Colombia" },
                    { 55, "SGP", "Singapore" },
                    { 62, "CRI", "Costa Rica" },
                    { 64, "DOM", "Dominican Republic" },
                    { 65, "ECU", "Ecuador" },
                    { 66, "GTM", "Guatemala" },
                    { 67, "HND", "Honduras" },
                    { 68, "MEX", "Mexico" },
                    { 69, "NIC", "Nicaragua" },
                    { 63, "CUB", "Cuba" },
                    { 36, "AUT", "Austria" },
                    { 54, "PHL", "Philippines" },
                    { 52, "MYS", "Malaysia" },
                    { 38, "DEU", "Germany" },
                    { 39, "LIE", "Liechtenstein" },
                    { 40, "LUX", "Luxembourg" },
                    { 41, "MDV", "Maldives" },
                    { 42, "BTN", "Bhutan" },
                    { 43, "GRC", "Greece" },
                    { 53, "NZL", "New Zealand" },
                    { 44, "029", "Caribbean" },
                    { 46, "BLZ", "Belize" },
                    { 47, "CAN", "Canada" },
                    { 48, "HKG", "Hong Kong SAR" },
                    { 49, "IDN", "Indonesia" },
                    { 50, "IRL", "Ireland" },
                    { 51, "JAM", "Jamaica" },
                    { 45, "AUS", "Australia" },
                    { 142, "TWN", "Taiwan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryId",
                table: "Users",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Countries_CountryId",
                table: "Users",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
