using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cms.Library.Migrations
{
    /// <inheritdoc />
    public partial class update_2024112102 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRetailFlows_CustomerRetailMasters_RetailMasterId",
                table: "CustomerRetailFlows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemInfos",
                table: "ItemInfos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemClss",
                table: "ItemClss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRetailMasters",
                table: "CustomerRetailMasters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRetailFlows",
                table: "CustomerRetailFlows");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerInfos",
                table: "CustomerInfos");

            migrationBuilder.RenameTable(
                name: "ItemInfos",
                newName: "ItemInfo");

            migrationBuilder.RenameTable(
                name: "ItemClss",
                newName: "ItemCls");

            migrationBuilder.RenameTable(
                name: "CustomerRetailMasters",
                newName: "CustomerRetailMaster");

            migrationBuilder.RenameTable(
                name: "CustomerRetailFlows",
                newName: "CustomerRetailFlow");

            migrationBuilder.RenameTable(
                name: "CustomerInfos",
                newName: "CustomerInfo");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRetailFlows_RetailMasterId",
                table: "CustomerRetailFlow",
                newName: "IX_CustomerRetailFlow_RetailMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemInfo",
                table: "ItemInfo",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCls",
                table: "ItemCls",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRetailMaster",
                table: "CustomerRetailMaster",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRetailFlow",
                table: "CustomerRetailFlow",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerInfo",
                table: "CustomerInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRetailFlow_CustomerRetailMaster_RetailMasterId",
                table: "CustomerRetailFlow",
                column: "RetailMasterId",
                principalTable: "CustomerRetailMaster",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerRetailFlow_CustomerRetailMaster_RetailMasterId",
                table: "CustomerRetailFlow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemInfo",
                table: "ItemInfo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCls",
                table: "ItemCls");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRetailMaster",
                table: "CustomerRetailMaster");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerRetailFlow",
                table: "CustomerRetailFlow");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CustomerInfo",
                table: "CustomerInfo");

            migrationBuilder.RenameTable(
                name: "ItemInfo",
                newName: "ItemInfos");

            migrationBuilder.RenameTable(
                name: "ItemCls",
                newName: "ItemClss");

            migrationBuilder.RenameTable(
                name: "CustomerRetailMaster",
                newName: "CustomerRetailMasters");

            migrationBuilder.RenameTable(
                name: "CustomerRetailFlow",
                newName: "CustomerRetailFlows");

            migrationBuilder.RenameTable(
                name: "CustomerInfo",
                newName: "CustomerInfos");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerRetailFlow_RetailMasterId",
                table: "CustomerRetailFlows",
                newName: "IX_CustomerRetailFlows_RetailMasterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemInfos",
                table: "ItemInfos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemClss",
                table: "ItemClss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRetailMasters",
                table: "CustomerRetailMasters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerRetailFlows",
                table: "CustomerRetailFlows",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CustomerInfos",
                table: "CustomerInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerRetailFlows_CustomerRetailMasters_RetailMasterId",
                table: "CustomerRetailFlows",
                column: "RetailMasterId",
                principalTable: "CustomerRetailMasters",
                principalColumn: "Id");
        }
    }
}
