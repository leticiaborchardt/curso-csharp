using Api.ApControle.Context;
using Api.ApControle.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.ApControle.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CondominiosController : ControllerBase
{
    private readonly AppDbContext _context;

    public CondominiosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Condominio>>> GetCondominios()
    {
        if (_context.Condominios == null)
        {
            return NotFound();
        }

        return await _context.Condominios.ToListAsync();
    }

    [HttpGet("{id: int}")]
    public ActionResult<Condominio> GetCondominio(int id)
    {
        var condominio = _context.Condominios.FirstOrDefault(c => c.Id == id);

        if (condominio == null)
        {
            return NotFound();    
        }

        return condominio;
    }
}
