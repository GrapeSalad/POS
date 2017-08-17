using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace POS.Migrations
{
    public partial class TestingCalculatedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Wines",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Markup",
                table: "Wines",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.DropColumn(
                name: "BottlePrice",
                table: "Wines");

            migrationBuilder.AlterColumn<double>(
                name: "GlassPrice",
                table: "Wines",
                nullable: false);

            migrationBuilder.Sql("ALTER TABLE Wines ADD BottlePrice AS CAST(Cost * Markup) AS DECIMAL(4.2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BottleCost",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Wines");

            migrationBuilder.DropColumn(
                name: "Markup",
                table: "Wines");

            migrationBuilder.AlterColumn<float>(
                name: "GlassPrice",
                table: "Wines",
                nullable: false);

            migrationBuilder.AlterColumn<float>(
                name: "BottlePrice",
                table: "Wines",
                nullable: false);
        }
    }
}
