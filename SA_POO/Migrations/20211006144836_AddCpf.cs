using Microsoft.EntityFrameworkCore.Migrations;

namespace SA_OOP.Migrations
{
    public partial class AddCpf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Convenio_ConvenioId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Procedimentos_ProcedimentoCodigo",
                table: "Paciente");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedimentoCodigo",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ConvenioId",
                table: "Paciente",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Paciente",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Medico",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Convenio_ConvenioId",
                table: "Paciente",
                column: "ConvenioId",
                principalTable: "Convenio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Procedimentos_ProcedimentoCodigo",
                table: "Paciente",
                column: "ProcedimentoCodigo",
                principalTable: "Procedimentos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Convenio_ConvenioId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Procedimentos_ProcedimentoCodigo",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Medico");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedimentoCodigo",
                table: "Paciente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ConvenioId",
                table: "Paciente",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Convenio_ConvenioId",
                table: "Paciente",
                column: "ConvenioId",
                principalTable: "Convenio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Procedimentos_ProcedimentoCodigo",
                table: "Paciente",
                column: "ProcedimentoCodigo",
                principalTable: "Procedimentos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
