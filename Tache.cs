namespace GestionProjetInformatique
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tache")]
    public partial class Tache
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int num_tache { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_Debut { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_Fin { get; set; }

        [StringLength(50)]
        public string fonction { get; set; }

        public int? num_projet { get; set; }

        [StringLength(50)]
        public string cin { get; set; }

        public virtual Developpeur Developpeur { get; set; }

        public virtual Projet Projet { get; set; }
    }
}
