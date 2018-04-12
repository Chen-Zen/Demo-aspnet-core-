using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ZheXian.Controllers;

namespace ZheXian.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : ZheXianControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
