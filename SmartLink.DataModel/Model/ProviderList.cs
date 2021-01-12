using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class ProviderList
    {
        public ProviderList()
        {
            AccountManager = new HashSet<AccountManager>();
            MonthlyHitsEstimated = new HashSet<MonthlyHitsEstimated>();
            PlatformsProvidersRel = new HashSet<PlatformsProvidersRel>();
            ProviderData = new HashSet<ProviderData>();
            ProvidersUploadedRbtNames = new HashSet<ProvidersUploadedRbtNames>();
            ProvidersUploadedRbtNamesHolded = new HashSet<ProvidersUploadedRbtNamesHolded>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LegalName { get; set; }
        public bool? IsDeleted { get; set; }
        public string ContractFilePath { get; set; }
        public int? DocId { get; set; }
        public int? ProviderContractId { get; set; }
        public DateTime? InsertionDate { get; set; }
        public DateTime? Modification { get; set; }
        public DateTime? PackageRunTime { get; set; }
        public bool? IsMuziCupContract { get; set; }
        public bool? PaidLocally { get; set; }
        public string CmsName { get; set; }
        public bool? IsArchived { get; set; }

        public virtual Providers ProviderContract { get; set; }
        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<MonthlyHitsEstimated> MonthlyHitsEstimated { get; set; }
        public virtual ICollection<PlatformsProvidersRel> PlatformsProvidersRel { get; set; }
        public virtual ICollection<ProviderData> ProviderData { get; set; }
        public virtual ICollection<ProvidersUploadedRbtNames> ProvidersUploadedRbtNames { get; set; }
        public virtual ICollection<ProvidersUploadedRbtNamesHolded> ProvidersUploadedRbtNamesHolded { get; set; }
    }
}
