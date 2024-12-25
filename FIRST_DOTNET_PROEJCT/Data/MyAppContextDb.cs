using FIRST_DOTNET_PROEJCT.Models;
using Microsoft.EntityFrameworkCore;

namespace FIRST_DOTNET_PROEJCT.Data
{
    public class MyAppContextDb : DbContext
    {
        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Produit> Produits { get; set; }


        public MyAppContextDb(DbContextOptions<MyAppContextDb> options) :
        base(options)
        { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categorie>().HasData(
            new Categorie { Id = 1, Name = "Mobile", OrdreAffichage = "1" },
            new Categorie { Id = 2, Name = "Ordinateur", OrdreAffichage = "2" },
            new Categorie { Id = 3, Name = "Périphériques", OrdreAffichage = "3" }
            );
            modelBuilder.Entity<Produit>().HasData(
                new Produit
                {
                    Id = 1,
                    Name = "Iphone 14",
                    Description = "iPhone 14 Pro. Avec un appareil photo principal de 48 MP pour capturer des détails époustouflants.DynamicIsland et l'écran toujours activé, qui offrent une toute nouvelle expérience sur iPhone",
                    PrixProduit = 10000,
                    Code = 123456789,
                    categorieId = 1

                },
                new Produit
                {
                    Id = 2,
                    Name = "Imprimante hp deskjet 2710",
                    Description = "Toutes les fonctions de base,désormais faciles à utiliser.Imprimez,numérisez et copiezles documents quotidiens,et profitez d’une connexion simple et sans fil",
                    PrixProduit = 5000,
                    Code = 546456789,
                    categorieId = 2,

                }
            );

        }
    }
}
