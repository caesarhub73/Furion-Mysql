using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations.Schema;

namespace tests.Core
{
    /// <summary>
    /// Aad用户表
    /// </summary>
    public class AadUser : EntityNotKey
    {
        public AadUser() : base("v_biportal_weeklyemlist")
        {
        }

        /// <summary>
        /// 数据生成时间
        /// </summary>
        public int KeyDate { get; set; }

        /// <summary>
        /// 时间类型
        /// </summary>
        public int DateType { get; set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        [Column("EmployeeID")]
        public int Id { get; set; }

        /// <summary>
        /// 用户名称
        /// </summary>
        [Column("FullName")]
        public string Name { get; set; }

        /// <summary>
        /// 用户邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 用户状态
        /// </summary>
        [Column("EmployeeStatus")]
        public string Status { get; set; }
    }
}