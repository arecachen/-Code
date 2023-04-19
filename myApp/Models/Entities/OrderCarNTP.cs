namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Core.Objects.DataClasses;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;


    [Table("OrderCarNTP")]
    public partial class OrderCarNTP
    {
        [Key]
        public int orderCarNTPTID { get; set; }

        public int? orderCarID { get; set; }
        [ForeignKey("orderCarID")]
        public virtual OrderCar OrderCar { get; set; }
        [Required]
        [StringLength(100)]
        public string? groupName { get; set; }

        public long groupDate { get; set; }
        [NotMapped]
        public string? sGroupDate
        {
            get { return ((long?)groupDate).LongToDateString(); }
            set { groupDate = value.ToDateLong(); }
        }

        [StringLength(200)]
        public string? jounery { get; set; }

        public int jouneryDay { get; set; }

        [StringLength(150)]
        public string? sn_reserveSeat { get; set; }

        public int? payByCash { get; set; }

        public int? payByTransfer { get; set; }

        public int? payByCredit { get; set; }

        public int? PayByCheque { get; set; }

        public int? PayByOther { get; set; }

        [StringLength(50)]
        public string? PayByOtherNote { get; set; }

        public int? AmountPaid { get; set; }

        public int? FeeCar { get; set; }

        public int? FeeInsurance { get; set; }

        public int? FeeTour { get; set; }

        public int? FeeOther { get; set; }

        public bool deleted { get; set; } = false;
        //������w
        public bool isDateDecided { get; set; } = false;

    }
    //���q�Ƶ���TNtpOutlyingIslandsRemarks
    public partial class OrderCarNTP
    {
        [Display(Name = "�ӱ����?"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? undertakingUnit { get; set; }
        [Display(Name = "�p���H"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? contract { get; set; }
        [Display(Name = "�p���H�q��"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? contractTel { get; set; }
        [Display(Name = "�H�Y�� ($/�H)")]
        public int? unitPrice { get; set; }
        [Display(Name = "net")]
        public int? net { get; set; }
        [Display(Name = "�H��")]
        public int? amount { get; set; }
        [Display(Name = "�ӥ]����:�\�U")]
        public bool isResaurant { get; set; }
        [Display(Name = "�ӥ]����:���J")]
        public bool isStay { get; set; }
        [Display(Name = "�ӥ]����:��q")]
        public bool isTransportation { get; set; }
        [Display(Name = "�ӥ]����:����")]
        public bool isTicket { get; set; }
        [Display(Name = "�ӥ]����:�O�I")]
        public bool isInsurence { get; set; }
        [Display(Name = "�ӥ]����:�ⶤ�A�ȶO")]
        public bool isGuideFee { get; set; }
        [Display(Name = "�ӥ]����:���a�ɹC�A�ȶO")]
        public bool isLocalGuideFee { get; set; }
        [Display(Name = "�p���H�q��"), StringLength(255), MaxLength(255, ErrorMessage = "���פ��i�W�L 255�Ӧr")]
        public string? otherService { get; set; }
        [Display(Name = "�X�o��q�u��:����")]
        public bool departureIsPlane { get; set; } = false;
        [Display(Name = "�X�o��q�u��:��")]
        public bool departureIsBoat { get; set; } = false;
        [Display(Name = "�X�o��q�u��:��Z"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? departureIsPlaneFlight { get; set; }
        [ Display(Name = "�X�o�ɶ�"), Column(TypeName = "time")]
        public TimeSpan? departureTime { get; set; }
        //[Range(0, 24), Display(Name = "�X�o�ɶ�:��")]
        //public int departureHour { get; set; } = 0;
        //[Range(0, 60), Display(Name = "�X�o�ɶ�:��")]
        //public int departureMinute { get; set; } = 0;
        [Display(Name = "�^�{��q�u��:����")]
        public bool returnPlane { get; set; } = false;
        [Display(Name = "�^�{��q�u��:��")]
        public bool returnBoat { get; set; } = false;
        [Display(Name = "�^�{��q�u��:��Z"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? returnPlaneFlight { get; set; }
        [Display(Name = "�^�{�ɶ�"),Column(TypeName = "time")]
        public TimeSpan? returnTime { get; set; }   
        //[Range(0, 24), Display(Name = "�^�{�ɶ�:��")]

        //public int returnHour { get; set; } = 0;
        //[Range(0, 60), Display(Name = "�^�{�ɶ�:��")]
        //public int returnMinute { get; set; } = 0;
        [Display(Name = "FOC")]
        public int? foc { get; set; } = 0;
        [Display(Name = "����")]
        public int? discount { get; set; } = 0;
        [Display(Name = "�q��")]
        public int? deposit { get; set; } = 0;
        [NotMapped, Display(Name = "����")]
        public int? finalpayment { get { return net - deposit - foc; } }
        [NotMapped, Display(Name = "�Ī�")]
        public int? commission { get { return (unitPrice * net * amount) - net - discount - foc; } }
    }
    //�u�@�ƶ� WorkMatters 
    public partial class OrderCarNTP
    {
        [Display(Name = "�����O�I")]
        public bool remindInsurance { get; set; } = false;
        [Display(Name = "�����O�I����")]
        public Nullable<bool> FinsRemindInsurance { get; set; }
        [Display(Name = "�H���O�I")]
        public Nullable<bool> onbordInsurance { get; set; }
        [Display(Name = "�����X����")]
        public bool remindContract { get; set; } = false;
        [Display(Name = "�����X���ѧ���")]
        public Nullable<bool> FinsRemindContract { get; set; }
        [Display(Name = "�H���X����")]
        public Nullable<bool> onbordContract { get; set; }

        [Display(Name = "��������")]
        public bool remindDrawLots { get; set; } = false;
        [Display(Name = "�������ҧ���")]
        public Nullable<bool> FinsRemindDrawLots { get; set; }
        [Display(Name = "�H������")]
        public Nullable<bool> onbordDrawLots { get; set; }

        [Display(Name = "�����Q�P")]
        public bool remindHangTag { get; set; } = false;
        [Display(Name = "�����Q�P����")]
        public Nullable<bool> FinsRemindHangTag { get; set; }
        [Display(Name = "�H���Q�P")]
        public Nullable<bool> onbordHangTag { get; set; }

        [Display(Name = "�����ȹC��U")]
        public bool remindTravelBrochure { get; set; } = false;
        [Display(Name = "�����ȹC��U����")]
        public Nullable<bool> FinsRemindTravelBrochure { get; set; }
        [Display(Name = "�H���ȹC��U")]
        public Nullable<bool> onbordTravelBrochure { get; set; }

        [Display(Name = "���������|���?")]
        public bool remindInformation { get; set; } = false;
        [Display(Name = "���������|��?����")]
        public Nullable<bool> FinsRemindInformation { get; set; }
        [Display(Name = "�H�������|���?")]
        public Nullable<bool> onbordInformation { get; set; }

        [Display(Name = "�������Ľc")]
        public bool remindMedicine { get; set; } = false;
        [Display(Name = "�������Ľc����")]
        public Nullable<bool> FinsRemindMedicine { get; set; }
        [Display(Name = "�H�����Ľc")]
        public Nullable<bool> onbordMedicine { get; set; }

        [Display(Name = "����������")]
        public bool remindRedCloth { get; set; } = false;
        [Display(Name = "��������������")]
        public Nullable<bool> FinsRemindRedCloth { get; set; }
        [Display(Name = "�H��������")]
        public Nullable<bool> onbordRedCloth { get; set; }
        [Display(Name = "������"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? redCloth { get; set; }

        [Display(Name = "�����K��")]
        public bool remindLabel { get; set; } = false;
        [Display(Name = "�����K������")]
        public Nullable<bool> FinsRemindLabel { get; set; }
        [Display(Name = "�H���K��")]
        public Nullable<bool> onbordLabel { get; set; }
        [Display(Name = "�K��"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? label { get; set; }

        [Display(Name = "�����d�]")]
        public bool remindNightSnack { get; set; } = false;
        [Display(Name = "�����d�]����")]
        public Nullable<bool> FinsRemindNightSnack { get; set; }
        [Display(Name = "�H���d�]")]
        public Nullable<bool> onbordNightSnack { get; set; }
        [Display(Name = "�d�]"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? nightSnack { get; set; }

        [Display(Name = "�����ث~")]
        public bool remindGiveaway { get; set; } = false;
        [Display(Name = "�����ث~����")]
        public Nullable<bool> FinsRemindGiveaway { get; set; }
        [Display(Name = "�H���ث~")]
        public Nullable<bool> onbordGiveaway { get; set; }
        [Display(Name = "�ث~"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? giveaway { get; set; }

        [Display(Name = "������L")]
        public bool remindOther { get; set; } = false;
        [Display(Name = "������L����")]
        public Nullable<bool> FinsRemindOther { get; set; }
        [Display(Name = "�H����L")]
        public Nullable<bool> onbordOther { get; set; }
        [Display(Name = "��L"), StringLength(100), MaxLength(100, ErrorMessage = "���פ��i�W�L 100�Ӧr")]
        public string? otherTodo { get; set; }

        [Display(Name = "�����q�u��")]
        public bool remindMineralWater { get; set; } = false;
        [Display(Name = "�����q�u������")]
        public Nullable<bool> FinsRemindMineralWater { get; set; }
        [Display(Name = "�H���q�u��")]
        public Nullable<bool> onbordMineralWater { get; set; }
        [Display(Name = "�q�u��")]
        public int mineralWater { get; set; }

        [Display(Name = "���������ⶤ")]
        public Nullable<bool> remindAssignLeader { get; set; }
        [Display(Name = "���������ⶤ����")]
        public Nullable<bool> FinsRemindAssignLeader { get; set; }
        [Display(Name = "�H�������ⶤ")]
        public Nullable<bool> onbordAssignLeader { get; set; }

        [Display(Name = "�����o��")]
        public Nullable<bool> remindBill { get; set; }
        [Display(Name = "�����o������")]
        public Nullable<bool> FinsRemindBill { get; set; }
        [Display(Name = "�H���o��")]
        public Nullable<bool> onbordBill { get; set; }

        [Display(Name = "�����N����I����")]
        public Nullable<bool> remindReceipt { get; set; }
        [Display(Name = "�����N����I����")]
        public Nullable<bool> FinsRmindReceipt { get; set; }
        [Display(Name = "�H���N����I���ڧ���")]
        public Nullable<bool> onbordReceipt { get; set; }

        [Display(Name = "�����״ڱb��")]
        public Nullable<bool> remindRemittanceAccount { get; set; }
        [Display(Name = "�����״ڱb������")]
        public Nullable<bool> FnsRemindRemittanceAccount { get; set; }
        [Display(Name = "�H���״ڱb��")]
        public Nullable<bool> onbordRemittanceAccount { get; set; }

        [Display(Name = "����������")]
        public Nullable<bool> remindEstimate { get; set; }
        [Display(Name = "���������槹��")]
        public Nullable<bool> FinsRemindEstimate { get; set; }
        [Display(Name = "�H��������")]
        public Nullable<bool> onbordEstimate { get; set; }

        [Display(Name = "�ȥ��I")]
        public bool travelInsurance { get; set; } = false;
        [Display(Name = "�ȥ��I�U�N�~ ")]
        public int? travelInsuranceAccident { get; set; }
        [Display(Name = "�ȥ��I�U����")]
        public int? travelInsuranceMedical { get; set; }
        [Display(Name = "�ȥ��I�O�O")]
        public int? travelInsuranceAmount { get; set; }

        [Display(Name = "�ȳd�I")]
        public bool travelDutyInsurance { get; set; } = false;
        [Display(Name = "�ȳd�I�U�N�~ ")]
        public int? travelDutyInsuranceAccident { get; set; }
        [Display(Name = "�ȳd�I�U����")]
        public int? travelDutyInsuranceMedical { get; set; }
        [Display(Name = "�ȳd�I�O�O")]
        public int? travelDutyInsuranceAmount { get; set; }
        [Display(Name = "���L��F�O")]
        public bool HasAdministrativeCosts { get; set; } = false;
        [Display(Name = "��F�O")]
        public int? AdministrativeCosts { get; set; }
        [Display(Name = "��F�O(�H��)")]
        public int? AdministrativeCostsAmount { get; set; }
    }
    //���ں޲z CollectionManagement
    public partial class OrderCarNTP
    {
        [Display(Name = "���ڤ覡_�{��")]
        public bool receiveByCash { get; set; } = false;
        [Display(Name = "���ڤ覡_��d")]
        public bool receiveByCard { get; set; } = false;
        [Display(Name = "���ڤ覡_�״�")]
        public bool receiveByMoneyTransfer { get; set; } = false;
        [Display(Name = "���ڤ覡_�䲼")]
        public bool receiveByCheck { get; set; } = false;
        [Display(Name = "���ڤ覡_�䥦")]
        public bool receiveByOther { get; set; } = false;
        [Display(Name = "��L���ڤ覡"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? otherReceive { get; set; }
        [Display(Name = "���{�`���B")]
        public int? receiveAmount { get; set; } = 0;
        [Display(Name = "���{����_����")]
        public int? receiveFare { get; set; } = 0;
        [Display(Name = "���{����_�O�I")]
        public int? receiveInsurance { get; set; } = 0;
        [Display(Name = "���{����_�ζO")]
        public int? receiveGroupFee { get; set; } = 0;
        [Display(Name = "���{����_��L")]
        public int? receiveOther { get; set; } = 0;
        [Display(Name = "�Q��")]
        public int? profit { get; set; } = 0;
    }

   
}


