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
    
    public partial class Cariler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cariler()
        {
            this.FaturaBilgi = new HashSet<FaturaBilgi>();
            this.UrunHareket = new HashSet<UrunHareket>();
            this.UrunKabul = new HashSet<UrunKabul>();
            this.UrunHareket1 = new HashSet<UrunHareket>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Adres { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Banka { get; set; }
        public string VergiAdresi { get; set; }
        public string VergiNo { get; set; }
        public string Statu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaBilgi> FaturaBilgi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunHareket> UrunHareket { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunKabul> UrunKabul { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunHareket> UrunHareket1 { get; set; }
    }
}
