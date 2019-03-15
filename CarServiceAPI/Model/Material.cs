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
    
    public partial class Material
    {
        public int MaterialId { get; private set; }
        public string Denumire { get; private set; }
        public decimal Cantitate { get; private set; }
        public decimal Pret { get; private set; }
        public System.DateTime DataAprovizionare { get; private set; }

        public Material()
        {
            // EF
        }

        public Material(string denumire, decimal cantitate, decimal pret, DateTime data)
        {
            Denumire = denumire ?? throw new ArgumentNullException(nameof(denumire));
            Cantitate = cantitate;
            Pret = pret;
            DataAprovizionare = data;
        }

        public override string ToString()
        {
            return Denumire;
        }
    }
}
