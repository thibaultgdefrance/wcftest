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
    
    public partial class TypeEnvironnement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeEnvironnement()
        {
            this.Environnement = new HashSet<Environnement>();
            this.SpawnEnnemi = new HashSet<SpawnEnnemi>();
            this.TypeEnnemi = new HashSet<TypeEnnemi>();
        }
    
        public int idTypeEnvironnement { get; set; }
        public string nomTypeEnvironnement { get; set; }
        public byte solTypeEnvironnement { get; set; }
        public byte cielTypeEnvironnement { get; set; }
        public string model3DEnvironnement { get; set; }
        public Nullable<int> idAmbianceSonore { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Environnement> Environnement { get; set; }
        public virtual Music Music { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SpawnEnnemi> SpawnEnnemi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TypeEnnemi> TypeEnnemi { get; set; }
    }
}
