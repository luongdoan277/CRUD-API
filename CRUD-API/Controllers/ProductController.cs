using CRUD_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_API.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        private readonly ProductEntities _context = new ProductEntities();

        [HttpPost]
        
        [Route("api/Product/Create")]
        public IHttpActionResult Create(ProductModel productModel)
        {
            var product = new product()
            {
                Name = productModel.Name,
                Qty = productModel.Qty,
                Price = productModel.Price
            };
            _context.products.Add(product);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPut]
        [Route("api/Product/Update")]
        public IHttpActionResult Update(ProductModel productModel)
        {
            var product = new product()
            {
                Id = productModel.Id,
                Name = productModel.Name,
                Qty = productModel.Qty,
                Price = productModel.Price,
            };
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var product = _context.products.SingleOrDefault(e => e.Id == id);
            _context.products.Remove(product);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}
