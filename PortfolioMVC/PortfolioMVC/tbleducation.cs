//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortfolioMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbleducation
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> eduStart { get; set; }
        public Nullable<System.DateTime> eduFinish { get; set; }
        public string eduName { get; set; }
        public string eduSchool { get; set; }
        public int portID { get; set; }
        public string eduAddress { get; set; }
    
        public virtual tblportfolio tblportfolio { get; set; }
    }
}
