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
    
    public partial class DeliveryMode
    {
        public DeliveryMode()
        {
            this.PackageInformations = new HashSet<PackageInformation>();
        }
    
        public int iddelmode { get; set; }
        public string delmode { get; set; }
    
        public virtual ICollection<PackageInformation> PackageInformations { get; set; }
    }
}
