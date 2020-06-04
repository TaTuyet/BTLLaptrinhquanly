using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLonLTQL.Models
{
    [Table("ChiTietBan")]
    public partial class ChiTietBan
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string SoHDBan { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaHangHoa { get; set; }

        [Required]
        [StringLength(20)]
        public string DonGia { get; set; }

        public int SoLuong { get; set; }

        public virtual HangHoa HangHoa { get; set; }

        public virtual HDBan HDBan { get; set; }
    }
}