//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kalendarz.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class User
    {
        public int Id { get; set; }
        [DisplayName("E-mail")]
        [Required(ErrorMessage ="To pole jest wymagane.")]
        public string Email { get; set; }
        [DisplayName("Has�o")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public string Haslo { get; set; }
        [DisplayName("Potwierd� has�o")]
        [DataType(DataType.Password)]
        [Compare("Haslo")]
        public string PotwierdzHaslo { get; set; }
    }
}
