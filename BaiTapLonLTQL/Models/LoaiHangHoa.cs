using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLonLTQL.Models
{
    [Table("LoaiHangHoa")]
    public partial class LoaiHangHoa
    {
        [Key]
        [StringLength(10)]
        public string MaLoaiHangHoa { get; set; }

        [Required]
        [StringLength(50)]
        public string TenLoaiHangHoa { get; set; }

        [Required]
        public string GhiChu { get; set; }
    }
}