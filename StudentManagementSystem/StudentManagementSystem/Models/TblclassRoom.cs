using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementSystem.Models
{
    public partial class TblclassRoom
    {
        public TblclassRoom()
        {
            Tblstudent = new HashSet<Tblstudent>();
        }

        public int IdCr { get; set; }
        public string NameCr { get; set; }
        public DateTime? CreaterDateCr { get; set; }

        public virtual ICollection<Tblstudent> Tblstudent { get; set; }
    }
}
