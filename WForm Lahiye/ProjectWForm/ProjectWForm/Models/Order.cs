//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectWForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.OrderBooks = new HashSet<OrderBook>();
        }
    
        public int Id { get; set; }
        public Nullable<System.DateTime> GiveDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public Nullable<System.DateTime> RealTime { get; set; }
        public Nullable<int> UsersId { get; set; }
        public Nullable<int> CustomersId { get; set; }
        public bool Deleted { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderBook> OrderBooks { get; set; }
        public virtual User User { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
