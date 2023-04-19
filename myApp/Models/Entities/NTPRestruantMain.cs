namespace hsintongERP2022.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NTPRestruantMain")]
    public partial class NTPRestruantMain
    {
        [Key, Required]
        public int NTPRestMainTID { get; set; }
        public int orderCarID { get; set; }
        //�ĴX��, �U�Կ�� (1~10)
        public int AccNightOrder { get; set; }
        //"���\���\�U����, �U�Կ��.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode
        [StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? BreakyRestCity { get; set; }
        [Display(Name = "���\���\�U.�m����")]
        public int? BreakyRestdist { get; set; }
        //���\���\�U�A�U�Կ��        FK_RestruantMain.RestruantMainTID
        public int? BreakyRestruantMainID { get; set; }
        //���\�\�U�p���H�q��
        [StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? BreakyRestContactNumber { get; set; }
        //���\���
        public int? BreakyPrice { get; set; }
        //���\����
        public int? BreakyQty { get; set; }
        //"���\������        �U�Կ��:  �s��bDictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25), MaxLength(25, ErrorMessage = "���פ��i�W�L 25�Ӧr")]
        public string? BreakyUnit { get; set; }
        //���\�������
        public int? BreakyVegaUnitPrice { get; set; }
        //���\��������
        public int? BreakyVegaQty { get; set; }
        [Display(Name = "���\�Ƶ�"), StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? BreakyRemark { get; set; }
        //���\�������Ƴ��        �O�d���A�ثe���� ""��"""        [StringLength(25)]
        public string? BreakyVegaUnit { get; set; }
        //���\�ж�������
        [Column(TypeName = "ntext")]
        public string? BreakyRestProvide { get; set; }
        //���\�ȤH�۳�
        [Column(TypeName = "ntext")]
        public string? BreakyCusProvide { get; set; }
        //���\���\�U����, �U�Կ��.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode
        [StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? LunchRestCity { get; set; }
        [Display(Name = "���\���\�U.�m����")]
        public int? LunchRestdist { get; set; }
        //���\���\�U�A�U�Կ��        FK_RestruantMain.RestruantMainTID
        public int? LunchRestruantMainID { get; set; }
        //���\�\�U�p���H�q��
        [StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? LunchRestContactNumber { get; set; }
        //���\���
        public int? LunchPrice { get; set; }
        //���\����
        public int? LunchQty { get; set; }
        //"���\������        �U�Կ��:  �s��bDictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25), MaxLength(25, ErrorMessage = "���פ��i�W�L 25�Ӧr")]
        public string? LunchUnit { get; set; }
        //���\�������
        public int? LunchVegaUnitPrice { get; set; }
        //���\��������
        public int? LunchVegaQty { get; set; }
        //���\�������Ƴ��        �O�d���A�ثe���� ""��""
        [StringLength(25), MaxLength(25, ErrorMessage = "���פ��i�W�L 25�Ӧr")]
        public string? LunchVegaUnit { get; set; }
        [Display(Name = "���\�Ƶ�"), StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? LunchRemark { get; set; }
        //���\�ж�������
        [Column(TypeName = "ntext")]
        public string? LunchRestProvide { get; set; }
        //���\�ȤH�۳�
        [Column(TypeName = "ntext")]
        public string? LunchCusProvide { get; set; }
        //���\���\�U����, �U�Կ��.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode
        [StringLength(50)]
        public string? DinnerRestCity { get; set; }
        [Display(Name = "���\���\�U.�m����")]
        public int? DinnerRestdist { get; set; }
        //"���\���\�U�A�U�Կ��        FK_RestruantMain.RestruantMainTID"
        public int? DinnerRestruantMainID { get; set; }
        //���\�\�U�p���H�q��
        [StringLength(50)]
        public string? DinnerRestContactNumber { get; set; }
        //���\���
        public int? DinnerPrice { get; set; }
        //���\����
        public int? DinnerQty { get; set; }
        //"���\������        �U�Կ��:  �s��bDictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25)]
        public string? DinnerUnit { get; set; }
        //���\�������
        public int? DinnerVegaUnitPrice { get; set; }
        //���\��������
        public int? DinnerVegaQty { get; set; }
        //"���\�������Ƴ��        �O�d���A�ثe���� ""��"""        [StringLength(25)]
        public string? DinnerVegaUnit { get; set; }
        [Display(Name = "���\�Ƶ�"), StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? DinnerRemark { get; set; }
        //���\�ж�������
        [Column(TypeName = "ntext")]
        public string? DinnerRestProvide { get; set; }
        //���\�ȤH�۳�
        [Column(TypeName = "ntext")]
        public string? DinnerCusProvide { get; set; }
        //"�]�d���\�U����, �U�Կ��.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode"
        [StringLength(50)]
        public string? SupRestCity { get; set; }
        [Display(Name = "�]�d���\�U.�m����")]
        public int? SupRestdist { get; set; }
        //"�]�d���\�U�A�U�Կ��        FK_RestruantMain.RestruantMainTID"
        public int? SupRestruantMainID { get; set; }
        //�]�d�\�U�p���H�q��
        [StringLength(50)]
        public string? SupRestContactNumber { get; set; }
        //�]�d���
        public int? SupPrice { get; set; }
        //�]�d����
        public int? SupQty { get; set; }
        //"�]�d������        �U�Կ��:  �s��bDictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25)]
        public string? SupUnit { get; set; }
        //�]�d�������
        public int? SupVegaUnitPrice { get; set; }
        //�]�d��������
        public int? SupVegaQty { get; set; }
        //�]�d�������Ƴ��        �O�d���A�ثe���� ""��""
        [StringLength(25)]
        public string? SupVegaUnit { get; set; }
        [Display(Name = "���]�Ƶ�"), StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? SupRemark { get; set; }
        //�]�d�ж�������
        [Column(TypeName = "ntext")]
        public string? SupRestProvide { get; set; }
        //SupCusProvide
        [Column(TypeName = "ntext")]
        public string? SupCusProvide { get; set; }
        [Display(Name = "���A"), StringLength(20), MaxLength(20, ErrorMessage = "���פ��i�W�L 20�Ӧr")]
        public string? status { get; set; } = "Active";
        [NotMapped]
        public string? BreakyRestTitle { get; set; }
        [NotMapped]
        public string? LunchRestTitle { get; set; }
        [NotMapped]
        public string? DinnerRestTitle { get; set; }
        [NotMapped]
        public string? SupRestTitle { get; set; }
        [NotMapped]
        public string? BreakyCityName { get; set; }
        [NotMapped]
        public string? LunchCityName { get; set; }
        [NotMapped]
        public string? DinnerCityName { get; set; }
        [NotMapped]
        public string? SupCityName { get; set; }
        public bool deleted { get; set; } = false;
        //[ForeignKey("BreakyRestCity")]
        //public virtual TaiwanCity BreakytTaiwanCity { get; set; }
        //[ForeignKey("LunchRestCity")]
        //public virtual TaiwanCity LunchTaiwanCity { get; set; }
        //[ForeignKey("DinnerRestCity")]
        //public virtual TaiwanCity DinnertTaiwanCity { get; set; }
        //[ForeignKey("SupRestCity")]
        //public virtual TaiwanCity SuptTaiwanCity { get; set; }
        [ForeignKey("BreakyRestruantMainID")]
        public virtual RestruantMain BreakyRestruantMain { get; set; }
        [ForeignKey("LunchRestruantMainID")]
        public virtual RestruantMain LunchRestruantMain { get; set; }
        [ForeignKey("DinnerRestruantMainID")]
        public virtual RestruantMain DinnerRestruantMain { get; set; }
        [ForeignKey("SupRestruantMainID")]
        public virtual RestruantMain SupRestruantMain { get; set; }
        [NotMapped]
        public bool isBreakFee { get; set; }
        [NotMapped]
        public bool isLumchFee { get; set; }
        [NotMapped]
        public bool isDinnerFee { get; set; }
        [NotMapped]
        public bool isSupFee { get; set; }
    }
    public partial class NTPRestruantOtherFee
    {
        [Key, Required]
        public int ID { get; set; }
        //FK_NTPRestruantTable.NTPRestMainTID
        public int NTPRestMainTID { get; set; }
        [Display(Name = "�\�O")]
        public RestruantType MealType { get; set; }
        [Display(Name = "�O�ζ���"), StringLength(15), MaxLength(15, ErrorMessage = "���פ��i�W�L 15�Ӧr")]
        public string? FeeType { get; set; }
        [Display(Name = "���")]
        public int? UnitPrice { get; set; }
        [Display(Name = "�ƶq")]
        public int? Amount   { get; set; }
        [Display(Name = "���"), StringLength(2), MaxLength(2, ErrorMessage = "���פ��i�W�L 2�Ӧr")]
        public string? Unit { get; set; }
        [Display(Name = "�Ƶ�"), StringLength(50), MaxLength(50, ErrorMessage = "���פ��i�W�L 50�Ӧr")]
        public string? Remark    { get; set; }
        public bool deleted { get; set; } = false;
    }
    public enum RestruantType
    {
        Break = 1,
        Lunch = 2,
        Dinner = 3,
        Sup = 4
    }
}
