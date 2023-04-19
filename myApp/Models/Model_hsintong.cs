using System;
//using hsintongERP.entity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
//using System.Data.Entity;
//using System.Linq;



namespace hsintongERP2022.Models
{
    public partial class Model_hsintong : DbContext {
        // public Model_hsintong()
        //     : base("name=DefaultConnection") {
        //     Database.SetInitializer<Model_hsintong>(null);
        // }
      
{
    private readonly string _connectionString;

    public Model_hsintong(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }

        public virtual DbSet<AccessAccount>? AccessAccount { get; set; }
        public virtual DbSet<AccessControl>? AccessControl { get; set; }
        public virtual DbSet<AccessControlGroup>? AccessControlGroup { get; set; }
        public virtual DbSet<AccessCorporation>? AccessCorporation { get; set; }
        public virtual DbSet<AccessLog>? AccessLog { get; set; }
        public virtual DbSet<AccomodationMain>? AccomodationMain { get; set; }
        public virtual DbSet<AccomodationRoom>? AccomodationRoom { get; set; }
        public virtual DbSet<AccomodationWithRoom>? AccomodationWithRoom { get; set; }
        public virtual DbSet<AspNetRoles>? AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims>? AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins>? AspNetUserLogins { get; set; }
        //public virtual DbSet<AspNetUserRoles>? AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers>? AspNetUsers { get; set; }
        public virtual DbSet<AttractionMain>? AttractionMain { get; set; }
        public virtual DbSet<BaseInfoSaving>? BaseInfoSaving { get; set; }
        public virtual DbSet<CarAccident>? CarAccident { get; set; }
        public virtual DbSet<CarAccidentFile>? CarAccidentFile { get; set; }
        public virtual DbSet<CarAppointment>? CarAppointment { get; set; }
        public virtual DbSet<CarCertificate>? CarCertificate { get; set; }
        public virtual DbSet<CarCertType>? CarCertType { get; set; }
        public virtual DbSet<CarDuty>? CarDuty { get; set; }
        public virtual DbSet<CarEquipment>? CarEquipment { get; set; }
        public virtual DbSet<CarFinedCategory>? CarFinedCategory { get; set; }
        public virtual DbSet<CarFinedDeduction>? CarFinedDeduction { get; set; }
        public virtual DbSet<CarFinedFile>? CarFinedFile { get; set; }
        public virtual DbSet<CarFuelRecord>? CarFuelRecord { get; set; }
        public virtual DbSet<CarGroup>? CarGroup { get; set; }
        public virtual DbSet<CarMain>? CarMain { get; set; }
        public virtual DbSet<CarMaintaince>? CarMaintaince { get; set; }
        public virtual DbSet<CarMaintainItem>? CarMaintainItem { get; set; }
        public virtual DbSet<CarMaintainWithItem>? CarMaintainWithItem { get; set; }
        public virtual DbSet<CarMaintainWithPart>? CarMaintainWithPart { get; set; }
        public virtual DbSet<CarNotAvailable>? CarNotAvailable { get; set; }

        public virtual DbSet<CarPartItem>? CarPartItem { get; set; }

        public virtual DbSet<CarPartItemWithCorporation>? CarPartItemWithCorporation { get; set; }
        public virtual DbSet<CarSafetyCheck_del>? CarSafetyCheck_del { get; set; }
        public virtual DbSet<CarSafetyRecord>? CarSafetyRecord { get; set; }
        public virtual DbSet<CarWithEquipment>? CarWithEquipment { get; set; }
        public virtual DbSet<CompanyCalendar>? CompanyCalendar { get; set; }
        public virtual DbSet<Corporation>? Corporation { get; set; }
        public virtual DbSet<Customer>? Customer { get; set; }  /*deprecation*/
        public virtual DbSet<CustomerAddress>? CustomerAddress { get; set; }
        public virtual DbSet<CustomerContact>? CustomerContact { get; set; }
        public virtual DbSet<CustomerSource>? CustomerSource { get; set; }
        public virtual DbSet<CustomerType>? CustomerType { get; set; }
        public virtual DbSet<CustomerUniCode>? CustomerUniCode { get; set; }
        public virtual DbSet<CustomerWithTypes>? CustomerWithTypes { get; set; }
        public virtual DbSet<DictionaryTable>? DictionaryTable { get; set; }
        public virtual DbSet<EmployeeAdvPayment>? EmployeeAdvPayment { get; set; }
        public virtual DbSet<EmployeeAttributes>? EmployeeAttributes { get; set; }
        public virtual DbSet<view_carCertStatus>? View_carCertStatus { get; set; }
        //internal Task<int>? DoSaveAddChanges(string? mthName, string? name, object userHostAddress)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual DbSet<EmployeeCertificate>? EmployeeCertificate { get; set; }
        public virtual DbSet<EmployeeCertType>? EmployeeCertType { get; set; }
        public virtual DbSet<EmployeeDepartment>? EmployeeDepartment { get; set; }
        public virtual DbSet<EmployeeDuty_del>? EmployeeDuty_del { get; set; }
        public virtual DbSet<EmployeeGrade_del>? EmployeeGrade_del { get; set; }
        public virtual DbSet<EmployeeGroup>? EmployeeGroup { get; set; }
        public virtual DbSet<EmployeeLeaveRecord>? EmployeeLeaveRecord { get; set; }
        public virtual DbSet<EmployeeMain>? EmployeeMain { get; set; }
        public virtual DbSet<EmployeeMsessage>? EmployeeMsessage { get; set; }
        public virtual DbSet<EmployeePaymentRecord>? EmployeePaymentRecord { get; set; }
        public virtual DbSet<EmployeeSalary>? EmployeeSalary { get; set; }
        public virtual DbSet<EmployeeSalaryDailyShift>? EmployeeSalaryDailyShift { get; set; }
        public virtual DbSet<EmployeeTimeSlot>? EmployeeTimeSlot { get; set; }
        public virtual DbSet<FileFolder>? FileFolder { get; set; }
        public virtual DbSet<FileGroup>? FileGroup { get; set; }
        public virtual DbSet<FileInformation>? FileInformation { get; set; }
        public virtual DbSet<FinAccountCodeItem>? FinAccountCodeItem { get; set; }
        public virtual DbSet<FinAccountCodeMain>? FinAccountCodeMain { get; set; }
        public virtual DbSet<FinCashFlowFinal>? FinCashFlowFinal { get; set; }
        public virtual DbSet<FinCashFlowMain>? FinCashFlowMain { get; set; }
        public virtual DbSet<MenuGroup>? MenuGroup { get; set; }
        public virtual DbSet<MenuMain>? MenuMain { get; set; }
        public virtual DbSet<MenuSub>? MenuSub { get; set; }
        public virtual DbSet<NTPAccomodationMain>? NTPAccomodationMain { get; set; }
        public virtual DbSet<NTPAccomodationRoom>? NTPAccomodationRoom { get; set; }
        public virtual DbSet<NTPRestruantMain>? NTPRestruantMain { get; set; }
        public virtual DbSet<NTPRestruantOtherFee>? NTPRestruantOtherFee { get; set; }
        public virtual DbSet<OrderCar>? OrderCar { get; set; }
        public virtual DbSet<OrderCarCostScheduleMain>? OrderCarCostScheduleMain { get; set; }
        public virtual DbSet<OrderCarCostScheduleSub>? OrderCarCostScheduleSub { get; set; }
        public virtual DbSet<OrderCarFile>? OrderCarFile { get; set; }
        public virtual DbSet<OrderCarInfo>? OrderCarInfo { get; set; }
        public virtual DbSet<OrderCarInfoPassenger_del>? OrderCarInfoPassenger_del { get; set; }
        public virtual DbSet<OrderCarInfoPayRecord>? OrderCarInfoPayRecord { get; set; }
        public virtual DbSet<OrderCarInfoWithEquip>? OrderCarInfoWithEquip { get; set; }
        public virtual DbSet<OrderCarJob>? OrderCarJob { get; set; }
        public virtual DbSet<OrderCarJobMain>? OrderCarJobMain { get; set; }
        public virtual DbSet<OrderCarNTP>? OrderCarNTP { get; set; }
        public virtual DbSet<OrderCarPartnerCarStatementItem>? OrderCarPartnerCarStatementItem { get; set; }
        public virtual DbSet<OrderCarPartnerCarStatementMain>? OrderCarPartnerCarStatementMain { get; set; }
        public virtual DbSet<OrderCarRegular>? OrderCarRegular { get; set; }
        public virtual DbSet<OrderCarRegularClass>? OrderCarRegularClass { get; set; }
        public virtual DbSet<OrderCarRegularExclude>? OrderCarRegularExclude { get; set; }
        public virtual DbSet<OrderCarRegularFunds>? OrderCarRegularFunds { get; set; }
        public virtual DbSet<OrderCarRegularGroup>? OrderCarRegularGroup { get; set; }
        public virtual DbSet<OrderCarRegularInfo>? OrderCarRegularInfo { get; set; }
        public virtual DbSet<OrderIrregular>? OrderIrregular { get; set; }
        public virtual DbSet<OrderRegular>? OrderRegular { get; set; }
        public virtual DbSet<OrderRegularContractPayment>? OrderRegularContractPayment { get; set; }
        public virtual DbSet<OrderRegularPayment>? OrderRegularPayment { get; set; }
        public virtual DbSet<QRCJobShareInfo>? QRCJobShareInfo { get; set; }
        public virtual DbSet<QRCodeJob>? QRCodeJob { get; set; }
        public virtual DbSet<QRCodeJobReport>? QRCodeJobReport { get; set; }
        public virtual DbSet<RestruantMain>? RestruantMain { get; set; }
        public virtual DbSet<StatusTable>? StatusTable { get; set; }
        public virtual DbSet<sysdiagrams>? sysdiagrams { get; set; }
        public virtual DbSet<SystemImage>? SystemImage { get; set; }
        public virtual DbSet<SystemMemo>? SystemMemo { get; set; }
        public virtual DbSet<SystemMessage>? SystemMessage { get; set; }
        public virtual DbSet<TaiwanCity>? TaiwanCity { get; set; }
        public virtual DbSet<TourGuideMain>? TourGuideMain { get; set; }
        public virtual DbSet<VehMantaince>? VehMantaince { get; set; }
        public virtual DbSet<CarFined>? CarFined { get; set; }
        public virtual DbSet<Menus>? Menus { get; set; }
        public virtual DbSet<EmpLeave>? EmpLeave { get; set; }
        public virtual DbSet<Activity>? Activity { get; set; }
        public virtual DbSet<NTPMeetingRoomMain>? NTPMeetingRoomMain { get; set; }
        public virtual DbSet<NTPTicketMain>? NTPTicketMain { get; set; }
        public virtual DbSet<NTPTickets>? NTPTickets { get; set; }
        public virtual DbSet<NTPFileType>? NTPFileType { get; set; }
        public virtual DbSet<NTPFiles>? NTPFiles { get; set; }
        public virtual DbSet<NtpFleet>? NtpFleet { get; set; }
        public virtual DbSet<NtpTourGuide>? NtpTourGuide { get; set; }
        public virtual DbSet<EventLog>? eventLog { get; set; }
        public virtual DbSet<PremessionGroup>? PremessionGroup { get; set; }
        public virtual DbSet<PremessionUser>? PremessionUser { get; set; }
        public virtual DbSet<view_AccessAccountList>? view_AccessAccountList { get; set; }
        public virtual DbSet<TaiwanDist>? TaiwanDist { get; set; }
        public virtual DbSet<CarItemCategory>? CarItemCategory { get; set; }
        public virtual DbSet<CarItemsMain>? CarItemsMain { get; set; }
        public virtual DbSet<CarEquipmentFiles>? CarEquipmentFiles { get; set; }
        public virtual DbSet<AttractionFile>? AttractionFile { get; set; }
        public virtual DbSet<AccomodationFile>? AccomodationFile { get; set; }
        public virtual DbSet<AccomodationFacility>? AccomodationFacility { get; set; }
        public virtual DbSet<FilesCollection>? FilesCollection { get; set; }
        public virtual DbSet<RestruantFile>? RestruantFile { get; set; }
        public virtual DbSet<CarEquipmentAudit>? CarEquipmentAudit { get; set; }
        public virtual DbSet<Invoice>? Invoice { get; set; }
        public virtual DbSet<InvoiceDetail>? InvoiceDetail { get; set; }
        public virtual DbSet<CarEquipmentAuditDetail>? CarEquipmentAuditDetail { get; set; }
        public virtual DbSet<Receipt>? Receipt { get; set; }
        public virtual DbSet<ExpBill>? ExpBill { get; set; }
        public virtual DbSet<NtpTGIncomeExpend>? NtpTGIncomeExpend { get; set; }
        public virtual DbSet<CustomerCompany>? CustomerCompany { get; set; }
        public virtual DbSet<CustomerWithCompany>? CustomerWithCompany { get; set; }
        public virtual DbSet<InsteadPay>? InsteadPay { get; set; }
        public virtual DbSet<PaymentItemName>? PaymentItemName { get; set; }
        //public virtual DbSet<SysMessage>? SysMessage { get; set; }
        public virtual DbSet<SysNotify>? SysNotify { get; set; }
        public virtual DbSet<SysMessageFlow>? SysMessageFlow { get; set; }
        public virtual DbSet<NotifyStaff>? NotifyStaff { get; set; }
        public virtual DbSet<MorningTravelRpt>? MorningTravelRpt { get; set; }
        public virtual DbSet<Organization>? Organization { get; set; }
        public virtual DbSet<MorningRptStaff>? MorningRptStaff { get; set; }
        public virtual DbSet<CarMileage>? CarMileage { get; set; }
        // public virtual DbSet<ViewCarWithEquipment>? ViewCarWithEquipment { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {

            //modelBuilder.Entity<ViewCarWithEquipment>().ToTable("ViewCarWithEquipment");
            //modelBuilder.Ignore<ViewCarWithEquipment>();

            modelBuilder.Entity<EmpLeave>()
            .Property(o => o.Hours)
            .HasPrecision(5, 1);

            modelBuilder.Entity<AccessAccount>()
                .Property(e => e.loginID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessAccount>()
                .Property(e => e.loginPWD)
                .IsUnicode(false);

            modelBuilder.Entity<AccessAccount>()
                .Property(e => e.empEmail)
                .IsUnicode(false);

            modelBuilder.Entity<AccessAccount>()
                .Property(e => e.accGroup)
                .IsUnicode(false);

            modelBuilder.Entity<AccessAccount>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<AccessAccount>()
                .HasMany(e => e.FinCashFlowMain)
                .WithRequired(e => e.AccessAccount)
                .HasForeignKey(e => e.FinCreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessAccount>()
                .HasMany(e => e.FinCashFlowMain1)
                .WithOptional(e => e.AccessAccount1)
                .HasForeignKey(e => e.FinLastModifyBy);

            modelBuilder.Entity<AccessAccount>()
                .HasMany(e => e.OrderCarPartnerCarStatementMain)
                .WithOptional(e => e.AccessAccount)
                .HasForeignKey(e => e.PCSSettleBy);

            modelBuilder.Entity<AccessControl>()
                .Property(e => e.ctPageName)
                .IsUnicode(false);

            modelBuilder.Entity<AccessControl>()
                .Property(e => e.ctlPageID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessControl>()
                .Property(e => e.ctlMemo)
                .IsUnicode(false);

            modelBuilder.Entity<AccessControl>()
                .HasMany(e => e.AccessControlGroup)
                .WithRequired(e => e.AccessControl)
                .HasForeignKey(e => e.accessControlID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessCorporation>()
                .Property(e => e.loginID)
                .IsUnicode(false);

            modelBuilder.Entity<AccessCorporation>()
                .Property(e => e.loginPWD)
                .IsUnicode(false);

            modelBuilder.Entity<AccessCorporation>()
                .Property(e => e.empEmail)
                .IsUnicode(false);

            modelBuilder.Entity<AccessCorporation>()
                .Property(e => e.accGroup)
                .IsUnicode(false);

            modelBuilder.Entity<AccessCorporation>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<AccessLog>()
                .Property(e => e.logAction)
                .IsUnicode(false);

            modelBuilder.Entity<AccessLog>()
                .Property(e => e.logDesc)
                .IsUnicode(false);

            modelBuilder.Entity<AccessLog>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.caOccured)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.caResolution)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.insuranceType)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.insuranceType2)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.caInsuranceMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.injuredMy)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.injuredOther)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.damageCarMy)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.damageCarOther)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.MemoMy)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.MemoOther)
                .IsUnicode(false);

            modelBuilder.Entity<CarAccident>()
                .Property(e => e.caStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarAppointment>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarAppointment>()
                .Property(e => e.apptType)
                .IsUnicode(false);

            modelBuilder.Entity<CarAppointment>()
                .Property(e => e.apptMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarAppointment>()
                .Property(e => e.apptJobMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarAppointment>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CarAppointment>()
                .Property(e => e.carType)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertificate>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertificate>()
                .Property(e => e.certID)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertificate>()
                .Property(e => e.certImgSrc)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertificate>()
                .Property(e => e.cerDoc)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertificate>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertificate>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertType>()
                .Property(e => e.carCertName)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertType>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertType>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CarCertType>()
                .HasMany(e => e.CarCertificate)
                .WithRequired(e => e.CarCertType)
                .HasForeignKey(e => e.certTypeID);

            modelBuilder.Entity<CarDuty>()
                .Property(e => e.DutyName)
                .IsUnicode(false);

            modelBuilder.Entity<CarDuty>()
                .Property(e => e.DutyStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarEquipment>()
                .Property(e => e.equipName)
                .IsUnicode(false);

            modelBuilder.Entity<CarEquipment>()
                .Property(e => e.assetNo)
                .IsUnicode(false);

            modelBuilder.Entity<CarEquipment>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CarEquipment>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CarEquipment>()
                .HasMany(e => e.CarWithEquipment)
                .WithRequired(e => e.CarEquipment)
                .HasForeignKey(e => e.carEquipID);

            modelBuilder.Entity<CarEquipment>()
                .HasMany(e => e.OrderCarInfoWithEquip)
                .WithRequired(e => e.CarEquipment)
                .HasForeignKey(e => e.carEquipmentID);

            modelBuilder.Entity<CarFuelRecord>()
                .Property(e => e.carID)
                .IsUnicode(false);

            //modelBuilder.Entity<CarFuelRecord>()
            //    .Property(e => e.fuelFilled)
            //    .HasPrecision(18, 4);

            modelBuilder.Entity<CarFuelRecord>()
                .Property(e => e.fuelMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarGroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<CarGroup>()
                .Property(e => e.GroupStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarMain>()
                .Property(e => e.CarID)
                .IsUnicode(false);

            modelBuilder.Entity<CarMain>()
                .Property(e => e.carMake)
                .IsUnicode(false);

            modelBuilder.Entity<CarMain>()
                .Property(e => e.carSize)
                .IsUnicode(false);

            modelBuilder.Entity<CarMain>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CarMain>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CarMain>()
                .HasMany(e => e.OrderCarInfo)
                .WithOptional(e => e.CarMain)
                .HasForeignKey(e => e.carAssign)
                .WillCascadeOnDelete();

            modelBuilder.Entity<CarMaintaince>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintaince>()
                .Property(e => e.ticketID)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintaince>()
                .Property(e => e.maintainType)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintaince>()
                .Property(e => e.maintainMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintaince>()
                .Property(e => e.maintainPerformBy)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintaince>()
                .HasMany(e => e.CarMaintainWithPart)
                .WithRequired(e => e.CarMaintaince)
                .HasForeignKey(e => e.carMaintainID);

            modelBuilder.Entity<CarMaintainItem>()
                .Property(e => e.itemName)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintainItem>()
                .Property(e => e.itemMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintainItem>()
                .Property(e => e.itemStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintainWithItem>()
                .Property(e => e.mtnStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintainWithItem>()
                .Property(e => e.mtnFaultyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintainWithItem>()
                .Property(e => e.nextCheckMile)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CarMaintainWithPart>()
                .Property(e => e.partStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarMaintainWithPart>()
                .Property(e => e.partFaultyDesc)
                .IsUnicode(false);

            modelBuilder.Entity<CarNotAvailable>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarNotAvailable>()
                .Property(e => e.carNAReason)
                .IsUnicode(false);

            modelBuilder.Entity<CarPartItem>()
                .Property(e => e.itemName)
                .IsUnicode(false);

            modelBuilder.Entity<CarPartItem>()
                .Property(e => e.itemMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarPartItem>()
                .Property(e => e.itemStatus)
                .IsUnicode(false);

            modelBuilder.Entity<CarPartItem>()
                .HasMany(e => e.CarMaintainWithPart)
                .WithRequired(e => e.CarPartItem)
                .HasForeignKey(e => e.carPartItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarPartItem>()
                .HasMany(e => e.CarPartItemWithCorporation)
                .WithRequired(e => e.CarPartItem)
                .HasForeignKey(e => e.carPartItemID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CarSafetyCheck_del>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarSafetyCheck_del>()
                .Property(e => e.chkDocument)
                .IsUnicode(false);

            modelBuilder.Entity<CarSafetyRecord>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarSafetyRecord>()
                .Property(e => e.chkDocument)
                .IsUnicode(false);

            modelBuilder.Entity<CarSafetyRecord>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CarWithEquipment>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpName)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpType)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpContact)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpMobile)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .Property(e => e.corpStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Corporation>()
                .HasMany(e => e.AccessCorporation)
                .WithRequired(e => e.Corporation)
                .HasForeignKey(e => e.corpID);

            modelBuilder.Entity<Corporation>()
                .HasMany(e => e.CarAccident)
                .WithRequired(e => e.Corporation)
                .HasForeignKey(e => e.caInsuranceID);

            modelBuilder.Entity<Corporation>()
                .HasMany(e => e.CarFuelRecord)
                .WithRequired(e => e.Corporation)
                .HasForeignKey(e => e.fuelCorpID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Corporation>()
                .HasMany(e => e.CarMaintaince)
                .WithOptional(e => e.Corporation)
                .HasForeignKey(e => e.corporationID);

            modelBuilder.Entity<Corporation>()
                .HasMany(e => e.CarPartItemWithCorporation)
                .WithRequired(e => e.Corporation)
                .HasForeignKey(e => e.corporationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.companyName)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.mainPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.caution)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerAddress)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.custID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerContact)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.custID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerUniCode)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.custID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.CustomerWithTypes)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.custID);

            modelBuilder.Entity<Customer>()
                .HasMany(e => e.OrderCar)
                .WithRequired(e => e.Customer)
                .HasForeignKey(e => e.custID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.custCity)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.custSuburb)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.custPostCode)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.custStreet)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerAddress>()
                .Property(e => e.custAddType)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.custName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.custPhone)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.custMobile)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.custEmail)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.custFax)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerContact>()
                .HasMany(e => e.OrderCar)
                .WithRequired(e => e.CustomerContact)
                .HasForeignKey(e => e.custContactID);

            modelBuilder.Entity<CustomerSource>()
                .Property(e => e.custSourceName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerSource>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerSource>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerSource>()
                .HasMany(e => e.Customer)
                .WithRequired(e => e.CustomerSource)
                .HasForeignKey(e => e.custSourceID);

            modelBuilder.Entity<CustomerType>()
                .Property(e => e.custTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerType>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerType>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerType>()
                .HasMany(e => e.CustomerWithTypes)
                .WithRequired(e => e.CustomerType)
                .HasForeignKey(e => e.custTypeID);

            modelBuilder.Entity<CustomerUniCode>()
                .Property(e => e.uniCode)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerUniCode>()
                .Property(e => e.uniName)
                .IsUnicode(false);

            modelBuilder.Entity<CustomerUniCode>()
                .HasMany(e => e.OrderCar)
                .WithOptional(e => e.CustomerUniCode)
                .HasForeignKey(e => e.payToCustUniCode);

            modelBuilder.Entity<DictionaryTable>()
                .Property(e => e.dicCategory)
                .IsUnicode(false);

            modelBuilder.Entity<DictionaryTable>()
                .Property(e => e.dicValue)
                .IsUnicode(false);

            modelBuilder.Entity<DictionaryTable>()
                .Property(e => e.dicText)
                .IsUnicode(false);

            modelBuilder.Entity<DictionaryTable>()
                .Property(e => e.dicStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeAdvPayment>()
                .Property(e => e.empContact)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeAdvPayment>()
                .Property(e => e.empCashMemo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertificate>()
                .Property(e => e.certID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertificate>()
                .Property(e => e.certImgSrc)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertificate>()
                .Property(e => e.cerDoc)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertificate>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertificate>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertType>()
                .Property(e => e.certName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertType>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeCertType>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDuty_del>()
                .Property(e => e.empDutyName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDuty_del>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDuty_del>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeGrade_del>()
                .Property(e => e.empGradeName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeGrade_del>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeGrade_del>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeLeaveRecord>()
                .Property(e => e.leaveReason)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeLeaveRecord>()
                .Property(e => e.leaveType)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeLeaveRecord>()
                .Property(e => e.leaveApplyStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empNID)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empSex)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empMainContact)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empSecondContact)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empDuty)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.empGrade)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.AccessAccount)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.empID);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.CarAccident)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.caDriver);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.CarAppointment)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.driver);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.CarMaintaince)
                .WithOptional(e => e.EmployeeMain)
                .HasForeignKey(e => e.maintainByDriver);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.CarSafetyRecord)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.checkBy)
                .WillCascadeOnDelete(false);

            //modelBuilder.Entity<EmployeeMain>()
            //    .HasMany(e => e.EmployeeCertificate)
            //    .WithRequired(e => e.EmployeeMain)
            //    .HasForeignKey(e => e.empID)
            //    .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.EmployeeLeaveRecord)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.employeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.EmployeeMsessage)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.CreateBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.EmployeeSalary)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.employeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.EmployeeSalaryDailyShift)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.DS_EmployeeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.OrderCarInfo)
                .WithOptional(e => e.EmployeeMain)
                .HasForeignKey(e => e.carDriver);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.OrderCar)
                .WithOptional(e => e.EmployeeMain)
                .HasForeignKey(e => e.createBy);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.OrderCar1)
                .WithOptional(e => e.EmployeeMain1)
                .HasForeignKey(e => e.inTouchBy);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.OrderCar2)
                .WithOptional(e => e.EmployeeMain2)
                .HasForeignKey(e => e.inChargeBy);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.SystemMessage)
                .WithRequired(e => e.EmployeeMain)
                .HasForeignKey(e => e.createBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMain>()
                .HasMany(e => e.SystemMessage1)
                .WithRequired(e => e.EmployeeMain1)
                .HasForeignKey(e => e.modifyBy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmployeeMsessage>()
                .Property(e => e.CreateTo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMsessage>()
                .Property(e => e.MsgTitle)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMsessage>()
                .Property(e => e.MsgPriority)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMsessage>()
                .Property(e => e.MsgBody)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeMsessage>()
                .Property(e => e.MsgStatus)
                .IsUnicode(false);

            //modelBuilder.Entity<EmployeePaymentRecord>()
            //    .Property(e => e.InsuranceAmount)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeePaymentRecord>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeePaymentRecord>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeSalary>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeSalary>()
                .Property(e => e.empStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeSalaryDailyShift>()
                .Property(e => e.DS_BaseRate)
                .HasPrecision(18, 0);

            modelBuilder.Entity<FileFolder>()
                .Property(e => e.FolderTitle)
                .IsUnicode(false);

            modelBuilder.Entity<FileFolder>()
                .Property(e => e.FolderInstroduction)
                .IsUnicode(false);

            modelBuilder.Entity<FileFolder>()
                .Property(e => e.FolderCreateDate)
                .IsUnicode(false);

            modelBuilder.Entity<FileFolder>()
                .Property(e => e.FolderEditDate)
                .IsUnicode(false);

            modelBuilder.Entity<FileFolder>()
                .HasMany(e => e.FileInformation)
                .WithRequired(e => e.FileFolder)
                .HasForeignKey(e => e.FileFolderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FileGroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<FileGroup>()
                .HasMany(e => e.FileFolder)
                .WithRequired(e => e.FileGroup)
                .HasForeignKey(e => e.FileGroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FileInformation>()
                .Property(e => e.InfoRelName)
                .IsUnicode(false);

            modelBuilder.Entity<FileInformation>()
                .Property(e => e.InfoSysName)
                .IsUnicode(false);

            modelBuilder.Entity<FinAccountCodeItem>()
                .Property(e => e.FinAccItemCode)
                .IsUnicode(false);

            modelBuilder.Entity<FinAccountCodeItem>()
                .Property(e => e.FinAccItemDirection)
                .IsUnicode(false);

            modelBuilder.Entity<FinAccountCodeItem>()
                .Property(e => e.FinAccItemStatus)
                .IsUnicode(false);

            modelBuilder.Entity<FinAccountCodeMain>()
                .Property(e => e.FinAccCode)
                .IsUnicode(false);

            modelBuilder.Entity<FinAccountCodeMain>()
                .Property(e => e.FinAccDirection)
                .IsUnicode(false);

            modelBuilder.Entity<FinAccountCodeMain>()
                .HasMany(e => e.FinAccountCodeItem)
                .WithRequired(e => e.FinAccountCodeMain)
                .HasForeignKey(e => e.FinAccountCodeMainID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FinCashFlowMain>()
                .Property(e => e.FinCSRelatedCompany)
                .IsUnicode(false);

            modelBuilder.Entity<FinCashFlowMain>()
                .Property(e => e.FinAccItemCodeUX)
                .IsUnicode(false);

            modelBuilder.Entity<FinCashFlowMain>()
                .Property(e => e.FinCFCashType)
                .IsUnicode(false);

            modelBuilder.Entity<FinCashFlowMain>()
                .Property(e => e.FinCFStatus)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .Property(e => e.subMenuIDs)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .Property(e => e.groupName)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<MenuGroup>()
                .HasMany(e => e.AccessControlGroup)
                .WithRequired(e => e.MenuGroup)
                .HasForeignKey(e => e.menuGroupID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MenuMain>()
                .Property(e => e.mainName)
                .IsUnicode(false);

            modelBuilder.Entity<MenuMain>()
                .Property(e => e.mainType)
                .IsUnicode(false);

            modelBuilder.Entity<MenuMain>()
                .Property(e => e.mainLink)
                .IsUnicode(false);

            modelBuilder.Entity<MenuMain>()
                .Property(e => e.mainProp)
                .IsUnicode(false);

            modelBuilder.Entity<MenuMain>()
                .Property(e => e.mainStatus)
                .IsUnicode(false);

            modelBuilder.Entity<MenuMain>()
                .HasMany(e => e.MenuSub)
                .WithRequired(e => e.MenuMain)
                .HasForeignKey(e => e.menuMainID);

            modelBuilder.Entity<MenuSub>()
                .Property(e => e.subName)
                .IsUnicode(false);

            modelBuilder.Entity<MenuSub>()
                .Property(e => e.subType)
                .IsUnicode(false);

            modelBuilder.Entity<MenuSub>()
                .Property(e => e.subLink)
                .IsUnicode(false);

            modelBuilder.Entity<MenuSub>()
                .Property(e => e.subProp)
                .IsUnicode(false);

            modelBuilder.Entity<MenuSub>()
                .Property(e => e.subStatus)
                .IsUnicode(false);

            //modelBuilder.Entity<NTPAccomodationMain>()
            //    .Property(e => e.AccFOC)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPAccomodationMain>()
            //    .Property(e => e.AccRebate)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPAccomodationMain>()
            //    .Property(e => e.AccAdvancePayment)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPAccomodationRoom>()
            //    .Property(e => e.RoomPrice)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPAccomodationRoom>()
            //    .Property(e => e.RoomNetPrice)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPRestruantMain>()
            //    .Property(e => e.BreakyPrice)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPRestruantMain>()
            //    .Property(e => e.LunchPrice)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPRestruantMain>()
            //    .Property(e => e.DinnerPrice)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<NTPRestruantMain>()
            //    .Property(e => e.SupPrice)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.custContactName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.custContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.custContactMobile)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.custContactFax)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.orderSource)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.orderType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.payWith)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.extraDocument)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.memoExternal)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.memoInternal)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCar>()
                .HasMany(e => e.OrderCarInfo)
                .WithRequired(e => e.OrderCar)
                .HasForeignKey(e => e.orderCarID);

            modelBuilder.Entity<OrderCar>()
                .HasMany(e => e.OrderIrregular)
                .WithRequired(e => e.OrderCar)
                .HasForeignKey(e => e.orderCarID);

            modelBuilder.Entity<OrderCar>()
                .HasMany(e => e.OrderRegular)
                .WithRequired(e => e.OrderCar)
                .HasForeignKey(e => e.orderCarID);

            modelBuilder.Entity<OrderCar>()
                .HasMany(e => e.OrderRegularContractPayment)
                .WithRequired(e => e.OrderCar)
                .HasForeignKey(e => e.orderCarID);

            modelBuilder.Entity<OrderCar>()
                .HasMany(e => e.OrderRegularPayment)
                .WithRequired(e => e.OrderCar)
                .HasForeignKey(e => e.orderCarID);

            modelBuilder.Entity<OrderCarCostScheduleMain>()
                .Property(e => e.costScheduleName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarCostScheduleMain>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarCostScheduleMain>()
                .HasMany(e => e.OrderCarCostScheduleSub)
                .WithOptional(e => e.OrderCarCostScheduleMain)
                .HasForeignKey(e => e.orderCarCostScheduleID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<OrderCarCostScheduleMain>()
                .HasMany(e => e.OrderRegular)
                .WithOptional(e => e.OrderCarCostScheduleMain)
                .HasForeignKey(e => e.orderCostScheduleID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<OrderCarCostScheduleSub>()
                .Property(e => e.carType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarCostScheduleSub>()
                .Property(e => e.startTime)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarCostScheduleSub>()
                .Property(e => e.endTime)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarFile>()
                .Property(e => e.RelName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarFile>()
                .Property(e => e.SysName)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.carType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.withCarContactPhone)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.withCarContactMobile)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.carAssign)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.jobType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.carInfoInMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .Property(e => e.carInfoExMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfo>()
                .HasMany(e => e.CarAppointment)
                .WithRequired(e => e.OrderCarInfo)
                .HasForeignKey(e => e.carOrderInfoID);

            modelBuilder.Entity<OrderCarInfo>()
                .HasMany(e => e.OrderCarInfoPassenger_del)
                .WithRequired(e => e.OrderCarInfo)
                .HasForeignKey(e => e.orderCarInfoID);

            modelBuilder.Entity<OrderCarInfo>()
                .HasMany(e => e.OrderCarInfoPayRecord)
                .WithRequired(e => e.OrderCarInfo)
                .HasForeignKey(e => e.orderCarInfoID);

            modelBuilder.Entity<OrderCarInfo>()
                .HasMany(e => e.OrderCarInfoWithEquip)
                .WithRequired(e => e.OrderCarInfo)
                .HasForeignKey(e => e.orderCarInfoID);

            modelBuilder.Entity<OrderCarInfoPassenger_del>()
                .Property(e => e.carType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfoPayRecord>()
                .Property(e => e.payDriveType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfoPayRecord>()
                .Property(e => e.sentReceiptNo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfoPayRecord>()
                .Property(e => e.multiSentReceiptMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfoPayRecord>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarInfoPayRecord>()
                .Property(e => e.accountCheckMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.carType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.apptType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.apptMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.apptJobMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.unpickMemo)
                .IsUnicode(false);

            //modelBuilder.Entity<OrderCarJob>()
            //    .Property(e => e.SalaryTips)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<OrderCarJob>()
            //    .Property(e => e.SalaryTrip)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.finalStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.JobSource)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .Property(e => e.CheckinLocation)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJob>()
                .HasOptional(e => e.OrderCarPartnerCarStatementItem)
                .WithRequired(e => e.OrderCarJob);

            modelBuilder.Entity<OrderCarJobMain>()
                .Property(e => e.CarJobStatus)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarJobMain>()
                .Property(e => e.CarJobFinalBy)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarPartnerCarStatementItem>()
                .Property(e => e.PCSItemDirection)
                .IsUnicode(false);

            //modelBuilder.Entity<OrderCarPartnerCarStatementItem>()
            //    .Property(e => e.PCSItemPrice)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<OrderCarPartnerCarStatementMain>()
            //    .Property(e => e.PCSRecordAmount)
            //    .HasPrecision(18, 0);

            //modelBuilder.Entity<OrderCarPartnerCarStatementMain>()
            //    .Property(e => e.PCSIntentAmount)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<OrderCarPartnerCarStatementMain>()
                .Property(e => e.PCSMemo)
                .IsUnicode(false);

            //modelBuilder.Entity<OrderCarPartnerCarStatementMain>()
            //    .Property(e => e.PCSSettleAmount)
            //    .HasPrecision(18, 0);

            modelBuilder.Entity<OrderCarPartnerCarStatementMain>()
                .Property(e => e.PCSSettleMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderCarRegularInfo>()
                .Property(e => e.Memo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderIrregular>()
                .Property(e => e.miscStickerMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderIrregular>()
                .Property(e => e.miscGiftMemo)
                .IsUnicode(false);

            modelBuilder.Entity<OrderRegular>()
                .Property(e => e.payTerm)
                .IsUnicode(false);

            modelBuilder.Entity<OrderRegular>()
                .Property(e => e.payPeriod)
                .IsUnicode(false);

            modelBuilder.Entity<OrderRegularContractPayment>()
                .Property(e => e.carType)
                .IsUnicode(false);

            modelBuilder.Entity<OrderRegularPayment>()
                .Property(e => e.memo)
                .IsUnicode(false);

            modelBuilder.Entity<QRCodeJob>()
                .Property(e => e.JobDescription)
                .IsUnicode(false);

            modelBuilder.Entity<QRCodeJob>()
                .HasMany(e => e.QRCJobShareInfo)
                .WithRequired(e => e.QRCodeJob)
                .HasForeignKey(e => e.QCJobID);

            modelBuilder.Entity<QRCodeJob>()
                .HasMany(e => e.QRCodeJobReport)
                .WithRequired(e => e.QRCodeJob)
                .HasForeignKey(e => e.QRCJobID);

            modelBuilder.Entity<QRCodeJobReport>()
                .Property(e => e.JReportDetails)
                .IsUnicode(false);

            modelBuilder.Entity<StatusTable>()
                .Property(e => e.statusGroup)
                .IsUnicode(false);

            modelBuilder.Entity<StatusTable>()
                .Property(e => e.statusValue)
                .IsUnicode(false);

            modelBuilder.Entity<StatusTable>()
                .Property(e => e.statusText)
                .IsUnicode(false);

            modelBuilder.Entity<SystemImage>()
                .Property(e => e.imageCode)
                .IsUnicode(false);

            modelBuilder.Entity<SystemImage>()
                .Property(e => e.imageName)
                .IsUnicode(false);

            modelBuilder.Entity<SystemImage>()
                .Property(e => e.imageFile)
                .IsUnicode(false);

            modelBuilder.Entity<SystemMemo>()
                .Property(e => e.joMemo)
                .IsUnicode(false);

            modelBuilder.Entity<SystemMemo>()
                .Property(e => e.salaryMemo)
                .IsUnicode(false);

            modelBuilder.Entity<SystemMessage>()
                .Property(e => e.msgTitle)
                .IsUnicode(false);

            modelBuilder.Entity<SystemMessage>()
                .Property(e => e.message)
                .IsUnicode(false);

            modelBuilder.Entity<VehMantaince>()
                .Property(e => e.vehMtItem)
                .IsUnicode(false);

            modelBuilder.Entity<VehMantaince>()
                .Property(e => e.vehMtMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caTicketID)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.carID)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caFineLocation)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caFineReason)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caThrough)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caLaw)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caMemo)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caTicketImage)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caTicketImageSysName)
                .IsUnicode(false);

            modelBuilder.Entity<CarFined>()
                .Property(e => e.caPartyStatement)
                .IsUnicode(false);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.Carlost_Hour)
                .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
               .Property(o => o.Carstay_Hour)
               .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
              .Property(o => o.MaxCarStay_Hour)
              .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
              .Property(o => o.TotalMileage)
              .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.Tollstation_Count)
                .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.AvgTempValue)
                .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.TOTALMILEAGE_2G)
                .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.TotalCost)
                .HasPrecision(18,5);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.DriveHour)
                .HasPrecision(18,4);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.FireHour)
                .HasPrecision(18,4);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.Drive_spentoil)
                .HasPrecision(18,4);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.CarSpentoil)
                .HasPrecision(18,4);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.totalhour)
                .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.Day_Total)
                .HasPrecision(18,2);
            modelBuilder.Entity<CarMileage>()
                .Property(o => o.CPCListPrice)
                .HasPrecision(18,2);
        }
        #region for SQL View
        public IQueryable<ViewCarWithEquipment> ViewCarWithEquipments {
            get {
                return this.Database.SqlQuery<ViewCarWithEquipment>("select * from dbo.View_CarWithEquipment").AsQueryable();
            }
        }
        public IQueryable<ViewRestruantMain> ViewRestruantMain {
            get {
                return this.Database.SqlQuery<ViewRestruantMain>("select * from dbo.View_RestruantMain").AsQueryable();
            }
        }
        public IQueryable<ViewOrderCarNTP> ViewOrderCarNTP {
            get {
                return this.Database.SqlQuery<ViewOrderCarNTP>("select * from dbo.View_OrderCarNTP").AsQueryable();
            }
        }
        public IQueryable<ViewOrderCar> ViewOrderCar {
            get {
                return this.Database.SqlQuery<ViewOrderCar>("select * from dbo.View_OrderCar").AsQueryable();
            }
        }
        public IQueryable<ViewNTPTicketMain> ViewNTPTicketMain {
            get {
                return this.Database.SqlQuery<ViewNTPTicketMain>("select * from dbo.View_NTPTicketMain").AsQueryable();
            }
        }
        public IQueryable<ViewNTPAccomodationRoom> ViewNTPAccomodationRoom {
            get {
                return this.Database.SqlQuery<ViewNTPAccomodationRoom>("select * from dbo.View_NTPAccomodationRoom").AsQueryable();
            }
        }
        public IQueryable<ViewCustomerContact> ViewCustomerContact {
            get {
                return this.Database.SqlQuery<ViewCustomerContact>("select * from dbo.View_CustomerContact").AsQueryable();
            }
        }
        public IQueryable<ViewAttractionMain> ViewAttractionMain {
            get {
                return this.Database.SqlQuery<ViewAttractionMain>("select * from dbo.View_AttractionMain").AsQueryable();
            }
        }
        public IQueryable<ViewOrderCarNTP1> ViewOrderCarNTP1 {
            get {
                return this.Database.SqlQuery<ViewOrderCarNTP1>("select * from dbo.View_OrderCarNTP1").AsQueryable();
            }
        }

        public IQueryable<ViewCarMaintainWithItem> ViewCarMaintainWithItem {
            get {
                var result = this.Database.SqlQuery<ViewCarMaintainWithItem>("select * from View_CarMaintainWithItem").AsQueryable();
                return result;
            }
        }
        public IQueryable<ViewCarMaintainWithItem> ViewCarMaintainWithPart {
            get {
                var result = this.Database.SqlQuery<ViewCarMaintainWithItem>("select * from View_CarMaintainWithPart").AsQueryable();
                return result;
            }
        }
        public IQueryable<ViewAccessAccountList> viewAccessAccountLists
        {
            get {
                var result = this.Database.SqlQuery<ViewAccessAccountList>("select * from view_AccessAccountList").AsQueryable();
                return result;
            }
        }

        #endregion for SQL View
    }
    public enum EntityStatus {
        [Description("�ϥΤ�")]
        Active = 1,
        [Description("���Τ�")]
        Inactive = 2,
        [Description("�w�R��")]
        Deleted = 0,
        [Description("����")] //���]�t�w�R��
        Undeleted = 3
    }
}
//EntityFramework6\Add-Migration