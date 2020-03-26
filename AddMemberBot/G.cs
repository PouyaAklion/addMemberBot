using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AddMemberBot
{
    
    class G
    {
        public static string ApiHash { get; set; }
        public static string ApiId { get; set; }

        public static void init(){
            ApiHash = ConfigurationManager.AppSettings[MemberInfoGetting.GetMemberName(() => ApiHash)];
            ApiId = ConfigurationManager.AppSettings[MemberInfoGetting.GetMemberName(() => ApiId)];
        }
        public static class MemberInfoGetting
        {
            public static string GetMemberName<T>(Expression<Func<T>> memberExpression)
            {
                MemberExpression expressionBody = (MemberExpression)memberExpression.Body;
                return expressionBody.Member.Name;
            }
        }
    }
    
}
