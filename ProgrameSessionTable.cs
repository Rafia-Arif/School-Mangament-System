//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class ProgrameSessionTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProgrameSessionTable()
        {
            this.StudentPromotTables = new HashSet<StudentPromotTable>();
        }
    
        public int ProgrameSessionID { get; set; }
        public int UserID { get; set; }
        public int SessionID { get; set; }
        public int ProgrameID { get; set; }
        public string Details { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime RegDate { get; set; }
        public string Description { get; set; }
    
        public virtual ProgrameTable ProgrameTable { get; set; }
        public virtual SessionTable SessionTable { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPromotTable> StudentPromotTables { get; set; }
    }
}
