using Microsoft.AspNetCore.Antiforgery;
using ZheXian.Controllers;

namespace ZheXian.Web.Host.Controllers
{
    public class AntiForgeryController : ZheXianControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
