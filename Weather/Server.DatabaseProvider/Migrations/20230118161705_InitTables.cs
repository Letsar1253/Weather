using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.DatabaseProvider.Migrations
{
    /// <inheritdoc />
    public partial class InitTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherIcon",
                columns: table => new
                {
                    WeatherIconId = table.Column<Guid>(type: "uuid", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherIcon", x => x.WeatherIconId);
                });

            migrationBuilder.CreateTable(
                name: "CurrentWeather",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DewPoint = table.Column<double>(type: "double precision", nullable: true),
                    Temperature = table.Column<double>(type: "double precision", nullable: true),
                    ApparentTemperature = table.Column<double>(type: "double precision", nullable: true),
                    TimeSunrise = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    TimeSunset = table.Column<TimeOnly>(type: "time without time zone", nullable: true),
                    AirQualityIndex = table.Column<double>(type: "double precision", nullable: true),
                    PartDay = table.Column<string>(type: "text", nullable: true),
                    WeatherIconId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentWeather", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentWeather_WeatherIcon_WeatherIconId",
                        column: x => x.WeatherIconId,
                        principalTable: "WeatherIcon",
                        principalColumn: "WeatherIconId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DailyWeather",
                columns: table => new
                {
                    DailyWeatherId = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SnowDepth = table.Column<double>(type: "double precision", nullable: true),
                    AverageTemperature = table.Column<double>(type: "double precision", nullable: true),
                    AverageDewPoint = table.Column<double>(type: "double precision", nullable: true),
                    MaxTemperature = table.Column<double>(type: "double precision", nullable: true),
                    MinTemperature = table.Column<double>(type: "double precision", nullable: true),
                    MaxApparenTemperaturet = table.Column<double>(type: "double precision", nullable: true),
                    MinApparenTemperaturet = table.Column<double>(type: "double precision", nullable: true),
                    IsForecast = table.Column<bool>(type: "boolean", nullable: false),
                    WeatherIconId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DailyWeather", x => x.DailyWeatherId);
                    table.ForeignKey(
                        name: "FK_DailyWeather_WeatherIcon_WeatherIconId",
                        column: x => x.WeatherIconId,
                        principalTable: "WeatherIcon",
                        principalColumn: "WeatherIconId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HourlyWeather",
                columns: table => new
                {
                    HourlyWeatherId = table.Column<Guid>(type: "uuid", nullable: false),
                    DateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    SnowDepth = table.Column<double>(type: "double precision", nullable: true),
                    Temperature = table.Column<double>(type: "double precision", nullable: true),
                    DewPoint = table.Column<double>(type: "double precision", nullable: true),
                    ApparenTemperaturet = table.Column<double>(type: "double precision", nullable: true),
                    PartDay = table.Column<string>(type: "text", nullable: true),
                    IsForecast = table.Column<bool>(type: "boolean", nullable: false),
                    WeatherIconId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HourlyWeather", x => x.HourlyWeatherId);
                    table.ForeignKey(
                        name: "FK_HourlyWeather_WeatherIcon_WeatherIconId",
                        column: x => x.WeatherIconId,
                        principalTable: "WeatherIcon",
                        principalColumn: "WeatherIconId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentWeather_WeatherIconId",
                table: "CurrentWeather",
                column: "WeatherIconId");

            migrationBuilder.CreateIndex(
                name: "IX_DailyWeather_WeatherIconId",
                table: "DailyWeather",
                column: "WeatherIconId");

            migrationBuilder.CreateIndex(
                name: "IX_HourlyWeather_WeatherIconId",
                table: "HourlyWeather",
                column: "WeatherIconId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentWeather");

            migrationBuilder.DropTable(
                name: "DailyWeather");

            migrationBuilder.DropTable(
                name: "HourlyWeather");

            migrationBuilder.DropTable(
                name: "WeatherIcon");
        }
    }
}
