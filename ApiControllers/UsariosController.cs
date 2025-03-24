using MongoDB.Driver;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UsuariosController : ControllerBase
{
    private readonly IMongoCollection<Usuario> _usuarios;

    public UsuariosController()
    {
        var client = new MongoClient(CadenasConexion.MONGO_DB);
        var database = client.GetDatabase("Practica2_Mia_Danna");
        _usuarios = database.GetCollection<Usuario>("Usuarios");
    }

    [HttpGet]
    public ActionResult<List<Usuario>> Get()
    {
        return _usuarios.Find(usuario => true).ToList();
    }
}
