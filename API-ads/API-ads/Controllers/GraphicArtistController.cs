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
    [RoutePrefix("graphicArtist")]
    public class GraphicArtistController : ApiController
    {
        [HttpGet]
        [Route("get-graphicArtist")]
        public static  BLL.GraphicArtistLogic GetGraphicArtist(string  id)
        {

            return BLL.GraphicArtistLogic.getgrafits(id); 
        }
    }
}
////[EnableCors(origins: "*", headers: "*", methods: "*")]
//[RoutePrefix("user")]
//public class TemplatesController : ApiController
//{
//    //[HttpPost]
//    //[Route("save-user")]
//    //public bool SaveUser(Orders userForSave)
//    //{
//    //    return TemplatesLogic.SaveUserDetails(userForSave);
//    //}
//}