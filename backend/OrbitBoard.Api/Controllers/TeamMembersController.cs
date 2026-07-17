using Microsoft.AspNetCore.Mvc;
using OrbitBoard.Api.Models;
using OrbitBoard.Api.Services;

namespace OrbitBoard.Api.Controllers;

[ApiController]
[Route("api/team-members")]
public sealed class TeamMembersController(IWorkspaceService service) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType<IReadOnlyList<TeamMember>>(StatusCodes.Status200OK)]
    public ActionResult<IReadOnlyList<TeamMember>> GetAll() => Ok(service.GetTeamMembers());
}
