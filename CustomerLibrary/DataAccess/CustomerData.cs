using CustomerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLibrary.DataAccess;

public class CustomerData : ICustomerData
{
    private readonly ISqlDataAccess _sql;

    public CustomerData(ISqlDataAccess sql)
    {
        _sql = sql;
    }

    public Task<List<CustomerModel>> GetAll(int cusId)
    {
        return _sql.LoadData<CustomerModel, dynamic>(
            "dbo.spCustomer_GetAll",
            new { CusId = cusId },
            "Default");

    }

    public async Task<CustomerModel> Create(string cusName, string cusAddress, string cusPhone)
    {
        var results = await _sql.LoadData<CustomerModel, dynamic>(
            "dbo.spCustomer_Create",
            new { CusName = cusName, CusAddress = cusAddress, CusPhone = cusPhone },
            "Default");

        return results.FirstOrDefault();
    }

    public Task Update(string cusName, string cusAddress, string cusPhone)
    {
        return _sql.SaveData<dynamic>(
            "dbo.spCustomer_Update",
            new { CusName = cusName, CusAddress = cusAddress, CusPhone = cusPhone },
            "Default");

    }

    public Task Delete(int cusId)
    {
        return _sql.SaveData<dynamic>(
            "dbo.spCustomer_Delete",
            new { CusId = cusId },
            "Default");

    }
}
