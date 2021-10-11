using MS.Web.DAL;
using MS.Web.Models;
using System;
using System.Linq;

namespace MS.Web.BLL
{
    /// <summary>
    /// 會員服務
    /// </summary>
    public class MemberService
    {
        /// <summary>
        /// 會員系統Context
        /// </summary>
        private readonly MsContext MsContext = new MsContext();

        /// <summary>
        /// 註冊
        /// </summary>
        /// <param name="request"></param>
        public void Register(MemberRequest request)
        {
            var member = new Members()
            {
                ID = Guid.NewGuid(),
                Account = request.Account,
                Password = request.Password,
                Name = request.Name,
                Gender = request.Gender,
                LoginType = "System",
                CreateTime = DateTime.Now
            };

            MsContext.Members.Add(member);
            MsContext.SaveChanges();
        }

        /// <summary>
        /// 取得-會員資料
        /// </summary>
        /// <param name="account"></param>
        /// <returns></returns>
        public Members GetMember(string account)
        {
            var member = MsContext.Members.FirstOrDefault(e => e.Account == account);
            return member;
        }
    }
}