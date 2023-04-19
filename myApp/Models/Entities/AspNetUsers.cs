namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

    public partial class AspNetUsers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AspNetUsers()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaims>();
            AspNetUserLogins = new HashSet<AspNetUserLogins>();
            AspNetRoles = new HashSet<AspNetRoles>();
        }

        public string? Id { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(256), Display(Name = "Email")]
        public string? Email { get; set; }

        public bool EmailConfirmed { get; set; }
        [Display(Name ="�K�X")]
        public string? PasswordHash { get; set; }

        public string? SecurityStamp { get; set; }

        public string? PhoneNumber { get; set; }

        public bool PhoneNumberConfirmed { get; set; }

        public bool TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        public bool LockoutEnabled { get; set; }

        public int AccessFailedCount { get; set; }

        [Required]
        [StringLength(256),Display(Name ="�b��")  ]
        public string? UserName { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserClaims> AspNetUserClaims { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetUserLogins> AspNetUserLogins { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AspNetRoles> AspNetRoles { get; set; }

        [StringLength(256)]
        public string? Name { get; set; }
        public bool IsSysAdmin { get; set; }
        public bool IsActive { get; set; }
        public string? UserId { get; set; }
        [StringLength(128)]
        public string? Discriminator { get; set; }
   
        [NotMapped, StringLength(128)]
        public string? roleName { get; set; }
        [NotMapped, StringLength(128)]
        public string? roleId { get; set; }
        [ForeignKey("EmployeeMain_employeeTID")]
        public EmployeeMain EmployeeMain { get; set; }
        [Display(Name = "���u�m�W")]
        public int EmployeeMain_employeeTID { get; set; }
        [NotMapped]
        public string? Password
        {
            get { return this.PasswordHash; }
            //set { this.PasswordHash = value; }
        }
    }
}
