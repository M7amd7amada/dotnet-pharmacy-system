using Microsoft.AspNetCore.Mvc;

namespace PharmacySystem.Api.Controllers.V1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/[controller]")]
public class BaseController : ControllerBase
{

}