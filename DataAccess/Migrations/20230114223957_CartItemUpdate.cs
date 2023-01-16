using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class CartItemUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_ShoppingSessions_ShoppingSessionId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_ShoppingSessionId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "ShoppingSessionId",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "CartItems",
                newName: "UserId");

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartItemId",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CartItemId",
                table: "Products",
                column: "CartItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products",
                column: "CartItemId",
                principalTable: "CartItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_CartItems_CartItemId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CartItemId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CartItemId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "CartItems",
                newName: "SessionId");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordSalt",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingSessionId",
                table: "CartItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ShoppingSessionId",
                table: "CartItems",
                column: "ShoppingSessionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Products_ProductId",
                table: "CartItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_ShoppingSessions_ShoppingSessionId",
                table: "CartItems",
                column: "ShoppingSessionId",
                principalTable: "ShoppingSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
