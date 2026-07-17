using Microsoft.AspNetCore.Mvc;
using OrbitBoard.Api.DTOs;
using OrbitBoard.Api.Services;

namespace OrbitBoard.Api.Controllers;

[ApiController]
[Route("api/projects")]
public sealed class ProjectsController(IWorkspaceService service) : ControllerBase
{
    [HttpGet]
    [ProducesResponseType<IReadOnlyList<ProjectResponse>>(StatusCodes.Status200OK)]
    public ActionResult<IReadOnlyList<ProjectResponse>> GetAll() => Ok(service.GetProjects());

    [HttpGet("{id:guid}")]
    [ProducesResponseType<ProjectResponse>(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ProjectResponse> GetById(Guid id) => Ok(service.GetProject(id));

    [HttpPost]
    [ProducesResponseType<ProjectResponse>(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public ActionResult<ProjectResponse> Create(CreateProjectRequest request)
    {
        var project = service.CreateProject(request);
        return CreatedAtAction(nameof(GetById), new { id = project.Id }, project);
    }

    [HttpPut("{id:guid}")]
    [ProducesResponseType<ProjectResponse>(StatusCodes.Status200OK)]
    public ActionResult<ProjectResponse> Update(Guid id, UpdateProjectRequest request) =>
        Ok(service.UpdateProject(id, request));

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Delete(Guid id)
    {
        service.DeleteProject(id);
        return NoContent();
    }
}
