using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.Dtos;
using School.Services;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _service;

        public AddressController(IAddressService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Address> AddAddress(AddressRequestDto address)
        {
            var _address = new Address
            {
                Country = address.Country,
                City = address.City,
                Street = address.Street,
                CreatedAt = DateTime.UtcNow
            };
            _service.AddAddress(_address);
            return _address;
        }

        [HttpGet]
        public ActionResult<List<Address>> GetAddresses()
        {
            return _service.GetAddresses();
        }
    }
}
