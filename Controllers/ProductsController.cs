using System.Collections.Generic;
using System.Threading.Tasks;
using FINLOGIX.API.Data;
using FINLOGIX.API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FINLOGIX.API.Controllers
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProducts(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return Ok(product);
        }

        [HttpPost]
        public IEnumerable<Product> AddProduct()
        {
            return null;
        }
    }
}