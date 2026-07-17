using Microsoft.AspNetCore.Mvc;
using OrbitBoard.Api.DTOs;
using OrbitBoard.Api.Services;

namespace OrbitBoard.Api.Controllers;

[ApiController]
[Route("api/dashboard")]
public sealed class DashboardController(IWorkspaceService service) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType<DashboardResponse>(StatusCodes.Status200OK)]
    public ActionResult<DashboardResponse> Get() => Ok(service.GetDashboard());
}
