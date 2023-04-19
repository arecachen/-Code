namespace hsintongERP2022.Models
{
    using Altways;
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [MetadataType(typeof(CarFinedMetadata))]
    [Table("CarFined")]
    public partial class CarFined
    {
        Model_hsintong _db = new Model_hsintong();
        [Key]
        [Column(Order = 0)]
        public int CarFinedTID { get; set; }

        [StringLength(25)]
        public string? CarFinedCategoryID { get; set; }

        //[Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long caCreatetime { get; set; }

        [StringLength(20)]
        public string? caTicketID { get; set; }

        //[Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long caDatetime { get; set; }


        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int caFinedHour { get; set; }

        //[Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int caFinedMinute { get; set; }

        public int? caRoughFinedTime { get; set; }

        //[Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int caDriver { get; set; }

        //[Key]
        [Column(Order = 6)]
        [StringLength(15)]
        public string? carID { get; set; }

        //[Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string? caFineLocation { get; set; }

        //[Key]
        [Column(Order = 8)]
        [StringLength(100)]
        public string? caFineReason { get; set; }

        [Column(TypeName = "text")]
        public string? caThrough { get; set; }

        [Column(TypeName = "text")]
        public string? caLaw { get; set; }

        public int? caDriverFinedAmount { get; set; }

        [StringLength(20)]
        public string? caDeductStatus { get; set; }

        public int? carDeductUnknow { get; set; }

        [StringLength(256)]
        public string? caMemo { get; set; }

        [StringLength(256)]
        public string? caTicketImage { get; set; }

        [StringLength(256)]
        public string? caTicketImageSysName { get; set; }

        [StringLength(50)]
        public string? caFinedSource { get; set; }

        [StringLength(25)]
        public string? caFinedResolution { get; set; }

        [Column(TypeName = "text")]
        public string? caPartyStatement { get; set; }

        public int? caFiledBy { get; set; }

        public int? caCreatedBy { get; set; }

        //[Key]
        [Column(Order = 9)]
        [StringLength(30)]
        public string? caStatus { get; set; }

        public virtual CarMain? CarMain { get; set; }
        [ForeignKey("caDriver")]
        public virtual EmployeeMain? EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
        [Column(TypeName = "time")]
        public TimeSpan? caFinedTime { get; set; }
        [NotMapped]
        public string? sCaFinedTime
        {
            get { return (caFinedTime == null || caFinedTime.ToString().Length == 0) ? "00:00" : caFinedTime.ToString().Substring(0, 5); }
            set { caFinedTime = value.StrToTimeSpan(); }
        }
        [NotMapped]
        public string? CarFinedCategory { get; set; }
        [NotMapped, Display(Name = "�߮פ��?")]
        public string? sCaCreatetime
        {
            get { return ((long?)caCreatetime).LongToDateString(); }
            set { caCreatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "�H�W���?")]
        public string? sCaDatetime
        {
            get { return ((long?)caDatetime).LongToDateString(); }
            set { caDatetime = value.ToDateLong(); }
        }
        [NotMapped, Display(Name = "�H�W����")]
        public string? crfinedCategory
        {
            get
            {
                return _db.DictionaryTable.FirstOrDefault(x => x.dicValue == CarFinedCategoryID).dicText;
            }
            set { CarFinedCategoryID = _db.DictionaryTable.FirstOrDefault(x => x.dicText.Contains(value)).dicValue; }
        }
        [NotMapped, Display(Name = "�O�_�������ɶ�")]
        public bool IsRoughFinedTime
        {
            get { return caRoughFinedTime.Ensure(x => x > 0, false); }
            set { caRoughFinedTime = value ? 1 : 0; }
        }
        [NotMapped, Display(Name = "���ڪ��B���w ")]
        public bool isDeductUnknow
        {
            get { return carDeductUnknow.Ensure(x => x > 0, false); }
            set { carDeductUnknow = value ? 1 : 0; }
        }

        [NotMapped]
        public string? TicketImage { get; set; }
    }
    public class CarFinedMetadata
    {
        [Key]
        public int CarFinedTID { get; set; }
        [Display(Name = "�H�W����")]// (FK_DictionaryTable.dicCategory='CarFined_CarFinedCategoryID
        public string? CarFinedCategoryID { get; set; }

        [Display(Name = "�H�W����ɤ��")]
        public long caCreatetime { get; set; }
        [Display(Name = "�@��s��")]
        public string? caTicketID { get; set; }
        [Display(Name = "�H�W���?")]
        public long caDatetime { get; set; }
        [Display(Name = "�H�W�ɶ� (��)")]
        public int caFinedHour { get; set; }
        [Display(Name = "�H�W�ɶ� (��)")]
        public int caFinedMinute { get; set; }
        [Display(Name = "�O�_�������ɶ�")]  // (�w�]0: �_�A1:�O)
        public int? caRoughFinedTime { get; set; }
        [Display(Name = "�q��")]// (�n�s�����u���?) FK_EmployeeMain_employeeTID
        public int caDriver { get; set; }
        [Display(Name = "���� ")]//FK_CarMain_carID
        public string? carID { get; set; }
        [Required, Display(Name = "�H�W�a�I ")]
        public string? caFineLocation { get; set; }
        [Display(Name = "�ƥ� ")]
        public string? caFineReason { get; set; }
        [Display(Name = "�H�W�ƹ� ")]
        public string? caThrough { get; set; }
        [Display(Name = "�H�Ϫk�� ")]
        public string? caLaw { get; set; }
        [Display(Name = "�@�ڪ��B ")]
        public int? caDriverFinedAmount { get; set; }
        [Display(Name = "���ڪ��A")] //(FK DictionaryTable.dicCategory='CarFined_caDeductStatus')
        public string? caDeductStatus { get; set; }
        [Display(Name = "���ڪ��B���w ")]
        public int? carDeductUnknow { get; set; }
        [Display(Name = "�Ƶ� ")]
        public string? caMemo { get; set; }
        [Display(Name = "�H�W�v�� ")]
        public string? caTicketImage { get; set; }
        [Display(Name = "�H�W�v���Y�� ")]
        public string? caTicketImageSysName { get; set; }
        [Display(Name = "�ץ�Ѩ�? ")]//(FK: DictionaryTable.dicCategory='CarFined_caFinedSource') 
        public string? caFinedSource { get; set; }
        [Display(Name = "�����B�� ")]//(FK_DictionaryTable.dicCategory='CarFined_caFinedResolution') 
        public string? caFinedResolution { get; set; }
        [Display(Name = "���ƤH���z ")]
        public string? caPartyStatement { get; set; }
        [Display(Name = "�߮פH ")]// (FK_EmployeeMain.EmployeeMainTID)
        public int? caFiledBy { get; set; }
        [Display(Name = "���ɪ� ")]// (FK_EmployeeMain.EmployeeMainTID)
        public int? caCreatedBy { get; set; }
        [Display(Name = "�H�W�檬�A")]//DictionaryTable.dicCategory = 'CarFined'
        public string? caStatus { get; set; }
        public virtual CarMain? CarMain { get; set; }

    }
}
