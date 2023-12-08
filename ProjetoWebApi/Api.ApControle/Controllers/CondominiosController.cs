using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.ApControle.Models;
using Api.ApControle.Context;

namespace Api.ApControle.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CondominiosController : ControllerBase
{
    private readonly AppDbContext _context;

    public CondominiosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Condominio>> GetCondominios()
    {
        var condominios = _context.Condominios.ToList();

        if (condominios == null)
        {
            return NotFound();
        }

        return condominios;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Condominio> GetCondominio(int id)
    {
        var condominio = _context.Condominios.FirstOrDefault(c => c.Id == id);

        if (condominio == null)
        {
            return NotFound();
        }

        return condominio;
    }

    [HttpPut("{id:int}")]
    public ActionResult PutCondominio(int id, Condominio condominio)
    {
        if (id != condominio.Id)
        {
            return BadRequest("Os campos preenchidos estão diferentes da base de dados.");
        }

        _context.Entry(condominio).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(condominio);
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeleteCondominio(int id)
    {
        var condominio = _context.Condominios.FirstOrDefault(c => c.Id == id);

        if (condominio == null)
        {
            return NotFound("Id não encontrado.");
        }

        _context.Condominios.Remove(condominio);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPost]
    public ActionResult PostCondominio(Condominio condominio)
    {
        if (condominio == null)
        {
            return BadRequest("Digite os dados do condomínio.");
        }

        _context.Condominios.Add(condominio);
        _context.SaveChanges();

        return Ok(condominio);
    }
}
