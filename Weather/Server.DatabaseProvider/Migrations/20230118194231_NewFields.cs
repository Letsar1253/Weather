using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.DatabaseProvider.Migrations
{
    /// <inheritdoc />
    public partial class NewFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardinalWindDirection",
                table: "HourlyWeather",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CloudCover",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Precipitation",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RelativeHumidity",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Snowfall",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WindDirection",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WindSpeed",
                table: "HourlyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardinalWindDirection",
                table: "DailyWeather",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CloudCover",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Precipitation",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RelativeHumidity",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Snowfall",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WindDirection",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WindSpeed",
                table: "DailyWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CardinalWindDirection",
                table: "CurrentWeather",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "CloudCover",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "CurrentWeather",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Precipitation",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RelativeHumidity",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Snowfall",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WindDirection",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "WindSpeed",
                table: "CurrentWeather",
                type: "double precision",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardinalWindDirection",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "CloudCover",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "Precipitation",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "Pressure",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "RelativeHumidity",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "Snowfall",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "WindDirection",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "HourlyWeather");

            migrationBuilder.DropColumn(
                name: "CardinalWindDirection",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "CloudCover",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "Precipitation",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "Pressure",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "RelativeHumidity",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "Snowfall",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "WindDirection",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "DailyWeather");

            migrationBuilder.DropColumn(
                name: "CardinalWindDirection",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "CloudCover",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "Precipitation",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "Pressure",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "RelativeHumidity",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "Snowfall",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "WindDirection",
                table: "CurrentWeather");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "CurrentWeather");
        }
    }
}
