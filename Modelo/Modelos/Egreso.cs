//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelo.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Egreso
    {
        public long id { get; set; }
        public System.DateTime fecha { get; set; }
        public string tratamiento { get; set; }
        public decimal monto { get; set; }
        public bool borrado { get; set; }
        public Nullable<long> medicoId { get; set; }
        public Nullable<long> pacienteId { get; set; }
    
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
