using CurriculumApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurriculumApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SyllabusController : ControllerBase
{
    private readonly SyllabusDb _context;

    public SyllabusController(SyllabusDb context)
    {
        _context = context;
    }
}