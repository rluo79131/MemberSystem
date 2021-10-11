namespace MS.Web.BLL
{
    public class MemberRequest
    {
        /// <summary>
        /// 帳號(電子信箱)
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public string Gender { get; set; }
    }
}