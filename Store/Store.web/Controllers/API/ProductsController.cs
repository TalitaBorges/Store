namespace Store.web.Controllers.API
{
    using Microsoft.AspNetCore.Mvc;
    using Store.web.Data;


    //isto é para o android

    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(this.productRepository.GetAll());
        }
    }
}
