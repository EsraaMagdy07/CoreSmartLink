using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Login
    {
        public Login()
        {
            AccountManager = new HashSet<AccountManager>();
            LoginPerCountry = new HashSet<LoginPerCountry>();
            MonthlyHitsEstimated = new HashSet<MonthlyHitsEstimated>();
            Notification = new HashSet<Notification>();
            NotificationTemplate = new HashSet<NotificationTemplate>();
            ProvidersMuzicUp = new HashSet<ProvidersMuzicUp>();
            StatusTransactions = new HashSet<StatusTransactions>();
            UserNotificationRel = new HashSet<UserNotificationRel>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public byte? SendReport { get; set; }
        public string GroupName { get; set; }
        public string IsContactPerson { get; set; }
        public string DisplayName { get; set; }
        public int? UserPrivileges { get; set; }
        public bool? Status { get; set; }
        public bool? Rbtsupervisor { get; set; }
        public bool? Rbtfinancial { get; set; }
        public bool? Rbtdaily { get; set; }
        public bool? MuzicUpfirst { get; set; }
        public bool? MuzicUpsecond { get; set; }
        public bool? MuzicUpinvoicing { get; set; }
        public bool? IsAccounManager { get; set; }
        public string Phone { get; set; }

        public virtual ICollection<AccountManager> AccountManager { get; set; }
        public virtual ICollection<LoginPerCountry> LoginPerCountry { get; set; }
        public virtual ICollection<MonthlyHitsEstimated> MonthlyHitsEstimated { get; set; }
        public virtual ICollection<Notification> Notification { get; set; }
        public virtual ICollection<NotificationTemplate> NotificationTemplate { get; set; }
        public virtual ICollection<ProvidersMuzicUp> ProvidersMuzicUp { get; set; }
        public virtual ICollection<StatusTransactions> StatusTransactions { get; set; }
        public virtual ICollection<UserNotificationRel> UserNotificationRel { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
