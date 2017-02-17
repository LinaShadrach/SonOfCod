using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SonOfCodSeafood.Migrations
{
    public partial class recipientUserRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Recipents");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Recipents",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Recipents",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recipents_ApplicationUserId",
                table: "Recipents",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipents_AspNetUsers_ApplicationUserId",
                table: "Recipents",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipents_AspNetUsers_ApplicationUserId",
                table: "Recipents");

            migrationBuilder.DropIndex(
                name: "IX_Recipents_ApplicationUserId",
                table: "Recipents");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Recipents");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Recipents",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ZipCode",
                table: "Recipents",
                nullable: false);
        }
    }
}
