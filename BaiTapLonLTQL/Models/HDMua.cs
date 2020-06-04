using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BaiTapLonLTQL.Models
{
    [Table("HDMua")]
    public partial class HDMua
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HDMua()
        {
            ChiTietMuas = new HashSet<ChiTietMua>();
        }

        [Key]
        [StringLength(50)]
        public string SoHDMua { get; set; }

        public DateTime NgayMua { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNCC { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietMua> ChiTietMuas { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}