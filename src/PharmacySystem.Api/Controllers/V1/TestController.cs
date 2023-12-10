using Microsoft.AspNetCore.Mvc;

using PharmacySystem.Api.Controllers.V1;

namespace PharmacySystem.Api.Controllers;

public class TestController : BaseController
{
    /// <summary>
    ///  This is just a test method
    /// </summary>
    /// <returns>200 StatusCode</returns>
    [HttpGet(template: "testOne", Name = "TestOne")]
    public IActionResult Test()
    {
        return Ok("Done!!");
    }

    /// <summary>
    ///  this is just a test method too
    /// </summary>
    /// <returns>200 statuscode</returns>
    [HttpGet(template: "testTwo", Name = "TestTwo")]
    [ProducesResponseType(200)]
    public IActionResult TestTwo()
    {
        return Ok("Fuck YOU!!");
    }
}