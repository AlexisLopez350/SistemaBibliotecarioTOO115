//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace blankspaces.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MATERIALBIBLIOGRAFICO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATERIALBIBLIOGRAFICO()
        {
            this.PRESTAMOes = new HashSet<PRESTAMO>();
        }
    
        public decimal IDMATBIBLIO { get; set; }
        public Nullable<decimal> IDLOCALIDAD { get; set; }
        public Nullable<decimal> IDCATEGORIA { get; set; }
        public Nullable<decimal> IDTIPO { get; set; }
        public string ID { get; set; }
        public Nullable<decimal> REL_IDAUTOR { get; set; }
        public string NOMBRE { get; set; }
        public string DESCRIPCION { get; set; }
        public string SINOPSIS { get; set; }
        public Nullable<System.DateTime> FECHA { get; set; }
        public Nullable<int> VOLUMEN { get; set; }
        public string UNIDADES { get; set; }
        public string EDITORIAL { get; set; }
        public string LENGUAJE { get; set; }
        public string FOTO { get; set; }
        public Nullable<int> IDAUTOR { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual DOCUMENTOLOCALIDAD DOCUMENTOLOCALIDAD { get; set; }
        public virtual TIPODOCUMENTO TIPODOCUMENTO { get; set; }
        public virtual RELATIONSHIP_15 RELATIONSHIP_15 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRESTAMO> PRESTAMOes { get; set; }
    }
}
