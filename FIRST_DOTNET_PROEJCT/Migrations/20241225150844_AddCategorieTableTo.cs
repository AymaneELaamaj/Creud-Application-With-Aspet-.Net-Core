using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FIRST_DOTNET_PROEJCT.Migrations
{
    /// <inheritdoc />
    public partial class AddCategorieTableTo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdreAffichage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<int>(type: "int", nullable: false),
                    PrixProduit = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categorieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produits_Categories_categorieId",
                        column: x => x.categorieId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "OrdreAffichage" },
                values: new object[,]
                {
                    { 1, "Mobile", "1" },
                    { 2, "Ordinateur", "2" },
                    { 3, "Périphériques", "3" }
                });

            migrationBuilder.InsertData(
                table: "Produits",
                columns: new[] { "Id", "Code", "Description", "Name", "PrixProduit", "categorieId" },
                values: new object[,]
                {
                    { 1, 123456789, "iPhone 14 Pro. Avec un appareil photo principal de 48 MP pour capturer des détails époustouflants.DynamicIsland et l'écran toujours activé, qui offrent une toute nouvelle expérience sur iPhone", "Iphone 14", 10000, 1 },
                    { 2, 546456789, "Toutes les fonctions de base,désormais faciles à utiliser.Imprimez,numérisez et copiezles documents quotidiens,et profitez d’une connexion simple et sans fil", "Imprimante hp deskjet 2710", 5000, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produits_categorieId",
                table: "Produits",
                column: "categorieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produits");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
