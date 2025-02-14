//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService2.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Joueur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Joueur()
        {
            this.Aeronef = new HashSet<Aeronef>();
            this.Inventaire = new HashSet<Inventaire>();
            this.Messagerie = new HashSet<Messagerie>();
            this.ParametreJoueur = new HashSet<ParametreJoueur>();
            this.Partie = new HashSet<Partie>();
        }
    
        public int idJoueur { get; set; }
        public string pseudoJoueur { get; set; }
        public string emailJoueur { get; set; }
        public string pwdJoueur { get; set; }
        public int idNiveauJoueur { get; set; }
        public int idParametre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Aeronef> Aeronef { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventaire> Inventaire { get; set; }
        public virtual NiveauJoueur NiveauJoueur { get; set; }
        public virtual Parametre Parametre { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Messagerie> Messagerie { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParametreJoueur> ParametreJoueur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Partie> Partie { get; set; }
    }
}
