//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReceptorDL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmisorDeUsuario
    {
        public string EmisorDeUsuarioId { get; set; }
        public int UsuarioId { get; set; }
        public string EmisorRFC { get; set; }
    
        public virtual Usuario Usuario { get; set; }
        public virtual Emisor Emisor { get; set; }
    }
}