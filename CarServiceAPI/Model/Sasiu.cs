//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarServiceAPI.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sasiu
    {
        public int SasiuId { get; private set; }
        public string CodSasiu { get; private set; }
        public string Denumire { get; private set; }

        public Sasiu()
        {
            // EF
        }

        public Sasiu(string codSasiu, string denumire)
        {
            CodSasiu = codSasiu ?? throw new ArgumentNullException(nameof(codSasiu));
            Denumire = denumire ?? throw new ArgumentNullException(nameof(denumire));
        }

        public override string ToString()
        {
            return Denumire;
        }
    }
}
