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
    
    public partial class Emisor
    {
        public Emisor()
        {
            this.Comprobantes = new HashSet<Comprobante>();
            this.DireccionFiscal = new DireccionFiscal();
        }
    
        public string EmisorRFC { get; set; }
    
        public DireccionFiscal DireccionFiscal { get; set; }
    
        public virtual ICollection<Comprobante> Comprobantes { get; set; }
    }
}
