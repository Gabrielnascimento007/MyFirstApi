﻿using Microsoft.AspNetCore.Mvc;

namespace MyFirtsApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class MyFirstApiBaseController : ControllerBase
{
    public string Author { get; set; } = "Gabriel Nascimento";

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("It's working");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
