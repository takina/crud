//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    
    public partial class fncConsultaPersonaPorId_Result
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<int> Id_Persona_Tipo { get; set; }
        public string Tipo_Descripcion { get; set; }
        public Nullable<byte> Id_Estatus { get; set; }
        public string Estatus_Descripcion { get; set; }
    }
}
