using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using product_backend.Data;
using product_backend.Models;
using product_backend.Repository;

namespace product_backend.Controllers
{
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IBaseRepository baseRepository;

        public ProductController(IBaseRepository baseRepository)
        {
            this.baseRepository = baseRepository;
        }
        [HttpGet("/product")]
        public List<ProductEntity> getAllProduct()
        {
            return this.baseRepository.Gets<ProductEntity>();
        }
        [HttpGet("/product/{id}")]
        public List<ProductEntity> getProductById(int id)
        {
            List<ProductEntity> product = this.baseRepository.Gets<ProductEntity>().Where(x => x.id == id).ToList();
            if(product.Count == 0)
            {
                throw new Exception("item in this id does not exist");
            }
            return product;
        }
        [HttpPost("/product")]
        public ProductEntity addProduct([FromBody] ProductEntity request)
        {
            ProductEntity productResponse = this.baseRepository.Create(request);
            return productResponse;
        }
        [HttpPatch("/product/{id}")]
        public ProductEntity updateProduct([FromBody] ProductEntity request, int id)
        {
            List<ProductEntity> products = this.baseRepository.Gets<ProductEntity>();
            ProductEntity product = products.FirstOrDefault(x => x.id == id);
            product.name = request.name;
            product.prices = request.prices;
            product.status_id = request.status_id;
            product.quantity = request.quantity;
            product.category_id = request.category_id;
            product.image_url = request.image_url;
            ProductEntity productResponse = this.baseRepository.Update(product);
            return productResponse;
        }
        [HttpPost("/category")]
        public CategoryEntity addCategory([FromBody] CategoryEntity request)
        {
            return this.baseRepository.Create(request);
        }
        [HttpDelete("/product/{id}")]
        public ProductEntity deleteProduct(int id)
        {
            List<ProductEntity> products = this.baseRepository.Gets<ProductEntity>();
            ProductEntity product = products.FirstOrDefault(x => x.id == id);
            ProductEntity productResponse = this.baseRepository.Delete(product);
            return productResponse;
        }
    }
}
