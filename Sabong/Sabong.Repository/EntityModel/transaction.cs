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
    
    public partial class transaction
    {
        public int id { get; set; }
        public int playerid { get; set; }
        public int matchno { get; set; }
        public float acceptedamount { get; set; }
        public float accepted_withodds { get; set; }
        public int betslno { get; set; }
        public float multiplier { get; set; }
        public string type { get; set; }
        public int currencytype { get; set; }
        public string cocktype { get; set; }
        public int cockid { get; set; }
        public string odds { get; set; }
        public System.DateTime date { get; set; }
        public int cancelstatus { get; set; }
        public double winloseamnt { get; set; }
        public System.DateTime time { get; set; }
        public string ip { get; set; }
        public string betstatus { get; set; }
        public bool betcomstat { get; set; }
        public float playerbcamt { get; set; }
        public int agentid { get; set; }
        public float agentbcamt { get; set; }
        public float agentbcper { get; set; }
        public float agentfbamt { get; set; }
        public float agentfbper { get; set; }
        public int masterid { get; set; }
        public float masterbcamt { get; set; }
        public float masterbcper { get; set; }
        public float masterfbamt { get; set; }
        public float masterfbper { get; set; }
        public int srmasterid { get; set; }
        public float srmasterbcamt { get; set; }
        public float srmasterbcper { get; set; }
        public float srmasterfbamt { get; set; }
        public float srmasterfbper { get; set; }
        public int houseid { get; set; }
        public float housebcamt { get; set; }
        public float housebcper { get; set; }
        public float housefbamt { get; set; }
        public float housefbper { get; set; }
        public float adminbcamt { get; set; }
        public float adminbcper { get; set; }
        public float adminfbamt { get; set; }
        public float adminfbper { get; set; }
        public int delflag { get; set; }
        public float agentbetcomm { get; set; }
        public float agentfb { get; set; }
        public float masterbetcomm { get; set; }
        public float masterfb { get; set; }
        public float srmasterbetcomm { get; set; }
        public float srmasterfb { get; set; }
        public float housebetcomm { get; set; }
        public float housefb { get; set; }
        public float adminbetcomm { get; set; }
        public float adminfb { get; set; }
        public double cb { get; set; }
    
        public virtual user user { get; set; }
    }
}
