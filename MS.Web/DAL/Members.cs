using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MS.Web.DAL
{
    /// <summary>
    /// 會員資料檔
    /// </summary>
    public class Members
    {
        /// <summary>
        /// 會員ID
        /// </summary>
        [Key]
        public Guid ID { get; set; }

        /// <summary>
        /// 帳號(電子信箱)
        /// </summary>
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [Column(TypeName = "varchar"), StringLength(50), Required]
        public string Password { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        [StringLength(50), Required]
        public string Name { get; set; }

        /// <summary>
        /// 性別(M：男、F：女)
        /// </summary>
        [Column(TypeName = "char"), StringLength(1), Required]
        public string Gender { get; set; }

        /// <summary>
        /// 登入類型(System、Facebook、Google、Line)
        /// </summary>
        [Column(TypeName = "varchar"), StringLength(10), Required]
        public string LoginType { get; set; }

        /// <summary>
        /// 更新時間
        /// </summary>
        public DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}