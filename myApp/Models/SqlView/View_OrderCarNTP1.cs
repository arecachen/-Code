using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hsintongERP2022.Models
{
    [Table("dbo.View_OrderCarNTP1")]
    public partial class ViewOrderCarNTP1
    {
        [Key]
        public int orderCarNTPTID { get; set; }
        public Nullable<int> orderCarID { get; set; }
        public string? groupName { get; set; }
        public long groupDate { get; set; }
        public string? jounery { get; set; }
        public int jouneryDay { get; set; }
        public string? sn_reserveSeat { get; set; }
        public Nullable<int> payByCash { get; set; }
        public Nullable<int> payByTransfer { get; set; }
        public Nullable<int> payByCredit { get; set; }
        public Nullable<int> PayByCheque { get; set; }
        public Nullable<int> PayByOther { get; set; }
        public string? PayByOtherNote { get; set; }
        public Nullable<int> AmountPaid { get; set; }
        public Nullable<int> FeeCar { get; set; }
        public Nullable<int> FeeInsurance { get; set; }
        public Nullable<int> FeeTour { get; set; }
        public Nullable<int> FeeOther { get; set; }
        public string? undertakingUnit { get; set; }
        public string? contract { get; set; }
        public string? contractTel { get; set; }
        public Nullable<int> unitPrice { get; set; }
        public Nullable<int> net { get; set; }
        public Nullable<int> amount { get; set; }
        public bool isResaurant { get; set; }
        public bool isStay { get; set; }
        public bool isTransportation { get; set; }
        public bool isTicket { get; set; }
        public bool isInsurence { get; set; }
        public bool isGuideFee { get; set; }
        public bool isLocalGuideFee { get; set; }
        public string? otherService { get; set; }
        public bool departureIsPlane { get; set; }
        public bool departureIsBoat { get; set; }
        public string? departureIsPlaneFlight { get; set; }
        public bool returnPlane { get; set; }
        public bool returnBoat { get; set; }
        public string? returnPlaneFlight { get; set; }
        public Nullable<int> foc { get; set; }
        public Nullable<int> discount { get; set; }
        public Nullable<int> deposit { get; set; }
        public bool remindInsurance { get; set; }
        public Nullable<bool> onbordInsurance { get; set; }
        public bool remindContract { get; set; }
        public Nullable<bool> onbordContract { get; set; }
        public bool remindDrawLots { get; set; }
        public Nullable<bool> onbordDrawLots { get; set; }
        public bool remindHangTag { get; set; }
        public Nullable<bool> onbordHangTag { get; set; }
        public bool remindTravelBrochure { get; set; }
        public Nullable<bool> onbordTravelBrochure { get; set; }
        public bool remindInformation { get; set; }
        public Nullable<bool> onbordInformation { get; set; }
        public bool remindMedicine { get; set; }
        public Nullable<bool> onbordMedicine { get; set; }
        public bool remindRedCloth { get; set; }
        public Nullable<bool> onbordRedCloth { get; set; }
        public string? redCloth { get; set; }
        public bool remindLabel { get; set; }
        public Nullable<bool> onbordLabel { get; set; }
        public string? label { get; set; }
        public bool remindNightSnack { get; set; }
        public Nullable<bool> onbordNightSnack { get; set; }
        public string? nightSnack { get; set; }
        public bool remindGiveaway { get; set; }
        public Nullable<bool> onbordGiveaway { get; set; }
        public string? giveaway { get; set; }
        public bool remindOther { get; set; }
        public Nullable<bool> onbordOther { get; set; }
        public string? otherTodo { get; set; }
        public bool remindMineralWater { get; set; }
        public Nullable<bool> onbordMineralWater { get; set; }
        public int mineralWater { get; set; }
        public Nullable<bool> remindAssignLeader { get; set; }
        public Nullable<bool> onbordAssignLeader { get; set; }
        public Nullable<bool> remindBill { get; set; }
        public Nullable<bool> onbordBill { get; set; }
        public Nullable<bool> remindReceipt { get; set; }
        public Nullable<bool> onbordReceipt { get; set; }
        public Nullable<bool> remindRemittanceAccount { get; set; }
        public Nullable<bool> onbordRemittanceAccount { get; set; }
        public Nullable<bool> remindEstimate { get; set; }
        public Nullable<bool> onbordEstimate { get; set; }
        public bool travelInsurance { get; set; }
        public Nullable<int> travelInsuranceAccident { get; set; }
        public Nullable<int> travelInsuranceMedical { get; set; }
        public Nullable<int> travelInsuranceAmount { get; set; }
        public bool travelDutyInsurance { get; set; }
        public Nullable<int> travelDutyInsuranceAccident { get; set; }
        public Nullable<int> travelDutyInsuranceMedical { get; set; }
        public Nullable<int> travelDutyInsuranceAmount { get; set; }
        public bool receiveByCash { get; set; }
        public bool receiveByCard { get; set; }
        public bool receiveByMoneyTransfer { get; set; }
        public bool receiveByCheck { get; set; }
        public bool receiveByOther { get; set; }
        public string? otherReceive { get; set; }
        public Nullable<int> receiveAmount { get; set; }
        public Nullable<int> receiveFare { get; set; }
        public Nullable<int> receiveInsurance { get; set; }
        public Nullable<int> receiveGroupFee { get; set; }
        public Nullable<int> receiveOther { get; set; }
        public Nullable<bool> FinsRemindInsurance { get; set; }
        public Nullable<bool> FinsRemindContract { get; set; }
        public Nullable<bool> FinsRemindDrawLots { get; set; }
        public Nullable<bool> FinsRemindHangTag { get; set; }
        public Nullable<bool> FinsRemindTravelBrochure { get; set; }
        public Nullable<bool> FinsRemindInformation { get; set; }
        public Nullable<bool> FinsRemindMedicine { get; set; }
        public Nullable<bool> FinsRemindRedCloth { get; set; }
        public Nullable<bool> FinsRemindLabel { get; set; }
        public Nullable<bool> FinsRemindNightSnack { get; set; }
        public Nullable<bool> FinsRemindGiveaway { get; set; }
        public Nullable<bool> FinsRemindOther { get; set; }
        public Nullable<bool> FinsRemindMineralWater { get; set; }
        public Nullable<bool> FinsRemindAssignLeader { get; set; }
        public Nullable<bool> FinsRemindBill { get; set; }
        public Nullable<bool> FinsRmindReceipt { get; set; }
        public Nullable<bool> FnsRemindRemittanceAccount { get; set; }
        public Nullable<bool> FinsRemindEstimate { get; set; }
        public bool deleted { get; set; }
        public bool isDateDecided { get; set; }
        public Nullable<System.TimeSpan> departureTime { get; set; }
        public Nullable<System.TimeSpan> returnTime { get; set; }
        public bool HasAdministrativeCosts { get; set; }
        public Nullable<int> AdministrativeCosts { get; set; }
        public Nullable<int> AdministrativeCostsAmount { get; set; }
        public Nullable<int> profit { get; set; }
        //public Nullable<int> custID { get; set; }
        public Nullable<int> custContactID { get; set; }
        public string? custPhone { get; set; }
        public string? custMobile { get; set; }
        public string? custContactPhone { get; set; }
        public string? custContactName { get; set; }
        public Nullable<int> custWithCompID { get; set; }
        public int companyId { get; set; }
        public string? companyName { get; set; }
    }
    public partial class ViewOrderCarNTP1
    {
        [NotMapped, Display(Name = "尾款")]
        public int? finalpayment { get { return net - deposit - foc; } }
        [NotMapped, Display(Name = "傭金")]
        public int? commission { get { return (unitPrice * net * amount) - net - discount - foc; } }
    }
}