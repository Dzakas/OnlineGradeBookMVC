using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OGB.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__1ABiology__1AGrades_GradesRef",
                table: "_1ABiology");

            migrationBuilder.DropForeignKey(
                name: "FK__1AChemistry__1AGrades_GradesRef",
                table: "_1AChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__1AEnglish__1AGrades_GradesRef",
                table: "_1AEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__1AGeography__1AGrades_GradesRef",
                table: "_1AGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__1AGerman__1AGrades_GradesRef",
                table: "_1AGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__1AHistory__1AGrades_GradesRef",
                table: "_1AHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__1AMath__1AGrades_GradesRef",
                table: "_1AMath");

            migrationBuilder.DropForeignKey(
                name: "FK__1BBiology__1BGrades_GradesRef",
                table: "_1BBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__1BChemistry__1BGrades_GradesRef",
                table: "_1BChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__1BEnglish__1BGrades_GradesRef",
                table: "_1BEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__1BGeography__1BGrades_GradesRef",
                table: "_1BGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__1BGerman__1BGrades_GradesRef",
                table: "_1BGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__1BHistory__1BGrades_GradesRef",
                table: "_1BHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__1BMath__1BGrades_GradesRef",
                table: "_1BMath");

            migrationBuilder.DropForeignKey(
                name: "FK__1CBiology__1CGrades_GradesRef",
                table: "_1CBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__1CChemistry__1CGrades_GradesRef",
                table: "_1CChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__1CEnglish__1CGrades_GradesRef",
                table: "_1CEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__1CGeography__1CGrades_GradesRef",
                table: "_1CGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__1CGerman__1CGrades_GradesRef",
                table: "_1CGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__1CHistory__1CGrades_GradesRef",
                table: "_1CHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__1CMath__1CGrades_GradesRef",
                table: "_1CMath");

            migrationBuilder.DropForeignKey(
                name: "FK__2ABiology__2AGrades_GradesRef",
                table: "_2ABiology");

            migrationBuilder.DropForeignKey(
                name: "FK__2AChemistry__2AGrades_GradesRef",
                table: "_2AChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__2AEnglish__2AGrades_GradesRef",
                table: "_2AEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__2AGeography__2AGrades_GradesRef",
                table: "_2AGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__2AGerman__2AGrades_GradesRef",
                table: "_2AGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__2AHistory__2AGrades_GradesRef",
                table: "_2AHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__2AMath__2AGrades_GradesRef",
                table: "_2AMath");

            migrationBuilder.DropForeignKey(
                name: "FK__2BBiology__2BGrades_GradesRef",
                table: "_2BBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__2BChemistry__2BGrades_GradesRef",
                table: "_2BChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__2BEnglish__2BGrades_GradesRef",
                table: "_2BEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__2BGeography__2BGrades_GradesRef",
                table: "_2BGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__2BGerman__2BGrades_GradesRef",
                table: "_2BGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__2BHistory__2BGrades_GradesRef",
                table: "_2BHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__2BMath__2BGrades_GradesRef",
                table: "_2BMath");

            migrationBuilder.DropForeignKey(
                name: "FK__2CBiology__2CGrades_GradesRef",
                table: "_2CBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__2CChemistry__2CGrades_GradesRef",
                table: "_2CChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__2CEnglish__2CGrades_GradesRef",
                table: "_2CEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__2CGeography__2CGrades_GradesRef",
                table: "_2CGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__2CGerman__2CGrades_GradesRef",
                table: "_2CGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__2CHistory__2CGrades_GradesRef",
                table: "_2CHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__2CMath__2CGrades_GradesRef",
                table: "_2CMath");

            migrationBuilder.DropForeignKey(
                name: "FK__3ABiology__3AGrades_GradesRef",
                table: "_3ABiology");

            migrationBuilder.DropForeignKey(
                name: "FK__3AChemistry__3AGrades_GradesRef",
                table: "_3AChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__3AEnglish__3AGrades_GradesRef",
                table: "_3AEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__3AGeography__3AGrades_GradesRef",
                table: "_3AGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__3AGerman__3AGrades_GradesRef",
                table: "_3AGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__3AHistory__3AGrades_GradesRef",
                table: "_3AHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__3AMath__3AGrades_GradesRef",
                table: "_3AMath");

            migrationBuilder.DropForeignKey(
                name: "FK__3BBiology__3BGrades_GradesRef",
                table: "_3BBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__3BChemistry__3BGrades_GradesRef",
                table: "_3BChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__3BEnglish__3BGrades_GradesRef",
                table: "_3BEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__3BGeography__3BGrades_GradesRef",
                table: "_3BGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__3BGerman__3BGrades_GradesRef",
                table: "_3BGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__3BHistory__3BGrades_GradesRef",
                table: "_3BHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__3BMath__3BGrades_GradesRef",
                table: "_3BMath");

            migrationBuilder.DropForeignKey(
                name: "FK__3CBiology__3CGrades_GradesRef",
                table: "_3CBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__3CChemistry__3CGrades_GradesRef",
                table: "_3CChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__3CEnglish__3CGrades_GradesRef",
                table: "_3CEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__3CGeography__3CGrades_GradesRef",
                table: "_3CGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__3CGerman__3CGrades_GradesRef",
                table: "_3CGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__3CHistory__3CGrades_GradesRef",
                table: "_3CHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__3CMath__3CGrades_GradesRef",
                table: "_3CMath");

            migrationBuilder.DropTable(
                name: "_1AGrades");

            migrationBuilder.DropTable(
                name: "_1BGrades");

            migrationBuilder.DropTable(
                name: "_1CGrades");

            migrationBuilder.DropTable(
                name: "_2AGrades");

            migrationBuilder.DropTable(
                name: "_2BGrades");

            migrationBuilder.DropTable(
                name: "_2CGrades");

            migrationBuilder.DropTable(
                name: "_3AGrades");

            migrationBuilder.DropTable(
                name: "_3BGrades");

            migrationBuilder.DropTable(
                name: "_3CGrades");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CMath_GradesRef",
                table: "_3CMath",
                newName: "IX__3CMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CHistory_GradesRef",
                table: "_3CHistory",
                newName: "IX__3CHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CGerman_GradesRef",
                table: "_3CGerman",
                newName: "IX__3CGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CGeography_GradesRef",
                table: "_3CGeography",
                newName: "IX__3CGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CEnglish_GradesRef",
                table: "_3CEnglish",
                newName: "IX__3CEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CChemistry_GradesRef",
                table: "_3CChemistry",
                newName: "IX__3CChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3CBiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CBiology_GradesRef",
                table: "_3CBiology",
                newName: "IX__3CBiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BMath_GradesRef",
                table: "_3BMath",
                newName: "IX__3BMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BHistory_GradesRef",
                table: "_3BHistory",
                newName: "IX__3BHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BGerman_GradesRef",
                table: "_3BGerman",
                newName: "IX__3BGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BGeography_GradesRef",
                table: "_3BGeography",
                newName: "IX__3BGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BEnglish_GradesRef",
                table: "_3BEnglish",
                newName: "IX__3BEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BChemistry_GradesRef",
                table: "_3BChemistry",
                newName: "IX__3BChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3BBiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BBiology_GradesRef",
                table: "_3BBiology",
                newName: "IX__3BBiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3AMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AMath_GradesRef",
                table: "_3AMath",
                newName: "IX__3AMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3AHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AHistory_GradesRef",
                table: "_3AHistory",
                newName: "IX__3AHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3AGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AGerman_GradesRef",
                table: "_3AGerman",
                newName: "IX__3AGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3AGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AGeography_GradesRef",
                table: "_3AGeography",
                newName: "IX__3AGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3AEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AEnglish_GradesRef",
                table: "_3AEnglish",
                newName: "IX__3AEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3AChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AChemistry_GradesRef",
                table: "_3AChemistry",
                newName: "IX__3AChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_3ABiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__3ABiology_GradesRef",
                table: "_3ABiology",
                newName: "IX__3ABiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CMath_GradesRef",
                table: "_2CMath",
                newName: "IX__2CMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CHistory_GradesRef",
                table: "_2CHistory",
                newName: "IX__2CHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CGerman_GradesRef",
                table: "_2CGerman",
                newName: "IX__2CGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CGeography_GradesRef",
                table: "_2CGeography",
                newName: "IX__2CGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CEnglish_GradesRef",
                table: "_2CEnglish",
                newName: "IX__2CEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CChemistry_GradesRef",
                table: "_2CChemistry",
                newName: "IX__2CChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2CBiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CBiology_GradesRef",
                table: "_2CBiology",
                newName: "IX__2CBiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BMath_GradesRef",
                table: "_2BMath",
                newName: "IX__2BMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BHistory_GradesRef",
                table: "_2BHistory",
                newName: "IX__2BHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BGerman_GradesRef",
                table: "_2BGerman",
                newName: "IX__2BGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BGeography_GradesRef",
                table: "_2BGeography",
                newName: "IX__2BGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BEnglish_GradesRef",
                table: "_2BEnglish",
                newName: "IX__2BEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BChemistry_GradesRef",
                table: "_2BChemistry",
                newName: "IX__2BChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2BBiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BBiology_GradesRef",
                table: "_2BBiology",
                newName: "IX__2BBiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2AMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AMath_GradesRef",
                table: "_2AMath",
                newName: "IX__2AMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2AHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AHistory_GradesRef",
                table: "_2AHistory",
                newName: "IX__2AHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2AGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AGerman_GradesRef",
                table: "_2AGerman",
                newName: "IX__2AGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2AGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AGeography_GradesRef",
                table: "_2AGeography",
                newName: "IX__2AGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2AEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AEnglish_GradesRef",
                table: "_2AEnglish",
                newName: "IX__2AEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2AChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AChemistry_GradesRef",
                table: "_2AChemistry",
                newName: "IX__2AChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_2ABiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__2ABiology_GradesRef",
                table: "_2ABiology",
                newName: "IX__2ABiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CMath_GradesRef",
                table: "_1CMath",
                newName: "IX__1CMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CHistory_GradesRef",
                table: "_1CHistory",
                newName: "IX__1CHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CGerman_GradesRef",
                table: "_1CGerman",
                newName: "IX__1CGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CGeography_GradesRef",
                table: "_1CGeography",
                newName: "IX__1CGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CEnglish_GradesRef",
                table: "_1CEnglish",
                newName: "IX__1CEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CChemistry_GradesRef",
                table: "_1CChemistry",
                newName: "IX__1CChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1CBiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CBiology_GradesRef",
                table: "_1CBiology",
                newName: "IX__1CBiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BMath_GradesRef",
                table: "_1BMath",
                newName: "IX__1BMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BHistory_GradesRef",
                table: "_1BHistory",
                newName: "IX__1BHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BGerman_GradesRef",
                table: "_1BGerman",
                newName: "IX__1BGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BGeography_GradesRef",
                table: "_1BGeography",
                newName: "IX__1BGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BEnglish_GradesRef",
                table: "_1BEnglish",
                newName: "IX__1BEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BChemistry_GradesRef",
                table: "_1BChemistry",
                newName: "IX__1BChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1BBiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BBiology_GradesRef",
                table: "_1BBiology",
                newName: "IX__1BBiology_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1AMath",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AMath_GradesRef",
                table: "_1AMath",
                newName: "IX__1AMath_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1AHistory",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AHistory_GradesRef",
                table: "_1AHistory",
                newName: "IX__1AHistory_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1AGerman",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AGerman_GradesRef",
                table: "_1AGerman",
                newName: "IX__1AGerman_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1AGeography",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AGeography_GradesRef",
                table: "_1AGeography",
                newName: "IX__1AGeography_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1AEnglish",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AEnglish_GradesRef",
                table: "_1AEnglish",
                newName: "IX__1AEnglish_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1AChemistry",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AChemistry_GradesRef",
                table: "_1AChemistry",
                newName: "IX__1AChemistry_StudentRef");

            migrationBuilder.RenameColumn(
                name: "GradesRef",
                table: "_1ABiology",
                newName: "StudentRef");

            migrationBuilder.RenameIndex(
                name: "IX__1ABiology_GradesRef",
                table: "_1ABiology",
                newName: "IX__1ABiology_StudentRef");

            migrationBuilder.AddForeignKey(
                name: "FK__1ABiology__1AStudents_StudentRef",
                table: "_1ABiology",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AChemistry__1AStudents_StudentRef",
                table: "_1AChemistry",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AEnglish__1AStudents_StudentRef",
                table: "_1AEnglish",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AGeography__1AStudents_StudentRef",
                table: "_1AGeography",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AGerman__1AStudents_StudentRef",
                table: "_1AGerman",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AHistory__1AStudents_StudentRef",
                table: "_1AHistory",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AMath__1AStudents_StudentRef",
                table: "_1AMath",
                column: "StudentRef",
                principalTable: "_1AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BBiology__1BStudents_StudentRef",
                table: "_1BBiology",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BChemistry__1BStudents_StudentRef",
                table: "_1BChemistry",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BEnglish__1BStudents_StudentRef",
                table: "_1BEnglish",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BGeography__1BStudents_StudentRef",
                table: "_1BGeography",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BGerman__1BStudents_StudentRef",
                table: "_1BGerman",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BHistory__1BStudents_StudentRef",
                table: "_1BHistory",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BMath__1BStudents_StudentRef",
                table: "_1BMath",
                column: "StudentRef",
                principalTable: "_1BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CBiology__1CStudents_StudentRef",
                table: "_1CBiology",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CChemistry__1CStudents_StudentRef",
                table: "_1CChemistry",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CEnglish__1CStudents_StudentRef",
                table: "_1CEnglish",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CGeography__1CStudents_StudentRef",
                table: "_1CGeography",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CGerman__1CStudents_StudentRef",
                table: "_1CGerman",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CHistory__1CStudents_StudentRef",
                table: "_1CHistory",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CMath__1CStudents_StudentRef",
                table: "_1CMath",
                column: "StudentRef",
                principalTable: "_1CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2ABiology__2AStudents_StudentRef",
                table: "_2ABiology",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AChemistry__2AStudents_StudentRef",
                table: "_2AChemistry",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AEnglish__2AStudents_StudentRef",
                table: "_2AEnglish",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AGeography__2AStudents_StudentRef",
                table: "_2AGeography",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AGerman__2AStudents_StudentRef",
                table: "_2AGerman",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AHistory__2AStudents_StudentRef",
                table: "_2AHistory",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AMath__2AStudents_StudentRef",
                table: "_2AMath",
                column: "StudentRef",
                principalTable: "_2AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BBiology__2BStudents_StudentRef",
                table: "_2BBiology",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BChemistry__2BStudents_StudentRef",
                table: "_2BChemistry",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BEnglish__2BStudents_StudentRef",
                table: "_2BEnglish",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BGeography__2BStudents_StudentRef",
                table: "_2BGeography",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BGerman__2BStudents_StudentRef",
                table: "_2BGerman",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BHistory__2BStudents_StudentRef",
                table: "_2BHistory",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BMath__2BStudents_StudentRef",
                table: "_2BMath",
                column: "StudentRef",
                principalTable: "_2BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CBiology__2CStudents_StudentRef",
                table: "_2CBiology",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CChemistry__2CStudents_StudentRef",
                table: "_2CChemistry",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CEnglish__2CStudents_StudentRef",
                table: "_2CEnglish",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CGeography__2CStudents_StudentRef",
                table: "_2CGeography",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CGerman__2CStudents_StudentRef",
                table: "_2CGerman",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CHistory__2CStudents_StudentRef",
                table: "_2CHistory",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CMath__2CStudents_StudentRef",
                table: "_2CMath",
                column: "StudentRef",
                principalTable: "_2CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3ABiology__3AStudents_StudentRef",
                table: "_3ABiology",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AChemistry__3AStudents_StudentRef",
                table: "_3AChemistry",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AEnglish__3AStudents_StudentRef",
                table: "_3AEnglish",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AGeography__3AStudents_StudentRef",
                table: "_3AGeography",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AGerman__3AStudents_StudentRef",
                table: "_3AGerman",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AHistory__3AStudents_StudentRef",
                table: "_3AHistory",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AMath__3AStudents_StudentRef",
                table: "_3AMath",
                column: "StudentRef",
                principalTable: "_3AStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BBiology__3BStudents_StudentRef",
                table: "_3BBiology",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BChemistry__3BStudents_StudentRef",
                table: "_3BChemistry",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BEnglish__3BStudents_StudentRef",
                table: "_3BEnglish",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BGeography__3BStudents_StudentRef",
                table: "_3BGeography",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BGerman__3BStudents_StudentRef",
                table: "_3BGerman",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BHistory__3BStudents_StudentRef",
                table: "_3BHistory",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BMath__3BStudents_StudentRef",
                table: "_3BMath",
                column: "StudentRef",
                principalTable: "_3BStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CBiology__3CStudents_StudentRef",
                table: "_3CBiology",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CChemistry__3CStudents_StudentRef",
                table: "_3CChemistry",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CEnglish__3CStudents_StudentRef",
                table: "_3CEnglish",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CGeography__3CStudents_StudentRef",
                table: "_3CGeography",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CGerman__3CStudents_StudentRef",
                table: "_3CGerman",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CHistory__3CStudents_StudentRef",
                table: "_3CHistory",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CMath__3CStudents_StudentRef",
                table: "_3CMath",
                column: "StudentRef",
                principalTable: "_3CStudents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__1ABiology__1AStudents_StudentRef",
                table: "_1ABiology");

            migrationBuilder.DropForeignKey(
                name: "FK__1AChemistry__1AStudents_StudentRef",
                table: "_1AChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__1AEnglish__1AStudents_StudentRef",
                table: "_1AEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__1AGeography__1AStudents_StudentRef",
                table: "_1AGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__1AGerman__1AStudents_StudentRef",
                table: "_1AGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__1AHistory__1AStudents_StudentRef",
                table: "_1AHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__1AMath__1AStudents_StudentRef",
                table: "_1AMath");

            migrationBuilder.DropForeignKey(
                name: "FK__1BBiology__1BStudents_StudentRef",
                table: "_1BBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__1BChemistry__1BStudents_StudentRef",
                table: "_1BChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__1BEnglish__1BStudents_StudentRef",
                table: "_1BEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__1BGeography__1BStudents_StudentRef",
                table: "_1BGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__1BGerman__1BStudents_StudentRef",
                table: "_1BGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__1BHistory__1BStudents_StudentRef",
                table: "_1BHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__1BMath__1BStudents_StudentRef",
                table: "_1BMath");

            migrationBuilder.DropForeignKey(
                name: "FK__1CBiology__1CStudents_StudentRef",
                table: "_1CBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__1CChemistry__1CStudents_StudentRef",
                table: "_1CChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__1CEnglish__1CStudents_StudentRef",
                table: "_1CEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__1CGeography__1CStudents_StudentRef",
                table: "_1CGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__1CGerman__1CStudents_StudentRef",
                table: "_1CGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__1CHistory__1CStudents_StudentRef",
                table: "_1CHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__1CMath__1CStudents_StudentRef",
                table: "_1CMath");

            migrationBuilder.DropForeignKey(
                name: "FK__2ABiology__2AStudents_StudentRef",
                table: "_2ABiology");

            migrationBuilder.DropForeignKey(
                name: "FK__2AChemistry__2AStudents_StudentRef",
                table: "_2AChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__2AEnglish__2AStudents_StudentRef",
                table: "_2AEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__2AGeography__2AStudents_StudentRef",
                table: "_2AGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__2AGerman__2AStudents_StudentRef",
                table: "_2AGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__2AHistory__2AStudents_StudentRef",
                table: "_2AHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__2AMath__2AStudents_StudentRef",
                table: "_2AMath");

            migrationBuilder.DropForeignKey(
                name: "FK__2BBiology__2BStudents_StudentRef",
                table: "_2BBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__2BChemistry__2BStudents_StudentRef",
                table: "_2BChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__2BEnglish__2BStudents_StudentRef",
                table: "_2BEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__2BGeography__2BStudents_StudentRef",
                table: "_2BGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__2BGerman__2BStudents_StudentRef",
                table: "_2BGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__2BHistory__2BStudents_StudentRef",
                table: "_2BHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__2BMath__2BStudents_StudentRef",
                table: "_2BMath");

            migrationBuilder.DropForeignKey(
                name: "FK__2CBiology__2CStudents_StudentRef",
                table: "_2CBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__2CChemistry__2CStudents_StudentRef",
                table: "_2CChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__2CEnglish__2CStudents_StudentRef",
                table: "_2CEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__2CGeography__2CStudents_StudentRef",
                table: "_2CGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__2CGerman__2CStudents_StudentRef",
                table: "_2CGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__2CHistory__2CStudents_StudentRef",
                table: "_2CHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__2CMath__2CStudents_StudentRef",
                table: "_2CMath");

            migrationBuilder.DropForeignKey(
                name: "FK__3ABiology__3AStudents_StudentRef",
                table: "_3ABiology");

            migrationBuilder.DropForeignKey(
                name: "FK__3AChemistry__3AStudents_StudentRef",
                table: "_3AChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__3AEnglish__3AStudents_StudentRef",
                table: "_3AEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__3AGeography__3AStudents_StudentRef",
                table: "_3AGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__3AGerman__3AStudents_StudentRef",
                table: "_3AGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__3AHistory__3AStudents_StudentRef",
                table: "_3AHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__3AMath__3AStudents_StudentRef",
                table: "_3AMath");

            migrationBuilder.DropForeignKey(
                name: "FK__3BBiology__3BStudents_StudentRef",
                table: "_3BBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__3BChemistry__3BStudents_StudentRef",
                table: "_3BChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__3BEnglish__3BStudents_StudentRef",
                table: "_3BEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__3BGeography__3BStudents_StudentRef",
                table: "_3BGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__3BGerman__3BStudents_StudentRef",
                table: "_3BGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__3BHistory__3BStudents_StudentRef",
                table: "_3BHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__3BMath__3BStudents_StudentRef",
                table: "_3BMath");

            migrationBuilder.DropForeignKey(
                name: "FK__3CBiology__3CStudents_StudentRef",
                table: "_3CBiology");

            migrationBuilder.DropForeignKey(
                name: "FK__3CChemistry__3CStudents_StudentRef",
                table: "_3CChemistry");

            migrationBuilder.DropForeignKey(
                name: "FK__3CEnglish__3CStudents_StudentRef",
                table: "_3CEnglish");

            migrationBuilder.DropForeignKey(
                name: "FK__3CGeography__3CStudents_StudentRef",
                table: "_3CGeography");

            migrationBuilder.DropForeignKey(
                name: "FK__3CGerman__3CStudents_StudentRef",
                table: "_3CGerman");

            migrationBuilder.DropForeignKey(
                name: "FK__3CHistory__3CStudents_StudentRef",
                table: "_3CHistory");

            migrationBuilder.DropForeignKey(
                name: "FK__3CMath__3CStudents_StudentRef",
                table: "_3CMath");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CMath_StudentRef",
                table: "_3CMath",
                newName: "IX__3CMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CHistory_StudentRef",
                table: "_3CHistory",
                newName: "IX__3CHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CGerman_StudentRef",
                table: "_3CGerman",
                newName: "IX__3CGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CGeography_StudentRef",
                table: "_3CGeography",
                newName: "IX__3CGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CEnglish_StudentRef",
                table: "_3CEnglish",
                newName: "IX__3CEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CChemistry_StudentRef",
                table: "_3CChemistry",
                newName: "IX__3CChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3CBiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3CBiology_StudentRef",
                table: "_3CBiology",
                newName: "IX__3CBiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BMath_StudentRef",
                table: "_3BMath",
                newName: "IX__3BMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BHistory_StudentRef",
                table: "_3BHistory",
                newName: "IX__3BHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BGerman_StudentRef",
                table: "_3BGerman",
                newName: "IX__3BGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BGeography_StudentRef",
                table: "_3BGeography",
                newName: "IX__3BGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BEnglish_StudentRef",
                table: "_3BEnglish",
                newName: "IX__3BEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BChemistry_StudentRef",
                table: "_3BChemistry",
                newName: "IX__3BChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3BBiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3BBiology_StudentRef",
                table: "_3BBiology",
                newName: "IX__3BBiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3AMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AMath_StudentRef",
                table: "_3AMath",
                newName: "IX__3AMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3AHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AHistory_StudentRef",
                table: "_3AHistory",
                newName: "IX__3AHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3AGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AGerman_StudentRef",
                table: "_3AGerman",
                newName: "IX__3AGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3AGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AGeography_StudentRef",
                table: "_3AGeography",
                newName: "IX__3AGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3AEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AEnglish_StudentRef",
                table: "_3AEnglish",
                newName: "IX__3AEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3AChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3AChemistry_StudentRef",
                table: "_3AChemistry",
                newName: "IX__3AChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_3ABiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__3ABiology_StudentRef",
                table: "_3ABiology",
                newName: "IX__3ABiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CMath_StudentRef",
                table: "_2CMath",
                newName: "IX__2CMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CHistory_StudentRef",
                table: "_2CHistory",
                newName: "IX__2CHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CGerman_StudentRef",
                table: "_2CGerman",
                newName: "IX__2CGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CGeography_StudentRef",
                table: "_2CGeography",
                newName: "IX__2CGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CEnglish_StudentRef",
                table: "_2CEnglish",
                newName: "IX__2CEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CChemistry_StudentRef",
                table: "_2CChemistry",
                newName: "IX__2CChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2CBiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2CBiology_StudentRef",
                table: "_2CBiology",
                newName: "IX__2CBiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BMath_StudentRef",
                table: "_2BMath",
                newName: "IX__2BMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BHistory_StudentRef",
                table: "_2BHistory",
                newName: "IX__2BHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BGerman_StudentRef",
                table: "_2BGerman",
                newName: "IX__2BGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BGeography_StudentRef",
                table: "_2BGeography",
                newName: "IX__2BGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BEnglish_StudentRef",
                table: "_2BEnglish",
                newName: "IX__2BEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BChemistry_StudentRef",
                table: "_2BChemistry",
                newName: "IX__2BChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2BBiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2BBiology_StudentRef",
                table: "_2BBiology",
                newName: "IX__2BBiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2AMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AMath_StudentRef",
                table: "_2AMath",
                newName: "IX__2AMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2AHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AHistory_StudentRef",
                table: "_2AHistory",
                newName: "IX__2AHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2AGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AGerman_StudentRef",
                table: "_2AGerman",
                newName: "IX__2AGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2AGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AGeography_StudentRef",
                table: "_2AGeography",
                newName: "IX__2AGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2AEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AEnglish_StudentRef",
                table: "_2AEnglish",
                newName: "IX__2AEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2AChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2AChemistry_StudentRef",
                table: "_2AChemistry",
                newName: "IX__2AChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_2ABiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__2ABiology_StudentRef",
                table: "_2ABiology",
                newName: "IX__2ABiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CMath_StudentRef",
                table: "_1CMath",
                newName: "IX__1CMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CHistory_StudentRef",
                table: "_1CHistory",
                newName: "IX__1CHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CGerman_StudentRef",
                table: "_1CGerman",
                newName: "IX__1CGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CGeography_StudentRef",
                table: "_1CGeography",
                newName: "IX__1CGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CEnglish_StudentRef",
                table: "_1CEnglish",
                newName: "IX__1CEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CChemistry_StudentRef",
                table: "_1CChemistry",
                newName: "IX__1CChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1CBiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1CBiology_StudentRef",
                table: "_1CBiology",
                newName: "IX__1CBiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BMath_StudentRef",
                table: "_1BMath",
                newName: "IX__1BMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BHistory_StudentRef",
                table: "_1BHistory",
                newName: "IX__1BHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BGerman_StudentRef",
                table: "_1BGerman",
                newName: "IX__1BGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BGeography_StudentRef",
                table: "_1BGeography",
                newName: "IX__1BGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BEnglish_StudentRef",
                table: "_1BEnglish",
                newName: "IX__1BEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BChemistry_StudentRef",
                table: "_1BChemistry",
                newName: "IX__1BChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1BBiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1BBiology_StudentRef",
                table: "_1BBiology",
                newName: "IX__1BBiology_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1AMath",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AMath_StudentRef",
                table: "_1AMath",
                newName: "IX__1AMath_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1AHistory",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AHistory_StudentRef",
                table: "_1AHistory",
                newName: "IX__1AHistory_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1AGerman",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AGerman_StudentRef",
                table: "_1AGerman",
                newName: "IX__1AGerman_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1AGeography",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AGeography_StudentRef",
                table: "_1AGeography",
                newName: "IX__1AGeography_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1AEnglish",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AEnglish_StudentRef",
                table: "_1AEnglish",
                newName: "IX__1AEnglish_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1AChemistry",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1AChemistry_StudentRef",
                table: "_1AChemistry",
                newName: "IX__1AChemistry_GradesRef");

            migrationBuilder.RenameColumn(
                name: "StudentRef",
                table: "_1ABiology",
                newName: "GradesRef");

            migrationBuilder.RenameIndex(
                name: "IX__1ABiology_StudentRef",
                table: "_1ABiology",
                newName: "IX__1ABiology_GradesRef");

            migrationBuilder.CreateTable(
                name: "_1AGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1AGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1AGrades__1AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1BGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1BGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1BGrades__1BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_1CGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__1CGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__1CGrades__1CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_1CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2AGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2AGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2AGrades__2AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2BGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2BGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2BGrades__2BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_2CGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__2CGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__2CGrades__2CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_2CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3AGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3AGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3AGrades__3AStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3AStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3BGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3BGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3BGrades__3BStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3BStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "_3CGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentRef = table.Column<int>(type: "int", nullable: false),
                    BiologyAvarage = table.Column<double>(type: "float", nullable: false),
                    ChemistryAvarage = table.Column<double>(type: "float", nullable: false),
                    EnglishAvarage = table.Column<double>(type: "float", nullable: false),
                    GeographyAvarage = table.Column<double>(type: "float", nullable: false),
                    GermanAvarage = table.Column<double>(type: "float", nullable: false),
                    HistoryAvarage = table.Column<double>(type: "float", nullable: false),
                    MathAvarage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__3CGrades", x => x.Id);
                    table.ForeignKey(
                        name: "FK__3CGrades__3CStudents_StudentRef",
                        column: x => x.StudentRef,
                        principalTable: "_3CStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX__1AGrades_StudentRef",
                table: "_1AGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1BGrades_StudentRef",
                table: "_1BGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__1CGrades_StudentRef",
                table: "_1CGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2AGrades_StudentRef",
                table: "_2AGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2BGrades_StudentRef",
                table: "_2BGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__2CGrades_StudentRef",
                table: "_2CGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3AGrades_StudentRef",
                table: "_3AGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3BGrades_StudentRef",
                table: "_3BGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX__3CGrades_StudentRef",
                table: "_3CGrades",
                column: "StudentRef",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK__1ABiology__1AGrades_GradesRef",
                table: "_1ABiology",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AChemistry__1AGrades_GradesRef",
                table: "_1AChemistry",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AEnglish__1AGrades_GradesRef",
                table: "_1AEnglish",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AGeography__1AGrades_GradesRef",
                table: "_1AGeography",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AGerman__1AGrades_GradesRef",
                table: "_1AGerman",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AHistory__1AGrades_GradesRef",
                table: "_1AHistory",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1AMath__1AGrades_GradesRef",
                table: "_1AMath",
                column: "GradesRef",
                principalTable: "_1AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BBiology__1BGrades_GradesRef",
                table: "_1BBiology",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BChemistry__1BGrades_GradesRef",
                table: "_1BChemistry",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BEnglish__1BGrades_GradesRef",
                table: "_1BEnglish",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BGeography__1BGrades_GradesRef",
                table: "_1BGeography",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BGerman__1BGrades_GradesRef",
                table: "_1BGerman",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BHistory__1BGrades_GradesRef",
                table: "_1BHistory",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1BMath__1BGrades_GradesRef",
                table: "_1BMath",
                column: "GradesRef",
                principalTable: "_1BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CBiology__1CGrades_GradesRef",
                table: "_1CBiology",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CChemistry__1CGrades_GradesRef",
                table: "_1CChemistry",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CEnglish__1CGrades_GradesRef",
                table: "_1CEnglish",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CGeography__1CGrades_GradesRef",
                table: "_1CGeography",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CGerman__1CGrades_GradesRef",
                table: "_1CGerman",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CHistory__1CGrades_GradesRef",
                table: "_1CHistory",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__1CMath__1CGrades_GradesRef",
                table: "_1CMath",
                column: "GradesRef",
                principalTable: "_1CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2ABiology__2AGrades_GradesRef",
                table: "_2ABiology",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AChemistry__2AGrades_GradesRef",
                table: "_2AChemistry",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AEnglish__2AGrades_GradesRef",
                table: "_2AEnglish",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AGeography__2AGrades_GradesRef",
                table: "_2AGeography",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AGerman__2AGrades_GradesRef",
                table: "_2AGerman",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AHistory__2AGrades_GradesRef",
                table: "_2AHistory",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2AMath__2AGrades_GradesRef",
                table: "_2AMath",
                column: "GradesRef",
                principalTable: "_2AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BBiology__2BGrades_GradesRef",
                table: "_2BBiology",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BChemistry__2BGrades_GradesRef",
                table: "_2BChemistry",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BEnglish__2BGrades_GradesRef",
                table: "_2BEnglish",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BGeography__2BGrades_GradesRef",
                table: "_2BGeography",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BGerman__2BGrades_GradesRef",
                table: "_2BGerman",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BHistory__2BGrades_GradesRef",
                table: "_2BHistory",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2BMath__2BGrades_GradesRef",
                table: "_2BMath",
                column: "GradesRef",
                principalTable: "_2BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CBiology__2CGrades_GradesRef",
                table: "_2CBiology",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CChemistry__2CGrades_GradesRef",
                table: "_2CChemistry",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CEnglish__2CGrades_GradesRef",
                table: "_2CEnglish",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CGeography__2CGrades_GradesRef",
                table: "_2CGeography",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CGerman__2CGrades_GradesRef",
                table: "_2CGerman",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CHistory__2CGrades_GradesRef",
                table: "_2CHistory",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__2CMath__2CGrades_GradesRef",
                table: "_2CMath",
                column: "GradesRef",
                principalTable: "_2CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3ABiology__3AGrades_GradesRef",
                table: "_3ABiology",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AChemistry__3AGrades_GradesRef",
                table: "_3AChemistry",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AEnglish__3AGrades_GradesRef",
                table: "_3AEnglish",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AGeography__3AGrades_GradesRef",
                table: "_3AGeography",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AGerman__3AGrades_GradesRef",
                table: "_3AGerman",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AHistory__3AGrades_GradesRef",
                table: "_3AHistory",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3AMath__3AGrades_GradesRef",
                table: "_3AMath",
                column: "GradesRef",
                principalTable: "_3AGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BBiology__3BGrades_GradesRef",
                table: "_3BBiology",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BChemistry__3BGrades_GradesRef",
                table: "_3BChemistry",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BEnglish__3BGrades_GradesRef",
                table: "_3BEnglish",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BGeography__3BGrades_GradesRef",
                table: "_3BGeography",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BGerman__3BGrades_GradesRef",
                table: "_3BGerman",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BHistory__3BGrades_GradesRef",
                table: "_3BHistory",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3BMath__3BGrades_GradesRef",
                table: "_3BMath",
                column: "GradesRef",
                principalTable: "_3BGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CBiology__3CGrades_GradesRef",
                table: "_3CBiology",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CChemistry__3CGrades_GradesRef",
                table: "_3CChemistry",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CEnglish__3CGrades_GradesRef",
                table: "_3CEnglish",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CGeography__3CGrades_GradesRef",
                table: "_3CGeography",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CGerman__3CGrades_GradesRef",
                table: "_3CGerman",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CHistory__3CGrades_GradesRef",
                table: "_3CHistory",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__3CMath__3CGrades_GradesRef",
                table: "_3CMath",
                column: "GradesRef",
                principalTable: "_3CGrades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
