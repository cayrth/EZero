using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace EZero.Infrastructure.Runtime.Security
{
    /// <summary>
    /// 密码策略
    /// </summary>
    public class PasswordStrategy
    {

        /// <summary>
        ///创建密码
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public static string CreateWithMD5(string password)
        {
            return MD5(password);
        }


        #region 私有方法

        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string MD5(string str)
        {
            byte[] result = Encoding.Default.GetBytes(str);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "");
        }

        #endregion

    }
}
