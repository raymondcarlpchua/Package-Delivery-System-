//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFinalProj
{
    using System;
    using System.Collections.Generic;
    
    public partial class DeliveryStat
    {
        public DeliveryStat()
        {
            this.PackageInformations = new HashSet<PackageInformation>();
        }
    
        public int iddeliver { get; set; }
        public string deliver { get; set; }
    
        public virtual ICollection<PackageInformation> PackageInformations { get; set; }
    }
}
