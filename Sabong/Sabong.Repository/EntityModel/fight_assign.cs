//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sabong.Repository.EntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class fight_assign
    {
        public int slno { get; set; }
        public string matchtype { get; set; }
        public int breeder_id { get; set; }
        public string breeder_name { get; set; }
        public int cock_id { get; set; }
        public string cock_name { get; set; }
        public int fightagainst_breeder_id { get; set; }
        public string fightagainst_breeder_name { get; set; }
        public int fightagainst_cock_id { get; set; }
        public string fightagainst_cock_name { get; set; }
        public string cock_type { get; set; }
        public string against_type { get; set; }
        public int match_no { get; set; }
        public string date { get; set; }
        public string hour { get; set; }
        public string minute { get; set; }
        public int matchstarttime { get; set; }
        public System.DateTime entry_date { get; set; }
        public int winner_cockid { get; set; }
        public int status { get; set; }
        public int knockout { get; set; }
        public int block { get; set; }
        public float block_warning_time { get; set; }
        public string block_warning_entry_time { get; set; }
        public string draw_odds { get; set; }
        public int addby { get; set; }
        public int cancelmatch { get; set; }
        public int arena { get; set; }
        public string handler_m { get; set; }
        public string graffer_m { get; set; }
        public string handler_w { get; set; }
        public string graffer_w { get; set; }
        public int match_order { get; set; }
        public string cancel_reason { get; set; }
        public System.DateTime updatetime { get; set; }
        public int del_flag { get; set; }
        public System.DateTime matchcreatetime { get; set; }
        public string winner { get; set; }
    }
}
