using CustomerLibrary.Models;

namespace CustomerLibrary.DataAccess
{
    public interface ICustomerData
    {
        Task<CustomerModel> Create(string cusName, string cusAddress, string cusPhone);
        Task Delete(int cusId);
        Task<List<CustomerModel>> GetAll(int cusId);
        Task Update(string cusName, string cusAddress, string cusPhone);
    }
}