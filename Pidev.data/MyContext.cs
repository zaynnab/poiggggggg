namespace Pidev.data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Solution.Data.CustomConvertions;
    using Pidev.data.Configuration;

    public partial class MyContext : DbContext
    {
        public MyContext()
            : base("name=MyContext")
        {
        }

        public virtual DbSet<account> account { get; set; }
        public virtual DbSet<expenses> expenses { get; set; }
        public virtual DbSet<formation> formation { get; set; }
        public virtual DbSet<formationcomment> formationcomment { get; set; }
        public virtual DbSet<formationnote> formationnote { get; set; }
        public virtual DbSet<frais> frais { get; set; }
        public virtual DbSet<mail> mail { get; set; }
        public virtual DbSet<mission> mission { get; set; }
        public virtual DbSet<user> user { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FraisConvention());
            modelBuilder.Entity<account>()
                      .HasMany(e => e.user)
                      .WithOptional(e => e.account)
                      .HasForeignKey(e => e.account_id);

         

            modelBuilder.Entity<expenses>()
                .Property(e => e.commentaire)
                .IsUnicode(false);


            modelBuilder.Entity<expenses>()
                .HasMany(e => e.frais)
                .WithOptional(e => e.expenses)
                .HasForeignKey(e => e.uneExp_id_Exp);

            modelBuilder.Entity<formation>()
                .Property(e => e.description_formation)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.duree_formation)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.niveau_formation)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .Property(e => e.nom_formation)
                .IsUnicode(false);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.formationcomment)
                .WithOptional(e => e.formation)
                .HasForeignKey(e => e.formation_id_formation);

            modelBuilder.Entity<formation>()
                .HasMany(e => e.formationnote)
                .WithOptional(e => e.formation)
                .HasForeignKey(e => e.formation_id_formation);

            modelBuilder.Entity<formationcomment>()
                .Property(e => e.contenu)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.header)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.mailAdresse)
                .IsUnicode(false);

            modelBuilder.Entity<mail>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.libelle)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.lieuMission)
                .IsUnicode(false);

            modelBuilder.Entity<mission>()
                .Property(e => e.motifMission)
                .IsUnicode(false);
          modelBuilder.Entity<expenses>().
                HasOptional(f => f.mission).
             WithMany(p => p.expenses).
             
             WillCascadeOnDelete(false);

            modelBuilder.Entity<mission>()
                .HasMany(e => e.expenses)
                .WithOptional(e => e.mission)
                .HasForeignKey(e => e.mm_id_mission);

            modelBuilder.Entity<mission>()
                .HasMany(e => e.user)
                .WithOptional(e => e.mission)
                .HasForeignKey(e => e.mis_id_mission);

            modelBuilder.Entity<user>()
                .Property(e => e.address_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.cin_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.nom_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.prenom_user)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.sexe)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.formationcomment)
                .WithOptional(e => e.user)
                .HasForeignKey(e => e.user_id_user);

            modelBuilder.Entity<user>()
                .HasMany(e => e.formation)
                .WithMany(e => e.user)
                .Map(m => m.ToTable("user_formation").MapLeftKey("users_id_user").MapRightKey("formations_id_formation"));
        }
    }
}
