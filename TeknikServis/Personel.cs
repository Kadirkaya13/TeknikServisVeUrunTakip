//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikServis
{
    using System;
    using System.Collections.Generic;
    
    public partial class Personel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personel()
        {
            this.FaturaBilgi = new HashSet<FaturaBilgi>();
            this.UrunHareket = new HashSet<UrunHareket>();
            this.UrunKabul = new HashSet<UrunKabul>();
        }
    
        public short Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Nullable<byte> Departman { get; set; }
        public string Fotograf { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
    
        public virtual Departman Departman1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaBilgi> FaturaBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunHareket> UrunHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunKabul> UrunKabul { get; set; }
    }
}
