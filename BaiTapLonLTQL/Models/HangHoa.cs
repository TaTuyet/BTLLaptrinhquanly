using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLonLTQL.Models
{
    [Table("HangHoa")]
    public partial class HangHoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HangHoa()
        {
            ChiTietBans = new HashSet<ChiTietBan>();
            ChiTietMuas = new HashSet<ChiTietMua>();
        }

        [Key]
        [StringLength(10)]
        public string MaHangHoa { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHangHoa { get; set; }

        [Required]
        [StringLength(15)]
        public string DonViTinh { get; set; }

        [Required]
        [StringLength(15)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietMua> ChiTietMuas { get; set; }
    }
}