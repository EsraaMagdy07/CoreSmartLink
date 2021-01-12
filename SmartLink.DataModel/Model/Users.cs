using System;
using System.Collections.Generic;

namespace SmartLink.DataModel.Model
{
    public partial class Users
    {
        public Users()
        {
            ContactUsAdmins = new HashSet<ContactUsAdmins>();
            Content = new HashSet<Content>();
            ContentAdmins = new HashSet<ContentAdmins>();
            NewsLetter = new HashSet<NewsLetter>();
            ProvidersAdminsList = new HashSet<ProvidersAdminsList>();
            RegistrationAdmins = new HashSet<RegistrationAdmins>();
            StatusTransactions = new HashSet<StatusTransactions>();
            UserNewsLetterRel = new HashSet<UserNewsLetterRel>();
            UserNotificationRel = new HashSet<UserNotificationRel>();
            UserRole = new HashSet<UserRole>();
        }

        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public int TypeId { get; set; }
        public string Address { get; set; }
        public int UserStatus { get; set; }
        public DateTime? InsertionDateTime { get; set; }

        public virtual Providers Provider { get; set; }
        public virtual UserType Type { get; set; }
        public virtual Status UserStatusNavigation { get; set; }
        public virtual ICollection<ContactUsAdmins> ContactUsAdmins { get; set; }
        public virtual ICollection<Content> Content { get; set; }
        public virtual ICollection<ContentAdmins> ContentAdmins { get; set; }
        public virtual ICollection<NewsLetter> NewsLetter { get; set; }
        public virtual ICollection<ProvidersAdminsList> ProvidersAdminsList { get; set; }
        public virtual ICollection<RegistrationAdmins> RegistrationAdmins { get; set; }
        public virtual ICollection<StatusTransactions> StatusTransactions { get; set; }
        public virtual ICollection<UserNewsLetterRel> UserNewsLetterRel { get; set; }
        public virtual ICollection<UserNotificationRel> UserNotificationRel { get; set; }
        public virtual ICollection<UserRole> UserRole { get; set; }
    }
}
