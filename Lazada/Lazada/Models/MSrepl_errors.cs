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
    
    public partial class MSrepl_errors
    {
        public int id { get; set; }
        public System.DateTime time { get; set; }
        public Nullable<int> error_type_id { get; set; }
        public Nullable<int> source_type_id { get; set; }
        public string source_name { get; set; }
        public string error_code { get; set; }
        public string error_text { get; set; }
        public byte[] xact_seqno { get; set; }
        public Nullable<int> command_id { get; set; }
        public Nullable<int> session_id { get; set; }
    }
}