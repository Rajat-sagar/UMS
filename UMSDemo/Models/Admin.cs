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

    public partial class Admin
    {
        public int UID { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This Field is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string LoginErrorMsg { get; set; }
    }
}
