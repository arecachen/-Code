namespace hsintongERP2022.Models
{
    using BotDetect;
    using Howgreater.util;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CarAccident")]
    public partial class CarAccident
    {
        [Key]
        public int carAccidentTID { get; set; }

        public long caCreateatetime { get; set; }

        public long caDatetime { get; set; }

        public int caDatetimeApprox { get; set; }

        [Required]
        
        [StringLength(15, MinimumLength = 1, ErrorMessage = "������������")]
        public string? carID { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "�q����������")]
        public int caDriver { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "�o�ͨƥѥ�������")]        
        public string? caOccured { get; set; }      
        [Column(TypeName = "text")]
        [Required(ErrorMessage = "�B�z�K�n��������")]
        public string? caResolution { get; set; }

        public int? caDriverFund { get; set; }

        public int caFixIt { get; set; }

        public int caRemedy { get; set; }

        public int caNotifyPolice { get; set; }

        public int caReportToPolice { get; set; }

        public int caUseInsurance { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "�X�I���q��������")]
        public int caInsuranceID { get; set; }

        [StringLength(50)]
        public string? insuranceType { get; set; }

        public int caInsuranceID2 { get; set; }

        [StringLength(50)]
        public string? insuranceType2 { get; set; }

        [Column(TypeName = "text")]
        public string? caInsuranceMemo { get; set; }

        [StringLength(256)]
        public string? injuredMy { get; set; }

        [StringLength(256)]
        public string? injuredOther { get; set; }

        [StringLength(256)]
        public string? damageCarMy { get; set; }

        [StringLength(256)]
        public string? damageCarOther { get; set; }

        [StringLength(256)]
        public string? MemoMy { get; set; }

        [StringLength(256)]
        public string? MemoOther { get; set; }

        [Required]
        [StringLength(20)]
        public string? caStatus { get; set; }

        public virtual CarMain? CarMain { get; set; }

        public virtual Corporation? Corporation { get; set; }
        [ForeignKey("caDriver")]
        public virtual EmployeeMain? EmployeeMain { get; set; }

        public bool deleted { get; set; } = false;
        [NotMapped]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "�F�Ƥ����������")]
        public string? sCaDatetime
        {
            get { return ((long?)caDatetime).LongToDateString(); }
            set { caDatetime = value.ToDateLong(); }
        }
        [NotMapped]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "���ɤ����������")]
        public string? sCaCreateatetime
        {
            get { return ((long?)caCreateatetime).LongToDateString(); }
            set { caCreateatetime = value.ToDateLong(); }
        }


        [NotMapped]
        public string? sStatus
        {
            get
            {
                return (caStatus == "Active") ? "��դ�"
                     : (caStatus == "Resolved") ? "����"
                     : (caStatus == "Reconciliation") ? "�O�I�M�Ѥ�"
                     : (caStatus == "litigation") ? "�D�^��"
                     : (caStatus == "SelfReconciliation") ? "�ۦ�M�Ѥ�"
                     : "������";
            }
        }
        [NotMapped]
        public bool bCaUseInsurance
        {
            get { return caUseInsurance == 1; }
            set { caUseInsurance = (value) ? 1 : 0; }
        }
    }
}
