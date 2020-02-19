//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nog.Prayas.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            this.Event_Gallery = new HashSet<Event_Gallery>();
        }
    
        public int Id { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public System.DateTime EventDate { get; set; }
        public string EventStartTime { get; set; }
        public string EventEndTime { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public bool IsActive { get; set; }
        public string EventLocation { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Event_Gallery> Event_Gallery { get; set; }
        public virtual EventCategory EventCategory { get; set; }
    }
}
