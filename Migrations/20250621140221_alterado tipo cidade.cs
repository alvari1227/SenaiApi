using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class alteradotipocidade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.AlterColumn<int>(
            // name: "Cidade",
            // table: "Endereço",
            //type: "integer",
            // maxLength: 60,
            // nullable: false,
            // oldClrType: typeof(string),
            // oldType: "character varying(60)",
            // oldMaxLength: 60);
            migrationBuilder.Sql(@"
               ALTER TABLE ""Endereco""
               ALTER COLUMN ""Cidade"" TYPE integer
               USING ""Cidade""::integer;
             ");


            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Nascimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Cpf = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    ClasseId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aluno_Classe_ClasseId",
                        column: x => x.ClasseId,
                        principalTable: "Classe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_ClasseId",
                table: "Aluno",
                column: "ClasseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.AlterColumn<string>(
                name: "Cidade",
                table: "Endereço",
                type: "character varying(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldMaxLength: 60);
        }
    }
}
