using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Common
{
    public class AuthorizeFilter : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            // 파라미터로부터 http Context 데이터를 얻는다.
            HttpContextBase httpContext = filterContext.HttpContext;
            // 세션이 null 이면, 즉, 로그인 상태가 아니라면 redirect로 /Home/Logout으로 이동한다.
            if (httpContext.Session["user"] == null)
            {
                httpContext.Response.Redirect("/Home/Logout");
                return;
            }

            // Filter Role이 Test의 경우는 통과한다.
            if ("TEST".Equals(Roles))
            {
                return;
            }
            else {
                //Filter Role이 Test가 아닌 경우 http code 401를 내보낸다.
                filterContext.Result = new HttpStatusCodeResult(401);
            }
            //base.OnAuthorization(filterContext);
        }
    }
}