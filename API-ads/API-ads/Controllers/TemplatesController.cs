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
  [EnableCors(origins: "*", headers: "*", methods: "*")]
  [RoutePrefix("user")]
  public class TemplatesController : ApiController
  {   
    //[HttpPost]
    //[Route("save-user")]
    //public bool SaveUser(Orders userForSave)
    //{
    //    return TemplatesLogic.SaveUserDetails(userForSave);
    //}
  }
}
