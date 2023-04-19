namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.Serialization;

    [MetadataType(typeof(CarEquipmentMetadata))]
    [Table("CarEquipment")]
    public partial class CarEquipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CarEquipment()
        {
            CarWithEquipment = new HashSet<CarWithEquipment>();
            OrderCarInfoWithEquip = new HashSet<OrderCarInfoWithEquip>();
        }

        [Key]
        public int carEquipTID { get; set; }

        public string? equipName { get; set; }

        [StringLength(50)]
        public string? assetNo { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        [Display(Name = "�γ~����")]
        public int? CarItemCategoryId { get; set; }
        [ForeignKey("CarItemCategoryId")]
        public virtual CarItemCategory? CarItemCategory { get; set; }
        [Display(Name = "�]�Ʋκ�")]
        public int? CarItemsId { get; set; }
        [ForeignKey("CarItemsId")]
        public virtual CarItemsMain? CarItemsMain { get; set; }
        [StringLength(256), Display(Name = "�t�P")]
        public string? label { get; set; }
        [StringLength(256), Display(Name = "������")]
        public string? supplier { get; set; }
        [Column(TypeName = "varchar(MAX)"), Display(Name = "�W��")]
        public string? specification { get; set; }
        [StringLength(256), Display(Name = "�����ɮ�")]
        public string? illustrateImgSrc { get; set; }
        public virtual ICollection<CarEquipmentFiles>? EquipmentFiles { get; set; }
        public bool deleted { get; set; } = false;
        [StringLength(10)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarWithEquipment>? CarWithEquipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfoWithEquip>? OrderCarInfoWithEquip { get; set; }
        [NotMapped]
        public string? ststusText { get; set; }

    }
    public class CarEquipmentMetadata
    {
        [Required]
        [StringLength(50), Display(Name = "��~�W��")]
        public string? equipName { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarWithEquipment>? CarWithEquipment { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCarInfoWithEquip>? OrderCarInfoWithEquip { get; set; }
    }
}
