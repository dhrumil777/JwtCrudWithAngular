using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebAPP.Models;
using WebAPP.Models.EntityModel;
using WebAPP.Service;

namespace WebAPP.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "*")]
    public class CrudController : ApiController
    {
        readonly CrudService crud;
        public CrudController()
        {
            crud = new CrudService();
        }

        [HttpGet]
        public IHttpActionResult GetData()
        {
            try
            {
                return Ok(crud.GetData());
            }
            catch(Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException);
            }
        }

        [HttpGet]
        public IHttpActionResult GetDataById(int Id)
        {
            try
            {
                return Ok(crud.GetDataById(Id));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException);
            }
        }

        [HttpPost]
        public IHttpActionResult PostData(Employee Emp)
        {
            try
            {
                return Ok(crud.PostData(Emp));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException);
            }
        }

        [HttpGet]
        public IHttpActionResult DeleteData(int Id)
        {
            try
            {
                return Ok(crud.DeleteData(Id));
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.InnerException);
            }
        }
    }
}
