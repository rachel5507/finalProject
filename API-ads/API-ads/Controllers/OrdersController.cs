using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API_ads.Controllers
{
   [RoutePrefix("ads")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrdersController : ApiController
    {
        //[HttpPost]
        //[Route("save-ads")]
        //public bool SaveAds(Templates adsForSave)
        //{
        //    return OrdersLogic.SaveUserDetails(adsForSave);
        //}
    }
}
