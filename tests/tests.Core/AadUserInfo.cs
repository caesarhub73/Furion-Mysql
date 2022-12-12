using Furion.DatabaseAccessor;
using System.ComponentModel.DataAnnotations.Schema;

namespace tests.Core
{
    /// <summary>
    /// Aad用户信息表
    /// </summary>
    public class AadUserInfo : EntityNotKey
    {
        public AadUserInfo() : base("v_biportal_weeklyomreport")
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
        [Column("EmployeeName")]
        public string Name { get; set; }

        public string ME { get; set; }

        public string IE { get; set; }

        public string LE { get; set; }

        public string Org { get; set; }
    }
}