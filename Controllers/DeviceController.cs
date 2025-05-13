using Microsoft.AspNetCore.Mvc;
using MyFirtsApi.Entities;

namespace MyFirtsApi.Controllers;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var key = GetCustomKey();

        return Ok(key);
    }
}
