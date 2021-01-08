using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AngularWebApp.Models;
// Namespace for Controller
namespace AngularWebApp.Controllers
{
    // Benji is busy (malcomx ohne Schema)
    [RoutePrefix("Api/Employee")]
    public class AngularWebAppController : ApiController
    {
        //www.microfocus.com/documentation/silk-test/200/en/silktestworkbench-help-en/SILKTEST-7FFBB86A-CREATINGNEWSQLSERVERADMINUSER-TSK.html
        [HttpGet]
        [Route("AllEmployeeDetails")]
        public IHttpActionResult GetEmaployee()
        {
            return null;
        }
    }
}
