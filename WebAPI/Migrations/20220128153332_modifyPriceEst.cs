using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class modifyPriceEst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rents_Vehicles_VehicleId",
                table: "Rents");

            migrationBuilder.DropIndex(
                name: "IX_Rents_VehicleId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "QuotaId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "Rents");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "RentId",
                table: "Rents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "RentAt",
                table: "Rents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "QuoteId",
                table: "Rents",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "PriceEstimations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PriceEstimations_VehicleId",
                table: "PriceEstimations",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_PriceEstimations_Vehicles_VehicleId",
                table: "PriceEstimations",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PriceEstimations_Vehicles_VehicleId",
                table: "PriceEstimations");

            migrationBuilder.DropIndex(
                name: "IX_PriceEstimations_VehicleId",
                table: "PriceEstimations");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Rents");

            migrationBuilder.DropColumn(
                name: "VehicleId",
                table: "PriceEstimations");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Rents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "RentId",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RentAt",
                table: "Rents",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "QuotaId",
                table: "Rents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "VehicleId",
                table: "Rents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rents_VehicleId",
                table: "Rents",
                column: "VehicleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rents_Vehicles_VehicleId",
                table: "Rents",
                column: "VehicleId",
                principalTable: "Vehicles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
