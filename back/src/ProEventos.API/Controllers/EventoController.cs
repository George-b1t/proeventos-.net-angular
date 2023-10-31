using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _eventos = new Evento[] {
        new(){  
            EventoId = 1,
            Tema = "Angular 11 e .NET 5",
            Local = "Belo Horizonte",
            Lote = "1 Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImageURL = "foto.png"
        },
        new(){  
            EventoId = 2,
            Tema = "Angular e Suas Novidades",
            Local = "São Paulo",
            Lote = "2 Lote",
            QtdPessoas = 350,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImageURL = "foto1.png"
        }
    };
    
    public EventoController()
    {}

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _eventos;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> Get(int id)
    {
        return _eventos.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "Post example";
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
