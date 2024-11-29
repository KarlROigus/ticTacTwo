﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class vol3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId1",
                table: "Configs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Configs_UserId1",
                table: "Configs",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Configs_Users_UserId1",
                table: "Configs",
                column: "UserId1",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Configs_Users_UserId1",
                table: "Configs");

            migrationBuilder.DropIndex(
                name: "IX_Configs_UserId1",
                table: "Configs");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Configs");
        }
    }
}
