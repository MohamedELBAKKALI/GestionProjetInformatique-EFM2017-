namespace GestionProjetInformatique
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Developpeur")]
    public partial class Developpeur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Developpeur()
        {
            Tache = new HashSet<Tache>();
        }

        [Key]
        [StringLength(50)]
        public string cin { get; set; }

        [StringLength(50)]
        public string nom { get; set; }

        [StringLength(50)]
        public string prenom { get; set; }

        [StringLength(50)]
        public string poste { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tache> Tache { get; set; }
    }
}
