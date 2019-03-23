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
    using System.ComponentModel.DataAnnotations;
    
    public partial class Auto
    {
        public int AutoId { get; private set; }

        [RegularExpression(@"((\w){2}\s(\d){3}\s(\w){3})|((\w){2}(\d){8})")]
        public string NumarAuto { get; private set; }

        public string SerieSasiu { get; private set; }
        public int ClientClientId { get; private set; }
    
        public virtual Sasiu Sasiu { get; private set; }

        public Auto()
        {
            // EF
        }

        public Auto(string numarAuto, string serieSasiu, int clientClientId, Sasiu sasiu)
        {
            NumarAuto = numarAuto ?? throw new ArgumentNullException(nameof(numarAuto));
            SerieSasiu = serieSasiu ?? throw new ArgumentNullException(nameof(serieSasiu));
            ClientClientId = clientClientId;
            Sasiu = sasiu ?? throw new ArgumentNullException(nameof(sasiu));
        }
    }
}
