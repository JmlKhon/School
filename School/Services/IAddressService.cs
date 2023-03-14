using School.Models;

namespace School.Services
{
    public interface IAddressService
    {
        public Address AddAddress(Address address);

        public List<Address> GetAddresses();
    }
}
