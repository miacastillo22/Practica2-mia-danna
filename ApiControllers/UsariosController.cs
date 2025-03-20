using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IMongoCollection<Usuario> _usuarios;

    public UsuariosController()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var database = client.GetDatabase("SistemaUsuarios");
        _usuarios = database.GetCollection<Usuario>("usuarios");
    }

    [HttpGet]
    public ActionResult<List<Usuario>> Get()
    {
        return _usuarios.Find(usuario => true).ToList();
    }
}
