namespace GestionProjetInformatique
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Projet")]
    public partial class Projet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projet()
        {
            Tache = new HashSet<Tache>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int num_projet { get; set; }

        [StringLength(50)]
        public string nom_projet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_projet { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_fin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tache> Tache { get; set; }
    }
}
