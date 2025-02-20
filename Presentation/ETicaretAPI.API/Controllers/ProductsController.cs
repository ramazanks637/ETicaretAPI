using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        readonly private IOrderWriteRepository _orderWriteRepository;
        readonly private IOrderReadRepository _orderReadRepository;

        readonly private ICustomerWriteRepository _customerWriteRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }

        [HttpGet] // attribute kullanılmaması durumunda swagger hata verecektir.
        public async Task Get()
        {
            //await _productWriteRepository.AddRangeAsync(new()
            //{
            //   new() {Id = Guid.NewGuid(), Name = "Product 1", Price = 100,CreatedDate = DateTime.UtcNow,Stock = 10},
            //   new() {Id = Guid.NewGuid(), Name = "Product 2", Price = 200,CreatedDate = DateTime.UtcNow,Stock = 20},
            //   new() {Id = Guid.NewGuid(), Name = "Product 3", Price = 300,CreatedDate = DateTime.UtcNow,Stock = 30},
            //});
            //var count =  await _productWriteRepository.SaveAsync();


            // aşağıdaki kod bloğu çalıştırıldığında veritabanında bulunan bir kaydın adını değiştirmesi beklenmektedir fakat tracking = false olduğu için değişiklik yapılmamaktadır. çünkü tracking mekanizması entity framework core tarafından takip edilmesini kapatmış oluyoruz.
            //Product p = await _productReadRepository.GetByIdAsync("a8da8715-36c8-4dc3-b9ad-9bf23e98d266",false);
            //p.Name = "Deneme AD";
            //await _productWriteRepository.SaveAsync();

            //await _productWriteRepository.AddAsync(new() { Name = "Product 4", Price = 1.500F, CreatedDate = DateTime.UtcNow, Stock = 40 });
            //await _productWriteRepository.SaveAsync();

            //var customerId = Guid.NewGuid();
            //await _customerWriteRepository.AddAsync(new() { Id = customerId, Name = "Customer 1" });

            //await _orderWriteRepository.AddAsync(new() { CustomerId = customerId, Description = "Order 1", Address = "Address 1" });
            //await _orderWriteRepository.AddAsync(new() { CustomerId = customerId, Description = "Order 2", Address = "Address 2"});
            //await _orderWriteRepository.SaveAsync();

            //Order order = await _orderReadRepository.GetByIdAsync("e36630d5-705e-4044-af7f-9cbd913910fd");
            //order.Address = "istanbul";
            //await _orderWriteRepository.SaveAsync();

        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }


    }
}
