using Microsoft.AspNetCore.Mvc;
using CustomerLibrary.Models;
using CustomerLibrary.DataAccess;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerData _data;

    public CustomersController(ICustomerData data)
    {
        _data = data;
    }
    
    // GET: api/<CustomersController>
    [HttpGet]
    //public ActionResult<IEnumerable<CustomerModel>> Get()
    //{
    //    var output = _data.GetAll();
    //    return Ok(output);
    //}

    // GET api/<CustomersController>/5
    [HttpGet("{id}")]
    public async Task<ActionResult<CustomerModel>> Get(int cusId)
    {
        var output = _data.GetAll(cusId);
        return Ok(output);
    }

    // POST api/<CustomersController>
    [HttpPost]
    public async Task<ActionResult<CustomerModel>> Post( string cusName, string cusAddress, string cusPhone)
    {
        var output = _data.Create(cusName, cusAddress, cusPhone);
        return Ok(output);
    }

    // PUT api/<CustomersController>/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, string cusName, string cusAddress, string cusPhone)
    {
        var output = _data.Update(cusName, cusAddress, cusPhone);
        return Ok(output);
    }

    // DELETE api/<CustomersController>/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var output = _data.Delete(id);
        return Ok(output);
    }
}
