﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class DELIVERYDBEntities : DbContext
    {
        public DELIVERYDBEntities()
            : base("name=DELIVERYDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<DeliveryMode> DeliveryModes { get; set; }
        public DbSet<DeliveryStat> DeliveryStats { get; set; }
        public DbSet<PackageInformation> PackageInformations { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
    
        public virtual int DeletePackageInformation(Nullable<int> packid)
        {
            var packidParameter = packid.HasValue ?
                new ObjectParameter("packid", packid) :
                new ObjectParameter("packid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePackageInformation", packidParameter);
        }
    
        public virtual int InsertPackageInformation(Nullable<int> packid, string sname, string saddress, string scontact, string rname, string raddress, string rcontact, Nullable<int> iddelmode, Nullable<int> iddeliver)
        {
            var packidParameter = packid.HasValue ?
                new ObjectParameter("packid", packid) :
                new ObjectParameter("packid", typeof(int));
    
            var snameParameter = sname != null ?
                new ObjectParameter("sname", sname) :
                new ObjectParameter("sname", typeof(string));
    
            var saddressParameter = saddress != null ?
                new ObjectParameter("saddress", saddress) :
                new ObjectParameter("saddress", typeof(string));
    
            var scontactParameter = scontact != null ?
                new ObjectParameter("scontact", scontact) :
                new ObjectParameter("scontact", typeof(string));
    
            var rnameParameter = rname != null ?
                new ObjectParameter("rname", rname) :
                new ObjectParameter("rname", typeof(string));
    
            var raddressParameter = raddress != null ?
                new ObjectParameter("raddress", raddress) :
                new ObjectParameter("raddress", typeof(string));
    
            var rcontactParameter = rcontact != null ?
                new ObjectParameter("rcontact", rcontact) :
                new ObjectParameter("rcontact", typeof(string));
    
            var iddelmodeParameter = iddelmode.HasValue ?
                new ObjectParameter("iddelmode", iddelmode) :
                new ObjectParameter("iddelmode", typeof(int));
    
            var iddeliverParameter = iddeliver.HasValue ?
                new ObjectParameter("iddeliver", iddeliver) :
                new ObjectParameter("iddeliver", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertPackageInformation", packidParameter, snameParameter, saddressParameter, scontactParameter, rnameParameter, raddressParameter, rcontactParameter, iddelmodeParameter, iddeliverParameter);
        }
    
        public virtual ObjectResult<SearchAllPackageInformation_Result> SearchAllPackageInformation()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchAllPackageInformation_Result>("SearchAllPackageInformation");
        }
    
        public virtual ObjectResult<SearchPackageInformationByID_Result> SearchPackageInformationByID(Nullable<int> packid)
        {
            var packidParameter = packid.HasValue ?
                new ObjectParameter("packid", packid) :
                new ObjectParameter("packid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchPackageInformationByID_Result>("SearchPackageInformationByID", packidParameter);
        }
    
        public virtual ObjectResult<SearchPackageInformationByRName_Result> SearchPackageInformationByRName(string rname)
        {
            var rnameParameter = rname != null ?
                new ObjectParameter("rname", rname) :
                new ObjectParameter("rname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchPackageInformationByRName_Result>("SearchPackageInformationByRName", rnameParameter);
        }
    
        public virtual ObjectResult<SearchPackageInformationBySName_Result> SearchPackageInformationBySName(string sname)
        {
            var snameParameter = sname != null ?
                new ObjectParameter("sname", sname) :
                new ObjectParameter("sname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchPackageInformationBySName_Result>("SearchPackageInformationBySName", snameParameter);
        }
    
        public virtual ObjectResult<SearchPackageInformationBySName2_Result> SearchPackageInformationBySName2(string sname)
        {
            var snameParameter = sname != null ?
                new ObjectParameter("sname", sname) :
                new ObjectParameter("sname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchPackageInformationBySName2_Result>("SearchPackageInformationBySName2", snameParameter);
        }
    
        public virtual ObjectResult<SearchPackageInformationBySName3_Result> SearchPackageInformationBySName3(string sname)
        {
            var snameParameter = sname != null ?
                new ObjectParameter("sname", sname) :
                new ObjectParameter("sname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchPackageInformationBySName3_Result>("SearchPackageInformationBySName3", snameParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int UpdatePackageInformation(Nullable<int> packid, string sname, string saddress, string scontact, string rname, string raddress, string rcontact, Nullable<int> iddelmode, Nullable<int> iddeliver)
        {
            var packidParameter = packid.HasValue ?
                new ObjectParameter("packid", packid) :
                new ObjectParameter("packid", typeof(int));
    
            var snameParameter = sname != null ?
                new ObjectParameter("sname", sname) :
                new ObjectParameter("sname", typeof(string));
    
            var saddressParameter = saddress != null ?
                new ObjectParameter("saddress", saddress) :
                new ObjectParameter("saddress", typeof(string));
    
            var scontactParameter = scontact != null ?
                new ObjectParameter("scontact", scontact) :
                new ObjectParameter("scontact", typeof(string));
    
            var rnameParameter = rname != null ?
                new ObjectParameter("rname", rname) :
                new ObjectParameter("rname", typeof(string));
    
            var raddressParameter = raddress != null ?
                new ObjectParameter("raddress", raddress) :
                new ObjectParameter("raddress", typeof(string));
    
            var rcontactParameter = rcontact != null ?
                new ObjectParameter("rcontact", rcontact) :
                new ObjectParameter("rcontact", typeof(string));
    
            var iddelmodeParameter = iddelmode.HasValue ?
                new ObjectParameter("iddelmode", iddelmode) :
                new ObjectParameter("iddelmode", typeof(int));
    
            var iddeliverParameter = iddeliver.HasValue ?
                new ObjectParameter("iddeliver", iddeliver) :
                new ObjectParameter("iddeliver", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePackageInformation", packidParameter, snameParameter, saddressParameter, scontactParameter, rnameParameter, raddressParameter, rcontactParameter, iddelmodeParameter, iddeliverParameter);
        }
    }
}
