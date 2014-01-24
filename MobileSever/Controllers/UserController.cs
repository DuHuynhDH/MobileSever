using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MobileSever.Models;
using System.Web.Security;
using System.Web.Http.Cors;
using System.Web;

namespace MobileSever.Controllers
{


    //[EnableCors(origins: "http://localhost:51212/api/User", headers: "*", methods: "*")]
    public class UserController : ApiController
    {
       
        MobileGameDataDataContext dataMobile = new MobileGameDataDataContext();

        // GET api/<controller>
        public string Get()
        {
            //var user = from u in dataMobile.tblUsers select u;
            return "userControll";
        }

        // GET api/<controller>/5
        public string Get(int id)
        {

            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }

       
        public bool GETLogin(string username, string password)
        {


            if (username=="admin"&&password=="admin")
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return true;
            }
            else
                return false;
        }



    }
}