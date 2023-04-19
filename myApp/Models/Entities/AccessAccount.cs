namespace hsintongERP2022.Models
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Runtime.Serialization;
    [MetadataType(typeof(AccessAccountMetadata))]
    [Table("AccessAccount")]
    public partial class AccessAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccessAccount()
        {
            FinCashFlowMain = new HashSet<FinCashFlowMain>();
            FinCashFlowMain1 = new HashSet<FinCashFlowMain>();
            OrderCarPartnerCarStatementMain = new HashSet<OrderCarPartnerCarStatementMain>();
        }

        [Key]
        public int loginTID { get; set; }

        public int empID { get; set; }

        [Required]
        [StringLength(30)]
        public string? loginID { get; set; }

        [Required]
        [StringLength(30)]
        public string? loginPWD { get; set; }

        [StringLength(256)]
        public string? empEmail { get; set; }

        [StringLength(256)]
        public string? accGroup { get; set; }

        [Required]
        [StringLength(10)]
        public string? status { get; set; }
        public bool deleted { get; set; } = false;

        public virtual EmployeeMain? EmployeeMain { get; set; }    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinCashFlowMain>? FinCashFlowMain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FinCashFlowMain>? FinCashFlowMain1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarPartnerCarStatementMain>? OrderCarPartnerCarStatementMain { get; set; }
        #region sql
        Model_hsintong db = new Model_hsintong();
        public Collection<AccessAccount> findByKeyword(string? sqlCmd)
        {
            return new Collection<AccessAccount>(db.AccessAccount.SqlQuery(sqlCmd).ToList());
        }
        public AccessAccount? findByPrimaryKey(int loginTID)
        {
            return (db.AccessAccount==null)?null:db.AccessAccount.Find(loginTID);
        }
        public int update()
        {
            var aa = db.AccessAccount.Find(this.loginTID);
            if (aa == null) return 0;
            aa.empID = this.empID;
            aa.loginID = this.loginID;
            aa.loginPWD = this.loginPWD;
            aa.empEmail = this.empEmail;
            aa.accGroup = this.accGroup;
            aa.status = this.status;
            return db.SaveChanges();
        }
        public int Delete(int loginTID)
        {
            var entity = db.AccessAccount.Find(loginTID);
            //  db.AccessAccount.Remove(entity);
            entity.deleted = true;
            return db.SaveChanges();
        }
        public int create(int empID, string? loginID, string? loginPWD, string? empEmail, string? accGroup, string? status)
        {
            AccessAccount aa = new AccessAccount()
            {
                empID = empID,
                loginID = loginID,
                loginPWD = loginPWD,
                empEmail = empEmail,
                accGroup = accGroup,
                status = status
            };
            db.AccessAccount.Add(aa);

            return db.SaveChanges();
        }
        #endregion
    }
    public class AccessAccountMetadata
    {
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<FinCashFlowMain>? FinCashFlowMain { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<FinCashFlowMain>? FinCashFlowMain1 { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCarPartnerCarStatementMain>? OrderCarPartnerCarStatementMain { get; set; }
       
    }
}
