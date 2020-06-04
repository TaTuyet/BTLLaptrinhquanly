using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLonLTQL.Models
{
    [Table("HDBan")]
    public partial class HDBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HDBan()
        {
            ChiTietBans = new HashSet<ChiTietBan>();
        }

        [Key]
        [StringLength(50)]
        public string SoHDBan { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKhachHang { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNhanVien { get; set; }

        public DateTime NgayBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietBan> ChiTietBans { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}