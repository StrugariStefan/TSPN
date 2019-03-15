//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace CarServiceAPI.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client(string nume, string prenume, string adresa, string localitate, string judet, string telefon, string email)
        {
            Autoes = new HashSet<Auto>();
            Nume = nume ?? throw new ArgumentNullException(nameof(nume));
            Prenume = prenume ?? throw new ArgumentNullException(nameof(prenume));
            Adresa = adresa ?? throw new ArgumentNullException(nameof(adresa));
            Localitate = localitate ?? throw new ArgumentNullException(nameof(localitate));
            Judet = judet ?? throw new ArgumentNullException(nameof(judet));
            Telefon = telefon ?? throw new ArgumentNullException(nameof(telefon));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public Client()
        {
            // EF
        }

        public int ClientId { get; private set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,15}$")]
        public string Nume { get; private set; }

        [RegularExpression(@"^[a-zA-Z''-'\s]{1,15}$")]
        public string Prenume { get; private set; }

        [RegularExpression(@"^[A-Za-z0-9]+(?:\s[A-Za-z0-9'_-]+)+$")]
        public string Adresa { get; private set; }

        public string Localitate { get; private set; }

        public string Judet { get; private set; }

        [RegularExpression(@"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}")]
        public string Telefon { get; private set; }

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")]
        public string Email { get; private set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auto> Autoes { get; private set; }

        public override string ToString()
        {
            return Nume + " " + Prenume;
        }
    }
}
