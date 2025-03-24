using MongoDB.Bson.Serialization.Attributes;
public class Usuario{
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
    public string? ObjectId { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public decimal Salario { get; set; }
    public bool EsActivo { get; set; }
    public DateTime FechaRegistro { get; set; }
    public string Direccion { get; set; }
    public List<string> Roles { get; set; }
    public decimal PuntuacionPromedio { get; set; }
}