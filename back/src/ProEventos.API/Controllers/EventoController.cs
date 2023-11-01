using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly DataContext _context;
    
    public EventoController(DataContext context) {
      _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var evento = _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);

        if (evento == null) {
            return NotFound();
        }

        return Ok(evento);
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromBody] Evento evento)
    {
        _context.Eventos.Add(evento);
        await _context.SaveChangesAsync();

        return Ok(evento);
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Put example with id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Delete example with id = {id}";
    }
}
