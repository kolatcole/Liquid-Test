using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3.Model
{
    public partial class WRI6283Context : DbContext
    {
        public WRI6283Context()
        {
        }

        public WRI6283Context(DbContextOptions<WRI6283Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AcctManager> AcctManagers { get; set; }
        public virtual DbSet<AddContact> AddContacts { get; set; }
        public virtual DbSet<AdditionalCostType> AdditionalCostTypes { get; set; }
        public virtual DbSet<AdvanceReportFormat> AdvanceReportFormats { get; set; }
        public virtual DbSet<Allocation> Allocations { get; set; }
        public virtual DbSet<AnalysisMaster> AnalysisMasters { get; set; }
        public virtual DbSet<AnalysisValue> AnalysisValues { get; set; }
        public virtual DbSet<ApprovalState> ApprovalStates { get; set; }
        public virtual DbSet<AssociateContact> AssociateContacts { get; set; }
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AuditDelete> AuditDeletes { get; set; }
        public virtual DbSet<BackOrderFile> BackOrderFiles { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BankAcct> BankAccts { get; set; }
        public virtual DbSet<BankAudit> BankAudits { get; set; }
        public virtual DbSet<BankFeedColName> BankFeedColNames { get; set; }
        public virtual DbSet<BankFeedDatum> BankFeedData { get; set; }
        public virtual DbSet<BankFeedTemplateDetail> BankFeedTemplateDetails { get; set; }
        public virtual DbSet<BankFeedTemplateHeader> BankFeedTemplateHeaders { get; set; }
        public virtual DbSet<Batch> Batches { get; set; }
        public virtual DbSet<BatchFile> BatchFiles { get; set; }
        public virtual DbSet<BatchNumber> BatchNumbers { get; set; }
        public virtual DbSet<BatchOrderFile> BatchOrderFiles { get; set; }
        public virtual DbSet<Bomcomponent> Bomcomponents { get; set; }
        public virtual DbSet<Bomitem> Bomitems { get; set; }
        public virtual DbSet<Bommanufacture> Bommanufactures { get; set; }
        public virtual DbSet<BommanufactureAdditionalCost> BommanufactureAdditionalCosts { get; set; }
        public virtual DbSet<BommanufactureComponent> BommanufactureComponents { get; set; }
        public virtual DbSet<BommanufactureStatus> BommanufactureStatuses { get; set; }
        public virtual DbSet<Bomstatus> Bomstatuses { get; set; }
        public virtual DbSet<Bomtracking> Bomtrackings { get; set; }
        public virtual DbSet<Bomtype> Bomtypes { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<CashAcct> CashAccts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryList> CategoryLists { get; set; }
        public virtual DbSet<Ci> Cis { get; set; }
        public virtual DbSet<CompStatus> CompStatuses { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<ContactAppSupp> ContactAppSupps { get; set; }
        public virtual DbSet<ContactHistory> ContactHistories { get; set; }
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<ContractTran> ContractTrans { get; set; }
        public virtual DbSet<CostingType> CostingTypes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CurrExch> CurrExches { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CustProduct> CustProducts { get; set; }
        public virtual DbSet<CustomTemplate> CustomTemplates { get; set; }
        public virtual DbSet<DebtChase> DebtChases { get; set; }
        public virtual DbSet<DebtGroup> DebtGroups { get; set; }
        public virtual DbSet<DebtManage> DebtManages { get; set; }
        public virtual DbSet<Declaration> Declarations { get; set; }
        public virtual DbSet<DeliveryTerm> DeliveryTerms { get; set; }
        public virtual DbSet<Deposit> Deposits { get; set; }
        public virtual DbSet<Dept> Depts { get; set; }
        public virtual DbSet<DeptGroup> DeptGroups { get; set; }
        public virtual DbSet<Diary> Diaries { get; set; }
        public virtual DbSet<EeChargeRate> EeChargeRates { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeNote> EmployeeNotes { get; set; }
        public virtual DbSet<Ep> Eps { get; set; }
        public virtual DbSet<Epo> Epos { get; set; }
        public virtual DbSet<Eposlookup> Eposlookups { get; set; }
        public virtual DbSet<ExcelFile> ExcelFiles { get; set; }
        public virtual DbSet<GlobalVariable> GlobalVariables { get; set; }
        public virtual DbSet<GoCardlessFeedDatum> GoCardlessFeedData { get; set; }
        public virtual DbSet<GoCardlessImportDatum> GoCardlessImportData { get; set; }
        public virtual DbSet<GovTalkHeader> GovTalkHeaders { get; set; }
        public virtual DbSet<Grn> Grns { get; set; }
        public virtual DbSet<Grnsale> Grnsales { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<GroupMember> GroupMembers { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<InvoiceDesign> InvoiceDesigns { get; set; }
        public virtual DbSet<JobDetail> JobDetails { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<LocationStock> LocationStocks { get; set; }
        public virtual DbSet<LuLocationType> LuLocationTypes { get; set; }
        public virtual DbSet<Mapping> Mappings { get; set; }
        public virtual DbSet<ModeOfContact> ModeOfContacts { get; set; }
        public virtual DbSet<Nic> Nics { get; set; }
        public virtual DbSet<Nirate> Nirates { get; set; }
        public virtual DbSet<Nlgroup> Nlgroups { get; set; }
        public virtual DbSet<NlgroupOld> NlgroupOlds { get; set; }
        public virtual DbSet<Nltran> Nltrans { get; set; }
        public virtual DbSet<NltranAdd> NltranAdds { get; set; }
        public virtual DbSet<Nominal> Nominals { get; set; }
        public virtual DbSet<NominalOld> NominalOlds { get; set; }
        public virtual DbSet<Nompost> Nomposts { get; set; }
        public virtual DbSet<Nomtemplate> Nomtemplates { get; set; }
        public virtual DbSet<NumberStatus> NumberStatuses { get; set; }
        public virtual DbSet<OnlineSeller> OnlineSellers { get; set; }
        public virtual DbSet<OnlineSellerShop> OnlineSellerShops { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<P11> P11s { get; set; }
        public virtual DbSet<P14> P14s { get; set; }
        public virtual DbSet<P35> P35s { get; set; }
        public virtual DbSet<PayErCont> PayErConts { get; set; }
        public virtual DbSet<PayPalBankFeedDatum> PayPalBankFeedData { get; set; }
        public virtual DbSet<PayPalImportDatum> PayPalImportData { get; set; }
        public virtual DbSet<Payamount> Payamounts { get; set; }
        public virtual DbSet<Payrate> Payrates { get; set; }
        public virtual DbSet<PayrollJournal> PayrollJournals { get; set; }
        public virtual DbSet<PickingSlipSummary> PickingSlipSummaries { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Price> Prices { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<RelatedContact> RelatedContacts { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }
        public virtual DbSet<ReportTemplateHeader> ReportTemplateHeaders { get; set; }
        public virtual DbSet<ReportWriter> ReportWriters { get; set; }
        public virtual DbSet<Reportsdb> Reportsdbs { get; set; }
        public virtual DbSet<SaleOrder> SaleOrders { get; set; }
        public virtual DbSet<SaleOrderRecd> SaleOrderRecds { get; set; }
        public virtual DbSet<SalesAnalysis> SalesAnalyses { get; set; }
        public virtual DbSet<Salesman> Salesmen { get; set; }
        public virtual DbSet<SelectOption> SelectOptions { get; set; }
        public virtual DbSet<SerialNumber> SerialNumbers { get; set; }
        public virtual DbSet<SlitemNote> SlitemNotes { get; set; }
        public virtual DbSet<Slnote> Slnotes { get; set; }
        public virtual DbSet<Smp> Smps { get; set; }
        public virtual DbSet<Ssp> Ssps { get; set; }
        public virtual DbSet<StandardText> StandardTexts { get; set; }
        public virtual DbSet<StandingOrder> StandingOrders { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<StockAssigned> StockAssigneds { get; set; }
        public virtual DbSet<StockBuild> StockBuilds { get; set; }
        public virtual DbSet<StockCostAssigned> StockCostAssigneds { get; set; }
        public virtual DbSet<StockCosting> StockCostings { get; set; }
        public virtual DbSet<StockCount> StockCounts { get; set; }
        public virtual DbSet<StockSupplier> StockSuppliers { get; set; }
        public virtual DbSet<StockTracking> StockTrackings { get; set; }
        public virtual DbSet<StockType> StockTypes { get; set; }
        public virtual DbSet<Stprice> Stprices { get; set; }
        public virtual DbSet<SubConTo> SubConTos { get; set; }
        public virtual DbSet<Subsidiary> Subsidiaries { get; set; }
        public virtual DbSet<SumUpFeedDatum> SumUpFeedData { get; set; }
        public virtual DbSet<SumUpImportDatum> SumUpImportData { get; set; }
        public virtual DbSet<SuppCi> SuppCis { get; set; }
        public virtual DbSet<SuppOrder> SuppOrders { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<Taxrate> Taxrates { get; set; }
        public virtual DbSet<Term> Terms { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Timesheet> Timesheets { get; set; }
        public virtual DbSet<TrackingType> TrackingTypes { get; set; }
        public virtual DbSet<Treasury> Treasuries { get; set; }
        public virtual DbSet<UploadedFile> UploadedFiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserAccordion> UserAccordions { get; set; }
        public virtual DbSet<UserBankAcct> UserBankAccts { get; set; }
        public virtual DbSet<UserBankFeedDatum> UserBankFeedData { get; set; }
        public virtual DbSet<UserBankImportDatum> UserBankImportData { get; set; }
        public virtual DbSet<UserDefObject> UserDefObjects { get; set; }
        public virtual DbSet<Vat> Vats { get; set; }
        public virtual DbSet<VatdrCr> VatdrCrs { get; set; }
        public virtual DbSet<Vatefile> Vatefiles { get; set; }
        public virtual DbSet<VatefileB> VatefileBs { get; set; }
        public virtual DbSet<Vatsaved> Vatsaveds { get; set; }
        public virtual DbSet<Xmluploaded> Xmluploadeds { get; set; }
        public virtual DbSet<Ybpayment> Ybpayments { get; set; }
        public virtual DbSet<YearEnd> YearEnds { get; set; }
        public virtual DbSet<YearEndReport> YearEndReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                 // optionsBuilder.UseSqlServer("Server=LAPTOP-28P35B81\\sqlexpress;Initial Catalog=WRI6283;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                  optionsBuilder.UseSqlServer("Server=VM7A14658;Database=WRI6283;User ID=sa;Password=hciFaLY54W@nu5L");

                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AcctManager>(entity =>
            {
                entity.HasKey(e => e.ManagerName);

                entity.ToTable("AcctManager");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AddContact>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AssistantName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Business_Name");

                entity.Property(e => e.ContactAdded).HasColumnType("smalldatetime");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.County)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeyId).HasColumnName("KeyID");

                entity.Property(e => e.ManagerName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AdditionalCostType>(entity =>
            {
                entity.ToTable("AdditionalCost_Type");

                entity.Property(e => e.AdditionalCostTypeId).HasColumnName("AdditionalCost_TypeID");

                entity.Property(e => e.AdditionalCostType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AdditionalCost_Type");
            });

            modelBuilder.Entity<AdvanceReportFormat>(entity =>
            {
                entity.ToTable("AdvanceReportFormat");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Align)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Columns)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Font)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsVisible).HasColumnName("isVisible");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");
            });

            modelBuilder.Entity<Allocation>(entity =>
            {
                entity.ToTable("Allocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Allocated).HasColumnType("money");

                entity.Property(e => e.AllocatedCurr).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EntryDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnalysisMaster>(entity =>
            {
                entity.ToTable("AnalysisMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DebitCredit)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Vattreatment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VATTreatment");
            });

            modelBuilder.Entity<AnalysisValue>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Col)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ref)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueMoney).HasColumnType("money");
            });

            modelBuilder.Entity<ApprovalState>(entity =>
            {
                entity.HasKey(e => e.ApId);

                entity.ToTable("ApprovalState");

                entity.Property(e => e.ApId).HasColumnName("AP_ID");

                entity.Property(e => e.ApDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AP_Description");

                entity.Property(e => e.ApNotes)
                    .HasColumnType("text")
                    .HasColumnName("AP_Notes");
            });

            modelBuilder.Entity<AssociateContact>(entity =>
            {
                entity.Property(e => e.AddContactId).HasColumnName("AddContactID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.ToTable("Audit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AuditRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Changes).HasColumnType("text");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<AuditDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AuditDelete");

                entity.Property(e => e.AdAudit)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AdDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdKey).ValueGeneratedOnAdd();

                entity.Property(e => e.AdNet).HasColumnType("money");

                entity.Property(e => e.AdQty).HasColumnType("money");

                entity.Property(e => e.AdRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdSource)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AdStock).HasMaxLength(50);

                entity.Property(e => e.AdVat)
                    .HasColumnType("money")
                    .HasColumnName("AdVAT");

                entity.Property(e => e.AdVatcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AdVATCode");

                entity.Property(e => e.AdVatflagged)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AdVATFlagged")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdVatreturn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AdVATReturn");

                entity.Property(e => e.AdYearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.AdonDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<BackOrderFile>(entity =>
            {
                entity.ToTable("BackOrderFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateDelivered).HasColumnType("smalldatetime");

                entity.Property(e => e.DateEntered).HasColumnType("smalldatetime");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("location");

                entity.Property(e => e.QtyDelivered).HasColumnType("money");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.ToTable("bank");

                entity.Property(e => e.BankId).HasColumnName("Bank_ID");

                entity.Property(e => e.BankAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Acct");

                entity.Property(e => e.BankAmount)
                    .HasColumnType("money")
                    .HasColumnName("Bank_Amount");

                entity.Property(e => e.BankDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Bank_Date");

                entity.Property(e => e.BankDetail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Detail");

                entity.Property(e => e.BankMemo)
                    .HasColumnType("text")
                    .HasColumnName("Bank_Memo");

                entity.Property(e => e.BankNet)
                    .HasColumnType("money")
                    .HasColumnName("Bank_Net");

                entity.Property(e => e.BankNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bank_No");

                entity.Property(e => e.BankNominal)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Nominal");

                entity.Property(e => e.BankOurRef)
                    .HasColumnType("numeric(19, 0)")
                    .HasColumnName("Bank_OurRef");

                entity.Property(e => e.BankPeriod).HasColumnName("Bank_Period");

                entity.Property(e => e.BankPosted)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Posted");

                entity.Property(e => e.BankRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Ref");

                entity.Property(e => e.BankSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Source");

                entity.Property(e => e.BankSubCat)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bank_SubCat");

                entity.Property(e => e.BankVat)
                    .HasColumnType("money")
                    .HasColumnName("Bank_VAT");

                entity.Property(e => e.BankVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Bank_VATCode");

                entity.Property(e => e.BankYe)
                    .HasColumnType("datetime")
                    .HasColumnName("Bank_YE");
            });

            modelBuilder.Entity<BankAcct>(entity =>
            {
                entity.ToTable("BankAcct");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcctCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AcctName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AcctNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Forex)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.ImportFileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaidControl)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptsControl)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RollNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StatFreq)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Swiftcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SWIFTCode");
            });

            modelBuilder.Entity<BankAudit>(entity =>
            {
                entity.ToTable("BankAudit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Nltkey).HasColumnName("NLTKey");

                entity.Property(e => e.PaidDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Rback).HasColumnName("RBack");

                entity.Property(e => e.Value).HasColumnType("money");
            });

            modelBuilder.Entity<BankFeedColName>(entity =>
            {
                entity.HasKey(e => e.TemplateId);

                entity.Property(e => e.TemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("TemplateID");

                entity.Property(e => e.ColNames).HasMaxLength(2000);

                entity.HasOne(d => d.Template)
                    .WithOne(p => p.BankFeedColName)
                    .HasForeignKey<BankFeedColName>(d => d.TemplateId)
                    .HasConstraintName("FK_BankFeedColNames_BankFeedTemplateHeader");
            });

            modelBuilder.Entity<BankFeedDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addeddate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("BatchID")
                    .IsFixedLength(true);

                entity.Property(e => e.Contact).HasMaxLength(200);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.Nominal)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PaidIn).HasColumnType("money");

                entity.Property(e => e.Paidout).HasColumnType("money");

                entity.Property(e => e.Processed)
                    .HasColumnName("processed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Vat)
                    .HasMaxLength(50)
                    .HasColumnName("VAT");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.BankFeedData)
                    .HasForeignKey(d => d.TemplateId)
                    .HasConstraintName("FK_BankFeedData_BankFeedTemplateHeader");
            });

            modelBuilder.Entity<BankFeedTemplateDetail>(entity =>
            {
                entity.HasKey(e => e.TemplateId)
                    .HasName("PK_BankFeedTemplateDetails_1");

                entity.Property(e => e.TemplateId)
                    .ValueGeneratedNever()
                    .HasColumnName("TemplateID");

                entity.Property(e => e.DebitCredit)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaidIn).HasMaxLength(100);

                entity.Property(e => e.PaidOut).HasMaxLength(100);

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.TransactionDate).HasMaxLength(100);

                entity.HasOne(d => d.Template)
                    .WithOne(p => p.BankFeedTemplateDetail)
                    .HasForeignKey<BankFeedTemplateDetail>(d => d.TemplateId)
                    .HasConstraintName("FK_BankFeedTemplateDetails_BankFeedTemplateHeader");
            });

            modelBuilder.Entity<BankFeedTemplateHeader>(entity =>
            {
                entity.ToTable("BankFeedTemplateHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Batch>(entity =>
            {
                entity.ToTable("Batch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Costing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrNet).HasColumnType("money");

                entity.Property(e => e.CurrVat).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DelivlDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Ledger)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.OurInvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Qty).HasColumnType("money");

                entity.Property(e => e.SettleDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TheirRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<BatchFile>(entity =>
            {
                entity.ToTable("BatchFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ledger)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("LineNo ");

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.NomCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OurInvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Repeat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TheirRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<BatchNumber>(entity =>
            {
                entity.HasKey(e => e.BatchNumber1)
                    .HasName("PK__BatchNum__F869ED6C25EB987A");

                entity.ToTable("BatchNumber");

                entity.Property(e => e.BatchNumber1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("BatchNumber");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.ValidDate).HasColumnType("datetime");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.BatchNumbers)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BatchNumb__Statu__563FA78C");
            });

            modelBuilder.Entity<BatchOrderFile>(entity =>
            {
                entity.ToTable("BatchOrderFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineNo).HasColumnName("LineNo ");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bomcomponent>(entity =>
            {
                entity.ToTable("BOMComponent");

                entity.Property(e => e.BomcomponentId).HasColumnName("BOMComponentID");

                entity.Property(e => e.Bomcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMCode");

                entity.Property(e => e.Bomcost).HasColumnName("BOMCost");

                entity.Property(e => e.BomstatusId).HasColumnName("BOMStatusID");

                entity.Property(e => e.ComponentCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IsBom).HasColumnName("IsBOM");

                entity.HasOne(d => d.BomcodeNavigation)
                    .WithMany(p => p.Bomcomponents)
                    .HasForeignKey(d => d.Bomcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMCompon__BOMCo__3B8BB150");

                entity.HasOne(d => d.Bomstatus)
                    .WithMany(p => p.Bomcomponents)
                    .HasForeignKey(d => d.BomstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMCompon__BOMSt__3D73F9C2");

                entity.HasOne(d => d.ComponentCodeNavigation)
                    .WithMany(p => p.Bomcomponents)
                    .HasForeignKey(d => d.ComponentCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMCompon__Compo__3C7FD589");
            });

            modelBuilder.Entity<Bomitem>(entity =>
            {
                entity.HasKey(e => e.Bomcode)
                    .HasName("PK__BOMItem__45EA9B8E73DBE84D");

                entity.ToTable("BOMItem");

                entity.Property(e => e.Bomcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMCode");

                entity.Property(e => e.BomdefaultLocation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BOMDefaultLocation");

                entity.Property(e => e.Bomdescription)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("BOMDescription");

                entity.Property(e => e.BomisUniqueSerial).HasColumnName("BOMIsUniqueSerial");

                entity.Property(e => e.BomstatusId).HasColumnName("BOMStatusID");

                entity.Property(e => e.BomtrackId).HasColumnName("BOMTrackID");

                entity.Property(e => e.BomtypeId).HasColumnName("BOMTypeID");

                entity.Property(e => e.BomunitOfMeasure)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("BOMUnitOfMeasure");

                entity.HasOne(d => d.BomdefaultLocationNavigation)
                    .WithMany(p => p.Bomitems)
                    .HasForeignKey(d => d.BomdefaultLocation)
                    .HasConstraintName("FK__BOMItem__BOMDefa__38AF44A5");

                entity.HasOne(d => d.Bomstatus)
                    .WithMany(p => p.Bomitems)
                    .HasForeignKey(d => d.BomstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMItem__BOMStat__36C6FC33");

                entity.HasOne(d => d.Bomtrack)
                    .WithMany(p => p.Bomitems)
                    .HasForeignKey(d => d.BomtrackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMItem__BOMTrac__37BB206C");

                entity.HasOne(d => d.Bomtype)
                    .WithMany(p => p.Bomitems)
                    .HasForeignKey(d => d.BomtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMItem__BOMType__35D2D7FA");
            });

            modelBuilder.Entity<Bommanufacture>(entity =>
            {
                entity.HasKey(e => e.BommanufacturingReference)
                    .HasName("PK__BOMManuf__BEF680EEA9AEC1FB");

                entity.ToTable("BOMManufacture");

                entity.Property(e => e.BommanufacturingReference)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BOMManufacturingReference");

                entity.Property(e => e.Bomcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMCode");

                entity.Property(e => e.Bomdate)
                    .HasColumnType("datetime")
                    .HasColumnName("BOMDate");

                entity.Property(e => e.Bomtype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMType");

                entity.Property(e => e.BomunitCost).HasColumnName("BOMUnitCost");

                entity.Property(e => e.Bomwarehouse)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("BOMWarehouse");

                entity.Property(e => e.ManufactureStatusId).HasColumnName("ManufactureStatusID");

                entity.Property(e => e.Qtymanufactured).HasColumnName("QTYManufactured");

                entity.Property(e => e.TrackingNumber)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.BomcodeNavigation)
                    .WithMany(p => p.Bommanufactures)
                    .HasForeignKey(d => d.Bomcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMManufa__BOMCo__4238AEDF");

                entity.HasOne(d => d.BomwarehouseNavigation)
                    .WithMany(p => p.Bommanufactures)
                    .HasForeignKey(d => d.Bomwarehouse)
                    .HasConstraintName("FK__BOMManufa__BOMWa__432CD318");

                entity.HasOne(d => d.ManufactureStatus)
                    .WithMany(p => p.Bommanufactures)
                    .HasForeignKey(d => d.ManufactureStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMManufa__Manuf__4420F751");
            });

            modelBuilder.Entity<BommanufactureAdditionalCost>(entity =>
            {
                entity.HasKey(e => e.AdditionalCostId)
                    .HasName("PK__BOMManuf__D6DBF6CEF0AE0279");

                entity.ToTable("BOMManufacture_AdditionalCost");

                entity.Property(e => e.AdditionalCostId).HasColumnName("AdditionalCost_ID");

                entity.Property(e => e.AdditionalCostTypeId).HasColumnName("AdditionalCost_TypeID");

                entity.Property(e => e.BommanufactureReference)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BOMManufactureReference");

                entity.HasOne(d => d.AdditionalCostType)
                    .WithMany(p => p.BommanufactureAdditionalCosts)
                    .HasForeignKey(d => d.AdditionalCostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMManufa__Addit__49D9D0A7");

                entity.HasOne(d => d.BommanufactureReferenceNavigation)
                    .WithMany(p => p.BommanufactureAdditionalCosts)
                    .HasForeignKey(d => d.BommanufactureReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMManufa__BOMMa__48E5AC6E");
            });

            modelBuilder.Entity<BommanufactureComponent>(entity =>
            {
                entity.HasKey(e => e.BommanufactureComponentsId)
                    .HasName("PK__BOMManuf__90537A27C7471435");

                entity.ToTable("BOMManufacture_Components");

                entity.Property(e => e.BommanufactureComponentsId).HasColumnName("BOMManufacture_Components_ID");

                entity.Property(e => e.Bomcomponents)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMComponents");

                entity.Property(e => e.BommanufactureReference)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BOMManufactureReference");

                entity.Property(e => e.StockAssignId).HasColumnName("StockAssignID");

                entity.Property(e => e.StockTrackingId).HasColumnName("StockTrackingID");

                entity.Property(e => e.TrackingReference)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnName("Unit Cost");

                entity.HasOne(d => d.BomcomponentsNavigation)
                    .WithMany(p => p.BommanufactureComponents)
                    .HasForeignKey(d => d.Bomcomponents)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMManufa__BOMCo__6399A2AA");

                entity.HasOne(d => d.BommanufactureReferenceNavigation)
                    .WithMany(p => p.BommanufactureComponents)
                    .HasForeignKey(d => d.BommanufactureReference)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMManufa__BOMMa__648DC6E3");

                entity.HasOne(d => d.StockAssign)
                    .WithMany(p => p.BommanufactureComponents)
                    .HasForeignKey(d => d.StockAssignId)
                    .HasConstraintName("FK__BOMManufa__Stock__6581EB1C");

                entity.HasOne(d => d.StockTracking)
                    .WithMany(p => p.BommanufactureComponents)
                    .HasForeignKey(d => d.StockTrackingId)
                    .HasConstraintName("FK__BOMManufa__Stock__66760F55");
            });

            modelBuilder.Entity<BommanufactureStatus>(entity =>
            {
                entity.HasKey(e => e.ManufactureStatusId)
                    .HasName("PK__BOMManuf__7FA782467D22AFFE");

                entity.ToTable("BOMManufactureStatus");

                entity.Property(e => e.ManufactureStatusId).HasColumnName("ManufactureStatusID");

                entity.Property(e => e.ManufactureStatus)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bomstatus>(entity =>
            {
                entity.ToTable("BOMStatus");

                entity.Property(e => e.BomstatusId).HasColumnName("BOMStatusID");

                entity.Property(e => e.Bomstatus1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMStatus");

                entity.Property(e => e.BomtypeId).HasColumnName("BOMTypeID");

                entity.HasOne(d => d.Bomtype)
                    .WithMany(p => p.Bomstatuses)
                    .HasForeignKey(d => d.BomtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BOMStatus__BOMTy__310E22DD");
            });

            modelBuilder.Entity<Bomtracking>(entity =>
            {
                entity.HasKey(e => e.BomtrackId)
                    .HasName("PK__BOMTrack__BADD34667C2A75F5");

                entity.ToTable("BOMTracking");

                entity.Property(e => e.BomtrackId).HasColumnName("BOMTrackID");

                entity.Property(e => e.Bomtracking1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMTracking");
            });

            modelBuilder.Entity<Bomtype>(entity =>
            {
                entity.ToTable("BOMType");

                entity.Property(e => e.BomtypeId).HasColumnName("BOMTypeID");

                entity.Property(e => e.Bomtype1)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BOMType");
            });

            modelBuilder.Entity<Budget>(entity =>
            {
                entity.HasKey(e => e.BudId);

                entity.ToTable("budgets");

                entity.Property(e => e.BudId).HasColumnName("BudID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BudCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudDept)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BudYear).HasColumnType("datetime");
            });

            modelBuilder.Entity<CashAcct>(entity =>
            {
                entity.HasKey(e => e.Detail);

                entity.ToTable("CashAcct");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Account)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CatId);

                entity.ToTable("Category");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Category1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Category");

                entity.Property(e => e.Description).HasColumnType("text");
            });

            modelBuilder.Entity<CategoryList>(entity =>
            {
                entity.HasKey(e => e.CatListId);

                entity.ToTable("CategoryList");

                entity.Property(e => e.CatListId).HasColumnName("CatListID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Ci>(entity =>
            {
                entity.ToTable("CIS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cistype)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CISType");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LabCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LabNom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Labour).HasColumnType("money");

                entity.Property(e => e.MatCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MatNom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Materials).HasColumnType("money");

                entity.Property(e => e.Paid).HasColumnType("money");

                entity.Property(e => e.PaidRef)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxDeducted).HasColumnType("money");

                entity.Property(e => e.TheirRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<CompStatus>(entity =>
            {
                entity.HasKey(e => e.CompStatus1);

                entity.ToTable("CompStatus");

                entity.Property(e => e.CompStatus1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CompStatus");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("company");

                entity.Property(e => e.CoAccurals)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Accurals");

                entity.Property(e => e.CoAdd1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CO_Add1");

                entity.Property(e => e.CoAdd2)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CO_Add2");

                entity.Property(e => e.CoAdd3)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CO_Add3");

                entity.Property(e => e.CoAdd4)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CO_Add4");

                entity.Property(e => e.CoArcDrive)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CO_ArcDrive");

                entity.Property(e => e.CoBankId)
                    .HasColumnType("numeric(10, 0)")
                    .HasColumnName("CO_BankID");

                entity.Property(e => e.CoBsstartNo).HasColumnName("CO_BSStartNo");

                entity.Property(e => e.CoCashControl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Cash_Control");

                entity.Property(e => e.CoCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CO_Code");

                entity.Property(e => e.CoContLabRate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Cont_Lab_Rate");

                entity.Property(e => e.CoCtry)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CO_Ctry");

                entity.Property(e => e.CoCurrentYe)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CO_Current_YE");

                entity.Property(e => e.CoDatePeriod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Date_Period");

                entity.Property(e => e.CoDbName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CO_dbName");

                entity.Property(e => e.CoDefaultBank)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Default_Bank");

                entity.Property(e => e.CoDiscControl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Disc_Control");

                entity.Property(e => e.CoEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Co_Email");

                entity.Property(e => e.CoEmployeeAlias)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Co_EmployeeAlias");

                entity.Property(e => e.CoEndNight)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_EndNight");

                entity.Property(e => e.CoEori)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("Co_EORI");

                entity.Property(e => e.CoExt)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CO_Ext");

                entity.Property(e => e.CoFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_Fax");

                entity.Property(e => e.CoInvName)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CO_Inv_Name");

                entity.Property(e => e.CoKey).HasColumnName("CO_Key");

                entity.Property(e => e.CoLogoText)
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasColumnName("CO_Logo_Text");

                entity.Property(e => e.CoMessTerms)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CO_MessTerms");

                entity.Property(e => e.CoName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CO_Name");

                entity.Property(e => e.CoNetPayAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Net_Pay_Acct");

                entity.Property(e => e.CoNlAuditNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_NL_Audit_No");

                entity.Property(e => e.CoNlReserves)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_NL_Reserves");

                entity.Property(e => e.CoNoPeriods)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_No_Periods");

                entity.Property(e => e.CoNomPeriod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Nom_Period");

                entity.Property(e => e.CoPayTaxYear)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CO_Pay_Tax_Year");

                entity.Property(e => e.CoPayeNicAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_PAYE_NIC_Acct");

                entity.Property(e => e.CoPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_Phone");

                entity.Property(e => e.CoPlControl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_PL_Control");

                entity.Property(e => e.CoPlInvNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_PL_Inv_No");

                entity.Property(e => e.CoPlOrdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_PL_Ord_No");

                entity.Property(e => e.CoPlPeriod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_PL_Period");

                entity.Property(e => e.CoPlorderFile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Co_PLOrderFile");

                entity.Property(e => e.CoPostcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_Postcode");

                entity.Property(e => e.CoPrepayment)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Prepayment");

                entity.Property(e => e.CoRegNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CO_Reg_No");

                entity.Property(e => e.CoServInvNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_ServInv_No");

                entity.Property(e => e.CoSlControl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_SL_Control");

                entity.Property(e => e.CoSlEnqNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_SL_Enq_No");

                entity.Property(e => e.CoSlInvNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_SL_Inv_No");

                entity.Property(e => e.CoSlPeriod)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_SL_Period");

                entity.Property(e => e.CoStartNight)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_StartNight");

                entity.Property(e => e.CoStdLabRate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Std_Lab_Rate");

                entity.Property(e => e.CoStdNom)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Std_Nom");

                entity.Property(e => e.CoSuspense)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Suspense");

                entity.Property(e => e.CoTaxOfficeName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_TaxOfficeName");

                entity.Property(e => e.CoTaxRef)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CO_Tax_Ref");

                entity.Property(e => e.CoVatCashIAcc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_VAT_CashI_Acc");

                entity.Property(e => e.CoVatControl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_VAT_Control");

                entity.Property(e => e.CoVatNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CO_VAT_Number");

                entity.Property(e => e.CoViewCoOnly)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_View_Co_Only");

                entity.Property(e => e.CostingTypeId)
                    .HasColumnName("CostingTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmailFooter).HasColumnType("text");

                entity.Property(e => e.PaypalClientId)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("PaypalClientID");

                entity.Property(e => e.PaypalClientSecret)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Prn).HasColumnName("PRN");

                entity.Property(e => e.Slaged1)
                    .HasColumnType("money")
                    .HasColumnName("SLAged1");

                entity.Property(e => e.Slaged2)
                    .HasColumnType("money")
                    .HasColumnName("SLAged2");

                entity.Property(e => e.Slaged3)
                    .HasColumnType("money")
                    .HasColumnName("SLAged3");

                entity.Property(e => e.Slaged4)
                    .HasColumnType("money")
                    .HasColumnName("SLAged4");

                entity.Property(e => e.VatflatRate)
                    .HasColumnType("money")
                    .HasColumnName("VATFlatRate");

                entity.Property(e => e.YearStart).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.CnKey);

                entity.ToTable("contacts");

                entity.HasIndex(e => new { e.PlCode, e.CnlOnStop }, "contacts8");

                entity.HasIndex(e => e.SlCode, "idxSLCode");

                entity.HasIndex(e => e.BusinessName, "idxSLCode1");

                entity.Property(e => e.CnKey).HasColumnName("CN_Key");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Business_Name");

                entity.Property(e => e.CapsuleAddressId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsuleAddressID");

                entity.Property(e => e.CapsuleContactId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsuleContactID");

                entity.Property(e => e.CapsuleContactType).HasMaxLength(20);

                entity.Property(e => e.CapsuleEmailId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsuleEmailID");

                entity.Property(e => e.CapsulePhoneFaxId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsulePhoneFaxID");

                entity.Property(e => e.CapsulePhoneId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsulePhoneID");

                entity.Property(e => e.CapsulePhoneMobileId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsulePhoneMobileID");

                entity.Property(e => e.CapsuleWebSiteId)
                    .HasMaxLength(20)
                    .HasColumnName("CapsuleWebSiteID");

                entity.Property(e => e.CnAcctManager)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CN_AcctManager");

                entity.Property(e => e.CnAddress1)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("CN_Address1");

                entity.Property(e => e.CnAddress2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Address2");

                entity.Property(e => e.CnAddress3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Address3");

                entity.Property(e => e.CnAddress4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Address4");

                entity.Property(e => e.CnAddress5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Address5");

                entity.Property(e => e.CnApprovalDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CN_ApprovalDate");

                entity.Property(e => e.CnApprovalState).HasColumnName("CN_ApprovalState");

                entity.Property(e => e.CnApproved).HasColumnName("CN_Approved");

                entity.Property(e => e.CnArchived)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Archived");

                entity.Property(e => e.CnArea)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Area");

                entity.Property(e => e.CnBankAcct)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_BankAcct");

                entity.Property(e => e.CnBankAddress)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CN_BankAddress");

                entity.Property(e => e.CnBankSort)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_BankSort");

                entity.Property(e => e.CnCash).HasColumnName("CN_Cash");

                entity.Property(e => e.CnCashAccount).HasColumnName("CN_CashAccount");

                entity.Property(e => e.CnCoAssigned)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Co_Assigned");

                entity.Property(e => e.CnCoRegNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_CoRegNo");

                entity.Property(e => e.CnContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Contact");

                entity.Property(e => e.CnCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Country");

                entity.Property(e => e.CnCrCardExp)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CN_Cr_Card_Exp");

                entity.Property(e => e.CnCrCardNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_Cr_Card_No");

                entity.Property(e => e.CnCurrency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_Currency")
                    .HasDefaultValueSql("('£')");

                entity.Property(e => e.CnDateArchived)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_DateArchived");

                entity.Property(e => e.CnDept)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Dept");

                entity.Property(e => e.CnEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Email");

                entity.Property(e => e.CnFax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Fax");

                entity.Property(e => e.CnForeignPay).HasColumnName("CN_ForeignPay");

                entity.Property(e => e.CnGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Group");

                entity.Property(e => e.CnInvFile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CN_InvFile");

                entity.Property(e => e.CnInvTemplate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_InvTemplate");

                entity.Property(e => e.CnInvoiceTo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_InvoiceTo");

                entity.Property(e => e.CnMemo)
                    .HasMaxLength(3000)
                    .IsUnicode(false)
                    .HasColumnName("CN_Memo");

                entity.Property(e => e.CnMobile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Mobile");

                entity.Property(e => e.CnOldCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Old_Code");

                entity.Property(e => e.CnPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Phone");

                entity.Property(e => e.CnPostcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_Postcode");

                entity.Property(e => e.CnRegion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Region");

                entity.Property(e => e.CnRemitDetails)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("CN_RemitDetails");

                entity.Property(e => e.CnRemitTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_RemitTo");

                entity.Property(e => e.CnSalesman)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Salesman");

                entity.Property(e => e.CnSalutation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Salutation");

                entity.Property(e => e.CnSld)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_SLD");

                entity.Property(e => e.CnSlm)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_SLM");

                entity.Property(e => e.CnSource)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Source");

                entity.Property(e => e.CnStatMessage)
                    .HasColumnType("text")
                    .HasColumnName("CN_Stat_Message");

                entity.Property(e => e.CnStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_Status")
                    .HasDefaultValueSql("('Contact only')");

                entity.Property(e => e.CnTerms)
                    .HasColumnType("text")
                    .HasColumnName("CN_Terms");

                entity.Property(e => e.CnTermsText)
                    .HasColumnType("text")
                    .HasColumnName("CN_TermsText");

                entity.Property(e => e.CnTitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Title");

                entity.Property(e => e.CnUser1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User1");

                entity.Property(e => e.CnUser10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User10");

                entity.Property(e => e.CnUser2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User2");

                entity.Property(e => e.CnUser3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User3");

                entity.Property(e => e.CnUser4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User4");

                entity.Property(e => e.CnUser5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User5");

                entity.Property(e => e.CnUser6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User6");

                entity.Property(e => e.CnUser7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User7");

                entity.Property(e => e.CnUser8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User8");

                entity.Property(e => e.CnUser9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_User9");

                entity.Property(e => e.CnVat).HasColumnName("CN_VAT");

                entity.Property(e => e.CnVatNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CN_VAT_No");

                entity.Property(e => e.CnWarrExpire)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_Warr_Expire");

                entity.Property(e => e.CnWebSite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CN_WebSite");

                entity.Property(e => e.CnlOnStop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CNL_On_Stop");

                entity.Property(e => e.CoTinumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_TINumber");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.Eomterms).HasColumnName("EOMTerms");

                entity.Property(e => e.Industry)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastAmended).HasColumnType("datetime");

                entity.Property(e => e.PlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PL_Code");

                entity.Property(e => e.SlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SL_Code");

                entity.Property(e => e.SuppLiqCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppLiqWebPass)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ticomments)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TIComments");
            });

            modelBuilder.Entity<ContactAppSupp>(entity =>
            {
                entity.ToTable("ContactAppSupp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");
            });

            modelBuilder.Entity<ContactHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId);

                entity.ToTable("ContactHistory");

                entity.Property(e => e.HistoryId).HasColumnName("HistoryID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.History).HasColumnType("text");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModeOfContact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.HasKey(e => e.ContractNo);

                entity.ToTable("Contract");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CommRate).HasColumnType("money");

                entity.Property(e => e.CostUnitPrice).HasColumnType("money");

                entity.Property(e => e.CostVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CostVATCode");

                entity.Property(e => e.CustOrdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustTerms)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DeliverTo)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.PackSize).HasColumnType("money");

                entity.Property(e => e.PackWeight).HasColumnType("money");

                entity.Property(e => e.Product)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleCurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SaleVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SaleVATCode");

                entity.Property(e => e.SellUnitPrice).HasColumnType("money");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SuppOrdNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SuppTerms)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalQty).HasColumnType("money");
            });

            modelBuilder.Entity<ContractTran>(entity =>
            {
                entity.ToTable("ContractTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActQty).HasColumnType("money");

                entity.Property(e => e.ActualDelDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BudgetDelDate).HasColumnType("smalldatetime");

                entity.Property(e => e.BudgetQty).HasColumnType("money");

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SaleOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.ContractNoNavigation)
                    .WithMany(p => p.ContractTrans)
                    .HasForeignKey(d => d.ContractNo)
                    .HasConstraintName("FK_ContractTran_Contract");
            });

            modelBuilder.Entity<CostingType>(entity =>
            {
                entity.ToTable("CostingType");

                entity.Property(e => e.CostingTypeId).HasColumnName("CostingTypeID");

                entity.Property(e => e.CostingType1)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CostingType");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CoCountry);

                entity.ToTable("country");

                entity.Property(e => e.CoCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_Country");

                entity.Property(e => e.CoCurrDateChg)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CO_Curr_Date_Chg");

                entity.Property(e => e.CoCurrExcRate)
                    .HasColumnType("money")
                    .HasColumnName("CO_Curr_Exc_Rate");

                entity.Property(e => e.CoCurrencyCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CO_Currency_Code");

                entity.Property(e => e.CoCurrencyDesc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_Currency_Desc");

                entity.Property(e => e.CoIntrastatCde)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CO_Intrastat_Cde");

                entity.Property(e => e.CoSwiftcode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CO_SWIFTCode");

                entity.Property(e => e.CoTelCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CO_Tel_Code");

                entity.Property(e => e.CoVatCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CO_VAT_Code");

                entity.Property(e => e.CoVatnumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CO_VATNumber");

                entity.Property(e => e.CoVcLength)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CO_VC_Length");

                entity.Property(e => e.Isocode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISOCode");
            });

            modelBuilder.Entity<CurrExch>(entity =>
            {
                entity.ToTable("CurrExch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Rate).HasColumnType("money");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.CurrCode);

                entity.ToTable("Currency");

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrRate).HasColumnType("money");

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Swift)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SWIFT");
            });

            modelBuilder.Entity<CustProduct>(entity =>
            {
                entity.ToTable("CustProduct");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Product)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TemplateDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Template_Description");

                entity.Property(e => e.TemplateLogo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Template_logo");

                entity.Property(e => e.TemplatePage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Template_Page");
            });

            modelBuilder.Entity<DebtChase>(entity =>
            {
                entity.HasKey(e => e.InvNo);

                entity.ToTable("DebtChase");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateSent).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DebtGroup>(entity =>
            {
                entity.HasKey(e => e.DebtGroup1);

                entity.ToTable("DebtGroup");

                entity.Property(e => e.DebtGroup1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DebtGroup");
            });

            modelBuilder.Entity<DebtManage>(entity =>
            {
                entity.HasKey(e => e.Dmkey);

                entity.ToTable("DebtManage");

                entity.Property(e => e.Dmkey).HasColumnName("DMKey");

                entity.Property(e => e.Dmacct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DMAcct")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Dmcreated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("DMCreated")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dmsession)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DMSession")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Dmtype).HasColumnName("DMType");
            });

            modelBuilder.Entity<Declaration>(entity =>
            {
                entity.ToTable("Declaration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpenseVouchers)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FinalDeclaration).HasColumnType("date");

                entity.Property(e => e.FreeOfTax)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LastFps)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LastFPS");

                entity.Property(e => e.OutsideUk)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OutsideUK");

                entity.Property(e => e.P11dforms)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P11DForms");

                entity.Property(e => e.PaySomeoneElse)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.YearEnd)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeliveryTerm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Deposit>(entity =>
            {
                entity.ToTable("Deposit");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DepositDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dept>(entity =>
            {
                entity.HasKey(e => e.DeptName);

                entity.ToTable("depts");

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BudgetCosts).HasColumnType("money");

                entity.Property(e => e.BudgetSales).HasColumnType("money");

                entity.Property(e => e.DeptDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeptEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("DeptID");

                entity.Property(e => e.DeptManager)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeptStat)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptGroup>(entity =>
            {
                entity.HasKey(e => e.GroupName);

                entity.ToTable("DeptGroup");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupDesc)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupEndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.GroupId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("GroupID");
            });

            modelBuilder.Entity<Diary>(entity =>
            {
                entity.ToTable("Diary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateRun).HasColumnType("smalldatetime");

                entity.Property(e => e.Duser)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DUser");

                entity.Property(e => e.Frequency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgramToRun)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RunBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RunDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Task)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EeChargeRate>(entity =>
            {
                entity.ToTable("EeChargeRate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChargeRate).HasColumnType("money");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EeId).HasColumnName("EeID");

                entity.Property(e => e.PayrollUpdated).HasColumnType("date");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EeAccount)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Account");

                entity.Property(e => e.EeAcctNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Acct_No");

                entity.Property(e => e.EeAdd1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Add1");

                entity.Property(e => e.EeAdd2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Add2");

                entity.Property(e => e.EeAdd3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Add3");

                entity.Property(e => e.EeAppointDir)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ee_Appoint_Dir");

                entity.Property(e => e.EeBankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Bank_Name");

                entity.Property(e => e.EeBranchAdd1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Branch_Add1");

                entity.Property(e => e.EeBranchAdd2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Branch_Add2");

                entity.Property(e => e.EeChargeRate).HasColumnName("Ee_ChargeRate");

                entity.Property(e => e.EeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Code");

                entity.Property(e => e.EeCompany)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Company");

                entity.Property(e => e.EeDateLeft)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ee_Date_Left");

                entity.Property(e => e.EeDateStart)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ee_Date_Start");

                entity.Property(e => e.EeDept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Dept");

                entity.Property(e => e.EeDirector).HasColumnName("Ee_Director");

                entity.Property(e => e.EeDob)
                    .HasColumnType("datetime")
                    .HasColumnName("Ee_DOB");

                entity.Property(e => e.EeEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Email");

                entity.Property(e => e.EeFirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ee_FirstName");

                entity.Property(e => e.EeGrossToDate).HasColumnName("Ee_Gross_To_Date");

                entity.Property(e => e.EeNetPay).HasColumnName("Ee_Net_Pay");

                entity.Property(e => e.EeNiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_NI_No");

                entity.Property(e => e.EeNiTable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ee_NI_Table");

                entity.Property(e => e.EeNomGross)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Nom_Gross");

                entity.Property(e => e.EeNomNic)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Nom_NIC");

                entity.Property(e => e.EeOldCo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Old_Co");

                entity.Property(e => e.EeOldCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Old_Code");

                entity.Property(e => e.EePayCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PayCode");

                entity.Property(e => e.EePayFrequency)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Pay_frequency");

                entity.Property(e => e.EePayNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Pay_No");

                entity.Property(e => e.EePayType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Pay_Type");

                entity.Property(e => e.EePhone)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Phone");

                entity.Property(e => e.EePostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PostCode");

                entity.Property(e => e.EePrevTax).HasColumnName("Ee_Prev_Tax");

                entity.Property(e => e.EePrevTaxable).HasColumnName("Ee_Prev_Taxable");

                entity.Property(e => e.EeRollNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Roll_No");

                entity.Property(e => e.EeSecCode)
                    .HasColumnName("Ee_SecCode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EeSex)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Sex");

                entity.Property(e => e.EeSortCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Sort_Code");

                entity.Property(e => e.EeSspFri).HasColumnName("Ee_SSP_Fri");

                entity.Property(e => e.EeSspMon).HasColumnName("Ee_SSP_Mon");

                entity.Property(e => e.EeSspSat).HasColumnName("Ee_SSP_Sat");

                entity.Property(e => e.EeSspSun).HasColumnName("Ee_SSP_Sun");

                entity.Property(e => e.EeSspThu).HasColumnName("Ee_SSP_Thu");

                entity.Property(e => e.EeSspTue).HasColumnName("Ee_SSP_Tue");

                entity.Property(e => e.EeSspWed).HasColumnName("Ee_SSP_Wed");

                entity.Property(e => e.EeStudentLoan).HasColumnName("Ee_Student_Loan");

                entity.Property(e => e.EeSurname)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Surname");

                entity.Property(e => e.EeTaxCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Tax_Code");

                entity.Property(e => e.EeTaxComments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Ee_TaxComments");

                entity.Property(e => e.EeTaxToDate).HasColumnName("Ee_Tax_To_Date");

                entity.Property(e => e.ForceFps).HasColumnName("ForceFPS");

                entity.Property(e => e.OtherPayType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salesman).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartDec)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeNote>(entity =>
            {
                entity.ToTable("EmployeeNote");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Note).HasColumnType("text");
            });

            modelBuilder.Entity<Ep>(entity =>
            {
                entity.ToTable("EPS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aspprecovered)
                    .HasColumnType("money")
                    .HasColumnName("ASPPRecovered");

                entity.Property(e => e.Cisdeductions)
                    .HasColumnType("money")
                    .HasColumnName("CISDeductions");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.NiccomponAspp)
                    .HasColumnType("money")
                    .HasColumnName("NICComponASPP");

                entity.Property(e => e.NiccomponSap)
                    .HasColumnType("money")
                    .HasColumnName("NICComponSAP");

                entity.Property(e => e.NiccomponSmp)
                    .HasColumnType("money")
                    .HasColumnName("NICComponSMP");

                entity.Property(e => e.NiccomponSpp)
                    .HasColumnType("money")
                    .HasColumnName("NICComponSPP");

                entity.Property(e => e.NiccomponSsp)
                    .HasColumnType("money")
                    .HasColumnName("NICComponSSP");

                entity.Property(e => e.Nicholiday)
                    .HasColumnType("money")
                    .HasColumnName("NICHoliday");

                entity.Property(e => e.Ospprecovered)
                    .HasColumnType("money")
                    .HasColumnName("OSPPRecovered");

                entity.Property(e => e.Saprecovered)
                    .HasColumnType("money")
                    .HasColumnName("SAPRecovered");

                entity.Property(e => e.Smprecovered)
                    .HasColumnType("money")
                    .HasColumnName("SMPRecovered");

                entity.Property(e => e.Ssprecovered)
                    .HasColumnType("money")
                    .HasColumnName("SSPRecovered");

                entity.Property(e => e.Submitted).HasColumnType("date");
            });

            modelBuilder.Entity<Epo>(entity =>
            {
                entity.ToTable("EPOS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Each).HasColumnType("money");

                entity.Property(e => e.Quantity).HasColumnType("money");

                entity.Property(e => e.TillId).HasColumnName("TillID");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<Eposlookup>(entity =>
            {
                entity.ToTable("EPOSLookup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Epostitle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EPOSTitle");

                entity.Property(e => e.StockCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExcelFile>(entity =>
            {
                entity.ToTable("ExcelFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExcelCell)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Template)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GlobalVariable>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("text");
            });

            modelBuilder.Entity<GoCardlessFeedDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addeddate).HasColumnType("date");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.Nominal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidIn).HasColumnType("money");

                entity.Property(e => e.Paidout).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Vat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<GoCardlessImportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNarrative)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BIC");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.NotPosted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Posted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trntype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRNtype");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<GovTalkHeader>(entity =>
            {
                entity.HasKey(e => e.PeriodEnd);

                entity.ToTable("GovTalkHeader");

                entity.Property(e => e.PeriodEnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentCo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentContact)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentFore)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AgentID")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentSur)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AgentTel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.AuditId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AuditID")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Class)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.DefaultCurr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.EnvVersion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Fore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.GatewayTest)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.GatewayTimestamp)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Gvalue)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GValue")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.KeyTon)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KeyTON")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.KeyTor)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("KeyTOR")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Namespace)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Organisation)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Principal)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Product)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SchemaVersion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sender)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.SenderId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("SenderID")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.TelNumber)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.TestMessage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.TopElementName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.TranId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TranID")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Ttl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Uri)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("URI")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Version)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<Grn>(entity =>
            {
                entity.ToTable("GRN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acidity).HasColumnType("money");

                entity.Property(e => e.AddCosts).HasColumnType("money");

                entity.Property(e => e.BestBefore).HasColumnType("smalldatetime");

                entity.Property(e => e.BinNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Brix).HasColumnType("money");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CountryOrigin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateProduced).HasColumnType("smalldatetime");

                entity.Property(e => e.DateRecd).HasColumnType("smalldatetime");

                entity.Property(e => e.Duty).HasColumnType("money");

                entity.Property(e => e.Fxrate)
                    .HasColumnType("money")
                    .HasColumnName("FXRate");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.PackCost).HasColumnType("money");

                entity.Property(e => e.PackQty).HasColumnType("money");

                entity.Property(e => e.PackType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Packs).HasColumnType("money");

                entity.Property(e => e.Ph)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PON");

                entity.Property(e => e.Ponline).HasColumnName("PONLine");

                entity.Property(e => e.PriceCurr).HasColumnType("money");

                entity.Property(e => e.ProdDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductFormat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Quarantined).HasDefaultValueSql("((0))");

                entity.Property(e => e.Query)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.RecdTemp).HasColumnType("money");

                entity.Property(e => e.Rhd)
                    .HasColumnType("money")
                    .HasColumnName("RHD");

                entity.Property(e => e.ScannedCofA)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScannedPhoto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SuppBatchNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnType("money");

                entity.Property(e => e.TotalQty).HasColumnType("money");

                entity.Property(e => e.Transport).HasColumnType("money");
            });

            modelBuilder.Entity<Grnsale>(entity =>
            {
                entity.ToTable("GRNSales");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Grnno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GRNNo");

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Packs).HasColumnType("money");

                entity.Property(e => e.SaleInvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GroupMember>(entity =>
            {
                entity.HasKey(e => e.GroupMemberId);

                entity.Property(e => e.GroupMemberId).HasColumnName("GroupMemberID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Interest>(entity =>
            {
                entity.Property(e => e.InterestId).HasColumnName("InterestID");

                entity.Property(e => e.CatId).HasColumnName("CatID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Interest1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Interest");
            });

            modelBuilder.Entity<InvoiceDesign>(entity =>
            {
                entity.ToTable("InvoiceDesign");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cssstyle)
                    .HasColumnType("text")
                    .HasColumnName("CSSStyle");

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Font)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FontSize)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Footer).HasColumnType("text");

                entity.Property(e => e.Header).HasColumnType("text");

                entity.Property(e => e.ShowCode).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowPrice).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowQty).HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowVat)
                    .HasColumnName("ShowVAT")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<JobDetail>(entity =>
            {
                entity.ToTable("JobDetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AcctRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address).HasColumnType("text");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Details)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.JobRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Location");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rhd)
                    .HasColumnType("money")
                    .HasColumnName("RHD");

                entity.Property(e => e.Storage).HasColumnType("money");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK__Location__TypeID__2C496DC0");
            });

            modelBuilder.Entity<LocationStock>(entity =>
            {
                entity.ToTable("Location_Stock");

                entity.Property(e => e.LocationStockId).HasColumnName("Location_StockID");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Minimumlevel).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.LocationStocks)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Location___Locat__2784B8A3");

                entity.HasOne(d => d.StockCodeNavigation)
                    .WithMany(p => p.LocationStocks)
                    .HasForeignKey(d => d.StockCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Location___Stock__2878DCDC");
            });

            modelBuilder.Entity<LuLocationType>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK__luLocati__516F0395E95850CB");

                entity.ToTable("luLocationType");

                entity.HasIndex(e => e.TypeName, "UQ__luLocati__D4E7DFA801983B4F")
                    .IsUnique();

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.AllowPurchase).HasColumnName("allowPurchase");

                entity.Property(e => e.AllowSales).HasColumnName("allowSales");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TypeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mapping>(entity =>
            {
                entity.ToTable("Mapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MapTo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModeOfContact>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK_TypeOfContactMade");

                entity.ToTable("ModeOfContact");

                entity.Property(e => e.TypeId).HasColumnName("TypeID");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nic>(entity =>
            {
                entity.ToTable("NICs");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AtLel)
                    .HasColumnType("money")
                    .HasColumnName("AtLEL");

                entity.Property(e => e.Both).HasColumnType("money");

                entity.Property(e => e.Emp).HasColumnType("money");

                entity.Property(e => e.EttoUel)
                    .HasColumnType("money")
                    .HasColumnName("ETtoUEL");

                entity.Property(e => e.LeltoEt)
                    .HasColumnType("money")
                    .HasColumnName("LELtoET");

                entity.Property(e => e.Nictable)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NICTable")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PeriodEnd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.UaptoUel)
                    .HasColumnType("money")
                    .HasColumnName("UAPtoUEL");

                entity.Property(e => e.WkNo)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");
            });

            modelBuilder.Entity<Nirate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nirates");

                entity.Property(e => e.EeLel).HasColumnName("EeLEL");

                entity.Property(e => e.ErLel).HasColumnName("ErLEL");

                entity.Property(e => e.Nitable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NITable");

                entity.Property(e => e.Period)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TaxYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Uel).HasColumnName("UEL");
            });

            modelBuilder.Entity<Nlgroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nlgroup");

                entity.Property(e => e.NlgCode).HasColumnName("NLG_Code");

                entity.Property(e => e.NlgDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Description");

                entity.Property(e => e.NlgDrCr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Dr_Cr");

                entity.Property(e => e.NlgId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NLG_ID");

                entity.Property(e => e.NlgMloType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_MLO_Type");

                entity.Property(e => e.NlgPrintCol)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Print_Col");

                entity.Property(e => e.NlgType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Type");
            });

            modelBuilder.Entity<NlgroupOld>(entity =>
            {
                entity.HasKey(e => e.NlgId)
                    .HasName("PK_nlgroup");

                entity.ToTable("nlgroupOld");

                entity.Property(e => e.NlgId).HasColumnName("NLG_ID");

                entity.Property(e => e.NlgCode).HasColumnName("NLG_Code");

                entity.Property(e => e.NlgDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Description");

                entity.Property(e => e.NlgDrCr)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Dr_Cr");

                entity.Property(e => e.NlgMloType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_MLO_Type");

                entity.Property(e => e.NlgPrintCol)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Print_Col");

                entity.Property(e => e.NlgType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLG_Type");
            });

            modelBuilder.Entity<Nltran>(entity =>
            {
                entity.HasKey(e => e.NltKey);

                entity.ToTable("nltran");

                entity.HasIndex(e => new { e.NltYearEnd, e.NltPeriod, e.NltDate, e.NltNet }, "IX_nltran");

                entity.HasIndex(e => e.NltRef, "IX_nltran_1");

                entity.HasIndex(e => e.NltInvNo, "IX_nltran_2");

                entity.HasIndex(e => e.NltStockCode, "IX_nltran_3");

                entity.HasIndex(e => new { e.NltYearEnd, e.NlCode }, "IX_nltran_4");

                entity.HasIndex(e => new { e.NlCode, e.NltAudit }, "RecdList");

                entity.HasIndex(e => new { e.NltSource, e.NltRef }, "idxBankRec");

                entity.HasIndex(e => new { e.NlCode, e.NltYearEnd, e.NltDate }, "idxBankRecT");

                entity.HasIndex(e => e.NltSource, "idxClearPay");

                entity.HasIndex(e => e.NltSource, "idxPLInsert");

                entity.HasIndex(e => e.NltReturn, "idxReturn");

                entity.HasIndex(e => new { e.NlCode, e.NltRef }, "idxToPay");

                entity.HasIndex(e => new { e.NlCode, e.NltYearEnd, e.NltPeriod }, "idxTran");

                entity.HasIndex(e => new { e.NltYearEnd, e.NltSource, e.NlCode }, "idxTurnover");

                entity.HasIndex(e => new { e.NlCode, e.NltRef, e.NltYearEnd }, "idxUBA");

                entity.HasIndex(e => e.NltDate, "idxVAT");

                entity.HasIndex(e => new { e.NltCosting, e.NltDate, e.NltSource }, "idxWIP");

                entity.HasIndex(e => e.NltSource, "idxYE");

                entity.HasIndex(e => new { e.NltInvNo, e.NlCode, e.NltDate, e.NltSource, e.NltRef, e.NltNet, e.NltTheirRef, e.NltPaid, e.NltDueDate }, "nltran3");

                entity.HasIndex(e => new { e.NlCode, e.NltCurrNet }, "nltran_NI_001");

                entity.HasIndex(e => new { e.NlCode, e.NltRef, e.NltSource }, "nltran_NI_005");

                entity.HasIndex(e => new { e.NlCode, e.NltRef, e.NltSource }, "nltran_NI_006");

                entity.Property(e => e.NltKey).HasColumnName("NLT_Key");

                entity.Property(e => e.LineDiscount).HasColumnType("money");

                entity.Property(e => e.NlCo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NL_Co");

                entity.Property(e => e.NlCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NL_Code");

                entity.Property(e => e.NltAudit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Audit");

                entity.Property(e => e.NltConsignment).HasColumnName("NLT_Consignment");

                entity.Property(e => e.NltContra)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Contra");

                entity.Property(e => e.NltCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Costing")
                    .HasDefaultValueSql("('NA')");

                entity.Property(e => e.NltCurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_CurrCode");

                entity.Property(e => e.NltCurrNet)
                    .HasColumnType("money")
                    .HasColumnName("NLT_CurrNet");

                entity.Property(e => e.NltCurrPaid)
                    .HasColumnType("money")
                    .HasColumnName("NLT_CurrPaid");

                entity.Property(e => e.NltCurrVat)
                    .HasColumnType("money")
                    .HasColumnName("NLT_CurrVAT");

                entity.Property(e => e.NltDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NLT_Date");

                entity.Property(e => e.NltDelAdd)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_DelAdd");

                entity.Property(e => e.NltDeliverDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NLT_DeliverDate");

                entity.Property(e => e.NltDept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Dept");

                entity.Property(e => e.NltDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Detail");

                entity.Property(e => e.NltDueDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NLT_DueDate");

                entity.Property(e => e.NltEntered)
                    .HasColumnType("datetime")
                    .HasColumnName("NLT_Entered")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NltEnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Entered_By");

                entity.Property(e => e.NltExchRate).HasColumnName("NLT_ExchRate");

                entity.Property(e => e.NltGrid).HasColumnName("NLT_GRID");

                entity.Property(e => e.NltInvNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_InvNo");

                entity.Property(e => e.NltInvoiceRef)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_InvoiceRef");

                entity.Property(e => e.NltLineNo).HasColumnName("NLT_LineNo");

                entity.Property(e => e.NltLocation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Location");

                entity.Property(e => e.NltNet)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Net");

                entity.Property(e => e.NltNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Notes");

                entity.Property(e => e.NltOnlyFlag)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Only_Flag");

                entity.Property(e => e.NltOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_OrderNo");

                entity.Property(e => e.NltPacks)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Packs");

                entity.Property(e => e.NltPaid)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Paid");

                entity.Property(e => e.NltPaidRecDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NLT_PaidRecDate");

                entity.Property(e => e.NltPaidRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_PaidRef");

                entity.Property(e => e.NltPayRef)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_PayRef");

                entity.Property(e => e.NltPeriod).HasColumnName("NLT_Period");

                entity.Property(e => e.NltPrice)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Price");

                entity.Property(e => e.NltQty)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Qty");

                entity.Property(e => e.NltRecon).HasColumnName("NLT_Recon");

                entity.Property(e => e.NltRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Ref");

                entity.Property(e => e.NltReturn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Return");

                entity.Property(e => e.NltSalesman)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Salesman");

                entity.Property(e => e.NltSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Source");

                entity.Property(e => e.NltStockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_StockCode");

                entity.Property(e => e.NltTheirRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_TheirRef");

                entity.Property(e => e.NltToPay)
                    .HasColumnType("money")
                    .HasColumnName("NLT_ToPay");

                entity.Property(e => e.NltToPayCurr)
                    .HasColumnType("money")
                    .HasColumnName("NLT_ToPayCurr");

                entity.Property(e => e.NltUnits)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Units");

                entity.Property(e => e.NltVat)
                    .HasColumnType("money")
                    .HasColumnName("NLT_VAT");

                entity.Property(e => e.NltVatCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NLT_VAT_Code");

                entity.Property(e => e.NltYearEnd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NLT_YearEnd");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NltranAdd>(entity =>
            {
                entity.ToTable("NLTranAdd");

                entity.HasIndex(e => new { e.InvType, e.InvNo }, "idxNLTranAdd1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BatchNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSent).HasColumnType("datetime");

                entity.Property(e => e.FactorDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InvType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OnHoldReason).HasColumnType("text");

                entity.Property(e => e.SettDisc).HasColumnType("money");
            });

            modelBuilder.Entity<Nominal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nominal");

                entity.Property(e => e.MergeAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NlAcctOrder)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Acct_Order");

                entity.Property(e => e.NlBalance)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Balance");

                entity.Property(e => e.NlBranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_BranchCode");

                entity.Property(e => e.NlCoCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Co_Code");

                entity.Property(e => e.NlCode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Code");

                entity.Property(e => e.NlCompany)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Company");

                entity.Property(e => e.NlCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_CurrencyCode");

                entity.Property(e => e.NlDateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("NL_DateCreated");

                entity.Property(e => e.NlDepartmentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_DepartmentCode");

                entity.Property(e => e.NlDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Description");

                entity.Property(e => e.NlExternalRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_ExternalRef");

                entity.Property(e => e.NlFlag).HasColumnName("NL_Flag");

                entity.Property(e => e.NlIrisCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Iris_Code");

                entity.Property(e => e.NlIsConfidential).HasColumnName("NL_IsConfidential");

                entity.Property(e => e.NlIsForex).HasColumnName("NL_IsForex");

                entity.Property(e => e.NlIsblocked).HasColumnName("NL_Isblocked");

                entity.Property(e => e.NlShowExpense).HasColumnName("NL_ShowExpense");

                entity.Property(e => e.NlShowJournals).HasColumnName("NL_ShowJournals");

                entity.Property(e => e.NlShowPurchase).HasColumnName("NL_ShowPurchase");

                entity.Property(e => e.NlShowSales).HasColumnName("NL_ShowSales");

                entity.Property(e => e.NlTaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_TaxCode");

                entity.Property(e => e.NlType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Type");

                entity.Property(e => e.NlWorkBal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Work_Bal");
            });

            modelBuilder.Entity<NominalOld>(entity =>
            {
                entity.HasKey(e => e.NlCode)
                    .HasName("PK_nominal");

                entity.ToTable("nominalOld");

                entity.Property(e => e.NlCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Code");

                entity.Property(e => e.MergeAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NlAcctOrder)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Acct_Order");

                entity.Property(e => e.NlBalance)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Balance");

                entity.Property(e => e.NlBranchCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_BranchCode");

                entity.Property(e => e.NlCoCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Co_Code");

                entity.Property(e => e.NlCompany)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Company");

                entity.Property(e => e.NlCurrencyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_CurrencyCode");

                entity.Property(e => e.NlDateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("NL_DateCreated");

                entity.Property(e => e.NlDepartmentCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_DepartmentCode");

                entity.Property(e => e.NlDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Description");

                entity.Property(e => e.NlExternalRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_ExternalRef");

                entity.Property(e => e.NlFlag)
                    .HasColumnName("NL_Flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.NlIrisCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Iris_Code");

                entity.Property(e => e.NlIsConfidential).HasColumnName("NL_IsConfidential");

                entity.Property(e => e.NlIsForex).HasColumnName("NL_IsForex");

                entity.Property(e => e.NlIsblocked).HasColumnName("NL_Isblocked");

                entity.Property(e => e.NlShowExpense).HasColumnName("NL_ShowExpense");

                entity.Property(e => e.NlShowJournals).HasColumnName("NL_ShowJournals");

                entity.Property(e => e.NlShowPurchase).HasColumnName("NL_ShowPurchase");

                entity.Property(e => e.NlShowSales).HasColumnName("NL_ShowSales");

                entity.Property(e => e.NlTaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NL_TaxCode");

                entity.Property(e => e.NlType)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Type");

                entity.Property(e => e.NlWorkBal)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Work_Bal");
            });

            modelBuilder.Entity<Nompost>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nompost");

                entity.Property(e => e.Curr)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExchRate).HasColumnType("money");

                entity.Property(e => e.IsCredit).HasColumnName("isCredit");

                entity.Property(e => e.NpCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Code");

                entity.Property(e => e.NpCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NP_Company");

                entity.Property(e => e.NpCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Costing");

                entity.Property(e => e.NpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NP_Date");

                entity.Property(e => e.NpDept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Dept");

                entity.Property(e => e.NpDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NP_Detail");

                entity.Property(e => e.NpIteration).HasColumnName("np_iteration");

                entity.Property(e => e.NpKey)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NP_Key");

                entity.Property(e => e.NpNet)
                    .HasColumnType("money")
                    .HasColumnName("NP_Net");

                entity.Property(e => e.NpPeriod).HasColumnName("np_Period");

                entity.Property(e => e.NpPostPer).HasColumnName("NP_PostPer");

                entity.Property(e => e.NpPosted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NP_Posted")
                    .IsFixedLength(true);

                entity.Property(e => e.NpRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Ref");

                entity.Property(e => e.NpSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NP_Source");

                entity.Property(e => e.NpTranNo).HasColumnName("NP_TranNo");

                entity.Property(e => e.NpType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("np_type");

                entity.Property(e => e.NpValue)
                    .HasColumnType("money")
                    .HasColumnName("np_value");

                entity.Property(e => e.NpVat)
                    .HasColumnType("money")
                    .HasColumnName("NP_VAT");

                entity.Property(e => e.NpVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NP_VATCode");

                entity.Property(e => e.NpYearEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("NP_YearEnd");
            });

            modelBuilder.Entity<Nomtemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("nomtemplate");

                entity.Property(e => e.NpCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Code")
                    .IsFixedLength(true);

                entity.Property(e => e.NpCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NP_Company")
                    .IsFixedLength(true);

                entity.Property(e => e.NpCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Costing")
                    .IsFixedLength(true);

                entity.Property(e => e.NpDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NP_Date");

                entity.Property(e => e.NpDept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Dept")
                    .IsFixedLength(true);

                entity.Property(e => e.NpDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NP_Detail")
                    .IsFixedLength(true);

                entity.Property(e => e.NpKey)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("NP_Key");

                entity.Property(e => e.NpNet).HasColumnName("NP_Net");

                entity.Property(e => e.NpPostPer).HasColumnName("NP_PostPer");

                entity.Property(e => e.NpPosted)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NP_Posted")
                    .IsFixedLength(true);

                entity.Property(e => e.NpRef)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NP_Ref")
                    .IsFixedLength(true);

                entity.Property(e => e.NpSource)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NP_Source")
                    .IsFixedLength(true);

                entity.Property(e => e.NpTranNo).HasColumnName("NP_TranNo");

                entity.Property(e => e.NpVat).HasColumnName("NP_VAT");

                entity.Property(e => e.NpVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NP_VATCode")
                    .IsFixedLength(true);

                entity.Property(e => e.NpYearEnd)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("NP_YearEnd");
            });

            modelBuilder.Entity<NumberStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__NumberSt__C8EE20433D1E06C3");

                entity.ToTable("NumberStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OnlineSeller>(entity =>
            {
                entity.HasKey(e => e.Oscode);

                entity.ToTable("OnlineSeller");

                entity.Property(e => e.Oscode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OSCODE");

                entity.Property(e => e.Notes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NOTES");

                entity.Property(e => e.Osname)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OSNAME");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("STATUS");
            });

            modelBuilder.Entity<OnlineSellerShop>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("OnlineSellerShop");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApiKey)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("API_KEY");

                entity.Property(e => e.ApiSecret)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("API_Secret");

                entity.Property(e => e.ApiToken)
                    .HasMaxLength(2500)
                    .IsUnicode(false)
                    .HasColumnName("API_TOKEN");

                entity.Property(e => e.AppName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DevEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEV_EMAIL");

                entity.Property(e => e.DevId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEV_ID");

                entity.Property(e => e.DevPwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEV_PWD");

                entity.Property(e => e.DevToken)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DEV_TOKEN");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LocationID");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NominalCode)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrderInterval)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Oscode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OSCode");

                entity.Property(e => e.ShopEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopPwd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ShopPWD");

                entity.Property(e => e.StartRunDateTime).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.HasOne(d => d.OscodeNavigation)
                    .WithMany(p => p.OnlineSellerShops)
                    .HasForeignKey(d => d.Oscode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnlineSellerShop_OnlineSeller");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.NltKey);

                entity.ToTable("orders");

                entity.Property(e => e.NltKey).HasColumnName("NLT_Key");

                entity.Property(e => e.NlCo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NL_Co");

                entity.Property(e => e.NlCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NL_Code");

                entity.Property(e => e.NltAudit)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Audit");

                entity.Property(e => e.NltCompleted).HasColumnName("NLT_Completed");

                entity.Property(e => e.NltCosting)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Costing");

                entity.Property(e => e.NltDate)
                    .HasColumnType("datetime")
                    .HasColumnName("NLT_Date");

                entity.Property(e => e.NltDelAdd)
                    .HasMaxLength(400)
                    .IsUnicode(false)
                    .HasColumnName("NLT_DelAdd");

                entity.Property(e => e.NltDept)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Dept");

                entity.Property(e => e.NltDetail)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Detail");

                entity.Property(e => e.NltEnteredBy)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Entered_By");

                entity.Property(e => e.NltEnteredDate)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Entered_Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.NltEnteredTime)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Entered_Time");

                entity.Property(e => e.NltInvNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_InvNo");

                entity.Property(e => e.NltInvoicedNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("NLT_InvoicedNo");

                entity.Property(e => e.NltInvoicedQty).HasColumnName("NLT_InvoicedQty");

                entity.Property(e => e.NltLineNo).HasColumnName("NLT_LineNo");

                entity.Property(e => e.NltNet)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Net");

                entity.Property(e => e.NltOnlyFlag)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Only_Flag");

                entity.Property(e => e.NltPacks).HasColumnName("NLT_Packs");

                entity.Property(e => e.NltPaid)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Paid");

                entity.Property(e => e.NltPaidRef)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_PaidRef");

                entity.Property(e => e.NltPeriod).HasColumnName("NLT_Period");

                entity.Property(e => e.NltPrice)
                    .HasColumnType("money")
                    .HasColumnName("NLT_Price");

                entity.Property(e => e.NltQty).HasColumnName("NLT_Qty");

                entity.Property(e => e.NltRecon).HasColumnName("NLT_Recon");

                entity.Property(e => e.NltRef)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Ref");

                entity.Property(e => e.NltReturn)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Return");

                entity.Property(e => e.NltSource)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_Source");

                entity.Property(e => e.NltStockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_StockCode");

                entity.Property(e => e.NltTheirRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("NLT_TheirRef");

                entity.Property(e => e.NltToPay)
                    .HasColumnType("money")
                    .HasColumnName("NLT_ToPay");

                entity.Property(e => e.NltVat)
                    .HasColumnType("money")
                    .HasColumnName("NLT_VAT");

                entity.Property(e => e.NltVatCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("NLT_VAT_Code");

                entity.Property(e => e.NltYearEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("NLT_YearEnd");
            });

            modelBuilder.Entity<P11>(entity =>
            {
                entity.ToTable("p11");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErContCharge)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErContCredit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErContValue).HasColumnType("money");

                entity.Property(e => e.Et)
                    .HasColumnType("money")
                    .HasColumnName("ET");

                entity.Property(e => e.Fps)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("FPS");

                entity.Property(e => e.Lel)
                    .HasColumnType("money")
                    .HasColumnName("LEL");

                entity.Property(e => e.P11Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P11_Company")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.P11Date)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("P11_Date");

                entity.Property(e => e.P11Dept)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P11_Dept");

                entity.Property(e => e.P11EeNi)
                    .HasColumnType("money")
                    .HasColumnName("P11_Ee_NI");

                entity.Property(e => e.P11Employee)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P11_Employee");

                entity.Property(e => e.P11ErNi)
                    .HasColumnType("money")
                    .HasColumnName("P11_Er_NI");

                entity.Property(e => e.P11FreePay)
                    .HasColumnType("money")
                    .HasColumnName("P11_Free_Pay");

                entity.Property(e => e.P11GrossPay)
                    .HasColumnType("money")
                    .HasColumnName("P11_GrossPay");

                entity.Property(e => e.P11MonthWeek)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P11_Month_Week");

                entity.Property(e => e.P11NiCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P11_NI_Code");

                entity.Property(e => e.P11Period).HasColumnName("P11_Period");

                entity.Property(e => e.P11Posted).HasColumnName("P11_Posted");

                entity.Property(e => e.P11Sap)
                    .HasColumnType("money")
                    .HasColumnName("P11_SAP");

                entity.Property(e => e.P11Sld)
                    .HasColumnType("money")
                    .HasColumnName("P11_SLD");

                entity.Property(e => e.P11Smp)
                    .HasColumnType("money")
                    .HasColumnName("P11_SMP");

                entity.Property(e => e.P11Spp)
                    .HasColumnType("money")
                    .HasColumnName("P11_SPP");

                entity.Property(e => e.P11Ssp)
                    .HasColumnType("money")
                    .HasColumnName("P11_SSP");

                entity.Property(e => e.P11StdNi)
                    .HasColumnType("money")
                    .HasColumnName("P11_Std_NI");

                entity.Property(e => e.P11Tax)
                    .HasColumnType("money")
                    .HasColumnName("P11_Tax");

                entity.Property(e => e.P11TaxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P11_Tax_Code");

                entity.Property(e => e.P11TaxYear)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("P11_Tax_Year");

                entity.Property(e => e.P11Taxable)
                    .HasColumnType("money")
                    .HasColumnName("P11_Taxable");

                entity.Property(e => e.P11TaxableGross)
                    .HasColumnType("money")
                    .HasColumnName("P11_TaxableGross");

                entity.Property(e => e.P11Tc)
                    .HasColumnType("money")
                    .HasColumnName("P11_TC");

                entity.Property(e => e.P11Temp)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("P11_Temp");

                entity.Property(e => e.P11Year)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P11_Year");

                entity.Property(e => e.Uap)
                    .HasColumnType("money")
                    .HasColumnName("UAP");

                entity.Property(e => e.Uel)
                    .HasColumnType("money")
                    .HasColumnName("UEL");
            });

            modelBuilder.Entity<P14>(entity =>
            {
                entity.HasKey(e => e.WkNo);

                entity.ToTable("P14");

                entity.Property(e => e.WkNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Add1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Add2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Add3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Add4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Company)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Dob)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("DOB")
                    .HasDefaultValueSql("('')")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Fore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Nino)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NINO")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PeriodEnd)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PrevTax).HasColumnType("money");

                entity.Property(e => e.PrevTaxablePay).HasColumnType("money");

                entity.Property(e => e.Sap)
                    .HasColumnType("money")
                    .HasColumnName("SAP");

                entity.Property(e => e.Smp)
                    .HasColumnType("money")
                    .HasColumnName("SMP");

                entity.Property(e => e.Spp)
                    .HasColumnType("money")
                    .HasColumnName("SPP");

                entity.Property(e => e.Ssp)
                    .HasColumnType("money")
                    .HasColumnName("SSP");

                entity.Property(e => e.StLoan).HasColumnType("money");

                entity.Property(e => e.Start)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sur)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Tax).HasColumnType("money");

                entity.Property(e => e.TaxCredit).HasColumnType("money");

                entity.Property(e => e.TaxablePay).HasColumnType("money");

                entity.Property(e => e.W1m1ind)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("W1M1Ind")
                    .HasDefaultValueSql("('')")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Week53Indicator)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.WidOrph).HasColumnType("money");
            });

            modelBuilder.Entity<P35>(entity =>
            {
                entity.HasKey(e => e.PeriodEnd);

                entity.ToTable("P35");

                entity.Property(e => e.PeriodEnd)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Cisdeduct)
                    .HasColumnType("money")
                    .HasColumnName("CISDeduct");

                entity.Property(e => e.CompEoys)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CompEOYS")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Econ)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ECON")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.EeOutOfUk)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EeOutOfUK")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ErAdd1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ErAdd2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ErCounty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ErName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ErPc)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ErPC")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ErTown)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ExpsOrBen)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.FreeOfTaxP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.IncentivePayment).HasColumnType("money");

                entity.Property(e => e.NetDeduct).HasColumnType("money");

                entity.Property(e => e.NetStatRec).HasColumnType("money");

                entity.Property(e => e.NetTaxCrs).HasColumnType("money");

                entity.Property(e => e.Nicholiday)
                    .HasColumnType("money")
                    .HasColumnName("NICHoliday");

                entity.Property(e => e.P11ddeclaration)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P11DDeclaration")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.P14declaration)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P14Declaration")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.P14tax)
                    .HasColumnType("money")
                    .HasColumnName("P14Tax");

                entity.Property(e => e.P38adeclaration)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("P38ADeclaration")
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.PayToThirdP)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.ReturnType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Sap)
                    .HasColumnType("money")
                    .HasColumnName("SAP");

                entity.Property(e => e.Sapcomp)
                    .HasColumnType("money")
                    .HasColumnName("SAPComp");

                entity.Property(e => e.ServPayments)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.Smp)
                    .HasColumnType("money")
                    .HasColumnName("SMP");

                entity.Property(e => e.Smpcomp)
                    .HasColumnType("money")
                    .HasColumnName("SMPComp");

                entity.Property(e => e.Smpcompensation)
                    .HasColumnType("money")
                    .HasColumnName("SMPCompensation");

                entity.Property(e => e.Spp)
                    .HasColumnType("money")
                    .HasColumnName("SPP");

                entity.Property(e => e.Sppcomp)
                    .HasColumnType("money")
                    .HasColumnName("SPPComp");

                entity.Property(e => e.Ssp)
                    .HasColumnType("money")
                    .HasColumnName("SSP");

                entity.Property(e => e.Sspcompensation)
                    .HasColumnType("money")
                    .HasColumnName("SSPCompensation");

                entity.Property(e => e.Sspsmpfunding)
                    .HasColumnType("money")
                    .HasColumnName("SSPSMPFunding");

                entity.Property(e => e.StudentLoan).HasColumnType("money");

                entity.Property(e => e.SubConTax).HasColumnType("money");

                entity.Property(e => e.SubmissionType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .UseCollation("Latin1_General_CI_AS");

                entity.Property(e => e.TaxAdvance).HasColumnType("money");

                entity.Property(e => e.TaxCrFund).HasColumnType("money");

                entity.Property(e => e.TaxCredits).HasColumnType("money");

                entity.Property(e => e.TotalAfterCis)
                    .HasColumnType("money")
                    .HasColumnName("TotalAfterCIS");

                entity.Property(e => e.TotalNic)
                    .HasColumnType("money")
                    .HasColumnName("TotalNIC");

                entity.Property(e => e.TotalNtsl)
                    .HasColumnType("money")
                    .HasColumnName("TotalNTSL");

                entity.Property(e => e.TotalPaid).HasColumnType("money");

                entity.Property(e => e.TotalPayable).HasColumnType("money");

                entity.Property(e => e.TotalRemainToPay).HasColumnType("money");

                entity.Property(e => e.TotalTax).HasColumnType("money");

                entity.Property(e => e.TotalTaxNic)
                    .HasColumnType("money")
                    .HasColumnName("TotalTaxNIC");
            });

            modelBuilder.Entity<PayErCont>(entity =>
            {
                entity.ToTable("PayErCont");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErContCharge)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErContCr)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ErContValue).HasColumnType("money");
            });

            modelBuilder.Entity<PayPalBankFeedDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addeddate).HasColumnType("date");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.Nominal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidIn).HasColumnType("money");

                entity.Property(e => e.Paidout).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Vat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<PayPalImportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNarrative)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BIC");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.NotPosted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Posted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trntype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRNtype");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Payamount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("payamount");

                entity.Property(e => e.EeAuditRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_AuditRef");

                entity.Property(e => e.EeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Code");

                entity.Property(e => e.EeCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Costing");

                entity.Property(e => e.EeDedToDate).HasColumnName("Ee_Ded_To_Date");

                entity.Property(e => e.EeDoNotDelete).HasColumnName("Ee_DoNotDelete");

                entity.Property(e => e.EeNetPayReqd).HasColumnName("Ee_Net_Pay_Reqd");

                entity.Property(e => e.EeNiable).HasColumnName("Ee_NIable");

                entity.Property(e => e.EeNomCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Nom_Code");

                entity.Property(e => e.EePayDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ee_Pay_Desc");

                entity.Property(e => e.EePayLine).HasColumnName("Ee_Pay_Line");

                entity.Property(e => e.EePayRate).HasColumnName("Ee_Pay_Rate");

                entity.Property(e => e.EePayTime).HasColumnName("Ee_Pay_Time");

                entity.Property(e => e.EeTaxable).HasColumnName("Ee_Taxable");

                entity.Property(e => e.EeTotReqd).HasColumnName("Ee_Tot_Reqd");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Payrate>(entity =>
            {
                entity.ToTable("payrates");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EePrAuditRef)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_AuditRef");

                entity.Property(e => e.EePrClient)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_Client");

                entity.Property(e => e.EePrCosting)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_Costing");

                entity.Property(e => e.EePrDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Ee_PR_Date");

                entity.Property(e => e.EePrDesc)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_Desc");

                entity.Property(e => e.EePrDuty)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_Duty");

                entity.Property(e => e.EePrLine).HasColumnName("Ee_PR_Line");

                entity.Property(e => e.EePrNetPay).HasColumnName("Ee_PR_Net_Pay");

                entity.Property(e => e.EePrNiable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_NIable");

                entity.Property(e => e.EePrNomCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_Nom_Code");

                entity.Property(e => e.EePrPosted).HasColumnName("Ee_PR_Posted");

                entity.Property(e => e.EePrRate).HasColumnName("Ee_PR_Rate");

                entity.Property(e => e.EePrTaxable)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Ee_PR_Taxable");

                entity.Property(e => e.EePrTime).HasColumnName("Ee_PR_Time");

                entity.Property(e => e.PrEeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PR_EeCode");
            });

            modelBuilder.Entity<PayrollJournal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PayrollJournal");

                entity.Property(e => e.Costing).IsUnicode(false);

                entity.Property(e => e.CreditEntry).HasColumnName("Credit_Entry");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("Display_Name");

                entity.Property(e => e.DtimeStamp)
                    .HasColumnType("datetime")
                    .HasColumnName("DTimeStamp")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MonthWeek)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Month_Week");

                entity.Property(e => e.NomCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Nom_Code");

                entity.Property(e => e.PayDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Pay_Date");

                entity.Property(e => e.PayrollId).HasColumnName("Payroll_ID");

                entity.Property(e => e.TaxYear)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Tax_Year");

                entity.Property(e => e.Value).HasColumnType("money");
            });

            modelBuilder.Entity<PickingSlipSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PickingSlipSummary");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName).IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.Property(e => e.PositionId).HasColumnName("PositionID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Position1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Position");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.ToTable("prices");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Notes).HasColumnType("text");

                entity.Property(e => e.QuotedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StockCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acidity).HasMaxLength(255);

                entity.Property(e => e.Added).HasMaxLength(255);

                entity.Property(e => e.Additives).HasMaxLength(255);

                entity.Property(e => e.ArtSweet).HasMaxLength(255);

                entity.Property(e => e.Brix20).HasMaxLength(255);

                entity.Property(e => e.Brix20Ss)
                    .HasMaxLength(255)
                    .HasColumnName("Brix20SS");

                entity.Property(e => e.Carb)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Celery).HasMaxLength(255);

                entity.Property(e => e.Cereals).HasMaxLength(255);

                entity.Property(e => e.Coconut).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Coelics).HasMaxLength(255);

                entity.Property(e => e.ConcFactor).HasMaxLength(255);

                entity.Property(e => e.ControlledDoc)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Corn).HasMaxLength(255);

                entity.Property(e => e.Crust).HasMaxLength(255);

                entity.Property(e => e.DateIss).HasColumnType("smalldatetime");

                entity.Property(e => e.Dietry).HasMaxLength(255);

                entity.Property(e => e.DocRef).HasMaxLength(255);

                entity.Property(e => e.Egg).HasMaxLength(255);

                entity.Property(e => e.Energy)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EnergyKj)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.F35).HasMaxLength(255);

                entity.Property(e => e.F77).HasMaxLength(255);

                entity.Property(e => e.F78).HasMaxLength(255);

                entity.Property(e => e.F79).HasMaxLength(255);

                entity.Property(e => e.F80).HasMaxLength(255);

                entity.Property(e => e.F81).HasMaxLength(255);

                entity.Property(e => e.F82).HasMaxLength(255);

                entity.Property(e => e.F83).HasMaxLength(255);

                entity.Property(e => e.Fat)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fibre)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Fish).HasMaxLength(255);

                entity.Property(e => e.Flavour).HasMaxLength(255);

                entity.Property(e => e.FlavourEn).HasMaxLength(255);

                entity.Property(e => e.Forms).HasMaxLength(255);

                entity.Property(e => e.FreeProcessAid).HasMaxLength(255);

                entity.Property(e => e.FreeYeast).HasMaxLength(255);

                entity.Property(e => e.Garlic).HasMaxLength(255);

                entity.Property(e => e.GeneralDesc).HasMaxLength(255);

                entity.Property(e => e.Genetic).HasMaxLength(255);

                entity.Property(e => e.Gmo)
                    .HasMaxLength(255)
                    .HasColumnName("GMO");

                entity.Property(e => e.Hala).HasMaxLength(255);

                entity.Property(e => e.Honey).HasMaxLength(255);

                entity.Property(e => e.Issue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Kosher).HasMaxLength(255);

                entity.Property(e => e.LatinName).HasMaxLength(255);

                entity.Property(e => e.MainAller).HasMaxLength(255);

                entity.Property(e => e.Meat).HasMaxLength(255);

                entity.Property(e => e.Milk).HasMaxLength(255);

                entity.Property(e => e.Moulds).HasMaxLength(255);

                entity.Property(e => e.Mustard).HasMaxLength(255);

                entity.Property(e => e.Nuts).HasMaxLength(255);

                entity.Property(e => e.Origin).HasMaxLength(255);

                entity.Property(e => e.Other).HasMaxLength(255);

                entity.Property(e => e.OtherNuts).HasMaxLength(255);

                entity.Property(e => e.Packaging).HasMaxLength(255);

                entity.Property(e => e.Pathogens).HasMaxLength(255);

                entity.Property(e => e.Peanuts).HasMaxLength(255);

                entity.Property(e => e.Ph20)
                    .HasMaxLength(255)
                    .HasColumnName("ph20");

                entity.Property(e => e.PineNuts).HasMaxLength(255);

                entity.Property(e => e.Poultry).HasMaxLength(255);

                entity.Property(e => e.Preserves).HasMaxLength(255);

                entity.Property(e => e.Process).HasMaxLength(255);

                entity.Property(e => e.Processing).HasMaxLength(255);

                entity.Property(e => e.Product1)
                    .HasMaxLength(255)
                    .HasColumnName("Product");

                entity.Property(e => e.Products).HasMaxLength(255);

                entity.Property(e => e.ProductsDer).HasMaxLength(255);

                entity.Property(e => e.Protein)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Seeds).HasMaxLength(255);

                entity.Property(e => e.Sesame).HasMaxLength(255);

                entity.Property(e => e.Sg20)
                    .HasMaxLength(255)
                    .HasColumnName("SG20");

                entity.Property(e => e.Sg20ss)
                    .HasMaxLength(255)
                    .HasColumnName("SG20SS");

                entity.Property(e => e.ShelfLife).HasMaxLength(255);

                entity.Property(e => e.Soya).HasMaxLength(255);

                entity.Property(e => e.Storage).HasMaxLength(255);

                entity.Property(e => e.Sulphur).HasMaxLength(255);

                entity.Property(e => e.TotalCount).HasMaxLength(255);

                entity.Property(e => e.Vegan).HasMaxLength(255);

                entity.Property(e => e.Veget).HasMaxLength(255);

                entity.Property(e => e.Warranty).HasMaxLength(255);

                entity.Property(e => e.Yeast).HasMaxLength(255);

                entity.Property(e => e.Yeasts).HasMaxLength(255);
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.HasKey(e => e.QuoteKey);

                entity.Property(e => e.CoAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("money");

                entity.Property(e => e.CustCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfQuote).HasColumnType("smalldatetime");

                entity.Property(e => e.DelAdd)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("money");

                entity.Property(e => e.QuoteNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RequiredDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StkCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");

                entity.Property(e => e.Weight).HasColumnType("money");
            });

            modelBuilder.Entity<RelatedContact>(entity =>
            {
                entity.HasKey(e => e.RelatedContactId);

                entity.Property(e => e.RelatedContactId).HasColumnName("RelatedContactID");

                entity.Property(e => e.FriendId).HasColumnName("FriendID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastContact).HasColumnType("smalldatetime");

                entity.Property(e => e.Strength)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Text).HasColumnType("text");
            });

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.ToTable("ReportTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccumAction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupAcctCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportTemplateHeader>(entity =>
            {
                entity.ToTable("ReportTemplateHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Col10Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col10Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col10YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col11Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col11Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col11YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col12Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col12Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col12YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col1Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col1Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col1YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col2Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col2Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col2YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col3Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col3Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col3YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col4Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col4Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col4YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col5Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col5Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col5YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col6Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col6Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col6YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col7Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col7Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col7YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col8Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col8Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col8YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.Col9Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Col9Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Col9YearEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.IncludeOb).HasColumnName("IncludeOB");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportWriter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ReportWriter");

                entity.Property(e => e.RwCol1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col1");

                entity.Property(e => e.RwCol10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col10");

                entity.Property(e => e.RwCol11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col11");

                entity.Property(e => e.RwCol12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col12");

                entity.Property(e => e.RwCol13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col13");

                entity.Property(e => e.RwCol14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col14");

                entity.Property(e => e.RwCol15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col15");

                entity.Property(e => e.RwCol2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col2");

                entity.Property(e => e.RwCol3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col3");

                entity.Property(e => e.RwCol4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col4");

                entity.Property(e => e.RwCol5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col5");

                entity.Property(e => e.RwCol6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col6");

                entity.Property(e => e.RwCol7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col7");

                entity.Property(e => e.RwCol8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col8");

                entity.Property(e => e.RwCol9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Col9");

                entity.Property(e => e.RwName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Name");

                entity.Property(e => e.RwOrder1).HasColumnName("RW_Order1");

                entity.Property(e => e.RwOrder10).HasColumnName("RW_Order10");

                entity.Property(e => e.RwOrder11).HasColumnName("RW_Order11");

                entity.Property(e => e.RwOrder12).HasColumnName("RW_Order12");

                entity.Property(e => e.RwOrder13).HasColumnName("RW_Order13");

                entity.Property(e => e.RwOrder14).HasColumnName("RW_Order14");

                entity.Property(e => e.RwOrder15).HasColumnName("RW_Order15");

                entity.Property(e => e.RwOrder2).HasColumnName("RW_Order2");

                entity.Property(e => e.RwOrder3).HasColumnName("RW_Order3");

                entity.Property(e => e.RwOrder4).HasColumnName("RW_Order4");

                entity.Property(e => e.RwOrder5).HasColumnName("RW_Order5");

                entity.Property(e => e.RwOrder6).HasColumnName("RW_Order6");

                entity.Property(e => e.RwOrder7).HasColumnName("RW_Order7");

                entity.Property(e => e.RwOrder8).HasColumnName("RW_Order8");

                entity.Property(e => e.RwOrder9).HasColumnName("RW_Order9");

                entity.Property(e => e.RwSql)
                    .HasMaxLength(4000)
                    .IsUnicode(false)
                    .HasColumnName("RW_SQL");

                entity.Property(e => e.RwTable)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table");

                entity.Property(e => e.RwTable1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table1");

                entity.Property(e => e.RwTable10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table10");

                entity.Property(e => e.RwTable11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table11");

                entity.Property(e => e.RwTable12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table12");

                entity.Property(e => e.RwTable13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table13");

                entity.Property(e => e.RwTable14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table14");

                entity.Property(e => e.RwTable15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table15");

                entity.Property(e => e.RwTable2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table2");

                entity.Property(e => e.RwTable3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table3");

                entity.Property(e => e.RwTable4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table4");

                entity.Property(e => e.RwTable5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table5");

                entity.Property(e => e.RwTable6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table6");

                entity.Property(e => e.RwTable7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table7");

                entity.Property(e => e.RwTable8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table8");

                entity.Property(e => e.RwTable9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_Table9");

                entity.Property(e => e.RwWhere1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where1");

                entity.Property(e => e.RwWhere10)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where10");

                entity.Property(e => e.RwWhere11)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where11");

                entity.Property(e => e.RwWhere12)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where12");

                entity.Property(e => e.RwWhere13)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where13");

                entity.Property(e => e.RwWhere14)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where14");

                entity.Property(e => e.RwWhere15)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where15");

                entity.Property(e => e.RwWhere2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where2");

                entity.Property(e => e.RwWhere3)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where3");

                entity.Property(e => e.RwWhere4)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where4");

                entity.Property(e => e.RwWhere5)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where5");

                entity.Property(e => e.RwWhere6)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where6");

                entity.Property(e => e.RwWhere7)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where7");

                entity.Property(e => e.RwWhere8)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where8");

                entity.Property(e => e.RwWhere9)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RW_Where9");

                entity.Property(e => e.RwWhereValue1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue1");

                entity.Property(e => e.RwWhereValue10)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue10");

                entity.Property(e => e.RwWhereValue11)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue11");

                entity.Property(e => e.RwWhereValue12)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue12");

                entity.Property(e => e.RwWhereValue13)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue13");

                entity.Property(e => e.RwWhereValue14)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue14");

                entity.Property(e => e.RwWhereValue15)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue15");

                entity.Property(e => e.RwWhereValue2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue2");

                entity.Property(e => e.RwWhereValue3)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue3");

                entity.Property(e => e.RwWhereValue4)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue4");

                entity.Property(e => e.RwWhereValue5)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue5");

                entity.Property(e => e.RwWhereValue6)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue6");

                entity.Property(e => e.RwWhereValue7)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue7");

                entity.Property(e => e.RwWhereValue8)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue8");

                entity.Property(e => e.RwWhereValue9)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RW_WhereValue9");
            });

            modelBuilder.Entity<Reportsdb>(entity =>
            {
                entity.HasKey(e => e.RepKey);

                entity.ToTable("reportsdb");

                entity.Property(e => e.BackColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ForeColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HelpText).HasColumnType("text");

                entity.Property(e => e.Menu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepDesc)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RepFile)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RepSelDates)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepTable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SelectColor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Traditional)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SaleOrder>(entity =>
            {
                entity.HasKey(e => e.QuoteKey);

                entity.ToTable("SaleOrder");

                entity.Property(e => e.BatchId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.CoAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConsignmentNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("money");

                entity.Property(e => e.CostPriceCurr).HasColumnType("money");

                entity.Property(e => e.Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfQuote).HasColumnType("smalldatetime");

                entity.Property(e => e.DelAdd)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DispatchStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSent).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchRate).HasColumnType("money");

                entity.Property(e => e.ExclFromPrint).HasDefaultValueSql("((0))");

                entity.Property(e => e.Invoiced).HasColumnType("money");

                entity.Property(e => e.LineDiscount).HasColumnType("money");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nominal)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PackSize).HasColumnType("money");

                entity.Property(e => e.PicklistStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qostatus)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("QOStatus");

                entity.Property(e => e.Qty).HasColumnType("money");

                entity.Property(e => e.QuoteNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.RequiredDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SellPrice).HasColumnType("money");

                entity.Property(e => e.SellPriceCurr).HasColumnType("money");

                entity.Property(e => e.ShippingInfo)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StkCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");

                entity.Property(e => e.Vatcurr)
                    .HasColumnType("money")
                    .HasColumnName("VATCurr");

                entity.Property(e => e.Weight).HasColumnType("money");
            });

            modelBuilder.Entity<SaleOrderRecd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SaleOrderRecd");

                entity.Property(e => e.Acct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InvNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OurRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TheirRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalesAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SalesAnalysis");

                entity.Property(e => e.SaCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SA_Code");
            });

            modelBuilder.Entity<Salesman>(entity =>
            {
                entity.ToTable("Salesman");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SelectOption>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SO_Code");

                entity.Property(e => e.SoKey)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SO_Key");

                entity.Property(e => e.SoOption)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SO_Option");

                entity.Property(e => e.SoOrder).HasColumnName("SO_Order");

                entity.Property(e => e.SoValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SO_Value");
            });

            modelBuilder.Entity<SerialNumber>(entity =>
            {
                entity.HasKey(e => e.SerialNumber1)
                    .HasName("PK__SerialNu__048A0009AEAABE1A");

                entity.ToTable("SerialNumber");

                entity.Property(e => e.SerialNumber1)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SerialNumber");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.SerialNumbers)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__SerialNum__Statu__53633AE1");
            });

            modelBuilder.Entity<SlitemNote>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SLItemNotes");

                entity.Property(e => e.Slinvoice)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SLInvoice");

                entity.Property(e => e.SllineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SLLineNo");

                entity.Property(e => e.Slnotes)
                    .HasColumnType("text")
                    .HasColumnName("SLNotes");
            });

            modelBuilder.Entity<Slnote>(entity =>
            {
                entity.HasKey(e => e.Slnkey);

                entity.ToTable("SLNotes");

                entity.HasIndex(e => new { e.Slncode, e.Slndate }, "IX_SLNotes");

                entity.Property(e => e.Slnkey).HasColumnName("SLNKey");

                entity.Property(e => e.Slnattachment)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SLNAttachment");

                entity.Property(e => e.Slncode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SLNCode");

                entity.Property(e => e.Slncomments)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("SLNComments");

                entity.Property(e => e.Slndate)
                    .HasColumnType("datetime")
                    .HasColumnName("SLNDate");

                entity.Property(e => e.SlnfollowUp)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SLNFollowUp");

                entity.Property(e => e.Slnfrom)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLNFrom");

                entity.Property(e => e.Slnnotes)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("SLNNotes");

                entity.Property(e => e.Slnsubject)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLNSubject");

                entity.Property(e => e.Slnto)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SLNTo");
            });

            modelBuilder.Entity<Smp>(entity =>
            {
                entity.ToTable("SMP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualStartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.AverageEarnings).HasColumnType("money");

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ewc)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EWC");
            });

            modelBuilder.Entity<Ssp>(entity =>
            {
                entity.ToTable("SSP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Due).HasColumnType("money");

                entity.Property(e => e.EeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Piw)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("PIW");

                entity.Property(e => e.QualifyDays).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<StandardText>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StandardText");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.StdTextDesc)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StandingOrder>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Costing)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastPosted).HasColumnType("smalldatetime");

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.Repeat)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTo).HasColumnType("smalldatetime");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Status1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Status");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.StCode);

                entity.ToTable("stock");

                entity.Property(e => e.StCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ST_Code");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CartonPrice).HasColumnType("money");

                entity.Property(e => e.CostPriceLastUpdate).HasColumnType("smalldatetime");

                entity.Property(e => e.EntityId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("entity_id");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsBom).HasColumnName("IsBOM");

                entity.Property(e => e.IsService).HasColumnName("isService");

                entity.Property(e => e.LastAmended).HasColumnType("datetime");

                entity.Property(e => e.PackPrice).HasColumnType("money");

                entity.Property(e => e.PurCurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PurchaseVATCode");

                entity.Property(e => e.Rhd)
                    .HasColumnType("money")
                    .HasColumnName("RHD");

                entity.Property(e => e.SaleCurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SalesVatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SalesVATCode");

                entity.Property(e => e.StAllocated)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ST_Allocated");

                entity.Property(e => e.StCompany)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ST_Company");

                entity.Property(e => e.StCostPrice)
                    .HasColumnType("money")
                    .HasColumnName("ST_Cost_Price");

                entity.Property(e => e.StCountry)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ST_Country");

                entity.Property(e => e.StDefaultLocation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ST_DefaultLocation");

                entity.Property(e => e.StDeptCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ST_Dept_Code");

                entity.Property(e => e.StDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ST_Description");

                entity.Property(e => e.StExcFromWeb)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ST_ExcFromWeb")
                    .IsFixedLength(true);

                entity.Property(e => e.StHold)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ST_Hold")
                    .IsFixedLength(true);

                entity.Property(e => e.StHscode)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("ST_HSCode");

                entity.Property(e => e.StImageFile1)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ST_ImageFile1");

                entity.Property(e => e.StImageFile2)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ST_ImageFile2");

                entity.Property(e => e.StInStock)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ST_In_stock");

                entity.Property(e => e.StIntStatCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ST_Int_stat_code");

                entity.Property(e => e.StLastUpdated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("ST_LastUpdated");

                entity.Property(e => e.StLocation)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ST_Location");

                entity.Property(e => e.StMinLevel)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ST_Min_Level");

                entity.Property(e => e.StNoTrans)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ST_No_Trans")
                    .IsFixedLength(true);

                entity.Property(e => e.StNomAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ST_Nom_acct");

                entity.Property(e => e.StNotes)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ST_Notes");

                entity.Property(e => e.StOnOrder)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("ST_On_order");

                entity.Property(e => e.StProdGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ST_ProdGroup");

                entity.Property(e => e.StSalePrice)
                    .HasColumnType("money")
                    .HasColumnName("ST_Sale_Price");

                entity.Property(e => e.StUnitsPerPallet).HasColumnName("ST_UnitsPerPallet");

                entity.Property(e => e.StVatOver)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ST_VAT_Over");

                entity.Property(e => e.StWeight)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ST_Weight");

                entity.Property(e => e.StorageCost).HasColumnType("money");

                entity.Property(e => e.StoredFromDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TradePrice).HasColumnType("money");

                entity.Property(e => e.ValuationBasis)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockAssigned>(entity =>
            {
                entity.HasKey(e => e.StockAssignId)
                    .HasName("PK__Stock_as__A72AA866DBBFF1EF");

                entity.ToTable("Stock_assigned");

                entity.Property(e => e.StockAssignId).HasColumnName("Stock_AssignID");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedReference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingId).HasColumnName("TrackingID");

                entity.HasOne(d => d.Tracking)
                    .WithMany(p => p.StockAssigneds)
                    .HasForeignKey(d => d.TrackingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stock_ass__Track__5A103870");
            });

            modelBuilder.Entity<StockBuild>(entity =>
            {
                entity.ToTable("StockBuild");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FromCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Product)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("money");
            });

            modelBuilder.Entity<StockCostAssigned>(entity =>
            {
                entity.HasKey(e => e.AssignId)
                    .HasName("PK__Stock_Co__9FFF4C4FF8B1867B");

                entity.ToTable("Stock_CostAssigned");

                entity.Property(e => e.AssignId).HasColumnName("AssignID");

                entity.Property(e => e.AssignedDate).HasColumnType("datetime");

                entity.Property(e => e.AssignedReference)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.CostingId).HasColumnName("CostingID");

                entity.Property(e => e.CostingTypeId).HasColumnName("CostingTypeID");
            });

            modelBuilder.Entity<StockCosting>(entity =>
            {
                entity.HasKey(e => e.CostingId)
                    .HasName("PK__Stock_Co__15D29546D9704935");

                entity.ToTable("Stock_Costing");

                entity.Property(e => e.CostingId).HasColumnName("CostingID");

                entity.Property(e => e.CostingEntryDate).HasColumnType("datetime");

                entity.Property(e => e.CostingReference)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostingTypeId).HasColumnName("CostingTypeID");

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StockItem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCost).HasColumnType("money");
            });

            modelBuilder.Entity<StockCount>(entity =>
            {
                entity.ToTable("StockCount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Count).HasColumnType("money");

                entity.Property(e => e.Detail)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockSupplier>(entity =>
            {
                entity.ToTable("StockSupplier");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.MinOrder).HasColumnType("money");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.StockId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("StockID");

                entity.Property(e => e.SuppId).HasColumnName("SuppID");

                entity.Property(e => e.SuppRef)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StockTracking>(entity =>
            {
                entity.HasKey(e => e.TrackingId)
                    .HasName("PK__Stock_Tr__3C19EDD190677D7E");

                entity.ToTable("Stock_Tracking");

                entity.Property(e => e.TrackingId).HasColumnName("TrackingID");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StockItem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingEntryDate).HasColumnType("datetime");

                entity.Property(e => e.TrackingNo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingReference)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingTypeId).HasColumnName("TrackingTypeID");

                entity.HasOne(d => d.LocationCodeNavigation)
                    .WithMany(p => p.StockTrackings)
                    .HasForeignKey(d => d.LocationCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stock_Tra__Locat__5B045CA9");

                entity.HasOne(d => d.TrackingType)
                    .WithMany(p => p.StockTrackings)
                    .HasForeignKey(d => d.TrackingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stock_Tra__Track__4E9E85C4");
            });

            modelBuilder.Entity<StockType>(entity =>
            {
                entity.HasKey(e => e.StTypeCode);

                entity.Property(e => e.StTypeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StTypeDesc)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StTypePurchCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StTypeSaleCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Stprice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stprices");

                entity.Property(e => e.StCode)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ST_Code");

                entity.Property(e => e.StpCostPrice)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STP_Cost_Price");

                entity.Property(e => e.StpDiscount)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STP_Discount");

                entity.Property(e => e.StpForQty)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STP_For_Qty");

                entity.Property(e => e.StpGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STP_Group");

                entity.Property(e => e.StpSalePrice)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("STP_Sale_Price");
            });

            modelBuilder.Entity<SubConTo>(entity =>
            {
                entity.ToTable("SubConTo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CoCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConFrom)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ConTo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Subsidiary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PercentHeld).HasColumnType("money");

                entity.Property(e => e.WebPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YearEnd).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<SumUpFeedDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addeddate).HasColumnType("date");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.Nominal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidIn).HasColumnType("money");

                entity.Property(e => e.Paidout).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Vat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<SumUpImportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNarrative)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BIC");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.NotPosted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Posted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trntype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRNtype");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SuppCi>(entity =>
            {
                entity.ToTable("SuppCIS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Add1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Add2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Add3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Add4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Crn)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CRN");

                entity.Property(e => e.LastVerified).HasColumnType("smalldatetime");

                entity.Property(e => e.Nino)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("NINO");

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Putr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PUTR");

                entity.Property(e => e.SuppId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SuppID");

                entity.Property(e => e.TaxTreatment)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TradingName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TradingType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Utr)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("UTR");

                entity.Property(e => e.VerificationNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WksNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SuppOrder>(entity =>
            {
                entity.HasKey(e => e.SuppOrderKey);

                entity.ToTable("SuppOrder");

                entity.Property(e => e.Backorder)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContractNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CostPrice).HasColumnType("money");

                entity.Property(e => e.CostPriceCurr).HasColumnType("money");

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfQuote).HasColumnType("smalldatetime");

                entity.Property(e => e.DelAdd)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Delivered).HasColumnType("money");

                entity.Property(e => e.DeliveredDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Detail)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DispatchStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailSent).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchRate).HasColumnType("money");

                entity.Property(e => e.Grnno).HasColumnName("GRNNo");

                entity.Property(e => e.LineDiscount).HasColumnType("money");

                entity.Property(e => e.Location)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MailStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.PackSize).HasColumnType("money");

                entity.Property(e => e.PicklistStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnType("money");

                entity.Property(e => e.RequiredDate).HasColumnType("smalldatetime");

                entity.Property(e => e.SaleOrderNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Salesman)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StkCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SuppOrderNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");

                entity.Property(e => e.Vatcurr)
                    .HasColumnType("money")
                    .HasColumnName("VATCurr");

                entity.Property(e => e.Weight).HasColumnType("money");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Account)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AcctRef)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Assignor)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Detail).HasColumnType("text");

                entity.Property(e => e.Enddate).HasColumnType("smalldatetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RepeatEvery)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TaskDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Taxrate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("taxrates");

                entity.Property(e => e.TaxYear)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Tax_Year");

                entity.Property(e => e.TtBandCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TT_Band_Code");

                entity.Property(e => e.TtBandNo).HasColumnName("TT_Band_No");

                entity.Property(e => e.TtBandWidth)
                    .HasColumnType("money")
                    .HasColumnName("TT_Band_Width");

                entity.Property(e => e.TtId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TT_ID");

                entity.Property(e => e.TtTaxOnBand)
                    .HasColumnType("money")
                    .HasColumnName("TT_Tax_on_Band");

                entity.Property(e => e.TtTaxRate)
                    .HasColumnType("money")
                    .HasColumnName("TT_Tax_Rate");
            });

            modelBuilder.Entity<Term>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Letter1)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Letter2)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Letter3)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Letter4)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.SignOff)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Test1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Test");
            });

            modelBuilder.Entity<Timesheet>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Client)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.PayrollFlagged).HasColumnType("date");

                entity.Property(e => e.Units).HasColumnType("money");

                entity.Property(e => e.WorkDate).HasColumnType("smalldatetime");

                entity.Property(e => e.WorkType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrackingType>(entity =>
            {
                entity.ToTable("TrackingType");

                entity.Property(e => e.TrackingTypeId).HasColumnName("TrackingTypeID");

                entity.Property(e => e.TrackingType1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TrackingType");
            });

            modelBuilder.Entity<Treasury>(entity =>
            {
                entity.ToTable("Treasury");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankAcct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BaseCost).HasColumnType("money");

                entity.Property(e => e.CloseOn).HasColumnType("smalldatetime");

                entity.Property(e => e.Currency)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Fxrate)
                    .HasColumnType("money")
                    .HasColumnName("FXRate");

                entity.Property(e => e.Reference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("money");
            });

            modelBuilder.Entity<UploadedFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateCompleted).HasColumnType("smalldatetime");

                entity.Property(e => e.DateUploaded)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FileType)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users");

                entity.Property(e => e.LwDefaultCo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("lwDefaultCo")
                    .IsFixedLength(true);

                entity.Property(e => e.LwDefaultCoExt)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lwDefaultCoExt")
                    .IsFixedLength(true);

                entity.Property(e => e.LwDefaultCoName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("lwDefaultCoName")
                    .IsFixedLength(true);

                entity.Property(e => e.UserCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserLocale)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<UserAccordion>(entity =>
            {
                entity.ToTable("UserAccordion");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HeaderId).HasColumnName("HeaderID");

                entity.Property(e => e.UserCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserBankAcct>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("UserBankAcct");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CurrCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UserBankFeedDatum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addeddate).HasColumnType("date");

                entity.Property(e => e.Bank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BatchId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BatchID");

                entity.Property(e => e.Contact)
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.Nominal)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaidIn).HasColumnType("money");

                entity.Property(e => e.Paidout).HasColumnType("money");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserBankId).HasColumnName("UserBankID");

                entity.Property(e => e.Vat)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VAT");
            });

            modelBuilder.Entity<UserBankImportDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AdditionalNarrative)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Balance).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bic)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BIC");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Currency)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerReference)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DebitAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Iban)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IBAN");

                entity.Property(e => e.ImportId)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ImportID");

                entity.Property(e => e.NotPosted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Posted).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trntype)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("TRNtype");

                entity.Property(e => e.UserBankId).HasColumnName("UserBankID");

                entity.Property(e => e.ValueDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UserDefObject>(entity =>
            {
                entity.ToTable("UserDefObject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Container)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vat>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vat");

                entity.Property(e => e.InputOrOutput)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VatCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VAT_Code");

                entity.Property(e => e.VatDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VAT_Description");

                entity.Property(e => e.VatNBox)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("VAT_N_Box");

                entity.Property(e => e.VatNumber)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VAT_Number");

                entity.Property(e => e.VatOrder).HasColumnName("VAT_Order");

                entity.Property(e => e.VatRate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT_Rate");

                entity.Property(e => e.VatType)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("VAT_Type");

                entity.Property(e => e.VatVBox)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("VAT_V_Box");
            });

            modelBuilder.Entity<VatdrCr>(entity =>
            {
                entity.ToTable("VATDrCr");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Acct)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ChangedReason).HasColumnType("text");

                entity.Property(e => e.DrCr)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Flagged)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<Vatefile>(entity =>
            {
                entity.ToTable("VATEFILE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Box1).HasColumnType("money");

                entity.Property(e => e.Box10).HasColumnType("money");

                entity.Property(e => e.Box2).HasColumnType("money");

                entity.Property(e => e.Box3).HasColumnType("money");

                entity.Property(e => e.Box4).HasColumnType("money");

                entity.Property(e => e.Box5).HasColumnType("money");

                entity.Property(e => e.Box6).HasColumnType("money");

                entity.Property(e => e.Box7).HasColumnType("money");

                entity.Property(e => e.Box8).HasColumnType("money");

                entity.Property(e => e.Box9).HasColumnType("money");

                entity.Property(e => e.EfileDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Period)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Response).HasColumnType("text");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VATNo");
            });

            modelBuilder.Entity<VatefileB>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VATEFile_B");

                entity.Property(e => e.Box1).HasColumnType("money");

                entity.Property(e => e.Box10).HasColumnType("money");

                entity.Property(e => e.Box2).HasColumnType("money");

                entity.Property(e => e.Box3).HasColumnType("money");

                entity.Property(e => e.Box4).HasColumnType("money");

                entity.Property(e => e.Box5).HasColumnType("money");

                entity.Property(e => e.Box6).HasColumnType("money");

                entity.Property(e => e.Box7).HasColumnType("money");

                entity.Property(e => e.Box8).HasColumnType("money");

                entity.Property(e => e.Box9).HasColumnType("money");

                entity.Property(e => e.EfileDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Period)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Response).HasColumnType("text");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("VATNo");
            });

            modelBuilder.Entity<Vatsaved>(entity =>
            {
                entity.ToTable("VATSaved");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CurrNet).HasColumnType("money");

                entity.Property(e => e.CurrVat)
                    .HasColumnType("money")
                    .HasColumnName("CurrVAT");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.Period)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatbox).HasColumnName("VATBox");

                entity.Property(e => e.Vatcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("VATCode");
            });

            modelBuilder.Entity<Xmluploaded>(entity =>
            {
                entity.ToTable("XMLUploaded");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Error).IsUnicode(false);

                entity.Property(e => e.Xmltext)
                    .IsUnicode(false)
                    .HasColumnName("XMLText");
            });

            modelBuilder.Entity<Ybpayment>(entity =>
            {
                entity.ToTable("YBPayments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DateEnded).HasColumnType("smalldatetime");

                entity.Property(e => e.PayDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TaxYear)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<YearEnd>(entity =>
            {
                entity.HasKey(e => e.YearEnd1)
                    .HasName("PK__YearEnd__ACCA3A05028121D2");

                entity.ToTable("YearEnd");

                entity.Property(e => e.YearEnd1)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("YearEnd");
            });

            modelBuilder.Entity<YearEndReport>(entity =>
            {
                entity.ToTable("YearEndReport");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.EnteredBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ledger)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("money");

                entity.Property(e => e.YearEnd).HasColumnType("date");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
