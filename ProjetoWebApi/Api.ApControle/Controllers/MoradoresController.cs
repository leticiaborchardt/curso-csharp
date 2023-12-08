using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api.ApControle.Models;
using Api.ApControle.Context;

namespace Api.ApControle.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MoradoresController : ControllerBase
{
    private readonly AppDbContext _context;

    public MoradoresController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Morador>> GetMoradores()
    {
        var moradores = _context.Moradores.ToList();

        if (moradores == null)
        {
            return NotFound();
        }

        return moradores;
    }

    [HttpGet("{id:int}")]
    public ActionResult<Morador> GetMorador(int id)
    {
        var morador = _context.Moradores.FirstOrDefault(c => c.Id == id);

        if (morador == null)
        {
            return NotFound();
        }

        return morador;
    }

    [HttpPut("{id:int}")]
    public ActionResult PutMorador(int id, Morador morador)
    {
        if (id != morador.Id)
        {
            return BadRequest("Os campos preenchidos estão diferentes da base de dados.");
        }

        _context.Entry(morador).State = EntityState.Modified;
        _context.SaveChanges();

        return Ok(morador);
    }

    [HttpDelete("{id:int}")]
    public ActionResult DeleteMorador(int id)
    {
        var morador = _context.Moradores.FirstOrDefault(c => c.Id == id);

        if (morador == null)
        {
            return NotFound("Id não encontrado.");
        }

        _context.Moradores.Remove(morador);
        _context.SaveChanges();

        return NoContent();
    }

    [HttpPost]
    public ActionResult PostMorador(Morador morador)
    {
        if (morador == null)
        {
            return BadRequest("Digite os dados do morador.");
        }

        var condominio = _context.Condominios.FirstOrDefault(c => c.Id == morador.CondominioId);

        if (condominio == null)
        {
            return NotFound("Condomínio vinculado não foi encontrado.");
        }

        _context.Entry(morador).State = EntityState.Added;
        _context.SaveChanges();

        return Ok(morador);
    }
}
