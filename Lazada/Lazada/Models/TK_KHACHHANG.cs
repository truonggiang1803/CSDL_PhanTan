//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lazada.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TK_KHACHHANG
    {
        public TK_KHACHHANG()
        {
            this.KHACHHANGs = new HashSet<KHACHHANG>();
        }
    
        public string MATK_KH { get; set; }
        public string TENTK_KH { get; set; }
        public string MK_KH { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }
    }
}
