using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Services
{
    public class AddressService : IAddressService
    {
        private readonly SchoolDbContext _context;

        public AddressService(SchoolDbContext context)
        {
            _context = context;
        }
        public Address AddAddress(Address address)
        {
            _context.Addresses.Add(address);
            _context.SaveChanges();
            return address;
        }

        public List<Address> GetAddresses() => _context.Addresses
            .Include(s => s.Students).ToList();
    }
}
