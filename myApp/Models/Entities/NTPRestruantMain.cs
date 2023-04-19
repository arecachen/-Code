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
        //第幾晚, 下拉選單 (1~10)
        public int AccNightOrder { get; set; }
        //"早餐的餐廳縣市, 下拉選單.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode
        [StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? BreakyRestCity { get; set; }
        [Display(Name = "早餐的餐廳.鄉鎮市區")]
        public int? BreakyRestdist { get; set; }
        //早餐的餐廳，下拉選單        FK_RestruantMain.RestruantMainTID
        public int? BreakyRestruantMainID { get; set; }
        //早餐餐廳聯絡人電話
        [StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? BreakyRestContactNumber { get; set; }
        //早餐單價
        public int? BreakyPrice { get; set; }
        //早餐份數
        public int? BreakyQty { get; set; }
        //"早餐單價單位        下拉選單:  存放在DictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25), MaxLength(25, ErrorMessage = "長度不可超過 25個字")]
        public string? BreakyUnit { get; set; }
        //早餐素食單價
        public int? BreakyVegaUnitPrice { get; set; }
        //早餐素食份數
        public int? BreakyVegaQty { get; set; }
        [Display(Name = "早餐備註"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? BreakyRemark { get; set; }
        //早餐素食份數單位        保留欄位，目前都填 ""份"""        [StringLength(25)]
        public string? BreakyVegaUnit { get; set; }
        //早餐請飯店提供
        [Column(TypeName = "ntext")]
        public string? BreakyRestProvide { get; set; }
        //早餐客人自備
        [Column(TypeName = "ntext")]
        public string? BreakyCusProvide { get; set; }
        //午餐的餐廳縣市, 下拉選單.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode
        [StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? LunchRestCity { get; set; }
        [Display(Name = "午餐的餐廳.鄉鎮市區")]
        public int? LunchRestdist { get; set; }
        //午餐的餐廳，下拉選單        FK_RestruantMain.RestruantMainTID
        public int? LunchRestruantMainID { get; set; }
        //午餐餐廳聯絡人電話
        [StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? LunchRestContactNumber { get; set; }
        //午餐單價
        public int? LunchPrice { get; set; }
        //午餐份數
        public int? LunchQty { get; set; }
        //"午餐單價單位        下拉選單:  存放在DictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25), MaxLength(25, ErrorMessage = "長度不可超過 25個字")]
        public string? LunchUnit { get; set; }
        //午餐素食單價
        public int? LunchVegaUnitPrice { get; set; }
        //午餐素食份數
        public int? LunchVegaQty { get; set; }
        //午餐素食份數單位        保留欄位，目前都填 ""份""
        [StringLength(25), MaxLength(25, ErrorMessage = "長度不可超過 25個字")]
        public string? LunchVegaUnit { get; set; }
        [Display(Name = "午餐備註"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? LunchRemark { get; set; }
        //午餐請飯店提供
        [Column(TypeName = "ntext")]
        public string? LunchRestProvide { get; set; }
        //午餐客人自備
        [Column(TypeName = "ntext")]
        public string? LunchCusProvide { get; set; }
        //晚餐的餐廳縣市, 下拉選單.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode
        [StringLength(50)]
        public string? DinnerRestCity { get; set; }
        [Display(Name = "晚餐的餐廳.鄉鎮市區")]
        public int? DinnerRestdist { get; set; }
        //"晚餐的餐廳，下拉選單        FK_RestruantMain.RestruantMainTID"
        public int? DinnerRestruantMainID { get; set; }
        //晚餐餐廳聯絡人電話
        [StringLength(50)]
        public string? DinnerRestContactNumber { get; set; }
        //晚餐單價
        public int? DinnerPrice { get; set; }
        //晚餐份數
        public int? DinnerQty { get; set; }
        //"晚餐單價單位        下拉選單:  存放在DictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25)]
        public string? DinnerUnit { get; set; }
        //晚餐素食單價
        public int? DinnerVegaUnitPrice { get; set; }
        //晚餐素食份數
        public int? DinnerVegaQty { get; set; }
        //"晚餐素食份數單位        保留欄位，目前都填 ""份"""        [StringLength(25)]
        public string? DinnerVegaUnit { get; set; }
        [Display(Name = "晚餐備註"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? DinnerRemark { get; set; }
        //晚餐請飯店提供
        [Column(TypeName = "ntext")]
        public string? DinnerRestProvide { get; set; }
        //晚餐客人自備
        [Column(TypeName = "ntext")]
        public string? DinnerCusProvide { get; set; }
        //"夜宵的餐廳縣市, 下拉選單.         Text: TaiwanCity.CityName        Value: TaiwanCity.CityCode"
        [StringLength(50)]
        public string? SupRestCity { get; set; }
        [Display(Name = "夜宵的餐廳.鄉鎮市區")]
        public int? SupRestdist { get; set; }
        //"夜宵的餐廳，下拉選單        FK_RestruantMain.RestruantMainTID"
        public int? SupRestruantMainID { get; set; }
        //夜宵餐廳聯絡人電話
        [StringLength(50)]
        public string? SupRestContactNumber { get; set; }
        //夜宵單價
        public int? SupPrice { get; set; }
        //夜宵份數
        public int? SupQty { get; set; }
        //"夜宵單價單位        下拉選單:  存放在DictionaryTable        Text RestruantUnit.text        value Restruantunit.value"
        [StringLength(25)]
        public string? SupUnit { get; set; }
        //夜宵素食單價
        public int? SupVegaUnitPrice { get; set; }
        //夜宵素食份數
        public int? SupVegaQty { get; set; }
        //夜宵素食份數單位        保留欄位，目前都填 ""份""
        [StringLength(25)]
        public string? SupVegaUnit { get; set; }
        [Display(Name = "消夜備註"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
        public string? SupRemark { get; set; }
        //夜宵請飯店提供
        [Column(TypeName = "ntext")]
        public string? SupRestProvide { get; set; }
        //SupCusProvide
        [Column(TypeName = "ntext")]
        public string? SupCusProvide { get; set; }
        [Display(Name = "狀態"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
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
        [Display(Name = "餐別")]
        public RestruantType MealType { get; set; }
        [Display(Name = "費用項目"), StringLength(15), MaxLength(15, ErrorMessage = "長度不可超過 15個字")]
        public string? FeeType { get; set; }
        [Display(Name = "單價")]
        public int? UnitPrice { get; set; }
        [Display(Name = "數量")]
        public int? Amount   { get; set; }
        [Display(Name = "單位"), StringLength(2), MaxLength(2, ErrorMessage = "長度不可超過 2個字")]
        public string? Unit { get; set; }
        [Display(Name = "備註"), StringLength(50), MaxLength(50, ErrorMessage = "長度不可超過 50個字")]
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
