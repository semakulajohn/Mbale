//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Higgs.Mbale.EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            this.Activities = new HashSet<Activity>();
            this.Activities1 = new HashSet<Activity>();
            this.Activities2 = new HashSet<Activity>();
            this.AspNetUserClaims = new HashSet<AspNetUserClaim>();
            this.AspNetUserLogins = new HashSet<AspNetUserLogin>();
            this.AspNetUsers1 = new HashSet<AspNetUser>();
            this.AspNetUsers11 = new HashSet<AspNetUser>();
            this.AspNetUsers12 = new HashSet<AspNetUser>();
            this.Batches = new HashSet<Batch>();
            this.Batches1 = new HashSet<Batch>();
            this.Batches2 = new HashSet<Batch>();
            this.Branches = new HashSet<Branch>();
            this.Branches1 = new HashSet<Branch>();
            this.Branches2 = new HashSet<Branch>();
            this.CasualWorkers = new HashSet<CasualWorker>();
            this.CasualWorkers1 = new HashSet<CasualWorker>();
            this.CasualWorkers2 = new HashSet<CasualWorker>();
            this.Deliveries = new HashSet<Delivery>();
            this.Deliveries1 = new HashSet<Delivery>();
            this.Deliveries2 = new HashSet<Delivery>();
            this.Documents = new HashSet<Document>();
            this.Documents1 = new HashSet<Document>();
            this.Documents2 = new HashSet<Document>();
            this.Expenses = new HashSet<Expense>();
            this.Expenses1 = new HashSet<Expense>();
            this.Expenses2 = new HashSet<Expense>();
            this.Factories = new HashSet<Factory>();
            this.Factories1 = new HashSet<Factory>();
            this.Factories2 = new HashSet<Factory>();
            this.Grades = new HashSet<Grade>();
            this.Grades1 = new HashSet<Grade>();
            this.Grades2 = new HashSet<Grade>();
            this.Incomes = new HashSet<Income>();
            this.Incomes1 = new HashSet<Income>();
            this.Incomes2 = new HashSet<Income>();
            this.Inventories = new HashSet<Inventory>();
            this.Inventories1 = new HashSet<Inventory>();
            this.Inventories2 = new HashSet<Inventory>();
            this.Products = new HashSet<Product>();
            this.Products1 = new HashSet<Product>();
            this.Products2 = new HashSet<Product>();
            this.Sectors = new HashSet<Sector>();
            this.Sectors1 = new HashSet<Sector>();
            this.Sectors2 = new HashSet<Sector>();
            this.Sizes = new HashSet<Size>();
            this.Sizes1 = new HashSet<Size>();
            this.Sizes2 = new HashSet<Size>();
            this.Status = new HashSet<Status>();
            this.Status1 = new HashSet<Status>();
            this.Status2 = new HashSet<Status>();
            this.Stocks = new HashSet<Stock>();
            this.Stocks1 = new HashSet<Stock>();
            this.Stocks2 = new HashSet<Stock>();
            this.Stores = new HashSet<Store>();
            this.Stores1 = new HashSet<Store>();
            this.Stores2 = new HashSet<Store>();
            this.WeightNotes = new HashSet<WeightNote>();
            this.WeightNotes1 = new HashSet<WeightNote>();
            this.WeightNotes2 = new HashSet<WeightNote>();
            this.WeightNotes3 = new HashSet<WeightNote>();
            this.WeightNoteValues = new HashSet<WeightNoteValue>();
            this.WeightNoteValues1 = new HashSet<WeightNoteValue>();
            this.WeightNoteValues2 = new HashSet<WeightNoteValue>();
            this.AspNetRoles = new HashSet<AspNetRole>();
            this.Batches3 = new HashSet<Batch>();
            this.Order = new HashSet<Order>();
            this.Order1 = new HashSet<Order>();
            this.Order2 = new HashSet<Order>();
            this.Order3 = new HashSet<Order>();
        }
    
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public Nullable<System.DateTime> LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public Nullable<int> GenderId { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Activity> Activities1 { get; set; }
        public virtual ICollection<Activity> Activities2 { get; set; }
        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers1 { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers11 { get; set; }
        public virtual AspNetUser AspNetUser2 { get; set; }
        public virtual ICollection<AspNetUser> AspNetUsers12 { get; set; }
        public virtual AspNetUser AspNetUser3 { get; set; }
        public virtual ICollection<Batch> Batches { get; set; }
        public virtual ICollection<Batch> Batches1 { get; set; }
        public virtual ICollection<Batch> Batches2 { get; set; }
        public virtual ICollection<Branch> Branches { get; set; }
        public virtual ICollection<Branch> Branches1 { get; set; }
        public virtual ICollection<Branch> Branches2 { get; set; }
        public virtual ICollection<CasualWorker> CasualWorkers { get; set; }
        public virtual ICollection<CasualWorker> CasualWorkers1 { get; set; }
        public virtual ICollection<CasualWorker> CasualWorkers2 { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        public virtual ICollection<Delivery> Deliveries1 { get; set; }
        public virtual ICollection<Delivery> Deliveries2 { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Document> Documents1 { get; set; }
        public virtual ICollection<Document> Documents2 { get; set; }
        public virtual ICollection<Expense> Expenses { get; set; }
        public virtual ICollection<Expense> Expenses1 { get; set; }
        public virtual ICollection<Expense> Expenses2 { get; set; }
        public virtual ICollection<Factory> Factories { get; set; }
        public virtual ICollection<Factory> Factories1 { get; set; }
        public virtual ICollection<Factory> Factories2 { get; set; }
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual ICollection<Grade> Grades1 { get; set; }
        public virtual ICollection<Grade> Grades2 { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Income> Incomes1 { get; set; }
        public virtual ICollection<Income> Incomes2 { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<Inventory> Inventories1 { get; set; }
        public virtual ICollection<Inventory> Inventories2 { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Product> Products1 { get; set; }
        public virtual ICollection<Product> Products2 { get; set; }
        public virtual ICollection<Sector> Sectors { get; set; }
        public virtual ICollection<Sector> Sectors1 { get; set; }
        public virtual ICollection<Sector> Sectors2 { get; set; }
        public virtual ICollection<Size> Sizes { get; set; }
        public virtual ICollection<Size> Sizes1 { get; set; }
        public virtual ICollection<Size> Sizes2 { get; set; }
        public virtual ICollection<Status> Status { get; set; }
        public virtual ICollection<Status> Status1 { get; set; }
        public virtual ICollection<Status> Status2 { get; set; }
        public virtual ICollection<Stock> Stocks { get; set; }
        public virtual ICollection<Stock> Stocks1 { get; set; }
        public virtual ICollection<Stock> Stocks2 { get; set; }
        public virtual ICollection<Store> Stores { get; set; }
        public virtual ICollection<Store> Stores1 { get; set; }
        public virtual ICollection<Store> Stores2 { get; set; }
        public virtual ICollection<WeightNote> WeightNotes { get; set; }
        public virtual ICollection<WeightNote> WeightNotes1 { get; set; }
        public virtual ICollection<WeightNote> WeightNotes2 { get; set; }
        public virtual ICollection<WeightNote> WeightNotes3 { get; set; }
        public virtual ICollection<WeightNoteValue> WeightNoteValues { get; set; }
        public virtual ICollection<WeightNoteValue> WeightNoteValues1 { get; set; }
        public virtual ICollection<WeightNoteValue> WeightNoteValues2 { get; set; }
        public virtual ICollection<AspNetRole> AspNetRoles { get; set; }
        public virtual ICollection<Batch> Batches3 { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Order> Order1 { get; set; }
        public virtual ICollection<Order> Order2 { get; set; }
        public virtual ICollection<Order> Order3 { get; set; }
    }
}
