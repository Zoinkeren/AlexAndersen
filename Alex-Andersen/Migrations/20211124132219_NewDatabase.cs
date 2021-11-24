using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Alex_Andersen.Migrations
{
    public partial class NewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Availabilities",
                columns: table => new
                {
                    AvailabilityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailabilityStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Availabilities", x => x.AvailabilityID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationID);
                });

            migrationBuilder.CreateTable(
                name: "TripLocations",
                columns: table => new
                {
                    TripLocationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationType = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripLocations", x => x.TripLocationID);
                });

            migrationBuilder.CreateTable(
                name: "UserMessages",
                columns: table => new
                {
                    UserMessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderReciever = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMessages", x => x.UserMessageID);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverResidence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDriverActive = table.Column<bool>(type: "bit", nullable: false),
                    AvailabilityID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Drivers_Availabilities_AvailabilityID",
                        column: x => x.AvailabilityID,
                        principalTable: "Availabilities",
                        principalColumn: "AvailabilityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsTripExpress = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripLocationsTripLocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripID);
                    table.ForeignKey(
                        name: "FK_Trips_TripLocations_TripLocationsTripLocationID",
                        column: x => x.TripLocationsTripLocationID,
                        principalTable: "TripLocations",
                        principalColumn: "TripLocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsMessageRead = table.Column<bool>(type: "bit", nullable: false),
                    UserMessagesUserMessageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Messages_UserMessages_UserMessagesUserMessageID",
                        column: x => x.UserMessagesUserMessageID,
                        principalTable: "UserMessages",
                        principalColumn: "UserMessageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypePreferences",
                columns: table => new
                {
                    TypePreferenceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriversDriverId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePreferences", x => x.TypePreferenceID);
                    table.ForeignKey(
                        name: "FK_TypePreferences_Drivers_DriversDriverId",
                        column: x => x.DriversDriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripsTripID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_Trips_TripsTripID",
                        column: x => x.TripsTripID,
                        principalTable: "Trips",
                        principalColumn: "TripID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TripsTripID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusID);
                    table.ForeignKey(
                        name: "FK_Statuses_Trips_TripsTripID",
                        column: x => x.TripsTripID,
                        principalTable: "Trips",
                        principalColumn: "TripID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityZip = table.Column<int>(type: "int", nullable: false),
                    DepartmentsDepartmentID = table.Column<int>(type: "int", nullable: true),
                    DriversDriverId = table.Column<int>(type: "int", nullable: true),
                    LocationsLocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Departments_DepartmentsDepartmentID",
                        column: x => x.DepartmentsDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Drivers_DriversDriverId",
                        column: x => x.DriversDriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cities_Locations_LocationsLocationID",
                        column: x => x.LocationsLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhoneNumber = table.Column<int>(type: "int", nullable: false),
                    DepartmentsDepartmentID = table.Column<int>(type: "int", nullable: true),
                    DriversDriverId = table.Column<int>(type: "int", nullable: true),
                    UserMessagesUserMessageID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_Users_Departments_DepartmentsDepartmentID",
                        column: x => x.DepartmentsDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Drivers_DriversDriverId",
                        column: x => x.DriversDriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_UserMessages_UserMessagesUserMessageID",
                        column: x => x.UserMessagesUserMessageID,
                        principalTable: "UserMessages",
                        principalColumn: "UserMessageID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CitiesCityID = table.Column<int>(type: "int", nullable: true),
                    DepartmentsDepartmentID = table.Column<int>(type: "int", nullable: true),
                    DriversDriverId = table.Column<int>(type: "int", nullable: true),
                    LocationsLocationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                    table.ForeignKey(
                        name: "FK_Countries_Cities_CitiesCityID",
                        column: x => x.CitiesCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Departments_DepartmentsDepartmentID",
                        column: x => x.DepartmentsDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Drivers_DriversDriverId",
                        column: x => x.DriversDriverId,
                        principalTable: "Drivers",
                        principalColumn: "DriverId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Countries_Locations_LocationsLocationID",
                        column: x => x.LocationsLocationID,
                        principalTable: "Locations",
                        principalColumn: "LocationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UsersUserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                    table.ForeignKey(
                        name: "FK_Roles_Users_UsersUserID",
                        column: x => x.UsersUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DepartmentsDepartmentID",
                table: "Cities",
                column: "DepartmentsDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_DriversDriverId",
                table: "Cities",
                column: "DriversDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_LocationsLocationID",
                table: "Cities",
                column: "LocationsLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_CitiesCityID",
                table: "Countries",
                column: "CitiesCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DepartmentsDepartmentID",
                table: "Countries",
                column: "DepartmentsDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_DriversDriverId",
                table: "Countries",
                column: "DriversDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_LocationsLocationID",
                table: "Countries",
                column: "LocationsLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_TripsTripID",
                table: "Departments",
                column: "TripsTripID");

            migrationBuilder.CreateIndex(
                name: "IX_Drivers_AvailabilityID",
                table: "Drivers",
                column: "AvailabilityID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserMessagesUserMessageID",
                table: "Messages",
                column: "UserMessagesUserMessageID");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_UsersUserID",
                table: "Roles",
                column: "UsersUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Statuses_TripsTripID",
                table: "Statuses",
                column: "TripsTripID");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TripLocationsTripLocationID",
                table: "Trips",
                column: "TripLocationsTripLocationID");

            migrationBuilder.CreateIndex(
                name: "IX_TypePreferences_DriversDriverId",
                table: "TypePreferences",
                column: "DriversDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DepartmentsDepartmentID",
                table: "Users",
                column: "DepartmentsDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_DriversDriverId",
                table: "Users",
                column: "DriversDriverId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserMessagesUserMessageID",
                table: "Users",
                column: "UserMessagesUserMessageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TypePreferences");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "UserMessages");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropTable(
                name: "Availabilities");

            migrationBuilder.DropTable(
                name: "TripLocations");
        }
    }
}
