namespace GestionProjetInformatique
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGestiondesProjetsinformatique : DbContext
    {
        public ModelGestiondesProjetsinformatique()
            : base("name=ModelGestiondesProjetsinformatique")
        {
        }

        public virtual DbSet<Developpeur> Developpeur { get; set; }
        public virtual DbSet<Projet> Projet { get; set; }
        public virtual DbSet<Tache> Tache { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Developpeur>()
                .Property(e => e.cin)
                .IsUnicode(false);

            modelBuilder.Entity<Developpeur>()
                .Property(e => e.nom)
                .IsUnicode(false);

            modelBuilder.Entity<Developpeur>()
                .Property(e => e.prenom)
                .IsUnicode(false);

            modelBuilder.Entity<Developpeur>()
                .Property(e => e.poste)
                .IsUnicode(false);

            modelBuilder.Entity<Projet>()
                .Property(e => e.nom_projet)
                .IsUnicode(false);

            modelBuilder.Entity<Tache>()
                .Property(e => e.fonction)
                .IsUnicode(false);

            modelBuilder.Entity<Tache>()
                .Property(e => e.cin)
                .IsUnicode(false);
        }
    }
}
