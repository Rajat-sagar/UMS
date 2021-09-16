//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UMSDemo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel;

    public partial class Faculty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faculty()
        {
            this.Subjects = new HashSet<Subject>();
        }

        [DisplayName("Registration Number")]
        [Required(ErrorMessage = "This Field is Required")]
        public string RegistrationNumber { get; set; }
        
        [Required(ErrorMessage = "This Field is Required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "This Field is Required")]
        public string Sex { get; set; }
        [DisplayName("Date Of Birth")]
        [Required(ErrorMessage = "This Field is Required")]
        public System.DateTime Dob { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Qualifications { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public int Experience { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public string Department { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        public System.DateTime DateJoined { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
