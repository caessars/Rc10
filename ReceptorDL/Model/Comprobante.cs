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
    
    public partial class Comprobante
    {
        public double ComprobanteId { get; set; }
        public string EmisorRFC { get; set; }
        public string ReceptorRFC { get; set; }
        public string UUID { get; set; }
        public string Estatus { get; set; }
        public string SubTotal { get; set; }
        public string Impuestos { get; set; }
        public string Total { get; set; }
    
        public virtual Emisor Emisor { get; set; }
        public virtual Receptor Receptor { get; set; }
    }
}