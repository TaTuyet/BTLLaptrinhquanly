using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLonLTQL.Models
{
    [Table("Accounts")]
    public class Account
    {
        [Key]
        [Required(ErrorMessage ="Username is required!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Username is required!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}