//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emlakcilik.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ilan
    {
        public int IlanId { get; set; }
        public int IlanTipId { get; set; }
        public Nullable<int> Fiyat { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public int SehirId { get; set; }
        public int IlceId { get; set; }
        public int GayrimenkulId { get; set; }
    
        public virtual Gayrimenkul Gayrimenkul { get; set; }
        public virtual IlanTip IlanTip { get; set; }
        public virtual Ilce Ilce { get; set; }
        public virtual Sehir Sehir { get; set; }
    }
}
