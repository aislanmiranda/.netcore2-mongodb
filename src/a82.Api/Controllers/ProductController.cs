using a82.Application;
using a82.Data;
using a82.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace a82.Api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductApp _service;

        public ProductController(IProductApp service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Json(_service.GetAll());
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get(string objectId = "59fbc96d5b407021f04f805e")
        {
            return new ObjectResult(_service.Get(objectId));
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult PostProduct(Product entity)
        {
            return new ObjectResult(_service.Insert(entity));
        }

        [HttpPost]
        [Route("Update")]
        public IActionResult Update(Product entity)
        {
            return new ObjectResult(_service.Update(entity));
        }

        [HttpGet]
        [Route("Delete")]
        public IActionResult Delete(string objectId = "59fbc96d5b407021f04f805e")
        {
            return new ObjectResult(_service.Delete(objectId));
        }


    }
}
