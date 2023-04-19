namespace hsintongERP2022.Models
{
    using Howgreater.util;
    using LinqKit;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    using System.Data.Entity.Spatial;
    using System.Linq.Expressions;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Collections.ObjectModel;

    [MetadataType(typeof(EmployeeMainMetadata))]
    [Table("EmployeeMain")]
    public partial class EmployeeMain : IDataObject<EmployeeMain>
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EmployeeMain()
        {
            AccessAccount = new HashSet<AccessAccount>();
            CarAccident = new HashSet<CarAccident>();
            CarAppointment = new HashSet<CarAppointment>();
            CarMaintaince = new HashSet<CarMaintaince>();
            CarSafetyRecord = new HashSet<CarSafetyRecord>();
            EmployeeCertificate = new HashSet<EmployeeCertificate>();
            EmployeeLeaveRecord = new HashSet<EmployeeLeaveRecord>();
            EmployeeMsessage = new HashSet<EmployeeMsessage>();
            EmployeeSalary = new HashSet<EmployeeSalary>();
            EmployeeSalaryDailyShift = new HashSet<EmployeeSalaryDailyShift>();
            OrderCarInfo = new HashSet<OrderCarInfo>();
            OrderCar = new HashSet<OrderCar>();
            OrderCar1 = new HashSet<OrderCar>();
            OrderCar2 = new HashSet<OrderCar>();
            SystemMessage = new HashSet<SystemMessage>();
            SystemMessage1 = new HashSet<SystemMessage>();
        }

        [Key]
        public int employeeTID { get; set; }

        [StringLength(15)]
        public string? empID { get; set; }

        [Required]
        [StringLength(15)]
        public string? empNID { get; set; }

        [Required]
        [StringLength(50)]
        public string? empName { get; set; }

        public long empDOB { get; set; }

        [Required]
        [StringLength(12)]
        public string? empSex { get; set; }

        [Required]
        [StringLength(30)]
        public string? empMainContact { get; set; }

        [Required]
        [StringLength(30)]
        public string? empSecondContact { get; set; }

        [Required]
        [StringLength(15)]
        public string? empDuty { get; set; }

        [Required]
        [StringLength(15)]
        public string? empGrade { get; set; }

        [Column(TypeName = "text")]
        public string? memo { get; set; }

        public int? EmployeeAttributesID { get; set; } 

        public int? EmployeeDepartmentID { get; set; } 

        public int? EmployeeGroupID { get; set; }

        [Required]
        [StringLength(15)]
        public string? status { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessAccount> AccessAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarAccident> CarAccident { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarAppointment> CarAppointment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarMaintaince> CarMaintaince { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarSafetyRecord> CarSafetyRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeCertificate> EmployeeCertificate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLeaveRecord> EmployeeLeaveRecord { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeMsessage> EmployeeMsessage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSalary> EmployeeSalary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSalaryDailyShift> EmployeeSalaryDailyShift { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCarInfo> OrderCarInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCar> OrderCar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCar> OrderCar1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderCar> OrderCar2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemMessage> SystemMessage { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SystemMessage> SystemMessage1 { get; set; }

  
        public double OnTheJob { get; set; }
        public double Resignation { get; set; }
        [Display(Name = "緊急聯絡人姓名"), StringLength(10), MaxLength(10, ErrorMessage = "長度不可超過 10個字")]
        public string? EmgContactName { get; set; }
        [Display(Name = "緊急聯絡人電話"), StringLength(20), MaxLength(20, ErrorMessage = "長度不可超過 20個字")]
        public string? EmgContactTel { get; set; }
        [Display(Name = "投保公司"), StringLength(30), MaxLength(30, ErrorMessage = "長度不可超過 30個字")]
        public string? InsuCorp { get; set; }
        [Display(Name = "投保級距")]
        public int? InsuClass { get; set; }
        [ForeignKey("EmployeeDepartmentID")]
        public EmployeeDepartment EmpDepartment { get; set; }
        [ForeignKey("EmployeeAttributesID")]
        public EmployeeAttributes EmpAttributes { get; set; }
        [ForeignKey("EmployeeGroupID")]
        public EmployeeGroup EmpGroup { get; set; }
        [NotMapped]
        public int ID { get { return employeeTID; } set { employeeTID = value; } }
        [NotMapped]
        [Display(Name = "到職日")]
        public string? OnTheJobDay
        {
            get { return ((long?)OnTheJob).LongToDateString(); }
            set { OnTheJob = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "離職日")]
        public string? ResignationDay
        {
            get { return ((long?)Resignation).LongToDateString(); }
            set { Resignation = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "生日")]
        public string? empBirthday
        {
            get { return ((long?)empDOB).LongToDateString(); }
            set { empDOB = value.ToDateLong(); }
        }
        [NotMapped]
        [Display(Name = "職務")]
        public string? dutyTitle
        {
            get
            {
                return (empDuty == "admin") ? "行政"
                  : (empDuty == "account") ? "財務"
                  : (empDuty == "marketing") ? "業務"
                   : (empDuty == "driver") ? "司機"
                   : (empDuty == "manager") ? "管理" : empDuty;
            }
        }
        #region function
        public IQueryable Take(Model_hsintong db, Expression<Func<EmployeeMain, bool>> expression, string? orderCol, bool desc, int start, int length)
        {
            return db.EmployeeMain.Where(x => !x.deleted).Where(m => m.status == "Active").Where(expression).OrderBy(orderCol, desc).Skip(start).Take(length);
        }

        public int FilterCount(Model_hsintong db, Expression<Func<EmployeeMain, bool>> expression)
        {
            return db.EmployeeMain.Where(x => !x.deleted).Where(m => m.status == "Active").Count(expression);
        }
        //public IQueryable Take(Model_hsintong db, string? keyword)
        //{
        //    ExpressionStarter<EmployeeMain> predicate = StringPredicate(keyword);
        //    return db.EmployeeMain.Where(x => !x.deleted).Where(m => m.status == "Active").Where(predicate);
        //}

        public int FilterCount(Model_hsintong db, string? keyword)
        {
            ExpressionStarter<EmployeeMain> predicate = StringPredicate(keyword);
            return db.EmployeeMain.Where(x => !x.deleted).Where(m => m.status == "Active").Count(predicate);
        }

        public Expression<Func<EmployeeMain, bool>> StringPredicate(string? keyword)
        {
            ExpressionStarter<EmployeeMain> predicate = PredicateBuilder.New<EmployeeMain>();
            predicate.And(m => m.status == "Active");
            if (string.IsNullOrEmpty(keyword))
                return predicate.Or(c => true);
            else
                return predicate.Or(c => c.empName.Contains(keyword))
                     .Or(c => c.empMainContact.Contains(keyword))
                     .Or(c => c.memo.Contains(keyword));
        }
        public int CountAll(Model_hsintong db)
        {
            return db.EmployeeMain.Count(m => m.status == "Active");
        }
        public EmployeeMain GetOne(Model_hsintong db, int? id)
        {
            if (id == null) { return null; }
            return db.EmployeeMain.Find(id);
        }
        public static int getNoDriverTID(Model_hsintong db)
        {
            var emps = db.EmployeeMain.FirstOrDefault(x => x.status == "noDriver");
            return (emps != null) ? emps.employeeTID : -999;
            //MssqlTool sql = new MssqlTool();
            //string? sqlCmd = "Select employeeTID from EmployeeMain where status = 'noDriver' ";
            //DataTable keyword = sql.findByKeywordDateTable(sqlCmd);
            //if (keyword != null && keyword.Rows.Count > 0)
            //{
            //    return Convert.ToInt32(keyword.Rows[0]["employeeTID"]);
            //}
            //else
            //{
            //    return -999;
            //}
        }
        #endregion function

        public bool deleted { get; set; } = false;
        //[Obsolete]
        //public Collection<EmployeeMain> findAll()
        //{

        //    Collection<EmployeeMain> c = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        DataSet ds = my.select("select * from EmployeeMain order by employeeTID asc", "EmployeeMain");
        //        if (ds.Tables["EmployeeMain"].Rows.Count > 0)
        //        {
        //            c = new Collection<EmployeeMain>();
        //            foreach (DataRow dr in ds.Tables["EmployeeMain"].Rows)
        //            {
        //                EmployeeMain am = new EmployeeMain();
        //                am.empID = Convert.ToString(dr["empID"]);
        //                am.empNID = Convert.ToString(dr["empNID"]);
        //                am.empName = Convert.ToString(dr["empName"]);
        //                am.empDOB = Convert.ToInt64(dr["empDOB"]);
        //                am.empSex = Convert.ToString(dr["empSex"]);
        //                am.empMainContact = Convert.ToString(dr["empMainContact"]);
        //                am.empSecondContact = Convert.ToString(dr["empSecondContact"]);
        //                am.empDuty = Convert.ToString(dr["empDuty"]);
        //                am.empGrade = Convert.ToString(dr["empGrade"]);
        //                am.memo = Convert.ToString(dr["memo"]);
        //                am.EmployeeAttributesID = Convert.ToInt32(dr["EmployeeAttributesID"]);
        //                am.EmployeeDepartmentID = Convert.ToInt32(dr["EmployeeDepartmentID"]);
        //                am.EmployeeGroupID = Convert.ToInt32(dr["EmployeeGroupID"]);
        //                am.status = Convert.ToString(dr["status"]);
        //                am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
        //                c.Add(am);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.findAll() : " + e.ToString());
        //    }
        //    return c;
        //}
        //[Obsolete]
        //public static Collection<EmployeeMain> findByKeyword(string? sqlCmd)
        //{
        //    Collection<EmployeeMain> c = null;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        DataSet ds = my.select(sqlCmd, "EmployeeMain");
        //        if (ds.Tables["EmployeeMain"].Rows.Count > 0)
        //        {
        //            c = new Collection<EmployeeMain>();
        //            foreach (DataRow dr in ds.Tables["EmployeeMain"].Rows)
        //            {
        //                EmployeeMain am = new EmployeeMain();
        //                am.empID = Convert.ToString(dr["empID"]);
        //                am.empNID = Convert.ToString(dr["empNID"]);
        //                am.empName = Convert.ToString(dr["empName"]);
        //                am.empDOB = Convert.ToInt64(dr["empDOB"]);
        //                am.empSex = Convert.ToString(dr["empSex"]);
        //                am.empMainContact = Convert.ToString(dr["empMainContact"]);
        //                am.empSecondContact = Convert.ToString(dr["empSecondContact"]);
        //                am.empDuty = Convert.ToString(dr["empDuty"]);
        //                am.empGrade = Convert.ToString(dr["empGrade"]);
        //                am.memo = Convert.ToString(dr["memo"]);
        //                am.EmployeeAttributesID = Convert.ToInt32(dr["EmployeeAttributesID"]);
        //                am.EmployeeDepartmentID = Convert.ToInt32(dr["EmployeeDepartmentID"]);
        //                am.EmployeeGroupID = Convert.ToInt32(dr["EmployeeGroupID"]);
        //                am.status = Convert.ToString(dr["status"]);
        //                am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
        //                c.Add(am);
        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.findByKeyword() : " + e.ToString());
        //    }
        //    return c;
        //}
        [Obsolete]
        public EmployeeMain findByPrimaryKey(int employeeTID)
        {
            EmployeeMain am = null;
            try
            {
                MssqlTool my = new MssqlTool("");
                string? sqlCmd = "select * FROM EmployeeMain a WHERE a.employeeTID = " + employeeTID;
                DataSet ds = my.select(sqlCmd, "EmployeeMain");
                if (ds.Tables["EmployeeMain"].Rows.Count == 1)
                {
                    DataRow dr = ds.Tables["EmployeeMain"].Rows[0];
                    am = new EmployeeMain();
                    am.empID = Convert.ToString(dr["empID"]);
                    am.empNID = Convert.ToString(dr["empNID"]);
                    am.empName = Convert.ToString(dr["empName"]);
                    am.empDOB = Convert.ToInt64(dr["empDOB"]);
                    am.empSex = Convert.ToString(dr["empSex"]);
                    am.empMainContact = Convert.ToString(dr["empMainContact"]);
                    am.empSecondContact = Convert.ToString(dr["empSecondContact"]);
                    am.empDuty = Convert.ToString(dr["empDuty"]);
                    am.empGrade = Convert.ToString(dr["empGrade"]);
                    am.memo = Convert.ToString(dr["memo"]);
                    am.EmployeeAttributesID = Convert.ToInt32(dr["EmployeeAttributesID"]);
                    am.EmployeeDepartmentID = Convert.ToInt32(dr["EmployeeDepartmentID"]);
                    am.EmployeeGroupID = Convert.ToInt32(dr["EmployeeGroupID"]);
                    am.status = Convert.ToString(dr["status"]);
                    am.employeeTID = Convert.ToInt32(dr["employeeTID"]);
                }
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.findByPrimaryKey() : " + e.ToString());
            }
            return am;
        }
        //[Obsolete]
        //public int create(string? empID, string? empNID, string? empName, long empDOB, string? empSex, string? empMainContact, string? empSecondContact, string? empDuty, string? empGrade, string? memo, int EmployeeAttributesID, int EmployeeDepartmentID, int EmployeeGroupID, string? status)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        StringBuilder sb_value = new StringBuilder();
        //        sb_value.Append((String.IsNullOrEmpty(empID) ? "null" : "N'" + Regex.Replace(empID, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empNID) ? "''" : "N'" + Regex.Replace(empNID, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empName) ? "''" : "N'" + Regex.Replace(empName, "'", "''") + "'") + ",");
        //        sb_value.Append(empDOB + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empSex) ? "''" : "N'" + Regex.Replace(empSex, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empMainContact) ? "''" : "N'" + Regex.Replace(empMainContact, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empSecondContact) ? "''" : "N'" + Regex.Replace(empSecondContact, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empDuty) ? "''" : "N'" + Regex.Replace(empDuty, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(empGrade) ? "''" : "N'" + Regex.Replace(empGrade, "'", "''") + "'") + ",");
        //        sb_value.Append((String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
        //        sb_value.Append(EmployeeAttributesID + ",");
        //        sb_value.Append(EmployeeDepartmentID + ",");
        //        sb_value.Append(EmployeeGroupID + ",");
        //        sb_value.Append((String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

        //        string? sqlCmd = "insert into EmployeeMain(empID,empNID,empName,empDOB,empSex,empMainContact,empSecondContact,empDuty,empGrade,memo,EmployeeAttributesID,EmployeeDepartmentID,EmployeeGroupID,status) values (" + sb_value.ToString() + ")";
        //        count = my.insertBackIdentity(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.create() : " + e.ToString());
        //    }
        //    return count;
        //}
        //[Obsolete]
        //public int Delete(int employeeTID)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        string? sqlCmd = "delete from EmployeeMain where employeeTID = " + employeeTID;
        //        count = my.delete(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.delete() : " + e.ToString());
        //    }
        //    return count;
        //}
        //[Obsolete]
        //public int DeleteByKeyword(string? sqlCmd)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        count = my.delete(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.DeleteByKeyword() : " + e.ToString());
        //    }
        //    return count;
        //}
        [Obsolete]
        public int update(string? empID, string? empNID, string? empName, long empDOB, string? empSex, string? empMainContact, string? empSecondContact, string? empDuty, string? empGrade, string? memo, int EmployeeAttributesID, int EmployeeDepartmentID, int EmployeeGroupID, string? status)
        {
            int count = 0;
            try
            {
                MssqlTool my = new MssqlTool("");
                StringBuilder sb_value = new StringBuilder();
                sb_value.Append("empID=" + (String.IsNullOrEmpty(empID) ? "null" : "N'" + Regex.Replace(empID, "'", "''") + "'") + ",");
                sb_value.Append("empNID=" + (String.IsNullOrEmpty(empNID) ? "''" : "N'" + Regex.Replace(empNID, "'", "''") + "'") + ",");
                sb_value.Append("empName=" + (String.IsNullOrEmpty(empName) ? "''" : "N'" + Regex.Replace(empName, "'", "''") + "'") + ",");
                sb_value.Append("empDOB =" + empDOB + ",");
                sb_value.Append("empSex=" + (String.IsNullOrEmpty(empSex) ? "''" : "N'" + Regex.Replace(empSex, "'", "''") + "'") + ",");
                sb_value.Append("empMainContact=" + (String.IsNullOrEmpty(empMainContact) ? "''" : "N'" + Regex.Replace(empMainContact, "'", "''") + "'") + ",");
                sb_value.Append("empSecondContact=" + (String.IsNullOrEmpty(empSecondContact) ? "''" : "N'" + Regex.Replace(empSecondContact, "'", "''") + "'") + ",");
                sb_value.Append("empDuty=" + (String.IsNullOrEmpty(empDuty) ? "''" : "N'" + Regex.Replace(empDuty, "'", "''") + "'") + ",");
                sb_value.Append("empGrade=" + (String.IsNullOrEmpty(empGrade) ? "''" : "N'" + Regex.Replace(empGrade, "'", "''") + "'") + ",");
                sb_value.Append("memo=" + (String.IsNullOrEmpty(memo) ? "null" : "N'" + Regex.Replace(memo, "'", "''") + "'") + ",");
                sb_value.Append("EmployeeAttributesID =" + EmployeeAttributesID + ",");
                sb_value.Append("EmployeeDepartmentID =" + EmployeeDepartmentID + ",");
                sb_value.Append("EmployeeGroupID =" + EmployeeGroupID + ",");
                sb_value.Append("status=" + (String.IsNullOrEmpty(status) ? "''" : "N'" + Regex.Replace(status, "'", "''") + "'"));

                string? sqlCmd = "update EmployeeMain set  " + sb_value.ToString() + "  where employeeTID = " + this.employeeTID;
                count = my.update(sqlCmd);
            }
            catch (Exception e)
            {
                new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.create() : " + e.ToString());
            }
            return count;
        }
        //[Obsolete]
        //public int update()
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        StringBuilder sb_value = new StringBuilder();
        //        sb_value.Append("empID=" + (String.IsNullOrEmpty(this.empID) ? "null" : "N'" + Regex.Replace(this.empID, "'", "''") + "'") + ",");
        //        sb_value.Append("empNID=" + (String.IsNullOrEmpty(this.empNID) ? "''" : "N'" + Regex.Replace(this.empNID, "'", "''") + "'") + ",");
        //        sb_value.Append("empName=" + (String.IsNullOrEmpty(this.empName) ? "''" : "N'" + Regex.Replace(this.empName, "'", "''") + "'") + ",");
        //        sb_value.Append("empDOB =" + this.empDOB + ",");
        //        sb_value.Append("empSex=" + (String.IsNullOrEmpty(this.empSex) ? "''" : "N'" + Regex.Replace(this.empSex, "'", "''") + "'") + ",");
        //        sb_value.Append("empMainContact=" + (String.IsNullOrEmpty(this.empMainContact) ? "''" : "N'" + Regex.Replace(this.empMainContact, "'", "''") + "'") + ",");
        //        sb_value.Append("empSecondContact=" + (String.IsNullOrEmpty(this.empSecondContact) ? "''" : "N'" + Regex.Replace(this.empSecondContact, "'", "''") + "'") + ",");
        //        sb_value.Append("empDuty=" + (String.IsNullOrEmpty(this.empDuty) ? "''" : "N'" + Regex.Replace(this.empDuty, "'", "''") + "'") + ",");
        //        sb_value.Append("empGrade=" + (String.IsNullOrEmpty(this.empGrade) ? "''" : "N'" + Regex.Replace(this.empGrade, "'", "''") + "'") + ",");
        //        sb_value.Append("memo=" + (String.IsNullOrEmpty(this.memo) ? "null" : "N'" + Regex.Replace(this.memo, "'", "''") + "'") + ",");
        //        sb_value.Append("EmployeeAttributesID =" + this.EmployeeAttributesID + ",");
        //        sb_value.Append("EmployeeDepartmentID =" + this.EmployeeDepartmentID + ",");
        //        sb_value.Append("EmployeeGroupID =" + this.EmployeeGroupID + ",");
        //        sb_value.Append("status=" + (String.IsNullOrEmpty(this.status) ? "''" : "N'" + Regex.Replace(this.status, "'", "''") + "'"));

        //        string? sqlCmd = "update EmployeeMain set  " + sb_value.ToString() + "  where employeeTID = " + this.employeeTID;
        //        count = my.update(sqlCmd);
        //    }
        //    catch (Exception e)
        //    {
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.update() : " + e.ToString());
        //    }
        //    return count;
        //}
        //[Obsolete]
        //public int TotalCountByKeyword(string? sqlCmd)
        //{
        //    int count = 0;
        //    try
        //    {
        //        MssqlTool my = new MssqlTool("");
        //        DataSet ds = my.select(sqlCmd, "EmployeeMain");
        //        if (ds.Tables["EmployeeMain"].Rows.Count > 0)
        //        {
        //            DataRow dr = ds.Tables["EmployeeMain"].Rows[0];
        //            count = Convert.ToInt32(dr[0]);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        count = 0;
        //        new log().wiriteSystemLog("hsintongERP2022.Models.EmployeeMain.TotalCountByKeyword() : " + e.ToString());
        //    }
        //    return count;
        //}
    }
    public class EmployeeMainMetadata
    {
        [StringLength(15)]
        [Display(Name = "員工編號")]
        public string? empID { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "員工身分證號")]
        public string? empNID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "員工姓名")]
        public string? empName { get; set; }

        [Required]
        [StringLength(12)]
        [Display(Name = "性別")]
        public string? empSex { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "主要連絡電話")]
        public string? empMainContact { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name = "第二聯絡電話")]
        public string? empSecondContact { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "員工職務")]
        public string? empDuty { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "員工職級")]
        public string? empGrade { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "狀態")]
        public string? status { get; set; }


        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<AccessAccount>? AccessAccount { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarAccident>? CarAccident { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarAppointment>? CarAppointment { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarMaintaince>? CarMaintaince { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<CarSafetyRecord>? CarSafetyRecord { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<EmployeeCertificate>? EmployeeCertificate { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<EmployeeLeaveRecord>? EmployeeLeaveRecord { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<EmployeeMsessage>? EmployeeMsessage { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<EmployeeSalary>? EmployeeSalary { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<EmployeeSalaryDailyShift>? EmployeeSalaryDailyShift { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCarInfo>? OrderCarInfo { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCar>? OrderCar { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCar>? OrderCar1 { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<OrderCar>? OrderCar2 { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<SystemMessage>? SystemMessage { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<SystemMessage>? SystemMessage1 { get; set; }

    }
}
