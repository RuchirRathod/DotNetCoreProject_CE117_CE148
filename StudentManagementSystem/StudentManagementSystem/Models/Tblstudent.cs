using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace StudentManagementSystem.Models
{
    public partial class Tblstudent
    {
        public int IdSt { get; set; }
        public string NameSt { get; set; }
        public DateTime? BirthdatSt { get; set; }
        public string AddressSt { get; set; }
        public DateTime? CreateDateSt { get; set; }
        public int? IdCr { get; set; }

        public virtual TblclassRoom IdCrNavigation { get; set; }
    }
}
