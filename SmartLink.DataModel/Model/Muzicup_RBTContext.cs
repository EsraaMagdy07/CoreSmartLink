using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SmartLink.DataModel.Model
{
    public partial class Muzicup_RBTContext : DbContext
    {
        public Muzicup_RBTContext()
        {
        }

        public Muzicup_RBTContext(DbContextOptions<Muzicup_RBTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccessMatrix> AccessMatrix { get; set; }
        public virtual DbSet<AccountManager> AccountManager { get; set; }
        public virtual DbSet<AccountManagerMonthlyTarget> AccountManagerMonthlyTarget { get; set; }
        public virtual DbSet<Action> Action { get; set; }
        public virtual DbSet<AdancePayments> AdancePayments { get; set; }
        public virtual DbSet<AdvanceMonthlyPaymentsAlertingLogs> AdvanceMonthlyPaymentsAlertingLogs { get; set; }
        public virtual DbSet<AdvanceMonthlyPaymentsEmailsLogs> AdvanceMonthlyPaymentsEmailsLogs { get; set; }
        public virtual DbSet<AdvanceMonthlyPaymentsSmsLogs> AdvanceMonthlyPaymentsSmsLogs { get; set; }
        public virtual DbSet<AdvancePaymentsContracts> AdvancePaymentsContracts { get; set; }
        public virtual DbSet<AdvancePaymentsDocument> AdvancePaymentsDocument { get; set; }
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AlbumHyperLinks> AlbumHyperLinks { get; set; }
        public virtual DbSet<AlgeriaOnda> AlgeriaOnda { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<BankDetails> BankDetails { get; set; }
        public virtual DbSet<Catalog> Catalog { get; set; }
        public virtual DbSet<Channel> Channel { get; set; }
        public virtual DbSet<Channel1> Channel1 { get; set; }
        public virtual DbSet<ChannelTypes> ChannelTypes { get; set; }
        public virtual DbSet<CmsAlbum> CmsAlbum { get; set; }
        public virtual DbSet<CmsApiConverationSongList> CmsApiConverationSongList { get; set; }
        public virtual DbSet<CmsApiConversationArtistList> CmsApiConversationArtistList { get; set; }
        public virtual DbSet<CmsApiConversationProcessStep> CmsApiConversationProcessStep { get; set; }
        public virtual DbSet<CmsApiHandleMsg> CmsApiHandleMsg { get; set; }
        public virtual DbSet<CmsApiIngoing> CmsApiIngoing { get; set; }
        public virtual DbSet<CmsApiLog> CmsApiLog { get; set; }
        public virtual DbSet<CmsApiOutgoing> CmsApiOutgoing { get; set; }
        public virtual DbSet<CmsApiOutgoing2> CmsApiOutgoing2 { get; set; }
        public virtual DbSet<CmsApiOutgoing21> CmsApiOutgoing21 { get; set; }
        public virtual DbSet<CmsApiProcessSteps> CmsApiProcessSteps { get; set; }
        public virtual DbSet<CmsApiUserArtistList> CmsApiUserArtistList { get; set; }
        public virtual DbSet<CmsApiUserSongList> CmsApiUserSongList { get; set; }
        public virtual DbSet<CmsArtist> CmsArtist { get; set; }
        public virtual DbSet<CmsCatalog> CmsCatalog { get; set; }
        public virtual DbSet<CmsChannel> CmsChannel { get; set; }
        public virtual DbSet<CmsCmsApiOutgoing2> CmsCmsApiOutgoing2 { get; set; }
        public virtual DbSet<CmsContent> CmsContent { get; set; }
        public virtual DbSet<CmsContentTemp> CmsContentTemp { get; set; }
        public virtual DbSet<CmsContentType> CmsContentType { get; set; }
        public virtual DbSet<CmsExclusivity> CmsExclusivity { get; set; }
        public virtual DbSet<CmsFileData> CmsFileData { get; set; }
        public virtual DbSet<CmsImage> CmsImage { get; set; }
        public virtual DbSet<CmsIsrc> CmsIsrc { get; set; }
        public virtual DbSet<CmsOperator> CmsOperator { get; set; }
        public virtual DbSet<CmsProvider> CmsProvider { get; set; }
        public virtual DbSet<CmsProviderContantRel> CmsProviderContantRel { get; set; }
        public virtual DbSet<CmsProviderContentChannelRel> CmsProviderContentChannelRel { get; set; }
        public virtual DbSet<CmsProviderContentContentTypeRel> CmsProviderContentContentTypeRel { get; set; }
        public virtual DbSet<CmsProviderContentOperatorRel> CmsProviderContentOperatorRel { get; set; }
        public virtual DbSet<CmsProviderContentTerritoryRel> CmsProviderContentTerritoryRel { get; set; }
        public virtual DbSet<CmsSource> CmsSource { get; set; }
        public virtual DbSet<CmsTerritory> CmsTerritory { get; set; }
        public virtual DbSet<CmsTrack> CmsTrack { get; set; }
        public virtual DbSet<ColumnType> ColumnType { get; set; }
        public virtual DbSet<ContactUs> ContactUs { get; set; }
        public virtual DbSet<ContactUsAdmins> ContactUsAdmins { get; set; }
        public virtual DbSet<Content> Content { get; set; }
        public virtual DbSet<Content1> Content1 { get; set; }
        public virtual DbSet<ContentAdmins> ContentAdmins { get; set; }
        public virtual DbSet<ContentChannels> ContentChannels { get; set; }
        public virtual DbSet<ContentHyperLinks> ContentHyperLinks { get; set; }
        public virtual DbSet<ContentMissingData> ContentMissingData { get; set; }
        public virtual DbSet<ContentsData> ContentsData { get; set; }
        public virtual DbSet<ContractContentData> ContractContentData { get; set; }
        public virtual DbSet<ContractContentDataDaily> ContractContentDataDaily { get; set; }
        public virtual DbSet<ContractContentDataError> ContractContentDataError { get; set; }
        public virtual DbSet<ContractContentDataMonthly> ContractContentDataMonthly { get; set; }
        public virtual DbSet<ContractContentDataTemp> ContractContentDataTemp { get; set; }
        public virtual DbSet<ContractType> ContractType { get; set; }
        public virtual DbSet<Currencies> Currencies { get; set; }
        public virtual DbSet<CurrencyConverter> CurrencyConverter { get; set; }
        public virtual DbSet<CurrencyConverter1> CurrencyConverter1 { get; set; }
        public virtual DbSet<CurrencyConverterLog> CurrencyConverterLog { get; set; }
        public virtual DbSet<CurrencyinEgp> CurrencyinEgp { get; set; }
        public virtual DbSet<DailyHits> DailyHits { get; set; }
        public virtual DbSet<DailyHitsAutoRenewal> DailyHitsAutoRenewal { get; set; }
        public virtual DbSet<DailyHitsChannelMetaData> DailyHitsChannelMetaData { get; set; }
        public virtual DbSet<DailySummerization> DailySummerization { get; set; }
        public virtual DbSet<DailySummerizationLogs> DailySummerizationLogs { get; set; }
        public virtual DbSet<DailyTemplate> DailyTemplate { get; set; }
        public virtual DbSet<DailyTemplateColumns> DailyTemplateColumns { get; set; }
        public virtual DbSet<DataShifting> DataShifting { get; set; }
        public virtual DbSet<DataShiftingDetails> DataShiftingDetails { get; set; }
        public virtual DbSet<DocumentType> DocumentType { get; set; }
        public virtual DbSet<Documentation> Documentation { get; set; }
        public virtual DbSet<FileData> FileData { get; set; }
        public virtual DbSet<HuaweiRbthits> HuaweiRbthits { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<InvoiceStatus> InvoiceStatus { get; set; }
        public virtual DbSet<Invoices> Invoices { get; set; }
        public virtual DbSet<InvoicesDetails> InvoicesDetails { get; set; }
        public virtual DbSet<InvoicesEmailsLogs> InvoicesEmailsLogs { get; set; }
        public virtual DbSet<InvoicesSmsLogs> InvoicesSmsLogs { get; set; }
        public virtual DbSet<LogEvent> LogEvent { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<LoginPerCountry> LoginPerCountry { get; set; }
        public virtual DbSet<MetaDataBasicColumns> MetaDataBasicColumns { get; set; }
        public virtual DbSet<MetaDataTemplate> MetaDataTemplate { get; set; }
        public virtual DbSet<MonthlyHits> MonthlyHits { get; set; }
        public virtual DbSet<MonthlyHitsEstimated> MonthlyHitsEstimated { get; set; }
        public virtual DbSet<MonthlyHitsLogs> MonthlyHitsLogs { get; set; }
        public virtual DbSet<MonthlySummerization> MonthlySummerization { get; set; }
        public virtual DbSet<MonthlySummerizationLogs> MonthlySummerizationLogs { get; set; }
        public virtual DbSet<NewsLetter> NewsLetter { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscription { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<NotificationConfiguration> NotificationConfiguration { get; set; }
        public virtual DbSet<NotificationTemplate> NotificationTemplate { get; set; }
        public virtual DbSet<NotificationType> NotificationType { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<PaymentsDetails> PaymentsDetails { get; set; }
        public virtual DbSet<PaymentsTerm> PaymentsTerm { get; set; }
        public virtual DbSet<PlatformCollections> PlatformCollections { get; set; }
        public virtual DbSet<PlatformDailyRevUploaderLog> PlatformDailyRevUploaderLog { get; set; }
        public virtual DbSet<PlatformData> PlatformData { get; set; }
        public virtual DbSet<PlatformDistributor> PlatformDistributor { get; set; }
        public virtual DbSet<PlatformHitPrice> PlatformHitPrice { get; set; }
        public virtual DbSet<PlatformList> PlatformList { get; set; }
        public virtual DbSet<PlatformListDefaultValues> PlatformListDefaultValues { get; set; }
        public virtual DbSet<PlatformListNotification> PlatformListNotification { get; set; }
        public virtual DbSet<PlatformListNotificationLogs> PlatformListNotificationLogs { get; set; }
        public virtual DbSet<PlatformReportUploaderType> PlatformReportUploaderType { get; set; }
        public virtual DbSet<PlatformRevFileEmailConfiguration> PlatformRevFileEmailConfiguration { get; set; }
        public virtual DbSet<PlatformRevFileFtpConfiguration> PlatformRevFileFtpConfiguration { get; set; }
        public virtual DbSet<PlatformType> PlatformType { get; set; }
        public virtual DbSet<PlatformsOperatorsRel> PlatformsOperatorsRel { get; set; }
        public virtual DbSet<PlatformsProvidersRel> PlatformsProvidersRel { get; set; }
        public virtual DbSet<ProfitabilityReport> ProfitabilityReport { get; set; }
        public virtual DbSet<ProivdersOperatorsEstimatedRel> ProivdersOperatorsEstimatedRel { get; set; }
        public virtual DbSet<ProivdersOperatorsRel> ProivdersOperatorsRel { get; set; }
        public virtual DbSet<ProivdersOperatorsRelDeleted> ProivdersOperatorsRelDeleted { get; set; }
        public virtual DbSet<PromotionContents> PromotionContents { get; set; }
        public virtual DbSet<ProviderBalance> ProviderBalance { get; set; }
        public virtual DbSet<ProviderBalanceDetails> ProviderBalanceDetails { get; set; }
        public virtual DbSet<ProviderData> ProviderData { get; set; }
        public virtual DbSet<ProviderDataLogs> ProviderDataLogs { get; set; }
        public virtual DbSet<ProviderList> ProviderList { get; set; }
        public virtual DbSet<ProviderStatements> ProviderStatements { get; set; }
        public virtual DbSet<ProviderStatementsDetails> ProviderStatementsDetails { get; set; }
        public virtual DbSet<Providers> Providers { get; set; }
        public virtual DbSet<ProvidersAdminsList> ProvidersAdminsList { get; set; }
        public virtual DbSet<ProvidersMuzicUp> ProvidersMuzicUp { get; set; }
        public virtual DbSet<ProvidersUploadedRbtNames> ProvidersUploadedRbtNames { get; set; }
        public virtual DbSet<ProvidersUploadedRbtNamesHolded> ProvidersUploadedRbtNamesHolded { get; set; }
        public virtual DbSet<ProvidersUsers> ProvidersUsers { get; set; }
        public virtual DbSet<RbtApiActions> RbtApiActions { get; set; }
        public virtual DbSet<RbtApiActionsLog> RbtApiActionsLog { get; set; }
        public virtual DbSet<RbtCurrencies> RbtCurrencies { get; set; }
        public virtual DbSet<RbtEmailsDetails> RbtEmailsDetails { get; set; }
        public virtual DbSet<RbtEmailsRequestType> RbtEmailsRequestType { get; set; }
        public virtual DbSet<RbtOperators> RbtOperators { get; set; }
        public virtual DbSet<RegistrationAdmins> RegistrationAdmins { get; set; }
        public virtual DbSet<RegistrationStatus> RegistrationStatus { get; set; }
        public virtual DbSet<ReportAmTargets> ReportAmTargets { get; set; }
        public virtual DbSet<ReportAmTargetsCost> ReportAmTargetsCost { get; set; }
        public virtual DbSet<ReportAmTargetsCostTest> ReportAmTargetsCostTest { get; set; }
        public virtual DbSet<ReportAmTargetsTesting> ReportAmTargetsTesting { get; set; }
        public virtual DbSet<ReportT1Targets> ReportT1Targets { get; set; }
        public virtual DbSet<ReportT1TargetsCost> ReportT1TargetsCost { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<SiteAction> SiteAction { get; set; }
        public virtual DbSet<SiteControllers> SiteControllers { get; set; }
        public virtual DbSet<SitePermissions> SitePermissions { get; set; }
        public virtual DbSet<SiteRegion> SiteRegion { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<StatusTransactions> StatusTransactions { get; set; }
        public virtual DbSet<TempUploadingContents> TempUploadingContents { get; set; }
        public virtual DbSet<TempUploadingContents1> TempUploadingContents1 { get; set; }
        public virtual DbSet<TemplateColumnFilterValues> TemplateColumnFilterValues { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }
        public virtual DbSet<ThirdParty> ThirdParty { get; set; }
        public virtual DbSet<Track> Track { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<UploadingControlTable> UploadingControlTable { get; set; }
        public virtual DbSet<UploadingControlTable1> UploadingControlTable1 { get; set; }
        public virtual DbSet<UserAlbum> UserAlbum { get; set; }
        public virtual DbSet<UserArtist> UserArtist { get; set; }
        public virtual DbSet<UserContent> UserContent { get; set; }
        public virtual DbSet<UserImage> UserImage { get; set; }
        public virtual DbSet<UserNewsLetterRel> UserNewsLetterRel { get; set; }
        public virtual DbSet<UserNotificationRel> UserNotificationRel { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserTracks> UserTracks { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsrCategory> UsrCategory { get; set; }
        public virtual DbSet<YouTubeReportsEntertainment> YouTubeReportsEntertainment { get; set; }
        public virtual DbSet<YouTubeReportsMusic> YouTubeReportsMusic { get; set; }
        public virtual DbSet<YouTubeTemp> YouTubeTemp { get; set; }

        // Unable to generate entity type for table 'dbo.YouTube_Daily_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.YouTube_Monthly_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.YouTube_PAID_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.YouTubeReportsEntertainment_Test'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.ContentsData_TempWithNull'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.Advance_Payments_Document_Temp-Del'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.Advance_Payments_Contracts_Temp-Del'. Please see the warning messages.
        // Unable to generate entity type for table 'CMS.cmsChannelCategory'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ContentDataDuplicateTemp'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.Advance_Payments_Collections_Details'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.NotActivatedUsers'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Artist_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.Contract_Content_Data_Temp_Zain'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.YouTubeSheet'. Please see the warning messages.
        // Unable to generate entity type for table 'RBT.Advance_Payments_Collections'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AccountManager_User'. Please see the warning messages.
        // Unable to generate entity type for table 'FCR.CurrencyConverter_Temp'. Please see the warning messages.
        // Unable to generate entity type for table 'CMS.TempUploadingContents_Temp'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.2.10.119;Database=Muzicup_RBT;Trusted_Connection=False;User ID=SA;Password=MIS4APCG;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<AccessMatrix>(entity =>
            {
                entity.ToTable("Access_Matrix", "logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PermissionLevel).HasColumnName("Permission_Level");

                entity.Property(e => e.RegionFk).HasColumnName("Region_FK");

                entity.Property(e => e.UserFk).HasColumnName("User_FK");

                entity.HasOne(d => d.PermissionLevelNavigation)
                    .WithMany(p => p.AccessMatrix)
                    .HasForeignKey(d => d.PermissionLevel)
                    .HasConstraintName("FK_Access_Matrix_Site_Permissions");
            });

            modelBuilder.Entity<AccountManager>(entity =>
            {
                entity.ToTable("AccountManager", "RBT");

                entity.Property(e => e.AccountId).HasColumnName("Account_Id");

                entity.Property(e => e.BiMonthlyCalculation)
                    .HasColumnName("BI_Monthly_Calculation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractTypeId).HasColumnName("ContractType_Id");

                entity.Property(e => e.ProviderDataId).HasColumnName("ProviderData_Id");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_Id");

                entity.Property(e => e.ProviderListId).HasColumnName("ProviderList_Id");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_AccountManager_Login");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_AccountManager_PlatformType");

                entity.HasOne(d => d.ContractType)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.ContractTypeId)
                    .HasConstraintName("FK_AccountManager_ContractType");

                entity.HasOne(d => d.ProviderData)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.ProviderDataId)
                    .HasConstraintName("FK_AccountManager_Provider_Data");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_AccountManager_Providers");

                entity.HasOne(d => d.ProviderList)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.ProviderListId)
                    .HasConstraintName("FK_AccountManager_Provider_List");
            });

            modelBuilder.Entity<AccountManagerMonthlyTarget>(entity =>
            {
                entity.ToTable("AccountManager_Monthly_Target", "RBT");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_Id");

                entity.Property(e => e.GmTarget)
                    .HasColumnName("GM_Target")
                    .HasColumnType("decimal(30, 0)");

                entity.Property(e => e.RevTarget)
                    .HasColumnName("Rev_Target")
                    .HasColumnType("decimal(30, 0)");

                entity.HasOne(d => d.AccountManager)
                    .WithMany(p => p.AccountManagerMonthlyTarget)
                    .HasForeignKey(d => d.AccountManagerId)
                    .HasConstraintName("FK_AccountManager_Monthly_Target_AccountManager");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.AccountManagerMonthlyTarget)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_AccountManager_Monthly_Target_Currencies");
            });

            modelBuilder.Entity<Action>(entity =>
            {
                entity.ToTable("Action", "logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<AdancePayments>(entity =>
            {
                entity.ToTable("Adance_Payments", "RBT");

                entity.HasIndex(e => new { e.Date, e.ProviderDataId, e.Paid })
                    .HasName("NonClusteredIndex-20200113-151516");

                entity.HasIndex(e => new { e.Date, e.ProviderContractId, e.ProviderListId, e.ProviderDataId, e.Paid })
                    .HasName("FirstDate-20200210-123716");

                entity.HasIndex(e => new { e.Date, e.PlatformId, e.Amount, e.ProviderContractId, e.ProviderDataId, e.Paid })
                    .HasName("NonClusteredIndex-20200113-151637");

                entity.HasIndex(e => new { e.Date, e.ProviderContractId, e.ProviderListId, e.ProviderDataId, e.PlatformId, e.Amount, e.Paid })
                    .HasName("NonClusteredIndex-20200113-151333");

                entity.HasIndex(e => new { e.Date, e.ProviderContractId, e.ProviderListId, e.ProviderDataId, e.PlatformId, e.Rejected, e.Paid })
                    .HasName("NonClusteredIndex-20160316-005001");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowToModify).HasDefaultValueSql("((1))");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountLocal)
                    .HasColumnName("Amount_Local")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ContractShare).HasColumnName("Contract_Share");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime)
                    .HasColumnName("Modification_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidDateTime)
                    .HasColumnName("Paid_Date_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.Rejected).HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmountLocal)
                    .HasColumnName("Total_Amount_Local")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<AdvanceMonthlyPaymentsAlertingLogs>(entity =>
            {
                entity.ToTable("Advance_Monthly_Payments_Alerting_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(300);

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderLegalId).HasColumnName("Provider_Legal_ID");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("Send_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<AdvanceMonthlyPaymentsEmailsLogs>(entity =>
            {
                entity.ToTable("Advance_Monthly_Payments_Emails_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderLegalId).HasColumnName("Provider_Legal_ID");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("Send_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<AdvanceMonthlyPaymentsSmsLogs>(entity =>
            {
                entity.ToTable("Advance_Monthly_Payments_SMS_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProviderLegalId).HasColumnName("Provider_Legal_ID");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("Send_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StartingDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<AdvancePaymentsContracts>(entity =>
            {
                entity.ToTable("Advance_Payments_Contracts", "RBT");

                entity.HasIndex(e => new { e.ProviderContractId, e.ProviderListId, e.ProviderDataId, e.StartDate, e.EndDate, e.PaymentTypeId, e.Paid })
                    .HasName("NonClusteredIndex-20160316-005128");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdvancePaymentsDocumentId).HasColumnName("Advance_Payments_DocumentId");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountLocal)
                    .HasColumnName("Amount_Local")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AutoRenewal).HasDefaultValueSql("((0))");

                entity.Property(e => e.BeEndDate)
                    .HasColumnName("BE_End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.BreakEvenPoint).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractMonths).HasColumnName("Contract_Months");

                entity.Property(e => e.CurrencyIdLocal).HasColumnName("Currency_ID_Local");

                entity.Property(e => e.CurrencyRate)
                    .HasColumnName("Currency_Rate")
                    .HasColumnType("decimal(18, 10)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.GraceMonths).HasColumnName("Grace_Months");

                entity.Property(e => e.GraceMonthsBeforeBe)
                    .HasColumnName("Grace_Months_Before_BE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertionDatetime)
                    .HasColumnName("Insertion_Datetime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAutomated).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsExpired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsGrace).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDatetime)
                    .HasColumnName("Modification_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidActionDateTime)
                    .HasColumnName("Paid_Action_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaidDate)
                    .HasColumnName("Paid_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentType_ID");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderCurrencyId).HasColumnName("Provider_Currency_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<AdvancePaymentsDocument>(entity =>
            {
                entity.ToTable("Advance_Payments_Document", "RBT");

                entity.HasIndex(e => new { e.MonthDate, e.YearDate, e.ProviderContractId, e.DocumentDate, e.IsDeleted, e.ProviderListId, e.ProviderDataId })
                    .HasName("CP_Monthly_Payments-20160504-110147")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.DocumentDate).HasColumnType("date");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMuzicUpPayment)
                    .HasColumnName("IsMuzicUP_Payment")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDateTime)
                    .HasColumnName("Modification_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.UploadedDateTime)
                    .HasColumnName("Uploaded_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.ToTable("Album", "SmartLink");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(50);

                entity.Property(e => e.NameEn).HasMaxLength(50);

                entity.Property(e => e.RoutingName).HasMaxLength(50);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Album)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_Album_Artist");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Album)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Album_Image");
            });

            modelBuilder.Entity<AlbumHyperLinks>(entity =>
            {
                entity.ToTable("AlbumHyperLinks", "SmartLink");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Url).HasMaxLength(600);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumHyperLinks)
                    .HasForeignKey(d => d.AlbumId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlbumHyperLinks_Album");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.AlbumHyperLinks)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AlbumHyperLinks_Channel");
            });

            modelBuilder.Entity<AlgeriaOnda>(entity =>
            {
                entity.ToTable("Algeria_ONDA", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.Onda)
                    .HasColumnName("ONDA")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OndaBased)
                    .HasColumnName("ONDA_Based")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Artist>(entity =>
            {
                entity.ToTable("Artist", "SmartLink");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.RoutingName).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Artist)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Artist_Image");
            });

            modelBuilder.Entity<BankDetails>(entity =>
            {
                entity.ToTable("BankDetails", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasMaxLength(200);

                entity.Property(e => e.BeneficiaryAddress).HasMaxLength(200);

                entity.Property(e => e.BeneficiaryBankAddress).HasMaxLength(200);

                entity.Property(e => e.BeneficiaryBankName).HasMaxLength(200);

                entity.Property(e => e.BeneficiaryName).HasMaxLength(200);

                entity.Property(e => e.CountryFk).HasColumnName("CountryFK");

                entity.Property(e => e.Iban)
                    .HasColumnName("IBAN")
                    .HasMaxLength(200);

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderFk).HasColumnName("ProviderFK");

                entity.Property(e => e.SwiftCode).HasMaxLength(200);
            });

            modelBuilder.Entity<Catalog>(entity =>
            {
                entity.ToTable("Catalog", "SmartLink");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("Channel", "RBT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Channel1>(entity =>
            {
                entity.ToTable("Channel", "SmartLink");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LogoPath).HasMaxLength(600);

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.ChannelType)
                    .WithMany(p => p.Channel1)
                    .HasForeignKey(d => d.ChannelTypeId)
                    .HasConstraintName("FK_Channel_ChannelTypes");
            });

            modelBuilder.Entity<ChannelTypes>(entity =>
            {
                entity.ToTable("ChannelTypes", "SmartLink");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);
            });

            modelBuilder.Entity<CmsAlbum>(entity =>
            {
                entity.ToTable("cmsAlbum", "CMS");

                entity.Property(e => e.CmsArtistId).HasColumnName("cmsArtistId");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(800);

                entity.Property(e => e.NameEn).HasMaxLength(800);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.CmsArtist)
                    .WithMany(p => p.CmsAlbum)
                    .HasForeignKey(d => d.CmsArtistId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Album_Artist");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.CmsAlbum)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Album_Image");
            });

            modelBuilder.Entity<CmsApiConverationSongList>(entity =>
            {
                entity.ToTable("cmsApi_ConverationSongList", "CMS");

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OptionChoise).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.SongName).HasMaxLength(100);
            });

            modelBuilder.Entity<CmsApiConversationArtistList>(entity =>
            {
                entity.ToTable("cmsApi_ConversationArtistList", "CMS");

                entity.Property(e => e.ArtistName).HasMaxLength(100);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OptionChoise).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(100);
            });

            modelBuilder.Entity<CmsApiConversationProcessStep>(entity =>
            {
                entity.ToTable("cmsApi_ConversationProcessStep", "CMS");

                entity.Property(e => e.Number).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiHandleMsg>(entity =>
            {
                entity.ToTable("cmsApi_HandleMsg", "CMS");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.MsgDetails).HasMaxLength(100);

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiIngoing>(entity =>
            {
                entity.ToTable("cmsApi_Ingoing", "CMS");

                entity.Property(e => e.ArtistName).HasMaxLength(100);

                entity.Property(e => e.Channel).HasMaxLength(50);

                entity.Property(e => e.ContantType).HasMaxLength(50);

                entity.Property(e => e.FromName).HasMaxLength(100);

                entity.Property(e => e.FromNumber).HasMaxLength(50);

                entity.Property(e => e.InsertionDateTime).HasColumnType("datetime");

                entity.Property(e => e.MsgText).HasMaxLength(100);

                entity.Property(e => e.MsgTime).HasColumnType("datetime");

                entity.Property(e => e.MsgUrl).HasMaxLength(200);

                entity.Property(e => e.OptionChoice).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.SongName).HasMaxLength(100);

                entity.Property(e => e.ToNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiLog>(entity =>
            {
                entity.ToTable("cmsAPI_Log", "CMS");

                entity.Property(e => e.MsgLog).HasMaxLength(200);
            });

            modelBuilder.Entity<CmsApiOutgoing>(entity =>
            {
                entity.ToTable("cmsApi_Outgoing", "CMS");

                entity.Property(e => e.AllowedChannel).HasMaxLength(50);

                entity.Property(e => e.ContentMsg).HasMaxLength(3000);

                entity.Property(e => e.FromName).HasMaxLength(50);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.ToNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiOutgoing2>(entity =>
            {
                entity.ToTable("cmsApi_Outgoing2");

                entity.Property(e => e.AllowedChannel).HasMaxLength(50);

                entity.Property(e => e.ContentMsg).HasMaxLength(300);

                entity.Property(e => e.FromName).HasMaxLength(50);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.ToNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiOutgoing21>(entity =>
            {
                entity.ToTable("cmsApiOutgoing2", "CMS");

                entity.Property(e => e.AllowedChannel).HasMaxLength(50);

                entity.Property(e => e.ContentMsg).HasMaxLength(300);

                entity.Property(e => e.FromName).HasMaxLength(50);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.ToNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiProcessSteps>(entity =>
            {
                entity.ToTable("cmsApi_ProcessSteps", "CMS");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsApiUserArtistList>(entity =>
            {
                entity.ToTable("cmsApi_UserArtistList", "CMS");

                entity.Property(e => e.ArtistName).HasMaxLength(100);

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OptionChoise).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(100);
            });

            modelBuilder.Entity<CmsApiUserSongList>(entity =>
            {
                entity.ToTable("cmsApi_UserSongList", "CMS");

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.OptionChoise).HasMaxLength(50);

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.SongName).HasMaxLength(100);
            });

            modelBuilder.Entity<CmsArtist>(entity =>
            {
                entity.ToTable("cmsArtist", "CMS");

                entity.HasIndex(e => new { e.NameEn, e.NameAr })
                    .HasName("NonClusteredIndex-20191222-133139")
                    .IsUnique();

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(800);

                entity.Property(e => e.NameEn).HasMaxLength(800);

                entity.Property(e => e.NameEnDisplay).HasMaxLength(800);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.CmsArtist)
                    .HasForeignKey(d => d.ImageId)
                    .HasConstraintName("FK_Artist_Image");
            });

            modelBuilder.Entity<CmsCatalog>(entity =>
            {
                entity.ToTable("cmsCatalog", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsChannel>(entity =>
            {
                entity.ToTable("cmsChannel", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsCmsApiOutgoing2>(entity =>
            {
                entity.ToTable("CMS.cmsApi_Outgoing2");

                entity.Property(e => e.AllowedChannel).HasMaxLength(50);

                entity.Property(e => e.ContentMsg).HasMaxLength(250);

                entity.Property(e => e.FromName).HasMaxLength(50);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.ToNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<CmsContent>(entity =>
            {
                entity.ToTable("cmsContent", "CMS");

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.CmsExclusivityId).HasColumnName("cmsExclusivityId");

                entity.Property(e => e.CmsSourceId).HasColumnName("cmsSourceId");

                entity.Property(e => e.Composer).HasMaxLength(100);

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(200);

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(300);

                entity.Property(e => e.NameEn).HasMaxLength(300);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.CmsContent)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsContent_cmsArtist");

                entity.HasOne(d => d.CmsExclusivity)
                    .WithMany(p => p.CmsContent)
                    .HasForeignKey(d => d.CmsExclusivityId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsContent_cmsExclusivity");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.CmsContent)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsContent_cmsImage");
            });

            modelBuilder.Entity<CmsContentTemp>(entity =>
            {
                entity.ToTable("cmsContent_Temp", "CMS");

                entity.Property(e => e.CmsExclusivityId).HasColumnName("cmsExclusivityId");

                entity.Property(e => e.CmsSourceId).HasColumnName("cmsSourceId");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(200);

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.CmsContentTemp)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_cmsContent_cmsAlbum_Temp");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.CmsContentTemp)
                    .HasForeignKey(d => d.ArtistId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsContent_cmsArtist_Temp");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.CmsContentTemp)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_cmsContent_cmsCatalog_Temp");

                entity.HasOne(d => d.CmsExclusivity)
                    .WithMany(p => p.CmsContentTemp)
                    .HasForeignKey(d => d.CmsExclusivityId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_cmsContent_cmsExclusivity_Temp");
            });

            modelBuilder.Entity<CmsContentType>(entity =>
            {
                entity.ToTable("cmsContentType", "CMS");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmsExclusivity>(entity =>
            {
                entity.ToTable("cmsExclusivity", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(800);

                entity.Property(e => e.NameEn).HasMaxLength(800);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsFileData>(entity =>
            {
                entity.ToTable("cmsFileData", "CMS");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FilePath).HasMaxLength(600);

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeExt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsImage>(entity =>
            {
                entity.ToTable("cmsImage", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.FileData)
                    .WithMany(p => p.CmsImage)
                    .HasForeignKey(d => d.FileDataId)
                    .HasConstraintName("FK_Image_FileData");
            });

            modelBuilder.Entity<CmsIsrc>(entity =>
            {
                entity.ToTable("cmsISRC", "CMS");

                entity.HasIndex(e => e.Isrc)
                    .HasName("NonClusteredIndex-20181127-114359")
                    .IsUnique();

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CmsOperator>(entity =>
            {
                entity.ToTable("cmsOperator", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(800);

                entity.Property(e => e.NameEn).HasMaxLength(800);

                entity.Property(e => e.SheetMapper).HasMaxLength(800);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.CmsOperator)
                    .HasForeignKey(d => d.TerritoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Operator_Territory");
            });

            modelBuilder.Entity<CmsProvider>(entity =>
            {
                entity.ToTable("cmsProvider", "CMS");

                entity.HasIndex(e => e.NameAr)
                    .HasName("NonClusteredIndex-ArabicName");

                entity.HasIndex(e => e.NameEn)
                    .HasName("NonClusteredIndex-EnglishName-20181016-124454")
                    .IsUnique();

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(255);

                entity.Property(e => e.NameEn).HasMaxLength(255);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsProviderContantRel>(entity =>
            {
                entity.ToTable("cmsProviderContantRel", "CMS");

                entity.Property(e => e.CmsContentId).HasColumnName("cmsContentId");

                entity.Property(e => e.CmsProviderId).HasColumnName("cmsProviderId");

                entity.Property(e => e.DocFk).HasColumnName("Doc_FK");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.CmsContent)
                    .WithMany(p => p.CmsProviderContantRel)
                    .HasForeignKey(d => d.CmsContentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContantRel_cmsContent");

                entity.HasOne(d => d.CmsProvider)
                    .WithMany(p => p.CmsProviderContantRel)
                    .HasForeignKey(d => d.CmsProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContantRel_cmsProvider");
            });

            modelBuilder.Entity<CmsProviderContentChannelRel>(entity =>
            {
                entity.ToTable("cmsProviderContentChannelRel", "CMS");

                entity.HasIndex(e => new { e.Excluded, e.CmsProviderContentRelId, e.CmsChannelId })
                    .HasName("NonClusteredIndex-Channel-20181023-102642")
                    .IsUnique();

                entity.Property(e => e.CmsChannelId).HasColumnName("cmsChannelId");

                entity.Property(e => e.CmsProviderContentRelId).HasColumnName("cmsProviderContentRelId");

                entity.Property(e => e.Excluded).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.CmsChannel)
                    .WithMany(p => p.CmsProviderContentChannelRel)
                    .HasForeignKey(d => d.CmsChannelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentChannelRel_cmsChannel");

                entity.HasOne(d => d.CmsProviderContentRel)
                    .WithMany(p => p.CmsProviderContentChannelRel)
                    .HasForeignKey(d => d.CmsProviderContentRelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentChannelRel_cmsProviderContantRel");
            });

            modelBuilder.Entity<CmsProviderContentContentTypeRel>(entity =>
            {
                entity.ToTable("cmsProviderContentContentTypeRel", "CMS");

                entity.HasIndex(e => new { e.CmsProviderContentRelId, e.CmsContentTypeId })
                    .HasName("NonClusteredIndex-20181025-192618")
                    .IsUnique();

                entity.Property(e => e.CmsContentTypeId).HasColumnName("cmsContentTypeId");

                entity.Property(e => e.CmsProviderContentRelId).HasColumnName("cmsProviderContentRelId");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.CmsContentType)
                    .WithMany(p => p.CmsProviderContentContentTypeRel)
                    .HasForeignKey(d => d.CmsContentTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentContentTypeRel_cmsContentType");

                entity.HasOne(d => d.CmsProviderContentRel)
                    .WithMany(p => p.CmsProviderContentContentTypeRel)
                    .HasForeignKey(d => d.CmsProviderContentRelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentContentTypeRel_cmsProviderContantRel");
            });

            modelBuilder.Entity<CmsProviderContentOperatorRel>(entity =>
            {
                entity.ToTable("cmsProviderContentOperatorRel", "CMS");

                entity.HasIndex(e => new { e.Excluded, e.CmsProviderContentRelId, e.CmsOperatorId })
                    .HasName("NonClusteredIndex-Operators-20181023-103013")
                    .IsUnique();

                entity.Property(e => e.CmsOperatorId).HasColumnName("cmsOperatorId");

                entity.Property(e => e.CmsProviderContentRelId).HasColumnName("cmsProviderContentRelId");

                entity.Property(e => e.Excluded).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.CmsProviderContentRel)
                    .WithMany(p => p.CmsProviderContentOperatorRel)
                    .HasForeignKey(d => d.CmsProviderContentRelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentOperatorRel_cmsProviderContantRel");
            });

            modelBuilder.Entity<CmsProviderContentTerritoryRel>(entity =>
            {
                entity.ToTable("cmsProviderContentTerritoryRel", "CMS");

                entity.HasIndex(e => new { e.Excluded, e.CmsProviderContentRelId, e.CmsTerritoryId })
                    .HasName("NonClusteredIndex-Territories-20181023-103047")
                    .IsUnique();

                entity.Property(e => e.CmsProviderContentRelId).HasColumnName("cmsProviderContentRelId");

                entity.Property(e => e.CmsTerritoryId).HasColumnName("cmsTerritoryId");

                entity.Property(e => e.Excluded).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.CmsProviderContentRel)
                    .WithMany(p => p.CmsProviderContentTerritoryRel)
                    .HasForeignKey(d => d.CmsProviderContentRelId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentTerritoryRel_cmsProviderContantRel");

                entity.HasOne(d => d.CmsTerritory)
                    .WithMany(p => p.CmsProviderContentTerritoryRel)
                    .HasForeignKey(d => d.CmsTerritoryId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_cmsProviderContentTerritoryRel_cmsTerritory");
            });

            modelBuilder.Entity<CmsSource>(entity =>
            {
                entity.ToTable("cmsSource", "CMS");

                entity.Property(e => e.ContainArabicData).HasDefaultValueSql("((1))");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsTerritory>(entity =>
            {
                entity.ToTable("cmsTerritory", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<CmsTrack>(entity =>
            {
                entity.ToTable("cmsTrack", "CMS");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.FileData)
                    .WithMany(p => p.CmsTrack)
                    .HasForeignKey(d => d.FileDataId)
                    .HasConstraintName("FK_Track_FileData");
            });

            modelBuilder.Entity<ColumnType>(entity =>
            {
                entity.ToTable("ColumnType", "RBT");

                entity.Property(e => e.ColumnType1)
                    .IsRequired()
                    .HasColumnName("ColumnType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ContactUs>(entity =>
            {
                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ContactUsAdmins>(entity =>
            {
                entity.ToTable("ContactUsAdmins", "RBT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContactUsAdmins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ContactUsAdmins_Users");
            });

            modelBuilder.Entity<Content>(entity =>
            {
                entity.ToTable("Content", "RBT");

                entity.Property(e => e.AlbumName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ArtistName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AttachmentContentPath)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ContentName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UploadingDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Content)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Content_Users");
            });

            modelBuilder.Entity<Content1>(entity =>
            {
                entity.ToTable("Content", "SmartLink");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(200);

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.NameAr).HasMaxLength(100);

                entity.Property(e => e.NameEn).HasMaxLength(100);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.Content1)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_Content_Album");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.Content1)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_Content_Artist");

                entity.HasOne(d => d.Catalog)
                    .WithMany(p => p.Content1)
                    .HasForeignKey(d => d.CatalogId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Content_Catalog");

                entity.HasOne(d => d.Image)
                    .WithMany(p => p.Content1)
                    .HasForeignKey(d => d.ImageId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Content_Image");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.Content1)
                    .HasForeignKey(d => d.TrackId)
                    .HasConstraintName("FK_Content_Track");
            });

            modelBuilder.Entity<ContentAdmins>(entity =>
            {
                entity.ToTable("ContentAdmins", "RBT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ContentAdmins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ContentAdmins_Users");
            });

            modelBuilder.Entity<ContentChannels>(entity =>
            {
                entity.ToTable("ContentChannels", "RBT");

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ContentChannels)
                    .HasForeignKey(d => d.ChannelId)
                    .HasConstraintName("FK_ContentChannels_Channel");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentChannels)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_ContentChannels_Content");
            });

            modelBuilder.Entity<ContentHyperLinks>(entity =>
            {
                entity.ToTable("ContentHyperLinks", "SmartLink");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Url).HasMaxLength(600);

                entity.HasOne(d => d.Channel)
                    .WithMany(p => p.ContentHyperLinks)
                    .HasForeignKey(d => d.ChannelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentHyperLinks_Channel");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.ContentHyperLinks)
                    .HasForeignKey(d => d.ContentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContentHyperLinks_Content");
            });

            modelBuilder.Entity<ContentMissingData>(entity =>
            {
                entity.ToTable("ContentMissingData", "RBT");

                entity.HasIndex(e => new { e.PlatformListId, e.ToneCode, e.ToneName, e.ArtistName })
                    .HasName("NonClusteredIndex-20200407-183009")
                    .IsUnique();

                entity.Property(e => e.ArtistName).HasMaxLength(250);

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlatformListId).HasColumnName("Platform_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.ToneName).HasMaxLength(250);
            });

            modelBuilder.Entity<ContentsData>(entity =>
            {
                entity.ToTable("ContentsData", "RBT");

                entity.HasIndex(e => new { e.PlatformId, e.ToneCode, e.DocId })
                    .HasName("NonClusteredIndex-20200412-200214");

                entity.HasIndex(e => new { e.PlatformId, e.ToneName, e.ToneCode, e.DocId })
                    .HasName("NonClusteredIndex-20200505-133310");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AlbumName).HasMaxLength(255);

                entity.Property(e => e.AlbumNameAr).HasMaxLength(255);

                entity.Property(e => e.ArtistName).HasMaxLength(255);

                entity.Property(e => e.ArtistNameAr).HasMaxLength(255);

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.Cmscode)
                    .HasColumnName("CMSCode")
                    .HasMaxLength(100);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(50);

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.LiveCode)
                    .HasColumnName("Live_Code")
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.Price).HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderName).HasMaxLength(255);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusDate)
                    .HasColumnName("Status_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.ToneName).HasMaxLength(255);

                entity.Property(e => e.ToneNameAr).HasMaxLength(255);

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ContractContentData>(entity =>
            {
                entity.ToTable("Contract_Content_Data", "RBT");

                entity.HasIndex(e => new { e.PlatformId, e.ProviderId, e.HoldedProviderId, e.ToneCode, e.SongName, e.SingerName, e.DateDay, e.DateYear, e.DateMonth, e.IsDaily })
                    .HasName("NonClusteredIndex-20170909-094142");

                entity.HasIndex(e => new { e.DateYear, e.DateMonth, e.DateDay, e.ToneCode, e.SingerName, e.SongName, e.ProviderName, e.PlatformId, e.ProviderId, e.HoldedProviderId, e.IsDaily })
                    .HasName("NonClusteredIndex-HoldProviders");

                entity.HasIndex(e => new { e.DateYear, e.DateMonth, e.DateDay, e.PlatformId, e.SingerName, e.SongName, e.ToneCode, e.IsDaily, e.ProviderId, e.ProviderDataId, e.ProviderName, e.HoldedProviderId, e.UploadedProviderName })
                    .HasName("NonClusteredIndex-20170907-190204")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateDay)
                    .HasColumnName("Date_Day")
                    .HasColumnType("date");

                entity.Property(e => e.DateMonth).HasColumnName("Date_Month");

                entity.Property(e => e.DateYear).HasColumnName("Date_Year");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDaily).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ContractContentDataDaily>(entity =>
            {
                entity.ToTable("Contract_Content_Data_Daily", "RBT");

                entity.HasIndex(e => new { e.PlatformId, e.ProviderId, e.HoldedProviderId, e.ToneCode, e.SongName, e.SingerName, e.DateDay, e.DateYear, e.DateMonth })
                    .HasName("NonClusteredIndex-Daily-Query");

                entity.HasIndex(e => new { e.DateYear, e.DateMonth, e.DateDay, e.PlatformId, e.SingerName, e.SongName, e.ToneCode, e.ProviderId, e.ProviderDataId, e.ProviderName })
                    .HasName("NonClusteredIndex-20170924-155620")
                    .IsUnique();

                entity.HasIndex(e => new { e.DateYear, e.DateMonth, e.DateDay, e.ToneCode, e.SingerName, e.SongName, e.ProviderName, e.PlatformId, e.ProviderId, e.HoldedProviderId })
                    .HasName("NonClusteredIndex-HoldProviders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateDay)
                    .HasColumnName("Date_Day")
                    .HasColumnType("date");

                entity.Property(e => e.DateMonth).HasColumnName("Date_Month");

                entity.Property(e => e.DateYear).HasColumnName("Date_Year");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ContractContentDataError>(entity =>
            {
                entity.ToTable("Contract_Content_Data_Error", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateDay)
                    .HasColumnName("Date_Day")
                    .HasColumnType("date");

                entity.Property(e => e.DateMonth).HasColumnName("Date_Month");

                entity.Property(e => e.DateYear).HasColumnName("Date_Year");

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("Error_Code")
                    .IsUnicode(false);

                entity.Property(e => e.ErrorColumn)
                    .HasColumnName("Error_Column")
                    .IsUnicode(false);

                entity.Property(e => e.ErrorDesc)
                    .HasColumnName("Error_Desc")
                    .IsUnicode(false);

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDaily).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.NewRecord).HasDefaultValueSql("((1))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ContractContentDataMonthly>(entity =>
            {
                entity.ToTable("Contract_Content_Data_Monthly", "RBT");

                entity.HasIndex(e => new { e.PlatformId, e.ProviderId, e.HoldedProviderId, e.ToneCode, e.SongName, e.SingerName, e.DateYear, e.DateMonth })
                    .HasName("NonClusteredIndex-Query");

                entity.HasIndex(e => new { e.DateYear, e.DateMonth, e.PlatformId, e.SingerName, e.SongName, e.ToneCode, e.ProviderId, e.ProviderDataId, e.ProviderName })
                    .HasName("NonClusteredIndex-20170924-155115")
                    .IsUnique();

                entity.HasIndex(e => new { e.DateYear, e.DateMonth, e.ToneCode, e.SingerName, e.SongName, e.ProviderName, e.PlatformId, e.ProviderId, e.HoldedProviderId })
                    .HasName("NonClusteredIndex-HoldProviders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateMonth).HasColumnName("Date_Month");

                entity.Property(e => e.DateYear).HasColumnName("Date_Year");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ContractContentDataTemp>(entity =>
            {
                entity.ToTable("Contract_Content_Data_Temp", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateDay)
                    .HasColumnName("Date_Day")
                    .HasColumnType("date");

                entity.Property(e => e.DateMonth).HasColumnName("Date_Month");

                entity.Property(e => e.DateYear).HasColumnName("Date_Year");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDaily).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ContractType>(entity =>
            {
                entity.ToTable("ContractType", "RBT");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InsertationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurrencyConverter>(entity =>
            {
                entity.ToTable("CurrencyConverter", "FCR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BudgetRate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.CurrencyIdFrom).HasColumnName("CurrencyID_From");

                entity.Property(e => e.CurrencyIdTo).HasColumnName("CurrencyID_To");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.CurrencyIdFromNavigation)
                    .WithMany(p => p.CurrencyConverterCurrencyIdFromNavigation)
                    .HasForeignKey(d => d.CurrencyIdFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurrencyConverter_Currencies_From");

                entity.HasOne(d => d.CurrencyIdToNavigation)
                    .WithMany(p => p.CurrencyConverterCurrencyIdToNavigation)
                    .HasForeignKey(d => d.CurrencyIdTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurrencyConverter_Currencies_To");
            });

            modelBuilder.Entity<CurrencyConverter1>(entity =>
            {
                entity.ToTable("CurrencyConverter", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BudgetRate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.CurrencyIdFrom).HasColumnName("CurrencyID_From");

                entity.Property(e => e.CurrencyIdTo).HasColumnName("CurrencyID_To");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurrencyConverterLog>(entity =>
            {
                entity.ToTable("CurrencyConverter_Log", "FCR");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BudgetRate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.CurrencyIdFrom).HasColumnName("CurrencyID_From");

                entity.Property(e => e.CurrencyIdTo).HasColumnName("CurrencyID_To");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 10)");

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CurrencyinEgp>(entity =>
            {
                entity.HasKey(e => e.IdPk);

                entity.ToTable("CurrencyinEGP");

                entity.Property(e => e.IdPk).HasColumnName("ID_PK");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueinEgp)
                    .HasColumnName("valueinEGP")
                    .HasColumnType("decimal(18, 4)");
            });

            modelBuilder.Entity<DailyHits>(entity =>
            {
                entity.ToTable("Daily_Hits", "RBT");

                entity.HasIndex(e => new { e.DayDate, e.PlatformId, e.ProviderId, e.ProviderDataId })
                    .HasName("NonClusteredIndex-T1Report");

                entity.HasIndex(e => new { e.DayDate, e.PlatformId, e.ToneCode, e.SingerName, e.SongName })
                    .HasName("NonClusteredIndex-20160120-162854");

                entity.HasIndex(e => new { e.DayDate, e.PlatformId, e.ProviderDataId, e.RevenuePerHit, e.ProviderId, e.Paid })
                    .HasName("NonClusteredIndex-20210108-143449");

                entity.HasIndex(e => new { e.DayDate, e.PlatformId, e.ProviderId, e.ProviderDataId, e.RevenuePerHit, e.Paid })
                    .HasName("NonClusteredIndex-20210108-143223");

                entity.HasIndex(e => new { e.DayDate, e.PlatformId, e.ProviderId, e.ProviderDataId, e.ProviderName, e.ToneCode, e.SingerName, e.SongName, e.UploadedProviderName, e.HoldedProviderId, e.LocalContent, e.IsArabic, e.Released, e.Paid })
                    .HasName("NonClusteredIndex-20151220-184604");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDescription)
                    .HasColumnName("Action_Description")
                    .HasMaxLength(300);

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.DayDate)
                    .HasColumnName("Day_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArabic).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAutomatedDefinition).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocalContent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthlySync).HasColumnName("Monthly_Sync");

                entity.Property(e => e.MonthlySyncDate)
                    .HasColumnName("Monthly_Sync_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NeedAction).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoTrx).HasColumnName("no_trx");

                entity.Property(e => e.OldHoldProviderId).HasColumnName("Old_Hold_Provider_ID");

                entity.Property(e => e.OldProivderDataId).HasColumnName("Old_Proivder_Data_ID");

                entity.Property(e => e.OldProviderId).HasColumnName("Old_Provider_ID");

                entity.Property(e => e.OldProviderName)
                    .HasColumnName("Old_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.OldUploadedProviderName)
                    .HasColumnName("Old_Uploaded_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PostPaidRevenue)
                    .HasColumnName("PostPaid_Revenue")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrePaidRevenue)
                    .HasColumnName("PrePaid_Revenue")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PricePerHit)
                    .HasColumnName("Price_Per_Hit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderInfo)
                    .HasColumnName("Provider_Info")
                    .HasMaxLength(250);

                entity.Property(e => e.ProviderInfoDate)
                    .HasColumnName("Provider_Info_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Released).HasDefaultValueSql("((0))");

                entity.Property(e => e.RenewalIncome)
                    .HasColumnName("Renewal_Income")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RenewalTimes)
                    .HasColumnName("Renewal_Times")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenuePerHit)
                    .HasColumnName("Revenue_Per_Hit")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.UploadedRevenue)
                    .HasColumnName("Uploaded_Revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<DailyHitsAutoRenewal>(entity =>
            {
                entity.ToTable("Daily_Hits_AutoRenewal", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDescription)
                    .HasColumnName("Action_Description")
                    .HasMaxLength(300);

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.DayDate)
                    .HasColumnName("Day_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArabic).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocalContent).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.NeedAction).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoTrx).HasColumnName("no_trx");

                entity.Property(e => e.OldHoldProviderId).HasColumnName("Old_Hold_Provider_ID");

                entity.Property(e => e.OldProivderDataId).HasColumnName("Old_Proivder_Data_ID");

                entity.Property(e => e.OldProviderId).HasColumnName("Old_Provider_ID");

                entity.Property(e => e.OldProviderName)
                    .HasColumnName("Old_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.OldUploadedProviderName)
                    .HasColumnName("Old_Uploaded_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PostPaidRevenue)
                    .HasColumnName("PostPaid_Revenue")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrePaidRevenue)
                    .HasColumnName("PrePaid_Revenue")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PricePerHit)
                    .HasColumnName("Price_Per_Hit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderInfo)
                    .HasColumnName("Provider_Info")
                    .HasMaxLength(250);

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Released).HasDefaultValueSql("((0))");

                entity.Property(e => e.RenewalIncome)
                    .HasColumnName("Renewal_Income")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RenewalTimes)
                    .HasColumnName("Renewal_Times")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenuePerHit)
                    .HasColumnName("Revenue_Per_Hit")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.UploadedRevenue)
                    .HasColumnName("Uploaded_Revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<DailyHitsChannelMetaData>(entity =>
            {
                entity.ToTable("Daily_Hits_Channel_MetaData", "RBT");

                entity.Property(e => e.AssetType)
                    .HasColumnName("Asset_type")
                    .HasMaxLength(100);

                entity.Property(e => e.AverageViewMinutes)
                    .HasColumnName("Average_view_minutes")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Comments).HasMaxLength(100);

                entity.Property(e => e.DailyHitsId).HasColumnName("Daily_HitsId");

                entity.Property(e => e.DayDate)
                    .HasColumnName("Day_Date")
                    .HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.Shares).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToneCode).HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.VideosInPlaylists).HasColumnName("Videos_in_playlists");

                entity.Property(e => e.WatchTimeMinutes).HasColumnName("Watch_time_minutes");

                entity.HasOne(d => d.DailyHits)
                    .WithMany(p => p.DailyHitsChannelMetaData)
                    .HasForeignKey(d => d.DailyHitsId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Daily_Hits_Channel_MetaData_Daily_Hits");
            });

            modelBuilder.Entity<DailySummerization>(entity =>
            {
                entity.ToTable("Daily_Summerization", "RBT");

                entity.HasIndex(e => new { e.DayDate, e.Cost, e.ProviderId, e.PlatformId })
                    .HasName("NonClusteredIndex-20180624-155345");

                entity.HasIndex(e => new { e.DayDate, e.TotalRevenue, e.ProviderId, e.PlatformId })
                    .HasName("NonClusteredIndex-Proftability-01");

                entity.HasIndex(e => new { e.ProviderId, e.DayDate, e.CountryId, e.PlatformId })
                    .HasName("NonClusteredIndex-20160120-163014");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.DayDate)
                    .HasColumnName("Day_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HoldCost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InsertedDateTime)
                    .HasColumnName("Inserted_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PlatformName)
                    .HasColumnName("Platform_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RevenueShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.DailySummerization)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Daily_Summerization_Platform_List");
            });

            modelBuilder.Entity<DailySummerizationLogs>(entity =>
            {
                entity.ToTable("Daily_Summerization_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.DayDate)
                    .HasColumnName("Day_Date")
                    .HasColumnType("date");

                entity.Property(e => e.DeletedDateTime)
                    .HasColumnName("Deleted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoldCost)
                    .HasColumnName("Hold_Cost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Modified).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PlatformName)
                    .HasColumnName("Platform_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RevenueShare)
                    .HasColumnName("Revenue_Share")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DailyTemplate>(entity =>
            {
                entity.ToTable("Daily_Template", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PlatformNameInExcel)
                    .HasColumnName("Platform_Name_In_Excel")
                    .HasMaxLength(200);

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.DailyTemplate)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Daily_Template_Platform_List");
            });

            modelBuilder.Entity<DailyTemplateColumns>(entity =>
            {
                entity.ToTable("Daily_Template_Columns", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsCalculated).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMandatory).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TemplateId).HasColumnName("Template_ID");

                entity.HasOne(d => d.ColumnType)
                    .WithMany(p => p.DailyTemplateColumns)
                    .HasForeignKey(d => d.ColumnTypeId)
                    .HasConstraintName("FK_Daily_Template_Columns_ColumnType");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.DailyTemplateColumns)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_Daily_Template_Columns_Daily_Template");
            });

            modelBuilder.Entity<DataShifting>(entity =>
            {
                entity.ToTable("DataShifting", "RBT");

                entity.Property(e => e.ApproveStatus)
                    .HasColumnName("Approve_Status")
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedDatetime).HasColumnType("datetime");

                entity.Property(e => e.Comment).HasMaxLength(2000);

                entity.Property(e => e.InsertionDatetime).HasColumnType("datetime");

                entity.Property(e => e.ShiftingDateTime).HasColumnType("datetime");

                entity.Property(e => e.SuperUserId).HasColumnName("SuperUser_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");
            });

            modelBuilder.Entity<DataShiftingDetails>(entity =>
            {
                entity.ToTable("Data_Shifting_Details", "RBT");

                entity.Property(e => e.ArtistName).HasMaxLength(250);

                entity.Property(e => e.MonthDate).HasColumnType("date");

                entity.Property(e => e.OperatorName).HasMaxLength(50);

                entity.Property(e => e.SongName).HasMaxLength(250);

                entity.Property(e => e.ToneCode).HasMaxLength(250);
            });

            modelBuilder.Entity<DocumentType>(entity =>
            {
                entity.ToTable("Document_Type", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<Documentation>(entity =>
            {
                entity.ToTable("Documentation", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DeletedDateTime)
                    .HasColumnName("Deleted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocType)
                    .HasColumnName("Doc_Type")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FileName)
                    .HasColumnName("File_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FilePath)
                    .HasColumnName("File_Path")
                    .HasMaxLength(4000);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.ParentDocId).HasColumnName("Parent_Doc_ID");

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("Serial_Number")
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.ParentDoc)
                    .WithMany(p => p.Documentation)
                    .HasForeignKey(d => d.ParentDocId)
                    .HasConstraintName("FK_Documentation_Document_Type");
            });

            modelBuilder.Entity<FileData>(entity =>
            {
                entity.ToTable("FileData", "SmartLink");

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.FilePath).HasMaxLength(600);

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.TypeExt)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");
            });

            modelBuilder.Entity<HuaweiRbthits>(entity =>
            {
                entity.ToTable("HuaweiRBTHits", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cpname)
                    .HasColumnName("CPName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EditingDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RbthitsTotal).HasColumnName("RBTHitsTotal");

                entity.Property(e => e.RbthitsTotalFee).HasColumnName("RBTHitsTotalFee");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image", "SmartLink");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.FileData)
                    .WithMany(p => p.Image)
                    .HasForeignKey(d => d.FileDataId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Image_FileData");
            });

            modelBuilder.Entity<InvoiceStatus>(entity =>
            {
                entity.ToTable("Invoice_Status", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Invoices>(entity =>
            {
                entity.ToTable("Invoices", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId)
                    .HasColumnName("Branch_ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CpNumber)
                    .HasColumnName("CP_Number")
                    .HasMaxLength(200);

                entity.Property(e => e.CurrecnyId).HasColumnName("Currecny_ID");

                entity.Property(e => e.DeletedDateTime)
                    .HasColumnName("Deleted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.InvoiceDocId).HasColumnName("Invoice_Doc_ID");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("Issue_Date")
                    .HasColumnType("date");

                entity.Property(e => e.IssueMonth).HasColumnName("Issue_Month");

                entity.Property(e => e.IssueYear).HasColumnName("Issue_Year");

                entity.Property(e => e.ModifiedByCp)
                    .HasColumnName("Modified_By_CP")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUser)
                    .HasColumnName("Modified_By_User")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime)
                    .HasColumnName("Modify_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.Remarks).HasMaxLength(2000);

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_ID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.TotalAdvance)
                    .HasColumnName("Total_Advance")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UploadDateTime)
                    .HasColumnName("Upload_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Invoices_Invoice_Status");
            });

            modelBuilder.Entity<InvoicesDetails>(entity =>
            {
                entity.ToTable("Invoices_Details", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DateMonth).HasColumnName("Date_Month");

                entity.Property(e => e.DateYear).HasColumnName("Date_Year");

                entity.Property(e => e.DetetedDateTime)
                    .HasColumnName("Deteted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceId).HasColumnName("Invoice_ID");

                entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedByCp)
                    .HasColumnName("Modified_By_CP")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifiedByUser)
                    .HasColumnName("Modified_By_User")
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyDateTime)
                    .HasColumnName("Modify_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.StatusId)
                    .HasColumnName("Status_ID")
                    .HasDefaultValueSql("((4))");

                entity.Property(e => e.TotalAdvanceAmount)
                    .HasColumnName("Total_Advance_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRemainAmount)
                    .HasColumnName("Total_Remain_Amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.InvoicesDetails)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Invoices_Details_Invoices");
            });

            modelBuilder.Entity<InvoicesEmailsLogs>(entity =>
            {
                entity.ToTable("Invoices_Emails_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderLegalId).HasColumnName("Provider_Legal_ID");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("Send_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<InvoicesSmsLogs>(entity =>
            {
                entity.ToTable("Invoices_SMS_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.PhoneNumber).HasMaxLength(50);

                entity.Property(e => e.ProviderLegalId).HasColumnName("Provider_Legal_ID");

                entity.Property(e => e.SendDateTime)
                    .HasColumnName("Send_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("Status_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<LogEvent>(entity =>
            {
                entity.ToTable("LogEvent", "logs");

                entity.Property(e => e.Level).HasMaxLength(100);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogDescription).HasMaxLength(1000);

                entity.HasOne(d => d.Action)
                    .WithMany(p => p.LogEvent)
                    .HasForeignKey(d => d.ActionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LogEvent_SiteAction");
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Login_1")
                    .ForSqlServerIsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("PK_Login")
                    .ForSqlServerIsClustered();

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsAccounManager).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsContactPerson)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MuzicUpfirst)
                    .HasColumnName("MuzicUPFirst")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MuzicUpinvoicing)
                    .HasColumnName("MuzicUPInvoicing")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MuzicUpsecond)
                    .HasColumnName("MuzicUPSecond")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Rbtdaily)
                    .HasColumnName("RBTDaily")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbtfinancial)
                    .HasColumnName("RBTFinancial")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Rbtsupervisor)
                    .HasColumnName("RBTSupervisor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasDefaultValueSql("((1))");

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<LoginPerCountry>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.LoginPerCountry)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_LoginPerCountry_Territory");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.LoginPerCountry)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK_LoginPerCountry_Login");
            });

            modelBuilder.Entity<MetaDataBasicColumns>(entity =>
            {
                entity.ToTable("MetaData_Basic_Columns", "RBT");

                entity.Property(e => e.ColumnName).HasMaxLength(100);
            });

            modelBuilder.Entity<MetaDataTemplate>(entity =>
            {
                entity.ToTable("MetaData_Template", "RBT");

                entity.Property(e => e.ColumnName).HasMaxLength(100);

                entity.Property(e => e.FilteredValue).HasMaxLength(100);

                entity.HasOne(d => d.BasicColumn)
                    .WithMany(p => p.MetaDataTemplate)
                    .HasForeignKey(d => d.BasicColumnId)
                    .HasConstraintName("FK_MetaData_Template_MetaData_Basic_Columns");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.MetaDataTemplate)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_MetaData_Template_Platform_List");
            });

            modelBuilder.Entity<MonthlyHits>(entity =>
            {
                entity.ToTable("Monthly_Hits", "RBT");

                entity.HasIndex(e => new { e.YearDate, e.MonthDate, e.PlatformId, e.ProviderId, e.ProviderDataId })
                    .HasName("NonClusteredIndex-T1Report");

                entity.HasIndex(e => new { e.YearDate, e.MonthDate, e.PlatformId, e.ToneCode, e.SongName })
                    .HasName("NonClusteredIndex-20160120-123116");

                entity.HasIndex(e => new { e.YearDate, e.MonthDate, e.PlatformId, e.ProviderId, e.ProviderDataId, e.ProviderName, e.ToneCode, e.SingerName, e.SongName, e.UploadedProviderName, e.HoldedProviderId })
                    .HasName("NonClusteredIndex-20131028-114207");

                entity.HasIndex(e => new { e.YearDate, e.MonthDate, e.ProviderId, e.ProviderDataId, e.ProviderName, e.ToneCode, e.SingerName, e.SongName, e.RevenuePerHit, e.UserId, e.ModificationDateTime, e.UploadedProviderName, e.ProviderInfo, e.PlatformId, e.NeedAction, e.Paid, e.Released })
                    .HasName("NonClusteredIndex-DataManagement");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDescription)
                    .HasColumnName("Action_Description")
                    .HasMaxLength(300);

                entity.Property(e => e.AllowToUpdate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConfirmedInvoice)
                    .HasColumnName("Confirmed_Invoice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HoldedProviderId).HasColumnName("Holded_Provider_ID");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAutomatedDefinition).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.NeedAction).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoTrx).HasColumnName("no_trx");

                entity.Property(e => e.OldHoldProviderId).HasColumnName("Old_Hold_Provider_ID");

                entity.Property(e => e.OldProivderDataId).HasColumnName("Old_Proivder_Data_ID");

                entity.Property(e => e.OldProviderId).HasColumnName("Old_Provider_ID");

                entity.Property(e => e.OldProviderName)
                    .HasColumnName("Old_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.OldUploadedProviderName)
                    .HasColumnName("Old_Uploaded_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PostPaidRevenue)
                    .HasColumnName("PostPaid_Revenue")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrePaidRevenue)
                    .HasColumnName("PrePaid_Revenue")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PricePerHit)
                    .HasColumnName("Price_Per_Hit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderInfo)
                    .HasColumnName("Provider_Info")
                    .HasMaxLength(250);

                entity.Property(e => e.ProviderInfoDate)
                    .HasColumnName("Provider_Info_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Released).HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenuePerHit)
                    .HasColumnName("Revenue_Per_Hit")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Reviewied).HasDefaultValueSql("((0))");

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SuperUserId).HasColumnName("SuperUser_ID");

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderName)
                    .HasColumnName("Uploaded_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<MonthlyHitsEstimated>(entity =>
            {
                entity.ToTable("Monthly_Hits_Estimated", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowToUpdate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("Currency_Id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Gm)
                    .HasColumnName("GM")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.Notes).HasMaxLength(300);

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Released).HasDefaultValueSql("((0))");

                entity.Property(e => e.Revenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.MonthlyHitsEstimated)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Monthly_Hits_Estimated_Platform_List");

                entity.HasOne(d => d.ProviderData)
                    .WithMany(p => p.MonthlyHitsEstimated)
                    .HasForeignKey(d => d.ProviderDataId)
                    .HasConstraintName("FK_Monthly_Hits_Estimated_Provider_Data");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.MonthlyHitsEstimated)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_Monthly_Hits_Estimated_Providers");

                entity.HasOne(d => d.ProviderList)
                    .WithMany(p => p.MonthlyHitsEstimated)
                    .HasForeignKey(d => d.ProviderListId)
                    .HasConstraintName("FK_Monthly_Hits_Estimated_Provider_List");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MonthlyHitsEstimated)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Monthly_Hits_Estimated_Login");
            });

            modelBuilder.Entity<MonthlyHitsLogs>(entity =>
            {
                entity.ToTable("Monthly_Hits_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDescriptionNew)
                    .HasColumnName("Action_Description_New")
                    .HasMaxLength(300);

                entity.Property(e => e.ActionDescriptionOld)
                    .HasColumnName("Action_Description_Old")
                    .HasMaxLength(300);

                entity.Property(e => e.DataId).HasColumnName("Data_ID");

                entity.Property(e => e.DataInsertionDateTime)
                    .HasColumnName("Data_InsertionDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataModificationDateTime)
                    .HasColumnName("Data_ModificationDateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoldedProviderIdNew).HasColumnName("Holded_Provider_ID_New");

                entity.Property(e => e.HoldedProviderIdOld).HasColumnName("Holded_Provider_ID_Old");

                entity.Property(e => e.LogDateTime)
                    .HasColumnName("Log_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.NeedActionNew).HasColumnName("NeedAction_New");

                entity.Property(e => e.NeedActionOld).HasColumnName("NeedAction_Old");

                entity.Property(e => e.NoTrx).HasColumnName("no_trx");

                entity.Property(e => e.OldProivderDataId).HasColumnName("Old_Proivder_Data_ID");

                entity.Property(e => e.OldProviderId).HasColumnName("Old_Provider_ID");

                entity.Property(e => e.OldProviderName)
                    .HasColumnName("Old_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PostPaidRevenue)
                    .HasColumnName("PostPaid_Revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrePaidRevenue)
                    .HasColumnName("PrePaid_Revenue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricePerHit)
                    .HasColumnName("Price_Per_Hit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProviderDataIdNew).HasColumnName("Provider_Data_ID_New");

                entity.Property(e => e.ProviderDataIdOld).HasColumnName("Provider_Data_ID_Old");

                entity.Property(e => e.ProviderIdNew).HasColumnName("Provider_ID_New");

                entity.Property(e => e.ProviderIdOld).HasColumnName("Provider_ID_Old");

                entity.Property(e => e.ProviderNameNew)
                    .HasColumnName("Provider_Name_New")
                    .HasMaxLength(200);

                entity.Property(e => e.ProviderNameOld)
                    .HasColumnName("Provider_Name_Old")
                    .HasMaxLength(200);

                entity.Property(e => e.RevenuePerHit)
                    .HasColumnName("Revenue_Per_Hit")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SingerName)
                    .HasColumnName("Singer_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SongName)
                    .HasColumnName("Song_Name")
                    .HasMaxLength(250);

                entity.Property(e => e.SuperUserIdNew).HasColumnName("SuperUser_ID_New");

                entity.Property(e => e.SuperUserIdOld).HasColumnName("SuperUser_ID_Old");

                entity.Property(e => e.ToneCode).HasMaxLength(2000);

                entity.Property(e => e.UploadedProviderNameNew)
                    .HasColumnName("Uploaded_Provider_Name_New")
                    .HasMaxLength(200);

                entity.Property(e => e.UploadedProviderNameOld)
                    .HasColumnName("Uploaded_Provider_Name_Old")
                    .HasMaxLength(200);

                entity.Property(e => e.UserIdNew).HasColumnName("User_ID_New");

                entity.Property(e => e.UserIdOld).HasColumnName("User_ID_Old");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<MonthlySummerization>(entity =>
            {
                entity.ToTable("Monthly_Summerization", "RBT");

                entity.HasIndex(e => new { e.MonthDate, e.Cost, e.ProviderId, e.PlatformId })
                    .HasName("NonClusteredIndex-20180624-155201");

                entity.HasIndex(e => new { e.MonthDate, e.TotalRevenue, e.ProviderId, e.PlatformId })
                    .HasName("NonClusteredIndex-Proftability-01");

                entity.HasIndex(e => new { e.ProviderId, e.MonthDate, e.CountryId, e.PlatformId })
                    .HasName("NonClusteredIndex-20160111-063532");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.ConfirmedInvoice)
                    .HasColumnName("Confirmed_Invoice")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.HoldCost)
                    .HasColumnName("Hold_Cost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.InsertedDateTime)
                    .HasColumnName("Inserted_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Month).HasMaxLength(100);

                entity.Property(e => e.MonthDate)
                    .HasColumnName("Month_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Paid).HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PlatfromName)
                    .HasColumnName("Platfrom_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RevenueShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<MonthlySummerizationLogs>(entity =>
            {
                entity.ToTable("Monthly_Summerization_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.DeletedDateTime)
                    .HasColumnName("Deleted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.HoldCost)
                    .HasColumnName("Hold_Cost")
                    .HasColumnType("decimal(18, 6)");

                entity.Property(e => e.Modified).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Month).HasMaxLength(100);

                entity.Property(e => e.MonthDate)
                    .HasColumnName("Month_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.PlatfromName)
                    .HasColumnName("Platfrom_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ProviderName)
                    .HasColumnName("Provider_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.RevenueShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<NewsLetter>(entity =>
            {
                entity.ToTable("NewsLetter", "Notification");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.SendingDate).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.NewsLetter)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_NewsLetter_Users");
            });

            modelBuilder.Entity<NewsLetterSubscription>(entity =>
            {
                entity.ToTable("NewsLetterSubscription", "RBT");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.InsertionDtm)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification", "Notification");

                entity.Property(e => e.AttachedFilePath).HasMaxLength(200);

                entity.Property(e => e.Cced).HasMaxLength(400);

                entity.Property(e => e.InsertionDateTime).HasColumnType("datetime");

                entity.Property(e => e.SendingDateTime).HasColumnType("datetime");

                entity.Property(e => e.Subject).HasMaxLength(50);

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_Notification_Login");

                entity.HasOne(d => d.NotificationTemplate)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.NotificationTemplateId)
                    .HasConstraintName("FK_Notification_NotificationTemplate");
            });

            modelBuilder.Entity<NotificationConfiguration>(entity =>
            {
                entity.ToTable("NotificationConfiguration", "Notification");

                entity.Property(e => e.Host).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<NotificationTemplate>(entity =>
            {
                entity.ToTable("NotificationTemplate", "Notification");

                entity.Property(e => e.Bccs).HasColumnName("BCCs");

                entity.Property(e => e.Ccs).HasColumnName("CCs");

                entity.Property(e => e.InsertionDateTime).HasColumnType("datetime");

                entity.Property(e => e.Params).HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.To).HasMaxLength(200);

                entity.HasOne(d => d.Admin)
                    .WithMany(p => p.NotificationTemplate)
                    .HasForeignKey(d => d.AdminId)
                    .HasConstraintName("FK_NotificationTemplate_Login");

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.NotificationTemplate)
                    .HasForeignKey(d => d.NotificationTypeId)
                    .HasConstraintName("FK_NotificationTemplate_NotificationType");
            });

            modelBuilder.Entity<NotificationType>(entity =>
            {
                entity.ToTable("NotificationType", "Notification");

                entity.Property(e => e.DisplayName).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.HasOne(d => d.NotificationConfig)
                    .WithMany(p => p.NotificationType)
                    .HasForeignKey(d => d.NotificationConfigId)
                    .HasConstraintName("FK_NotificationType_NotificationConfiguration");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("Payment_Type", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentsDetails>(entity =>
            {
                entity.ToTable("Payments_Details", "RBT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AnnexId).HasColumnName("Annex_ID");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.CurrencyFk).HasColumnName("Currency_FK");

                entity.Property(e => e.DocFk).HasColumnName("Doc_FK");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeFk).HasColumnName("Payment_Type_FK");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");
            });

            modelBuilder.Entity<PaymentsTerm>(entity =>
            {
                entity.ToTable("Payments_Term", "RBT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AnnexId).HasColumnName("Annex_ID");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentDetialsFk).HasColumnName("Payment_Detials_FK");
            });

            modelBuilder.Entity<PlatformCollections>(entity =>
            {
                entity.ToTable("Platform_Collections", "RBT");

                entity.HasIndex(e => new { e.Month, e.Year, e.Collected, e.PlatformId })
                    .HasName("NonClusteredIndex-20160120-163258");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.Collected).HasDefaultValueSql("((0))");

                entity.Property(e => e.CollectedDatetime)
                    .HasColumnName("Collected_Datetime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrecnyId).HasColumnName("Currecny_ID");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<PlatformDailyRevUploaderLog>(entity =>
            {
                entity.ToTable("Platform_Daily_RevUploader_Log", "RBT");

                entity.Property(e => e.DaysInSheet).HasColumnName("Days_In_Sheet");

                entity.Property(e => e.DownloadedFileName)
                    .HasColumnName("Downloaded_File_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.ErrorMessage).HasColumnName("Error_Message");

                entity.Property(e => e.FileLastModificationDate)
                    .HasColumnName("File_Last_Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_Id");

                entity.Property(e => e.RecordsFailedCount).HasColumnName("Records_Failed_Count");

                entity.Property(e => e.RecordsSuccessCount).HasColumnName("Records_Success_Count");

                entity.Property(e => e.RecordsUploadedBeforCount).HasColumnName("Records_UploadedBefor_Count");

                entity.Property(e => e.RecordsWithEmptyCellsCount).HasColumnName("Records_With_Empty_Cells_Count");

                entity.Property(e => e.RecordsWithInvalidFormatCount).HasColumnName("Records_With_Invalid_Format_Count");

                entity.Property(e => e.RunDateTime)
                    .HasColumnName("Run_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.TotalRecordsCount).HasColumnName("Total_Records_Count");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnName("Total_Revenue")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformDailyRevUploaderLog)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Platform_Daily_RevUploader_Log_Platform_List");
            });

            modelBuilder.Entity<PlatformData>(entity =>
            {
                entity.ToTable("Platform_Data", "RBT");

                entity.HasIndex(e => new { e.CountryId, e.PlatformId, e.StartMonth, e.StartYear, e.EndMonth, e.EndYear })
                    .HasName("NonClusteredIndex-20131119-152557");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BadDebt).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.CountryId).HasColumnName("Country_ID");

                entity.Property(e => e.EndMonth).HasColumnName("End_Month");

                entity.Property(e => e.EndYear).HasColumnName("End_Year");

                entity.Property(e => e.Notes).HasMaxLength(250);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.RevenueShare)
                    .HasColumnName("Revenue_Share")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartMonth).HasColumnName("Start_Month");

                entity.Property(e => e.StartYear).HasColumnName("Start_Year");

                entity.Property(e => e.Taxes)
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxesPostPaid)
                    .HasColumnName("Taxes_PostPaid")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxesPrePaid)
                    .HasColumnName("Taxes_PrePaid")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxesProviders)
                    .HasColumnName("Taxes_Providers")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PlatformData)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Platform_Data_Territory");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformData)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Platform_Data_Platform_List");
            });

            modelBuilder.Entity<PlatformDistributor>(entity =>
            {
                entity.ToTable("Platform_Distributor", "RBT");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<PlatformHitPrice>(entity =>
            {
                entity.ToTable("Platform_Hit_Price", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");
            });

            modelBuilder.Entity<PlatformList>(entity =>
            {
                entity.ToTable("Platform_List", "RBT");

                entity.HasIndex(e => new { e.Name, e.TerritoryId, e.Daily, e.Monthly, e.IsDeleted })
                    .HasName("NonClusteredIndex-20131111-114448")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ArtistNameDefinition)
                    .HasColumnName("ArtistName_Definition")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Daily).HasDefaultValueSql("((0))");

                entity.Property(e => e.DailyReportUploaderTypeId).HasColumnName("Daily_Report_Uploader_Type_Id");

                entity.Property(e => e.GraphColor).HasMaxLength(50);

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.Monthly).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PlatformDistributerId).HasColumnName("Platform_Distributer_Id");

                entity.Property(e => e.PlatformTypeId)
                    .HasColumnName("PlatformType_Id")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TerritoryId).HasColumnName("Territory_ID");

                entity.Property(e => e.ToneCodeDefinition)
                    .HasColumnName("ToneCode_Definition")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ToneNameDefinition)
                    .HasColumnName("ToneName_Definition")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.DailyReportUploaderType)
                    .WithMany(p => p.PlatformList)
                    .HasForeignKey(d => d.DailyReportUploaderTypeId)
                    .HasConstraintName("FK_Platform_List_Platform_Report_Uploader_Type");

                entity.HasOne(d => d.PlatformDistributer)
                    .WithMany(p => p.PlatformList)
                    .HasForeignKey(d => d.PlatformDistributerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Platform_List_Platform_Distributor");

                entity.HasOne(d => d.PlatformType)
                    .WithMany(p => p.PlatformList)
                    .HasForeignKey(d => d.PlatformTypeId)
                    .HasConstraintName("FK_Platform_List_PlatformType");
            });

            modelBuilder.Entity<PlatformListDefaultValues>(entity =>
            {
                entity.ToTable("Platform_List_Default_Values", "RBT");

                entity.Property(e => e.ArtistNameDefault).HasMaxLength(100);

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformListDefaultValues)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Platform_List_Default_Values_Platform_List");
            });

            modelBuilder.Entity<PlatformListNotification>(entity =>
            {
                entity.ToTable("Platform_List_Notification", "Notification");

                entity.Property(e => e.NoticePeriod).HasColumnName("Notice_Period");

                entity.Property(e => e.NotificationTemplateId).HasColumnName("Notification_Template_Id");

                entity.Property(e => e.NotificationType).HasColumnName("Notification_Type");

                entity.Property(e => e.PlatformListId).HasColumnName("Platform_List_Id");

                entity.HasOne(d => d.NotificationTemplate)
                    .WithMany(p => p.PlatformListNotification)
                    .HasForeignKey(d => d.NotificationTemplateId)
                    .HasConstraintName("FK_Platform_List_Notification_NotificationTemplate");

                entity.HasOne(d => d.NotificationTypeNavigation)
                    .WithMany(p => p.PlatformListNotification)
                    .HasForeignKey(d => d.NotificationType)
                    .HasConstraintName("FK_Platform_List_Notification_NotificationType");

                entity.HasOne(d => d.PlatformList)
                    .WithMany(p => p.PlatformListNotification)
                    .HasForeignKey(d => d.PlatformListId)
                    .HasConstraintName("FK_Platform_List_Notification_Platform_List");
            });

            modelBuilder.Entity<PlatformListNotificationLogs>(entity =>
            {
                entity.ToTable("Platform_List_Notification_Logs", "Notification");

                entity.Property(e => e.InsertionDateTime).HasColumnType("datetime");

                entity.Property(e => e.PlatformNotificationId).HasColumnName("Platform_Notification_Id");

                entity.Property(e => e.SendingDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.PlatformNotification)
                    .WithMany(p => p.PlatformListNotificationLogs)
                    .HasForeignKey(d => d.PlatformNotificationId)
                    .HasConstraintName("FK_Platform_List_Notification_Logs_Platform_List_Notification");
            });

            modelBuilder.Entity<PlatformReportUploaderType>(entity =>
            {
                entity.ToTable("Platform_Report_Uploader_Type", "RBT");

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<PlatformRevFileEmailConfiguration>(entity =>
            {
                entity.ToTable("Platform_RevFile_Email_Configuration", "RBT");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FileName)
                    .HasColumnName("File_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.Host).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_Id");

                entity.Property(e => e.Sender).HasMaxLength(50);

                entity.Property(e => e.SheetName)
                    .HasColumnName("Sheet_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformRevFileEmailConfiguration)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Platform_RevFile_Email_Configuration_Platform_List");
            });

            modelBuilder.Entity<PlatformRevFileFtpConfiguration>(entity =>
            {
                entity.ToTable("Platform_RevFile_Ftp_Configuration", "RBT");

                entity.Property(e => e.FileName)
                    .HasColumnName("File_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.FtpPassword)
                    .HasColumnName("Ftp_Password")
                    .HasMaxLength(50);

                entity.Property(e => e.FtpUrl)
                    .HasColumnName("Ftp_Url")
                    .HasMaxLength(200);

                entity.Property(e => e.FtpUserName)
                    .HasColumnName("ftp_UserName")
                    .HasMaxLength(50);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_Id");

                entity.Property(e => e.ProviderSheetInfo).HasMaxLength(100);

                entity.Property(e => e.SheetName)
                    .HasColumnName("Sheet_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.TemplateId).HasColumnName("Template_Id");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformRevFileFtpConfiguration)
                    .HasForeignKey(d => d.PlatformId)
                    .HasConstraintName("FK_Platform_RevFile_Ftp_Configuration_Platform_List");
            });

            modelBuilder.Entity<PlatformType>(entity =>
            {
                entity.ToTable("PlatformType", "RBT");

                entity.Property(e => e.CmsChannelId).HasColumnName("cmsChannelId");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PlatformsOperatorsRel>(entity =>
            {
                entity.ToTable("Platforms_Operators_Rel", "RBT");

                entity.HasIndex(e => new { e.PlatfromId, e.OperatorId })
                    .HasName("NonClusteredIndex-20151201-172323");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.PlatfromId).HasColumnName("Platfrom_ID");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.PlatformsOperatorsRel)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_Platforms_Operators_Rel_RBT_Operators");

                entity.HasOne(d => d.Platfrom)
                    .WithMany(p => p.PlatformsOperatorsRel)
                    .HasForeignKey(d => d.PlatfromId)
                    .HasConstraintName("FK_Platforms_Operators_Rel_Platform_List");
            });

            modelBuilder.Entity<PlatformsProvidersRel>(entity =>
            {
                entity.ToTable("Platforms_Providers_Rel", "RBT");

                entity.HasIndex(e => new { e.PlatformId, e.ProviderId, e.Name })
                    .HasName("NonClusteredIndex-20150225-193444");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.HasOne(d => d.Platform)
                    .WithMany(p => p.PlatformsProvidersRel)
                    .HasForeignKey(d => d.PlatformId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Platforms_Providers_Rel_Platform_List");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PlatformsProvidersRel)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Platforms_Providers_Rel_Provider_List");
            });

            modelBuilder.Entity<ProfitabilityReport>(entity =>
            {
                entity.ToTable("Profitability_Report", "RBT");

                entity.Property(e => e.CostMonthShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYearShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastEstimatedMonth).HasColumnType("date");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.PlatformName).HasMaxLength(100);

                entity.Property(e => e.PlatformTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.ReportTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RevenueMonth)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenuePerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ProivdersOperatorsEstimatedRel>(entity =>
            {
                entity.ToTable("Proivders_Operators_Estimated_Rel", "RBT");

                entity.HasIndex(e => new { e.ProviderDataId, e.OperatorId })
                    .HasName("NonClusteredIndex-20190510-144637")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocFk).HasColumnName("Doc_FK");

                entity.Property(e => e.InsertionDate)
                    .HasColumnName("Insertion_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate)
                    .HasColumnName("Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.ProivdersOperatorsEstimatedRel)
                    .HasForeignKey(d => d.OperatorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proivders_Operators_Estimated_Rel_RBT_Operators");

                entity.HasOne(d => d.ProviderData)
                    .WithMany(p => p.ProivdersOperatorsEstimatedRel)
                    .HasForeignKey(d => d.ProviderDataId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proivders_Operators_Estimated_Rel_Provider_Data");
            });

            modelBuilder.Entity<ProivdersOperatorsRel>(entity =>
            {
                entity.ToTable("Proivders_Operators_Rel", "RBT");

                entity.HasIndex(e => new { e.ProviderDataId, e.OperatorId, e.DocFk })
                    .HasName("NonClusteredIndex-20151201-172258");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocFk).HasColumnName("Doc_FK");

                entity.Property(e => e.InsertionDate)
                    .HasColumnName("Insertion_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate)
                    .HasColumnName("Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.HasOne(d => d.Operator)
                    .WithMany(p => p.ProivdersOperatorsRel)
                    .HasForeignKey(d => d.OperatorId)
                    .HasConstraintName("FK_Proivders_Operators_Rel_RBT_Operators");

                entity.HasOne(d => d.ProviderData)
                    .WithMany(p => p.ProivdersOperatorsRel)
                    .HasForeignKey(d => d.ProviderDataId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Proivders_Operators_Rel_Provider_Data");
            });

            modelBuilder.Entity<ProivdersOperatorsRelDeleted>(entity =>
            {
                entity.ToTable("Proivders_Operators_Rel_Deleted", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocFk).HasColumnName("Doc_FK");

                entity.Property(e => e.InsertionDate)
                    .HasColumnName("Insertion_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate)
                    .HasColumnName("Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OperatorId).HasColumnName("Operator_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");
            });

            modelBuilder.Entity<PromotionContents>(entity =>
            {
                entity.ToTable("PromotionContents", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.PlatformId).HasColumnName("PlatformID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 5)");

                entity.Property(e => e.SingerName).HasMaxLength(300);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.ToneCode).HasMaxLength(50);

                entity.Property(e => e.ToneName).HasMaxLength(300);
            });

            modelBuilder.Entity<ProviderBalance>(entity =>
            {
                entity.ToTable("Provider_Balance", "RBT");

                entity.HasIndex(e => new { e.MonthDate, e.Year, e.Month, e.ProviderContractId, e.ProviderListId, e.ProviderDataId })
                    .HasName("NonClusteredIndex-20161206-121808")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.InsertionDate)
                    .HasColumnName("Insertion_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAutomated).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsOutStandingBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDate)
                    .HasColumnName("Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthDate)
                    .HasColumnName("Month_Date")
                    .HasColumnType("date");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<ProviderBalanceDetails>(entity =>
            {
                entity.ToTable("Provider_Balance_Details", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BalanceDate)
                    .HasColumnName("Balance_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.InsertionDate)
                    .HasColumnName("Insertion_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAutomated).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.LocalBalance)
                    .HasColumnName("Local_Balance")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModificationDate)
                    .HasColumnName("Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderBalanceId).HasColumnName("Provider_Balance_ID");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.ProviderBalance)
                    .WithMany(p => p.ProviderBalanceDetails)
                    .HasForeignKey(d => d.ProviderBalanceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Provider_Balance_Details_Provider_Balance");
            });

            modelBuilder.Entity<ProviderData>(entity =>
            {
                entity.ToTable("Provider_Data", "RBT");

                entity.HasIndex(e => new { e.Id, e.ProviderId, e.RevenueShare, e.IsMuziCupContract })
                    .HasName("NonClusteredIndex-20210108-143714");

                entity.HasIndex(e => new { e.ProviderId, e.StartMonth, e.StartYear, e.EndMonth, e.EndYear, e.PaymentTypeId, e.Expired, e.AutoRenewal, e.ContractId, e.AnnexId, e.DocId, e.IsAnnex })
                    .HasName("NonClusteredIndex-20131119-152723");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowToDelete).HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowToUpdate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnnexId).HasColumnName("Annex_ID");

                entity.Property(e => e.AutoRenewal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Channels)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.CostEndDate)
                    .HasColumnName("Cost_End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CostStartDate)
                    .HasColumnName("Cost_Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Countries)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.EndMonth).HasColumnName("End_Month");

                entity.Property(e => e.EndYear).HasColumnName("End_Year");

                entity.Property(e => e.Expired).HasDefaultValueSql("((0))");

                entity.Property(e => e.GraceMonths).HasDefaultValueSql("((0))");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAnnex).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsMuziCupContract)
                    .HasColumnName("Is_MuziCup_Contract")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.NotificationDays).HasDefaultValueSql("((30))");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentType_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ReqToDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReqToUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueShare)
                    .HasColumnName("Revenue_Share")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start_Date")
                    .HasColumnType("date");

                entity.Property(e => e.StartMonth).HasColumnName("Start_Month");

                entity.Property(e => e.StartYear).HasColumnName("Start_Year");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderData)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Provider_Data_Provider_List");
            });

            modelBuilder.Entity<ProviderDataLogs>(entity =>
            {
                entity.ToTable("Provider_Data_Logs", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowToDelete).HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowToUpdate).HasDefaultValueSql("((1))");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AnnexId).HasColumnName("Annex_ID");

                entity.Property(e => e.AutoRenewal).HasDefaultValueSql("((0))");

                entity.Property(e => e.Channels)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Checked).HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractId).HasColumnName("Contract_ID");

                entity.Property(e => e.Countries)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.EndMonth).HasColumnName("End_Month");

                entity.Property(e => e.EndYear).HasColumnName("End_Year");

                entity.Property(e => e.Expired).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsAnnex).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMuziCupContract).HasColumnName("Is_MuziCup_Contract");

                entity.Property(e => e.ModificationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NotificationDays).HasDefaultValueSql("((30))");

                entity.Property(e => e.OrgId).HasColumnName("Org_ID");

                entity.Property(e => e.PaymentTypeId).HasColumnName("PaymentType_ID");

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.Property(e => e.ReqToDelete).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReqToUpdate).HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueShare)
                    .HasColumnName("Revenue_Share")
                    .HasColumnType("decimal(5, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SendEmail).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartMonth).HasColumnName("Start_Month");

                entity.Property(e => e.StartYear).HasColumnName("Start_Year");
            });

            modelBuilder.Entity<ProviderList>(entity =>
            {
                entity.ToTable("Provider_List", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CmsName)
                    .HasColumnName("CMS_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractFilePath)
                    .HasColumnName("Contract_File_Path")
                    .HasMaxLength(4000);

                entity.Property(e => e.DocId).HasColumnName("Doc_ID");

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsArchived).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMuziCupContract)
                    .HasColumnName("Is_MuziCup_Contract")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LegalName)
                    .HasColumnName("Legal_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.Modification).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.PackageRunTime).HasColumnType("datetime");

                entity.Property(e => e.PaidLocally)
                    .HasColumnName("Paid_Locally")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.HasOne(d => d.ProviderContract)
                    .WithMany(p => p.ProviderList)
                    .HasForeignKey(d => d.ProviderContractId)
                    .HasConstraintName("FK_Provider_List_Providers");
            });

            modelBuilder.Entity<ProviderStatements>(entity =>
            {
                entity.ToTable("Provider_Statements", "RBT");

                entity.HasIndex(e => new { e.ProviderContractId, e.IsPaid })
                    .HasName("NonClusteredIndex-CPStatements");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DateValue)
                    .HasColumnName("Date_Value")
                    .HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsOutStandingBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.OperatorAmount)
                    .HasColumnName("Operator_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutStBalanceAmount)
                    .HasColumnName("OutSt_Balance_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidAdvance)
                    .HasColumnName("Paid_Advance")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidAmount)
                    .HasColumnName("Paid_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidContractAmount)
                    .HasColumnName("Paid_Contract_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidDateTime)
                    .HasColumnName("Paid_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidOutStBalance)
                    .HasColumnName("Paid_OutSt_Balance")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPaidAmount)
                    .HasColumnName("Total_Paid_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ProviderStatementsDetails>(entity =>
            {
                entity.ToTable("Provider_Statements_Details", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConfirmedDateTime)
                    .HasColumnName("Confirmed_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.CurrencyId).HasColumnName("Currency_ID");

                entity.Property(e => e.DateValue)
                    .HasColumnName("Date_Value")
                    .HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsConfirmed).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOutStandingBalance).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPaid).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.OperatorAmount)
                    .HasColumnName("Operator_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OutStBalanceAmount)
                    .HasColumnName("OutSt_Balance_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidAdvance)
                    .HasColumnName("Paid_Advance")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidAmount)
                    .HasColumnName("Paid_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidContractAmount)
                    .HasColumnName("Paid_Contract_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaidDateTime)
                    .HasColumnName("Paid_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaidOutStBalance)
                    .HasColumnName("Paid_OutSt_Balance")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.ProviderContractId).HasColumnName("Provider_Contract_ID");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_Data_ID");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_List_ID");

                entity.Property(e => e.StatementId).HasColumnName("Statement_ID");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("Total_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPaidAmount)
                    .HasColumnName("Total_Paid_Amount")
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.ProviderStatementsDetails)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Provider_Statements_Details_Provider_Statements");
            });

            modelBuilder.Entity<Providers>(entity =>
            {
                entity.ToTable("Providers", "RBT");

                entity.HasIndex(e => new { e.Name, e.CommercialName, e.AccountNumber, e.MonthlyPayments, e.ViewReports, e.CurrencyId })
                    .HasName("NonClusteredIndex-20160316-005335");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.CommercialName)
                    .HasColumnName("Commercial_Name")
                    .HasMaxLength(100);

                entity.Property(e => e.CurrencyId)
                    .HasColumnName("Currency_ID")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.DeletedDateTime)
                    .HasColumnName("Deleted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnName("Insertion_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceDescription).HasMaxLength(50);

                entity.Property(e => e.Invoicing).HasDefaultValueSql("((1))");

                entity.Property(e => e.InvoicingModificationDatetime).HasColumnType("datetime");

                entity.Property(e => e.IsDeleted).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTop).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDateTime)
                    .HasColumnName("Modified_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.MonthlyAdvanceShare)
                    .HasColumnName("Monthly_Advance_Share")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MonthlyPayments)
                    .HasColumnName("Monthly_Payments")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.PersonalEmail)
                    .HasColumnName("Personal_Email")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonalPhone)
                    .HasColumnName("Personal_Phone")
                    .HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.ViewReports)
                    .HasColumnName("View_Reports")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ProvidersAdminsList>(entity =>
            {
                entity.ToTable("ProvidersAdminsList", "RBT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProvidersAdminsList)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ProvidersAdmisList_Users");
            });

            modelBuilder.Entity<ProvidersMuzicUp>(entity =>
            {
                entity.ToTable("Providers_MuzicUP", "RBT");

                entity.HasIndex(e => e.ProvidersId)
                    .HasName("NonClusteredIndex-20170814-124056")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.InsterationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentIssue).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.ProvidersMuzicUp)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK_Providers_MuzicUP_Login");

                entity.HasOne(d => d.Providers)
                    .WithOne(p => p.ProvidersMuzicUp)
                    .HasForeignKey<ProvidersMuzicUp>(d => d.ProvidersId)
                    .HasConstraintName("FK_Providers_MuzicUP_Providers");
            });

            modelBuilder.Entity<ProvidersUploadedRbtNames>(entity =>
            {
                entity.ToTable("Providers_Uploaded_RBT_Names", "RBT");

                entity.HasIndex(e => new { e.Name, e.ProviderId })
                    .HasName("NonClusteredIndex-20150228-173324")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnName("Insert_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProvidersUploadedRbtNames)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Providers_Uploaded_RBT_Names_Provider_List");
            });

            modelBuilder.Entity<ProvidersUploadedRbtNamesHolded>(entity =>
            {
                entity.ToTable("Providers_Uploaded_RBT_Names_Holded", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InsertDateTime)
                    .HasColumnName("Insert_DateTime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_ID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProvidersUploadedRbtNamesHolded)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Providers_Uploaded_RBT_Names_Holded_Provider_List");
            });

            modelBuilder.Entity<ProvidersUsers>(entity =>
            {
                entity.HasKey(e => e.ProviderId);

                entity.ToTable("Providers_Users", "RBT");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("Provider_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InsertationDate)
                    .HasColumnName("Insertation_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDate)
                    .HasColumnName("Modification_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MuzicUpProviderId).HasColumnName("MuzicUP_Provider_ID");

                entity.Property(e => e.UserId).HasColumnName("User_ID");
            });

            modelBuilder.Entity<RbtApiActions>(entity =>
            {
                entity.ToTable("Rbt_Api_Actions", "RBT");

                entity.Property(e => e.Action).HasMaxLength(200);
            });

            modelBuilder.Entity<RbtApiActionsLog>(entity =>
            {
                entity.ToTable("Rbt_Api_Actions_Log", "RBT");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.RbtApiActionId).HasColumnName("Rbt_Api_Action_Id");

                entity.HasOne(d => d.RbtApiAction)
                    .WithMany(p => p.RbtApiActionsLog)
                    .HasForeignKey(d => d.RbtApiActionId)
                    .HasConstraintName("FK_Rbt_Api_Actions_Log_Rbt_Api_Actions");
            });

            modelBuilder.Entity<RbtCurrencies>(entity =>
            {
                entity.ToTable("RBT_Currencies", "RBT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencySymbol)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RbtEmailsDetails>(entity =>
            {
                entity.ToTable("RBT_Emails_Details", "RBT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accepted).HasDefaultValueSql("((0))");

                entity.Property(e => e.AcceptedDateTime)
                    .HasColumnName("Accepted_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContentUserId).HasColumnName("Content_User_ID");

                entity.Property(e => e.ContentUserName)
                    .HasColumnName("Content_User_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.Executed).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExecutionDateTime)
                    .HasColumnName("Execution_DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinancialUserId).HasColumnName("Financial_User_ID");

                entity.Property(e => e.FinancialUserName)
                    .HasColumnName("Financial_User_Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.NewProviderDataId).HasColumnName("New_Provider_Data_ID");

                entity.Property(e => e.NewProviderId).HasColumnName("New_Provider_ID");

                entity.Property(e => e.NewProviderName)
                    .HasColumnName("New_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.OldProviderDataId).HasColumnName("Old_Provider_Data_ID");

                entity.Property(e => e.OldProviderId).HasColumnName("Old_Provider_ID");

                entity.Property(e => e.OldProviderName)
                    .HasColumnName("Old_Provider_Name")
                    .HasMaxLength(200);

                entity.Property(e => e.PlatformId).HasColumnName("Platform_ID");

                entity.Property(e => e.RequestTypeId).HasColumnName("Request_Type_ID");

                entity.Property(e => e.SelectedIds)
                    .HasColumnName("Selected_IDs")
                    .HasMaxLength(2000);

                entity.Property(e => e.SelectedProviderDataId).HasColumnName("Selected_Provider_Data_ID");

                entity.Property(e => e.SelectedProviderId).HasColumnName("Selected_Provider_ID");

                entity.Property(e => e.SendCc)
                    .HasColumnName("SendCC")
                    .HasMaxLength(200);

                entity.Property(e => e.SendDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SendTo).HasMaxLength(200);

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<RbtEmailsRequestType>(entity =>
            {
                entity.ToTable("RBT_Emails_Request_Type", "RBT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Request).HasMaxLength(50);
            });

            modelBuilder.Entity<RbtOperators>(entity =>
            {
                entity.ToTable("RBT_Operators", "RBT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.InsertionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mcc)
                    .HasColumnName("MCC")
                    .HasMaxLength(10);

                entity.Property(e => e.Mnc)
                    .HasColumnName("MNC")
                    .HasMaxLength(10);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Networkcode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TerritoryFk).HasColumnName("Territory_FK");

                entity.HasOne(d => d.TerritoryFkNavigation)
                    .WithMany(p => p.RbtOperators)
                    .HasForeignKey(d => d.TerritoryFk)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_RBT_Operator_Territory");
            });

            modelBuilder.Entity<RegistrationAdmins>(entity =>
            {
                entity.ToTable("RegistrationAdmins", "RBT");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RegistrationAdmins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_RegistrationAdmins_Users");
            });

            modelBuilder.Entity<RegistrationStatus>(entity =>
            {
                entity.ToTable("RegistrationStatus", "Users");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status).HasMaxLength(50);
            });

            modelBuilder.Entity<ReportAmTargets>(entity =>
            {
                entity.ToTable("Report_AM_Targets", "RBT");

                entity.HasIndex(e => new { e.RevenueMonth, e.RevenueYear, e.RevenuePerContract, e.CostMonthShare, e.CostYearShare, e.CostPerContractShare, e.ProviderDataId, e.YearDate, e.MonthDate, e.Date })
                    .HasName("NonClusteredIndex-20190227-103009");

                entity.Property(e => e.CostMonthShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYearShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastEstimatedMonth).HasColumnType("date");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.PlatformName).HasMaxLength(100);

                entity.Property(e => e.PlatformTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.ReportTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RevenueMonth)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenuePerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ReportAmTargetsCost>(entity =>
            {
                entity.ToTable("Report_AM_Targets_Cost", "RBT");

                entity.Property(e => e.CostMonth)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostMonthAdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostMonthShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractAdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYearAdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYearShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.RevenueMonth)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenuePerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ReportAmTargetsCostTest>(entity =>
            {
                entity.ToTable("Report_AM_Targets_Cost_Test", "RBT");

                entity.Property(e => e.CostMonth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostMonthAdv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostMonthShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostPerContract).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostPerContractAdv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostPerContractShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostYear).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostYearAdv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostYearShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutomated).HasDefaultValueSql("((1))");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.RevenueMonth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenuePerContract).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenueYear).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ReportAmTargetsTesting>(entity =>
            {
                entity.ToTable("Report_AM_Targets_Testing", "RBT");

                entity.Property(e => e.CostMonthShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostPerContractShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostYearShare).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime).HasColumnType("datetime");

                entity.Property(e => e.IsAutomated).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastEstimatedMonth).HasColumnType("date");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.PlatformName).HasMaxLength(100);

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.RevenueMonth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenuePerContract).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.RevenueYear).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalRevenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ReportT1Targets>(entity =>
            {
                entity.ToTable("Report_T1_Targets", "RBT");

                entity.HasIndex(e => new { e.Date, e.ProviderId, e.PlatformId })
                    .HasName("NonClusteredIndex-20180524-125753");

                entity.Property(e => e.CostMonthShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYearShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LastEstimatedMonth).HasColumnType("date");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.PlatformName).HasMaxLength(100);

                entity.Property(e => e.PlatformTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.ReportTypeId).HasDefaultValueSql("((1))");

                entity.Property(e => e.RevenueMonth)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenuePerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ReportT1TargetsCost>(entity =>
            {
                entity.ToTable("Report_T1_Targets_Cost", "RBT");

                entity.Property(e => e.CostMonth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostMonthAdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostMonthShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractAdv)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostPerContractShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CostYearAdv).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostYearShare)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("datetime");

                entity.Property(e => e.MonthDate).HasColumnName("Month_Date");

                entity.Property(e => e.ProviderDataId).HasColumnName("Provider_DataId");

                entity.Property(e => e.ProviderListId).HasColumnName("Provider_ListId");

                entity.Property(e => e.ProviderName).HasMaxLength(100);

                entity.Property(e => e.RevenueMonth)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenuePerContract)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RevenueYear)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalRevenue)
                    .HasColumnType("decimal(18, 2)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.YearDate).HasColumnName("Year_Date");
            });

            modelBuilder.Entity<ReportType>(entity =>
            {
                entity.ToTable("ReportType", "RBT");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SiteAction>(entity =>
            {
                entity.ToTable("SiteAction", "logs");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SiteControllers>(entity =>
            {
                entity.ToTable("SiteControllers", "logs");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.IsVisible)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SitePermissions>(entity =>
            {
                entity.ToTable("Site_Permissions", "logs");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);
            });

            modelBuilder.Entity<SiteRegion>(entity =>
            {
                entity.ToTable("Site_Region", "logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Platform)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status", "RBT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<StatusTransactions>(entity =>
            {
                entity.ToTable("StatusTransactions", "Users");

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.HasOne(d => d.AccountManager)
                    .WithMany(p => p.StatusTransactions)
                    .HasForeignKey(d => d.AccountManagerId)
                    .HasConstraintName("FK_StatusTransactions_Login1");

                entity.HasOne(d => d.RegistrationStatus)
                    .WithMany(p => p.StatusTransactions)
                    .HasForeignKey(d => d.RegistrationStatusId)
                    .HasConstraintName("FK_StatusTransactions_RegistrationStatus1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StatusTransactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_StatusTransactions_Users1");
            });

            modelBuilder.Entity<TempUploadingContents>(entity =>
            {
                entity.Property(e => e.AlbumArabic)
                    .HasColumnName("Album_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.AlbumEnglish)
                    .HasColumnName("Album_English")
                    .HasMaxLength(800);

                entity.Property(e => e.AlbumId).HasColumnName("Album_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.CategoryNationality)
                    .HasColumnName("Category/Nationality")
                    .HasMaxLength(800);

                entity.Property(e => e.ContentArabic)
                    .HasColumnName("Content_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.ContentEnglish)
                    .HasColumnName("Content_English")
                    .HasMaxLength(800);

                entity.Property(e => e.ContentId).HasColumnName("Content_Id");

                entity.Property(e => e.Countries).HasMaxLength(800);

                entity.Property(e => e.CountriesIds).HasMaxLength(800);

                entity.Property(e => e.Exclusive).HasMaxLength(800);

                entity.Property(e => e.Notes).HasMaxLength(800);

                entity.Property(e => e.OperatorIds).HasMaxLength(800);

                entity.Property(e => e.Operators).HasMaxLength(800);

                entity.Property(e => e.ProviderArabic)
                    .HasColumnName("Provider_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.ProviderEnglish)
                    .HasColumnName("Provider_English")
                    .HasMaxLength(800);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_Id");

                entity.Property(e => e.Services).HasMaxLength(800);

                entity.Property(e => e.ServicesIds).HasMaxLength(800);

                entity.Property(e => e.SingerArabic)
                    .HasColumnName("Singer_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.SingerEnglish)
                    .HasColumnName("Singer_English")
                    .HasMaxLength(800);

                entity.Property(e => e.SingerId).HasColumnName("Singer_Id");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.Property(e => e.UploadingDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TempUploadingContents1>(entity =>
            {
                entity.ToTable("TempUploadingContents", "CMS");

                entity.HasIndex(e => new { e.SingerEnglish, e.SingerArabic, e.AlbumEnglish, e.AlbumArabic, e.ContentEnglish, e.ContentArabic, e.ProviderEnglish, e.CategoryNationality, e.Source, e.Uctid, e.SingerId, e.AlbumId, e.ContentId, e.ProviderId, e.CategoryId, e.SourceId })
                    .HasName("NonClusteredIndex-20181015-202646");

                entity.Property(e => e.AlbumArabic)
                    .HasColumnName("Album_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.AlbumEnglish)
                    .HasColumnName("Album_English")
                    .HasMaxLength(800);

                entity.Property(e => e.AlbumId).HasColumnName("Album_Id");

                entity.Property(e => e.AlbumImage).HasMaxLength(800);

                entity.Property(e => e.ArtistImage).HasMaxLength(800);

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.CategoryNationality)
                    .HasColumnName("Category/Nationality")
                    .HasMaxLength(800);

                entity.Property(e => e.Composer).HasMaxLength(100);

                entity.Property(e => e.ContentArabic)
                    .HasColumnName("Content_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.ContentEnglish)
                    .HasColumnName("Content_English")
                    .HasMaxLength(800);

                entity.Property(e => e.ContentId).HasColumnName("Content_Id");

                entity.Property(e => e.ContentType).HasMaxLength(800);

                entity.Property(e => e.Countries).HasMaxLength(800);

                entity.Property(e => e.CountriesIds).HasMaxLength(800);

                entity.Property(e => e.Exclusive).HasMaxLength(800);

                entity.Property(e => e.FileName).HasMaxLength(800);

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(255);

                entity.Property(e => e.Notes).HasMaxLength(800);

                entity.Property(e => e.OperatorIds).HasMaxLength(800);

                entity.Property(e => e.Operators).HasMaxLength(400);

                entity.Property(e => e.ProviderArabic)
                    .HasColumnName("Provider_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.ProviderEnglish)
                    .HasColumnName("Provider_English")
                    .HasMaxLength(800);

                entity.Property(e => e.ProviderId).HasColumnName("Provider_Id");

                entity.Property(e => e.ReleaseDate).HasMaxLength(255);

                entity.Property(e => e.Services).HasMaxLength(800);

                entity.Property(e => e.ServicesIds).HasMaxLength(800);

                entity.Property(e => e.SingerArabic)
                    .HasColumnName("Singer_Arabic")
                    .HasMaxLength(800);

                entity.Property(e => e.SingerDisplayNameEn)
                    .HasColumnName("Singer_Display_Name_En")
                    .HasMaxLength(800);

                entity.Property(e => e.SingerEnglish)
                    .HasColumnName("Singer_English")
                    .HasMaxLength(800);

                entity.Property(e => e.SingerId).HasColumnName("Singer_Id");

                entity.Property(e => e.Source).HasMaxLength(200);

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(255);

                entity.Property(e => e.UploadingDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TemplateColumnFilterValues>(entity =>
            {
                entity.ToTable("Template_Column_Filter_Values", "RBT");

                entity.Property(e => e.FilterValue).HasMaxLength(200);

                entity.HasOne(d => d.PlatformTemplateColumn)
                    .WithMany(p => p.TemplateColumnFilterValues)
                    .HasForeignKey(d => d.PlatformTemplateColumnId)
                    .HasConstraintName("FK_TemplateColumnFilterValues_Daily_Template_Columns");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.ToTable("Territory", "RBT");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyFk).HasColumnName("Currency_FK");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ThirdParty>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CompanyPrefix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EditingDatetime).HasColumnType("smalldatetime");

                entity.Property(e => e.EndOfContract).HasColumnType("smalldatetime");

                entity.Property(e => e.IsContentProvider).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isexpired)
                    .HasColumnName("ISExpired")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.StartOfContract).HasColumnType("smalldatetime");

                entity.Property(e => e.ThirdPassword).HasMaxLength(50);

                entity.Property(e => e.ThirdUserName).HasMaxLength(50);

                entity.Property(e => e.Website)
                    .IsRequired()
                    .HasColumnName("website")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.ToTable("Track", "SmartLink");

                entity.Property(e => e.Duration).HasDefaultValueSql("((30))");

                entity.Property(e => e.InsertationDateTime)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModificationDateTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Uctid).HasColumnName("UCTId");

                entity.HasOne(d => d.FileData)
                    .WithMany(p => p.Track)
                    .HasForeignKey(d => d.FileDataId)
                    .HasConstraintName("FK_Track_FileData");
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.ToTable("Transactions", "logs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionFk).HasColumnName("Action_FK");

                entity.Property(e => e.DateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NewValue).HasMaxLength(4000);

                entity.Property(e => e.ObjectSqlId).HasColumnName("ObjectSQL_ID");

                entity.Property(e => e.OldValue).HasMaxLength(4000);

                entity.Property(e => e.ProcName).HasMaxLength(4000);

                entity.Property(e => e.RowId).HasColumnName("Row_ID");

                entity.Property(e => e.SchemaName)
                    .HasColumnName("Schema_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("User_ID");

                entity.HasOne(d => d.ActionFkNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ActionFk)
                    .HasConstraintName("FK_Transactions_Action");
            });

            modelBuilder.Entity<UploadingControlTable>(entity =>
            {
                entity.ToTable("UploadingControlTable", "CMS");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.OperationStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RunningDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UploadingControlTable1>(entity =>
            {
                entity.ToTable("UploadingControlTable");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FileName).HasMaxLength(100);

                entity.Property(e => e.OperationStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.RunningDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<UserAlbum>(entity =>
            {
                entity.ToTable("userAlbum", "Users");

                entity.Property(e => e.AlbumNameAr).HasMaxLength(255);

                entity.Property(e => e.AlbumNameEn).HasMaxLength(255);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.UserCoverId).HasColumnName("userCoverId");

                entity.HasOne(d => d.UserCover)
                    .WithMany(p => p.UserAlbum)
                    .HasForeignKey(d => d.UserCoverId)
                    .HasConstraintName("FK_userAlbum_userImage");
            });

            modelBuilder.Entity<UserArtist>(entity =>
            {
                entity.ToTable("userArtist", "Users");

                entity.Property(e => e.ArtistNameAr).HasMaxLength(255);

                entity.Property(e => e.ArtistNameEn).HasMaxLength(255);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.UserImageId).HasColumnName("userImageId");

                entity.HasOne(d => d.UserImage)
                    .WithMany(p => p.UserArtist)
                    .HasForeignKey(d => d.UserImageId)
                    .HasConstraintName("FK_userArtist_userImage");
            });

            modelBuilder.Entity<UserContent>(entity =>
            {
                entity.ToTable("userContent", "Users");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.Isrc).HasMaxLength(50);

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.NameAr).HasMaxLength(50);

                entity.Property(e => e.NameEn).HasMaxLength(50);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.UserContent)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_userContent_userContent");

                entity.HasOne(d => d.Artist)
                    .WithMany(p => p.UserContent)
                    .HasForeignKey(d => d.ArtistId)
                    .HasConstraintName("FK_userContent_userArtist");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.UserContent)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_userContent_usrCategory");

                entity.HasOne(d => d.Track)
                    .WithMany(p => p.UserContent)
                    .HasForeignKey(d => d.TrackId)
                    .HasConstraintName("FK_userContent_userTracks");
            });

            modelBuilder.Entity<UserImage>(entity =>
            {
                entity.ToTable("userImage", "Users");

                entity.Property(e => e.ImageName).HasMaxLength(100);

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserNewsLetterRel>(entity =>
            {
                entity.ToTable("UserNewsLetterRel", "Notification");

                entity.Property(e => e.AlternativeEmail).HasMaxLength(50);

                entity.Property(e => e.SendingDate).HasColumnType("datetime");

                entity.HasOne(d => d.NewsLetter)
                    .WithMany(p => p.UserNewsLetterRel)
                    .HasForeignKey(d => d.NewsLetterId)
                    .HasConstraintName("FK_UserNewsLetterRel_NewsLetter");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserNewsLetterRel)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserNewsLetterRel_Users1");
            });

            modelBuilder.Entity<UserNotificationRel>(entity =>
            {
                entity.ToTable("UserNotificationRel", "Notification");

                entity.Property(e => e.AlternativeRecipient).HasMaxLength(400);

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsSent).HasDefaultValueSql("((1))");

                entity.Property(e => e.NotificationId).HasDefaultValueSql("((1))");

                entity.Property(e => e.SendingDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AdminRecieve)
                    .WithMany(p => p.UserNotificationRel)
                    .HasForeignKey(d => d.AdminRecieveId)
                    .HasConstraintName("FK_UserNotificationRel_Login");

                entity.HasOne(d => d.Notification)
                    .WithMany(p => p.UserNotificationRel)
                    .HasForeignKey(d => d.NotificationId)
                    .HasConstraintName("FK_UserNotificationRel_Notification");

                entity.HasOne(d => d.UserRecieve)
                    .WithMany(p => p.UserNotificationRel)
                    .HasForeignKey(d => d.UserRecieveId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("UsersRecievers");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole", "logs");

                entity.HasOne(d => d.Controller)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.ControllerId)
                    .HasConstraintName("FK_UserRole_SiteControllers");

                entity.HasOne(d => d.Login)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.LoginId)
                    .HasConstraintName("FK_UserRole_Login");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserRole_Users");
            });

            modelBuilder.Entity<UserTracks>(entity =>
            {
                entity.ToTable("userTracks", "Users");

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.TrackName).HasMaxLength(100);
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType", "RBT");

                entity.Property(e => e.NameAr).HasMaxLength(50);

                entity.Property(e => e.NameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users", "RBT");

                entity.HasIndex(e => new { e.ProviderId, e.Email })
                    .HasName("NonClusteredIndex-20170129-152618")
                    .IsUnique();

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InsertionDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mobile)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_Users_Providers");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserType");

                entity.HasOne(d => d.UserStatusNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserStatus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Status");
            });

            modelBuilder.Entity<UsrCategory>(entity =>
            {
                entity.ToTable("usrCategory", "Users");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.InsertionDate).HasColumnType("datetime");

                entity.Property(e => e.ModificationDate).HasColumnType("datetime");

                entity.Property(e => e.NameEn).HasMaxLength(50);
            });

            modelBuilder.Entity<YouTubeReportsEntertainment>(entity =>
            {
                entity.Property(e => e.AdjustmentType).HasMaxLength(500);

                entity.Property(e => e.AssetChannelId)
                    .HasColumnName("AssetChannelID")
                    .HasMaxLength(500);

                entity.Property(e => e.AssetId)
                    .HasColumnName("AssetID")
                    .HasMaxLength(500);

                entity.Property(e => e.AssetLabels).HasMaxLength(500);

                entity.Property(e => e.AssetTitle).HasMaxLength(500);

                entity.Property(e => e.AssetType).HasMaxLength(500);

                entity.Property(e => e.CustomId)
                    .HasColumnName("CustomID")
                    .HasMaxLength(500);

                entity.Property(e => e.OwnedViews).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenue).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueAuction).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenuePartnerSoldPartnerServed).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenuePartnerSoldYouTubeServed).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueReserved).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplit).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitAuction).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitPartnerSoldPartnerServedYouTubeRevenueSplit).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitPartnerSoldYouTubeServed).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitReserved).HasMaxLength(500);
            });

            modelBuilder.Entity<YouTubeReportsMusic>(entity =>
            {
                entity.Property(e => e.AdjustmentType).HasMaxLength(500);

                entity.Property(e => e.AdministerPublishRights).HasMaxLength(500);

                entity.Property(e => e.Album).HasMaxLength(500);

                entity.Property(e => e.Artist).HasMaxLength(500);

                entity.Property(e => e.AssetChannelId)
                    .HasColumnName("AssetChannelID")
                    .HasMaxLength(500);

                entity.Property(e => e.AssetId)
                    .HasColumnName("AssetID")
                    .HasMaxLength(500);

                entity.Property(e => e.AssetLabels).HasMaxLength(500);

                entity.Property(e => e.AssetTitle).HasMaxLength(500);

                entity.Property(e => e.AssetType).HasMaxLength(500);

                entity.Property(e => e.CustomId)
                    .HasColumnName("CustomID")
                    .HasMaxLength(500);

                entity.Property(e => e.Grid)
                    .HasColumnName("GRid")
                    .HasMaxLength(500);

                entity.Property(e => e.Isrc)
                    .HasColumnName("ISRC")
                    .HasMaxLength(500);

                entity.Property(e => e.Label).HasMaxLength(500);

                entity.Property(e => e.OwnedViews).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenue).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueAuction).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenuePartnerSoldPartnerServed).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenuePartnerSoldYouTubeServed).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueReserved).HasMaxLength(500);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplit).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitAuction).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitPartnerSoldPartnerServed).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitPartnerSoldYouTubeServed).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitReserved).HasMaxLength(500);
            });

            modelBuilder.Entity<YouTubeTemp>(entity =>
            {
                entity.Property(e => e.AssetChannel).HasMaxLength(500);

                entity.Property(e => e.AssetId).HasMaxLength(500);

                entity.Property(e => e.AssetLabels).HasMaxLength(500);

                entity.Property(e => e.AssetTitle).HasMaxLength(500);

                entity.Property(e => e.Country).HasMaxLength(500);

                entity.Property(e => e.CustomId).HasMaxLength(500);

                entity.Property(e => e.OwnedViews).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsAdEnabled).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsAdRequested).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsChannelPage).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsEmbeddedPlayer).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsLive).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsOnDemand).HasMaxLength(500);

                entity.Property(e => e.OwnedViewsWatchPage).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenue).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueAdSenseServedYouTubeSold).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueDoubleClickServedPartnerSold).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenueDoubleClickServedYouTubeSold).HasMaxLength(500);

                entity.Property(e => e.PartnerRevenuePartnerServedPartnerSold).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplit).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitAdSenseServedYouTubeSold).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitDoubleClickServedPartnerSold).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitDoubleClickServedYouTubeSold).HasMaxLength(500);

                entity.Property(e => e.YouTubeRevenueSplitPartnerServedPartnerSold).HasMaxLength(500);
            });
        }
    }
}
