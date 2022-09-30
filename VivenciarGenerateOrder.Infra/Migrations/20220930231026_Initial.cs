using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VivenciarGenerateOrder.Infra.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Professional",
                columns: table => new
                {
                    ProfessionalId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Phone = table.Column<string>(type: "TEXT", nullable: true),
                    Street = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Number = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    MoreIfo = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    City = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professional", x => x.ProfessionalId);
                });

            migrationBuilder.CreateTable(
                name: "Sponsor",
                columns: table => new
                {
                    SponsorId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Company = table.Column<bool>(type: "INTEGER", nullable: false),
                    NationalRegister = table.Column<string>(type: "VARCHAR(18)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(11)", nullable: true),
                    Street = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Number = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    MoreIfo = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    City = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Address_State = table.Column<int>(type: "INTEGER", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sponsor", x => x.SponsorId);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(type: "TEXT", nullable: false),
                    NationalRegister = table.Column<string>(type: "VARCHAR(11)", nullable: false),
                    Discharged = table.Column<bool>(type: "INTEGER", nullable: false),
                    SponsorId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ResponsiblePsychologistId = table.Column<Guid>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(11)", nullable: true),
                    Street = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Number = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    MoreIfo = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    City = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    State = table.Column<int>(type: "INTEGER", nullable: true),
                    ZipCode = table.Column<string>(type: "VARCHAR(9)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_Patient_Professional_ResponsiblePsychologistId",
                        column: x => x.ResponsiblePsychologistId,
                        principalTable: "Professional",
                        principalColumn: "ProfessionalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patient_Sponsor_SponsorId",
                        column: x => x.SponsorId,
                        principalTable: "Sponsor",
                        principalColumn: "SponsorId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patient_ResponsiblePsychologistId",
                table: "Patient",
                column: "ResponsiblePsychologistId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_SponsorId",
                table: "Patient",
                column: "SponsorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Professional");

            migrationBuilder.DropTable(
                name: "Sponsor");
        }
    }
}
