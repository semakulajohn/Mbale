using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Higgs.Mbale.DTO
{
  public  class DeliveryDTO
    {
        public long DeliveryId { get; set; }
        public long CustomerId { get; set; }
        public double DriverName { get; set; }
        public long ProductId { get; set; }
        public string VehicleNumber { get; set; }
        public long MediaId { get; set; }
        public long BranchId { get; set; }
        public string Location { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string DeletedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public Nullable<System.DateTime> DeletedOn { get; set; }
    }
}
