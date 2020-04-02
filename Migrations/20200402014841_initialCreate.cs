using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Zoo.Place.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zoos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZooName = table.Column<string>(type: "ntext", maxLength: 30, nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zoos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimalClass",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClassName = table.Column<string>(type: "ntext", maxLength: 50, nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    AgeRange = table.Column<float>(nullable: false),
                    Information = table.Column<string>(nullable: true),
                    ZooId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalClass", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnimalClass_Zoos_ZooId",
                        column: x => x.ZooId,
                        principalTable: "Zoos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 20, nullable: true),
                    EnvironmentType = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    Area = table.Column<float>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    ZooId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cage_Zoos_ZooId",
                        column: x => x.ZooId,
                        principalTable: "Zoos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    zooId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitor_Zoos_zooId",
                        column: x => x.zooId,
                        principalTable: "Zoos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    AnimalClassId = table.Column<Guid>(nullable: true),
                    CageId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_AnimalClass_AnimalClassId",
                        column: x => x.AnimalClassId,
                        principalTable: "AnimalClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Animal_Cage_CageId",
                        column: x => x.CageId,
                        principalTable: "Cage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_AnimalClassId",
                table: "Animal",
                column: "AnimalClassId");

            migrationBuilder.CreateIndex(
                name: "IX_Animal_CageId",
                table: "Animal",
                column: "CageId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimalClass_ZooId",
                table: "AnimalClass",
                column: "ZooId");

            migrationBuilder.CreateIndex(
                name: "IX_Cage_ZooId",
                table: "Cage",
                column: "ZooId");

            migrationBuilder.CreateIndex(
                name: "IX_Visitor_zooId",
                table: "Visitor",
                column: "zooId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "AnimalClass");

            migrationBuilder.DropTable(
                name: "Cage");

            migrationBuilder.DropTable(
                name: "Zoos");
        }
    }
}
