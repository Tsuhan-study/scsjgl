using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CEP.Framework.Database
{
    /// <summary>
    /// 数据库转义特殊字符辅助类
    /// </summary>
    public static class StringEscapeUtils
    {
        /// <summary>
        /// 对SQL中的特殊字符进行转移，避免SQL注入
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static string EscapeSql(string sql)
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(sql) == false)
            {
                char[] old = sql.ToCharArray();
                for (int i = 0; i < old.Length; i++)
                {
                    char c = old[i];
                    switch (c)
                    {
                        case '[':
                            {
                                sb.Append("[[]");
                                break;
                            }
                        case '\'':
                            {
                                sb.Append("\'\'");
                                break;
                            }
                        case '%':
                            {
                                sb.Append("[%]");
                                break;
                            }
                        case '_':
                            {
                                sb.Append("[_]");
                                break;
                            }
                        case '^':
                            {
                                sb.Append("[^]");
                                break;
                            }
                        default:
                            {
                                sb.Append(c); break;
                            }
                    }
                }

            }
            return sb.ToString();

        }

    }
}
