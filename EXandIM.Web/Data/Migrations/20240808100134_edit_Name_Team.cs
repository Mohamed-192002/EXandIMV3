﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EXandIM.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class edit_Name_Team : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Teams_Name",
                table: "Teams");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Teams_Name",
                table: "Teams",
                column: "Name",
                unique: true);
        }
    }
}
