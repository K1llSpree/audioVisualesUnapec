//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace audioVisuales
{
    using System;
    using System.Collections.Generic;
    
    public partial class Modelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelos()
        {
            this.Equipos = new HashSet<Equipos>();
        }
    
        public int ID { get; set; }
        public int IDMARCA { get; set; }
        public string Descripcion { get; set; }
        public string Estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipos> Equipos { get; set; }
        public virtual Marcas Marcas { get; set; }
    }
}
