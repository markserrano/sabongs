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
    
    public partial class commission
    {
        public int slno { get; set; }
        public int agentid { get; set; }
        public int for_id { get; set; }
        public double bet_commission { get; set; }
        public float win_commission { get; set; }
        public int delflag { get; set; }
    }
}
